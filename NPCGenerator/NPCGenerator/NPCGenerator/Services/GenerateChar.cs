using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using NPCGenerator.Model;

namespace NPCGenerator.Services
{
    static class GenerateChar
    {
        static ObservableCollection<PropertyModel> AllProperties => AppModel.Instance.AllProperties;
        public static void RandomTraits()
        {
            if (AppModel.Instance.CurrentGenre == null)
            {
                return;
            }

            if (!AllProperties[2].IsUserFixed)
            {
                RandomSex();
            }
            if (!AllProperties[1].IsUserFixed)
            {
                RandomRace();
            }
            RandomName();
            RandomAge();
            RandomJob();
            RandomAbilitiesSmall();
            //RandomAbilities();
            RandomEyes();
            RandomHair();
        }

        public static void RandomSex()
        {
            Random RandomNumber = new Random();
            int Zahl = RandomNumber.Next(0, Model.DataModel.SexList.Count);

            AllProperties[2].Content = Model.DataModel.SexList[Zahl];
        }

        private static void RandomRace()
        {
            Random RandomNumber = new Random();
            int Zahl = RandomNumber.Next(0, Model.DataModel.RaceList.Count);

            AllProperties[1].Content = Model.DataModel.RaceList[Zahl];
        }

        private static void RandomName()
        {
            if(AllProperties[2].Content.ToString() == "Male")
            {
                Random RandomNumber = new Random();
                int Zahl = RandomNumber.Next(0, Model.DataModel.MaleNameList.Count);

                AllProperties[0].Content = Model.DataModel.MaleNameList[Zahl];
            }
            else if(AllProperties[2].Content.ToString() == "Female")
            {
                Random RandomNumber = new Random();
                int Zahl = RandomNumber.Next(0, Model.DataModel.FemaleNameList.Count);

                AllProperties[0].Content = Model.DataModel.FemaleNameList[Zahl];
            }
            else
            {
                Random RandomNumber = new Random();
                int Zahl = RandomNumber.Next(0, Model.DataModel.ObjectNameList.Count);

                AllProperties[0].Content = Model.DataModel.ObjectNameList[Zahl];
            }

        }

        public static void RandomAge()
        {
            Random RandomNumber = new Random();
            int Zahl = RandomNumber.Next(16, 120);

            AllProperties[3].Content = Zahl;
        }

        public static void RandomJob()
        {
            if (AppModel.Instance.CurrentGenre == AppModel.Instance.Genres[0])
            {
                Random RandomNumber = new Random();
                int Zahl = RandomNumber.Next(0, Model.DataModel.JobFantasyList.Count);

                AllProperties[4].Content = Model.DataModel.JobFantasyList[Zahl];
            }
            else if (AppModel.Instance.CurrentGenre == AppModel.Instance.Genres[1])
            {
                Random RandomNumber = new Random();
                int Zahl = RandomNumber.Next(0, Model.DataModel.JobShandowrunList.Count);

                AllProperties[4].Content = Model.DataModel.JobShandowrunList[Zahl];
            }
            else if (AppModel.Instance.CurrentGenre == AppModel.Instance.Genres[2])
            {
                Random RandomNumber = new Random();
                int Zahl = RandomNumber.Next(0, Model.DataModel.JobModernList.Count);

                AllProperties[4].Content = Model.DataModel.JobModernList[Zahl];
            }
            else
            {
                Random RandomNumber = new Random();
                int Zahl = RandomNumber.Next(0, Model.DataModel.JobFallbackList.Count);

                AllProperties[4].Content = Model.DataModel.JobFallbackList[Zahl];
            }
        }

        //public static void RandomAbilities()
        //{
        //    Random RandomNumber = new Random();
        //    int AbilityCount = RandomNumber.Next(2, 5);

        //    switch (AppModel.Instance.CurrentGenre.GenreName)
        //    {
        //        case "Fantasy":
        //            {
        //                if (AbilityCount <= 2)
        //                {
        //                    for (int i = 0; i < AbilityCount; i++)
        //                    {
        //                        int Zahl = RandomNumber.Next(0,DataModel.AbilityJobFantasy.Count);
        //                        AllProperties[5].Content += DataModel.AbilityJobFantasy[Zahl];
        //                    }
        //                }
        //            }
        //            break;
        //        case "Shandowrun":
        //            {

        //            }
        //            break;
        //        case "Modern":
        //            {

        //            }
        //            break;
        //        default:
        //            {

        //            }
        //            break;
        //    }
        //}

        public static void RandomEyes()
        {
            Random RandomNumber = new Random();
            int Zahl = RandomNumber.Next(0, Model.DataModel.EyeList.Count);

            AllProperties[6].Content = Model.DataModel.EyeList[Zahl];
        }

        public static void RandomHair()
        {
            Random RandomNumber = new Random();
            int Zahl = RandomNumber.Next(0, Model.DataModel.EyeList.Count);
            string ContentUpdate;

            ContentUpdate = Model.DataModel.HairColourList[Zahl] as string;

            Zahl = RandomNumber.Next(0, Model.DataModel.EyeList.Count);
            ContentUpdate = ContentUpdate + " " +Model.DataModel.HairstyleList[Zahl];

            AllProperties[7].Content = ContentUpdate;
        }

        public static void RandomAbilitiesSmall()
        {
            Random RandomNumber = new Random();
            int Zahl = RandomNumber.Next(0, Model.DataModel.AbilityHobby.Count);

            AllProperties[5].Content = DataModel.AbilityHobby[Zahl];
        }

    }
}
