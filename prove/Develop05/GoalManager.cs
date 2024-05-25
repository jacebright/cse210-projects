using System.Runtime;
using System.Xml.Serialization;

public class GoalManager
{
    private List<Goal> _goals = [];
    private int _score;
    public GoalManager(int score)
    {
        _score = score;
    }
    public void Start()
    {
        string choice = "1";
        while (choice != "6")
        {
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options:\n\t1. Create New Goal\n\t2. List Goals\n\t3. Save Goals\n\t4. Load Goals\n\t5. Record Event\n\t6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoalDetails();
            }
            else if (choice == "3")
            {
                SaveGoals();
            }
            else if (choice == "4")
            {
                LoadGoals();
            }
            else if (choice == "5")
            {
                RecordEvent();
            }
            else if (choice == "6")
            {
                break;
            }
        }
    }
    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.\n");
    }
    private void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        int count = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{count}. {goal.GetName()}");
            count +=1;
        }
    }
    private void ListGoalDetails()
    {
        int count = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{count}. {goal.GetDetailsString()}");
            count +=1;
        }
    }
    private void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:\n\t1. Simple Goal\n\t2. Eternal Goal\n\t3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();

        if (choice == "1")
        {
            // Create the Simple Goal object then add it to the list
            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);
        }
        else if (choice == "2")
        {
            // Create the Eternal Goal object then add it to the list
            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
        }
        else if (choice == "3")
        {
            // Get the additional information needed to create a checklist goal
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            string number = Console.ReadLine();
            int target = Int32.Parse(number);
            Console.Write("What is the bonus for accomplishing it that many times? ");
            string bonusPoints = Console.ReadLine();
            int bonus = Int32.Parse(bonusPoints);

            // Create the checklist goal object then add it to the list
            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, 0, target, bonus);
            _goals.Add(checklistGoal);
        }

        Thread.Sleep(300);
        Console.Clear();
        Console.WriteLine($"{name} goal created!");
    }
    private void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        string indexString = Console.ReadLine();
        int indexInt = Int32.Parse(indexString) - 1;

        Goal goal = _goals[indexInt];
        _score += goal.RecordEvent();

        Console.Clear();
        Thread.Sleep(250);
        Console.WriteLine($"You just got {goal.GetPoints()} points!\n");

    }
    private void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        ShowSpinner(1);
        Console.Clear();
        Console.WriteLine($"File ({filename}) saved.");
        Thread.Sleep(300);
    }
    private void LoadGoals()
    {
        _goals = [];
        Console.Write("What is the filename for the goal file? ");
        var filename = Console.ReadLine();
            using(var reader = new StreamReader(filename))
            {
                var content = reader.ReadLine();
                int score = Int32.Parse(content);
                _score = score;

                while(reader.EndOfStream == false)
                {
                    content = reader.ReadLine();
                    var line = content.Split(":");
                    string type = line[0];
                    var details = line[1];
                    var detailList = details.Split("|");

                    if (type == "SimpleGoal")
                    {
                        SimpleGoal simpleGoal = new SimpleGoal(detailList[0], detailList[1], detailList[2], bool.Parse(detailList[3]));
                        _goals.Add(simpleGoal);
                    }
                    else if (type == "EternalGoal")
                    {
                        EternalGoal eternalGoal = new EternalGoal(detailList[0], detailList[1], detailList[2]);
                        _goals.Add(eternalGoal);
                    }
                    else if (type == "ChecklistGoal")
                    {
                        ChecklistGoal checklistGoal = new ChecklistGoal(detailList[0], detailList[1], detailList[2], Int32.Parse(detailList[3]), Int32.Parse(detailList[4]), Int32.Parse(detailList[5]));
                        _goals.Add(checklistGoal);
                    }
                }
                ShowSpinner(1);
                Console.Clear();
                Console.WriteLine("File loaded.\n");
                Thread.Sleep(300);
            }
    }
    private void ShowSpinner(int seconds)
    {
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(seconds);

        while (currentTime < futureTime)
        {
            List<string> characters = ["\\", "|", "/", "-", "\\", "|", "/", "-"];
            foreach (string character in characters)
            {
                Console.Write(character);
                Thread.Sleep(300);
                Console.Write("\b \b");
            }
            currentTime = DateTime.Now;
        }
    }
}