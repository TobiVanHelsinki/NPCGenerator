using System;
using System.Collections.Generic;
using System.Text;

namespace NPCGenerator.Model
{
    static public class DataModel
    {
        static public List<String> MaleNameList = new List<string>() { "Hans Martin", "Jack", "Oberon", "Laskin","Mulder","Bug", "Nao" };
        static public List<String> FemaleNameList = new List<string>() { "Sarah", "Ana", "Daisy", "Mara", "Miranda", "IceQueen", "Letizia" };
        static public List<String> ObjectNameList = new List<string>() {"Subject 47", "Object 2", "Prisoner  Zero", "Kieselchen", "Thing", "Zyrilix" };
        static public List<String> SexList = new List<string>() {"Male","Female","Neutral","a stone" };
        static public List<String> RaceList = new List<string>() { "Human", "Elf", "Dwarf", "Windling", "Orc", "A.I.", "Mutant" };
        static public List<String> JobFantasyList = new List<string>() {"Warrior", "Mage", "Thief", "Singer", "Scout", "Scholar"};
        static public List<String> JobShandowrunList = new List<string>() { "StreetSam", "Hacker", "Rigger", "Mage", "Adept", "Social", "Squater", "Ganger", "Exec", "Smuggler"};
        static public List<String> JobModernList = new List<string>() {"Teacher", "Baker", "Doctor", "Student", "Taxidriver", "Programmer", "Barkeeper" };
        static public List<String> JobFallbackList = new List<string>() {"Adventurer", "Pirate", "Dancer", "Cop", "Politican" };


        static public List<String> Placeholder = new List<string>() { };


    }
}
