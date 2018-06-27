using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace NPCGenerator.Model
{
    static public class DataModel
    {
        static PropertyModels Props = AppModel.Instance.AllProperties;
        static public List<object> MaleNameList = new List<object>() { "Hans Martin", "Jack", "Oberon", "Laskin","Mulder","Bug", "Nao", "Tourch", "Khaless", "Lucius" };
        static public List<object> FemaleNameList = new List<object>() { "Sarah", "Ana", "Daisy", "Mara", "Miranda", "IceQueen", "Letizia", "Romy", "Rosalie", "Burnhilde" };
        static public List<object> ObjectNameList = new List<object>() {"Subject 47", "Object 2", "Prisoner  Zero", "Kieselchen", "Thing", "Zyrilix" };
        static public List<object> SexList = new List<object>() {"Male","Female","Neutral" };
        static public List<object> RaceList = new List<object>() { "Human", "Elf", "Dwarf", "Windling", "Orc", "A.I.", "Mutant", "Hobbit", "Ghost" };
        static public List<object> JobFantasyList = new List<object>() {"Warrior", "Mage", "Thief", "Singer", "Scout", "Scholar", "Hunter", "Farmer", "Smith", "Cleric", "Robber", "Carpenter"};
        static public List<object> JobShandowrunList = new List<object>() { "StreetSam", "Hacker", "Rigger", "Mage", "Adept", "Social", "Squater", "Ganger", "Exec", "Smuggler"};
        static public List<object> JobModernList = new List<object>() {"Teacher", "Baker", "Doctor", "Student", "Taxidriver", "Programmer", "Barkeeper", "Politican" };
        static public List<object> JobFallbackList = new List<object>() {"Adventurer", "Pirate", "Dancer", "Cop", "Politican", "Engineer", "Salesman" };
        static public List<object> AbilityJobFantasy = new List<object>() { };
        static public List<object> AbilityHobby = new List<object>() { "Cooking", "Chess", "Crafting", "Gambling", "Climbing", "Drawing", "Football", "Swimming", "Boxing", "Rhetoric", "Chemistry", "Gossip" };
        static public List<object> EyeList = new List<object>() { "Blue", "Green", "Red", "Amber", "Silver", "Seagreen", "Brown", "Blind", "No Eyes", "Golden Cateyes", "Grey"};
        static public List<object> HairstyleList = new List<object>() { "Short", "long with Braid ", "Afro", "Rhasta", "Quiff", "Emo", "UnderCut", "Mohark", "Punk", "long and open", "Military Cut" };
        static public List<object> HairColourList = new List<object>() { "white", "blond", "dark blond", "reddish", "brown", "dark brown", "grey", "black", "blue", "amber", "violett" };

        static public List<object> Placeholder = new List<object>() { };

        // New System

        static public List<PossiblePropertyContent> SexListNew = new List<PossiblePropertyContent>() {
            new PossiblePropertyContent("Male", ()=>true){ },
            new PossiblePropertyContent("Female", ()=>true){ },
            new PossiblePropertyContent("Neutral", ()=>true){ },
        };
        static public List<PossiblePropertyContent> NameListNew = new List<PossiblePropertyContent>() {
            new PossiblePropertyContent("Hans Martin", 
                ()=>Props["Sex"].Content as string =="Male"
                ){ },
            new PossiblePropertyContent("Sarah", ()=>Props["Sex"].Content as string =="Female"){ },
            new PossiblePropertyContent("Subject 47", ()=>Props["Sex"].Content as string =="Neutral"){ }
        };
        //static public List<object> MaleNameList = new List<object>() { "", "Jack", "Oberon", "Laskin", "Mulder", "Bug", "Nao", "Tourch", "Khaless", "Lucius" };
        //static public List<object> FemaleNameList = new List<object>() { "", "Ana", "Daisy", "Mara", "Miranda", "IceQueen", "Letizia", "Romy", "Rosalie", "Burnhilde" };
        //static public List<object> ObjectNameList = new List<object>() { "", "Object 2", "Prisoner  Zero", "Kieselchen", "Thing", "Zyrilix" };




    }
}
