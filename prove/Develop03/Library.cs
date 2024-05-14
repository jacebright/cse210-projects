// This class will load a txt file with scriptures able to be memorized. Methods
// will allow user to randomly select a scripture. Each part of the scripture
// (book, chapter, etc) will be separated by the "|" character to ensure no
// splicing issues
using System.IO;

public class Library
{
    private List<Scripture> _scriptures = [];
    private string _fileName;
    public Library(string fileName)
    {
        _fileName = fileName;
        
        if (!File.Exists(fileName))
        {
            CreateFile();
        }

        using(var reader = new StreamReader(_fileName))
        {
            string firstLine = reader.ReadLine();
            while(reader.EndOfStream == false)
            {              
                var content = reader.ReadLine();
                var line = content.Split("|").ToList();

                string book = line[0];
                int chapter = Int32.Parse(line[1]);
                int startVerse = Int32.Parse(line[2]);

                if (line.Count() == 4)
                {
                    string text = line[3];
                    Reference reference = new Reference(book, chapter, startVerse);
                    Scripture scripture = new Scripture(reference, text);

                    _scriptures.Add(scripture);

                }
                else
                {
                    int endVerse = Int32.Parse(line[3]);
                    string text = line[4];
                    Reference reference = new Reference(book, chapter, startVerse, endVerse);
                    Scripture scripture = new Scripture(reference, text);

                    _scriptures.Add(scripture);
                }
            }
        }
    }
    public Scripture GetScripture()
    {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(0,_scriptures.Count);

        return _scriptures[index];
    }
    private void CreateFile()
    {
        // Create the scriptures.txt file if it does not exist in the operating directory

        List<string> text = ["Book|Chapter|First Verse|Last Verse (Optional)|Text",
                            "John|3|16|For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.",
                            "Alma|48|17|Yea, verily, verily I say unto you, if all men had been, and were, and ever would be, like unto Moroni, behold, the very powers of hell would have been shaken forever; yea, the devil would never have power over the hearts of the children of men.",
                            "Proverbs|3|5|6|Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.",
                            "Doctrine and Covenants|4|1|7|Now behold, a marvelous work is about to come forth among the children of men. Therefore, O ye that embark in the service of God, see that ye serve him with all your heart, might, mind and strength, that ye may stand blameless before God at the last day. Therefore, if ye have desires to serve God ye are called to the work; For behold the field is white already to harvest; and lo, he that thrusteth in his sickle with his might, the same layeth up in store that he perisheth not, but bringeth salvation to his soul; And faith, hope, charity and love, with an eye single to the glory of God, qualify him for the work. Remember faith, virtue, knowledge, temperance, patience, brotherly kindness, godliness, charity, humility, diligence. Ask, and ye shall receive; knock, and it shall be opened unto you. Amen.",
                            "Phillipians|4|13|I can do all things through Christ which strengtheneth me.",
                            "Heleman|5|12|And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall.",
                            "Mosiah|4|9|Believe in God; believe that he is, and that he created all things, both in heaven and in earth; believe that he has all wisdom, and all power, both in heaven and in earth; believe that man doth not comprehend all the things which the Lord can comprehend.",
                            "Mosiah|4|5|7|For behold, if the knowledge of the goodness of God at this time has awakened you to a sense of your nothingness, and your worthless and fallen state— I say unto you, if ye have come to a knowledge of the goodness of God, and his matchless power, and his wisdom, and his patience, and his long-suffering towards the children of men; and also, the atonement which has been prepared from the foundation of the world, that thereby salvation might come to him that should put his trust in the Lord, and should be diligent in keeping his commandments, and continue in the faith even unto the end of his life, I mean the life of the mortal body— I say, that this is the man who receiveth salvation, through the atonement which was prepared from the foundation of the world for all mankind, which ever were since the fall of Adam, or who are, or who ever shall be, even unto the end of the world.",
                            "Moses|1|39|For behold, this is my work and my glory— to bring to pass the immortality and eternal life of man.",
                            "Romans|8|16|The Spirit itself beareth witness with our spirit, that we are the children of God:",
                            "Amos|3|7|Surely the Lord God will do nothing, but he revealeth his secret unto his servants the prophets.",
                            "Doctrine and Covenants|25|10|And verily I say unto thee that thou shalt lay aside the things of this world, and seek for the things of a better.",
                            "Romans|8|18|For I reckon that the sufferings of this present time are not worthy to be compared with the glory which shall be revealed in us.",
                            "John|14|18|I will not leave you comfortless: I will come to you.",
                            "Doctrine and Covenants|50|40|42|Behold, ye are little children and ye cannot bear all things now; ye must grow in grace and in the knowledge of the truth. Fear not, little children, for you are mine, and I have overcome the world, and you are of them that my Father hath given me; And none of them that my Father hath given me shall be lost.",
                            "2 Nephi|8|24|25|Awake, awake, put on thy strength, O Zion; put on thy beautiful garments, O Jerusalem, the holy city; for henceforth there shall no more come into thee the uncircumcised and the unclean. Shake thyself from the dust; arise, sit down, O Jerusalem; loose thyself from the bands of thy neck, O captive daughter of Zion.",
                            "Doctrine and Covenants|6|36|Look unto me in every thought; doubt not, fear not.",
                            "1 Nephi|4|6|And I was led by the Spirit, not knowing beforehand the things which I should do."];
        using (StreamWriter writer = File.CreateText(_fileName))
        {
            foreach (string line in text)
            {
                writer.WriteLine(line);
            }
        }
    }
}