using NPCGenerator.Model;
using System;
using System.Collections.Generic;

namespace NPCGenerator.Data
{
    class HardCoded
    {
        #region Model Access Points
        static AppModel Model => AppModel.Instance;
        static PropertyModels Props => AppModel.Instance.AllProperties;
        static GenreModel Genre => AppModel.Instance.CurrentGenre;
        #endregion
        #region Consts
        public const string Name = "Name";
        public const string Sex = "Sex";
        public const string Race = "Race";
        public const string Job = "Job";
        public const string Age = "Age";
        public const string Hobby = "Hobby";
        public const string Eye = "Eye";
        public const string HairStyle = "HairStyle";
        public const string HairColor = "HairColor";
        public const string Birthdate = "Birthdate";
        public const string Abilities = "Abilities";
        

        public const string GenreShadowRun = "ShadowRun";
        public const string GenreFantasy = "Fantasy";
        public const string GenreModern = "Modern";
        #endregion

        #region Content Lists

        static public IEnumerable<PossiblePropertyContent> JobList = new List<PossiblePropertyContent>()
        {
            new PossiblePropertyContent("Warrior", ()=>Genre.GenreName == GenreFantasy),
            new PossiblePropertyContent("Mage", ()=>Genre.GenreName == GenreFantasy),
            new PossiblePropertyContent("Thief", ()=>Genre.GenreName == GenreFantasy),
            new PossiblePropertyContent("Singer", ()=>Genre.GenreName == GenreFantasy),
            new PossiblePropertyContent("Scout", ()=>Genre.GenreName == GenreFantasy),
            new PossiblePropertyContent("Scholar", ()=>Genre.GenreName == GenreFantasy),
            new PossiblePropertyContent("Hunter", ()=>Genre.GenreName == GenreFantasy),
            new PossiblePropertyContent("Farmer", ()=>Genre.GenreName == GenreFantasy),
            new PossiblePropertyContent("Smith", ()=>Genre.GenreName == GenreFantasy),
            new PossiblePropertyContent("Cleric", ()=>Genre.GenreName == GenreFantasy),
            new PossiblePropertyContent("Robber", ()=>Genre.GenreName == GenreFantasy),
            new PossiblePropertyContent("Carpenter", ()=>Genre.GenreName == GenreFantasy),

            new PossiblePropertyContent("StreetSam", ()=>Genre.GenreName == GenreShadowRun),
            new PossiblePropertyContent("Hacker", ()=>Genre.GenreName == GenreShadowRun),
            new PossiblePropertyContent("Rigger", ()=>Genre.GenreName == GenreShadowRun),
            new PossiblePropertyContent("Mage", ()=>Genre.GenreName == GenreShadowRun),
            new PossiblePropertyContent("Adept", ()=>Genre.GenreName == GenreShadowRun),
            new PossiblePropertyContent("Social", ()=>Genre.GenreName == GenreShadowRun),
            new PossiblePropertyContent("Squater", ()=>Genre.GenreName == GenreShadowRun),
            new PossiblePropertyContent("Ganger", ()=>Genre.GenreName == GenreShadowRun),
            new PossiblePropertyContent("Exec", ()=>Genre.GenreName == GenreShadowRun),
            new PossiblePropertyContent("Smuggler", ()=>Genre.GenreName == GenreShadowRun),

            new PossiblePropertyContent("Teacher", ()=>Genre.GenreName == GenreModern),
            new PossiblePropertyContent("Baker", ()=>Genre.GenreName == GenreModern),
            new PossiblePropertyContent("Doctor", ()=>Genre.GenreName == GenreModern),
            new PossiblePropertyContent("Student", ()=>Genre.GenreName == GenreModern),
            new PossiblePropertyContent("Taxidriver", ()=>Genre.GenreName == GenreModern),
            new PossiblePropertyContent("Programmer", ()=>Genre.GenreName == GenreModern),
            new PossiblePropertyContent("Barkeeper", ()=>Genre.GenreName == GenreModern),
            new PossiblePropertyContent("Politican", ()=>Genre.GenreName == GenreModern),

            new PossiblePropertyContent("Adventurer"),
            new PossiblePropertyContent("Pirate"),
            new PossiblePropertyContent("Dancer"),
            new PossiblePropertyContent("Cop"),
            new PossiblePropertyContent("Politican"),
            new PossiblePropertyContent("Engineer"),
            new PossiblePropertyContent("Salesman"),
        };

        static public IEnumerable<PossiblePropertyContent> SexList = new List<PossiblePropertyContent>() {
            new PossiblePropertyContent("Male"),
            new PossiblePropertyContent("Female"),
            new PossiblePropertyContent("Neutral"),
        };

        static public IEnumerable<PossiblePropertyContent> RaceList = new List<PossiblePropertyContent>() {
            new PossiblePropertyContent("Human"),
            new PossiblePropertyContent("Elf"),
            new PossiblePropertyContent("Dwarf"),
            new PossiblePropertyContent("Windling"),
            new PossiblePropertyContent("Orc"),
            new PossiblePropertyContent("A.I"),
            new PossiblePropertyContent("Mutant"),
            new PossiblePropertyContent("Hobbit"),
            new PossiblePropertyContent("Ghost"),
        };

        static public IEnumerable<PossiblePropertyContent> NameList = new List<PossiblePropertyContent>() {
            new PossiblePropertyContent("Hans Martin", ()=>Props[Sex].Content as string =="Male"),
            new PossiblePropertyContent("Jack", ()=>Props[Sex].Content as string =="Male"),
            new PossiblePropertyContent("Oberon", ()=>Props[Sex].Content as string =="Male"),
            new PossiblePropertyContent("Laskin", ()=>Props[Sex].Content as string =="Male"),
            new PossiblePropertyContent("Mulder", ()=>Props[Sex].Content as string =="Male"),
            new PossiblePropertyContent("Bug", ()=>Props[Sex].Content as string =="Male"),
            new PossiblePropertyContent("Nao", ()=>Props[Sex].Content as string =="Male"),
            new PossiblePropertyContent("Tourch", ()=>Props[Sex].Content as string =="Male"),
            new PossiblePropertyContent("Khaless", ()=>Props[Sex].Content as string =="Male"),
            new PossiblePropertyContent("Lucius", ()=>Props[Sex].Content as string =="Male"),

            new PossiblePropertyContent("Sarah", ()=>Props[Sex].Content as string =="Female"),
            new PossiblePropertyContent("Ana", ()=>Props[Sex].Content as string =="Female"),
            new PossiblePropertyContent("Daisy", ()=>Props[Sex].Content as string =="Female"),
            new PossiblePropertyContent("Mara", ()=>Props[Sex].Content as string =="Female"),
            new PossiblePropertyContent("Miranda", ()=>Props[Sex].Content as string =="Female"),
            new PossiblePropertyContent("IceQueen", ()=>Props[Sex].Content as string =="Female"),
            new PossiblePropertyContent("Letizia", ()=>Props[Sex].Content as string =="Female"),
            new PossiblePropertyContent("Romy", ()=>Props[Sex].Content as string =="Female"),
            new PossiblePropertyContent("Rosalie", ()=>Props[Sex].Content as string =="Female"),
            new PossiblePropertyContent("Burnhilde", ()=>Props[Sex].Content as string =="Female"),

            new PossiblePropertyContent("Subject 47", ()=>Props[Sex].Content as string =="Neutral"),
            new PossiblePropertyContent("Object 2", ()=>Props[Sex].Content as string =="Neutral"),
            new PossiblePropertyContent("Prisoner 0", ()=>Props[Sex].Content as string =="Neutral"),
            new PossiblePropertyContent("Zero", ()=>Props[Sex].Content as string =="Neutral"),
            new PossiblePropertyContent("Kieselchen", ()=>Props[Sex].Content as string =="Neutral"),
            new PossiblePropertyContent("Thing", ()=>Props[Sex].Content as string =="Neutral"),
            new PossiblePropertyContent("Zyrilix", ()=>Props[Sex].Content as string =="Neutral")
        };

        static public IEnumerable<PossiblePropertyContent> EyeList = new List<PossiblePropertyContent>() {
            new PossiblePropertyContent("Blue"),
            new PossiblePropertyContent("Green"),
            new PossiblePropertyContent("Red"),
            new PossiblePropertyContent("Amber"),
            new PossiblePropertyContent("Silver"),
            new PossiblePropertyContent("Seagreen"),
            new PossiblePropertyContent("Brown"),
            new PossiblePropertyContent("Blind"),
            new PossiblePropertyContent("No Eyes"),
            new PossiblePropertyContent("Golden Cateyes"),
            new PossiblePropertyContent("Grey"),
        };

        static public IEnumerable<PossiblePropertyContent> HairStyleList = new List<PossiblePropertyContent>() {
            new PossiblePropertyContent("Short"),
            new PossiblePropertyContent("long with Braid"),
            new PossiblePropertyContent("Afro"),
            new PossiblePropertyContent("Rhasta"),
            new PossiblePropertyContent("Quiff"),
            new PossiblePropertyContent("Emo"),
            new PossiblePropertyContent("Mohark"),
            new PossiblePropertyContent("Punk"),
            new PossiblePropertyContent("long and open"),
            new PossiblePropertyContent("Military Cut"),
        };

        static public IEnumerable<PossiblePropertyContent> HairColorList = new List<PossiblePropertyContent>() {
            new PossiblePropertyContent("white"),
            new PossiblePropertyContent("blond"),
            new PossiblePropertyContent("dark blond"),
            new PossiblePropertyContent("reddish"),
            new PossiblePropertyContent("brown"),
            new PossiblePropertyContent("dark brown"),
            new PossiblePropertyContent("grey"),
            new PossiblePropertyContent("black"),
            new PossiblePropertyContent("blue"),
            new PossiblePropertyContent("amber"),
            new PossiblePropertyContent("violett"),
        };

        static public IEnumerable<PossiblePropertyContent> HobbyList = new List<PossiblePropertyContent>() {
            new PossiblePropertyContent("Cooking"),
            new PossiblePropertyContent("Chess"),
            new PossiblePropertyContent("Crafting"),
            new PossiblePropertyContent("Gambling"),
            new PossiblePropertyContent("Climbing"),
            new PossiblePropertyContent("Swimming"),
            new PossiblePropertyContent("Boxing"),
            new PossiblePropertyContent("Football"),
            new PossiblePropertyContent("Drawing"),
            new PossiblePropertyContent("Rhetoric"),
            new PossiblePropertyContent("Chemistry"),
            new PossiblePropertyContent("Gossip"),
        };

        static public IEnumerable<PossiblePropertyContent> AbilityList = new List<PossiblePropertyContent>() {
            new PossiblePropertyContent("Warrior", ()=>Genre.GenreName == GenreFantasy),
            new PossiblePropertyContent("Mage", ()=>Genre.GenreName == GenreFantasy),
            new PossiblePropertyContent("Thief", ()=>Genre.GenreName == GenreFantasy),
            new PossiblePropertyContent("Singer", ()=>Genre.GenreName == GenreFantasy),
            new PossiblePropertyContent("Scout", ()=>Genre.GenreName == GenreFantasy),
            new PossiblePropertyContent("Scholar", ()=>Genre.GenreName == GenreFantasy),
            new PossiblePropertyContent("Hunter", ()=>Genre.GenreName == GenreFantasy),
            new PossiblePropertyContent("Farmer", ()=>Genre.GenreName == GenreFantasy),
            new PossiblePropertyContent("Smith", ()=>Genre.GenreName == GenreFantasy),
            new PossiblePropertyContent("Cleric", ()=>Genre.GenreName == GenreFantasy),
            new PossiblePropertyContent("Robber", ()=>Genre.GenreName == GenreFantasy),
            new PossiblePropertyContent("Carpenter", ()=>Genre.GenreName == GenreFantasy),

            new PossiblePropertyContent("StreetSam", ()=>Genre.GenreName == GenreShadowRun),
            new PossiblePropertyContent("Hacker", ()=>Genre.GenreName == GenreShadowRun),
            new PossiblePropertyContent("Rigger", ()=>Genre.GenreName == GenreShadowRun),
            new PossiblePropertyContent("Mage", ()=>Genre.GenreName == GenreShadowRun),
            new PossiblePropertyContent("Adept", ()=>Genre.GenreName == GenreShadowRun),
            new PossiblePropertyContent("Social", ()=>Genre.GenreName == GenreShadowRun),
            new PossiblePropertyContent("Squater", ()=>Genre.GenreName == GenreShadowRun),
            new PossiblePropertyContent("Ganger", ()=>Genre.GenreName == GenreShadowRun),
            new PossiblePropertyContent("Exec", ()=>Genre.GenreName == GenreShadowRun),
            new PossiblePropertyContent("Smuggler", ()=>Genre.GenreName == GenreShadowRun),

        };

        #endregion

        public static void CreateTestModel()
        {
            Model.Genres.Add(new GenreModel(GenreFantasy, "fantasy.jpg") { StartDate = new DateTime(1500, 1, 1) });
            Model.Genres.Add(new GenreModel(GenreShadowRun, "shadowrun.png") { StartDate = new DateTime(1977, 1, 1) });
            Model.Genres.Add(new GenreModel(GenreModern, "modern.jpg"));
            Model.Genres.Add(new GenreModel("More", "more.jpg"));

            //Ordering neccesary for functional dependencies
            Props.Add(new PropertyModel(Sex, PropertyTypes.String, SexList));
            Props.Add(new PropertyModel(Race, PropertyTypes.String, RaceList));
            Props.Add(new PropertyModel(Name, PropertyTypes.String, NameList));
            Props.Add(new PropertyModel(Job, PropertyTypes.String, JobList));
            Props.Add(new PropertyModel(Age, PropertyTypes.Int, new DynamicAgeCollection(100)));
            Props.Add(new PropertyModel(Hobby, PropertyTypes.String, HobbyList) { Content = "NDY" });
            Props.Add(new PropertyModel(Eye, PropertyTypes.String, EyeList));
            Props.Add(new PropertyModel(HairColor, PropertyTypes.String, HairColorList));
            Props.Add(new PropertyModel(HairStyle, PropertyTypes.String, HairStyleList));
            Props.Add(new PropertyModel(Birthdate, PropertyTypes.Date, new DynamicDateCollection()));
            Props.Add(new PropertyModel(Abilities, PropertyTypes.String, new ListCollection(4, AbilityList)));
            
            //Props.Add(new PropertyModel(Special_Placeholder,  PropertyTypes.Boolean, Content = false );

            //Use All properties at all Genres
            for (int i = 0; i < Props.Count; i++)
            {
                for (int j = 0; j < Model.Genres.Count; j++)
                {
                    Model.Genres[j].UsedProperties.Add(Props[i]);
                }
            }
        }

    }
}
