using System;
using System.Collections.Generic;
using System.Text;
using NPCGenerator.Model;

namespace NPCGenerator.Services
{
    static class GenerateChar
    {

        public static void RandomTraits()
        {
            RandomSex();
            RandomRace();
            RandomName();
            RandomAge();
            RandomJob();                       
        }

        public static void RandomSex()
        {
            Random RandomNumber = new Random();

            int Zahl = RandomNumber.Next(0, Model.DataModel.SexList.Count);

            AppModel.Instance.AllProperties[2].Content = Model.DataModel.SexList[Zahl];
        }

        private static void RandomRace()
        {
            Random RandomNumber = new Random();
            int Zahl = RandomNumber.Next(1, Model.DataModel.RaceList.Count);

            AppModel.Instance.AllProperties[1].Content = Model.DataModel.RaceList[Zahl];
        }

        private static void RandomName()
        {
            if(AppModel.Instance.AllProperties[2].Content.ToString() == "Male")
            {
                Random RandomNumber = new Random();
                int Zahl = RandomNumber.Next(1, Model.DataModel.MaleNameList.Count);

                AppModel.Instance.AllProperties[0].Content = Model.DataModel.MaleNameList[Zahl];
            }
            else if(AppModel.Instance.AllProperties[2].Content.ToString() == "Female")
            {
                Random RandomNumber = new Random();
                int Zahl = RandomNumber.Next(1, Model.DataModel.FemaleNameList.Count);

                AppModel.Instance.AllProperties[0].Content = Model.DataModel.FemaleNameList[Zahl];
            }
            else
            {
                Random RandomNumber = new Random();
                int Zahl = RandomNumber.Next(1, Model.DataModel.ObjectNameList.Count);

                AppModel.Instance.AllProperties[0].Content = Model.DataModel.ObjectNameList[Zahl];
            }

        }

        public static void RandomAge()
        {
            Random RandomNumber = new Random();
            int Zahl = RandomNumber.Next(16, 120);

            AppModel.Instance.AllProperties[3].Content = Zahl;
        }

        public static void RandomJob()
        {
            if (AppModel.Instance.CurrentGenre == AppModel.Instance.Genres[0])
            {
                Random RandomNumber = new Random();
                int Zahl = RandomNumber.Next(1, Model.DataModel.JobFantasyList.Count);

                AppModel.Instance.AllProperties[4].Content = Model.DataModel.JobFantasyList[Zahl];
            }
            else if (AppModel.Instance.CurrentGenre == AppModel.Instance.Genres[1])
            {
                Random RandomNumber = new Random();
                int Zahl = RandomNumber.Next(1, Model.DataModel.JobShandowrunList.Count);

                AppModel.Instance.AllProperties[4].Content = Model.DataModel.JobShandowrunList[Zahl];
            }
            else if (AppModel.Instance.CurrentGenre == AppModel.Instance.Genres[2])
            {
                Random RandomNumber = new Random();
                int Zahl = RandomNumber.Next(1, Model.DataModel.JobModernList.Count);

                AppModel.Instance.AllProperties[4].Content = Model.DataModel.JobModernList[Zahl];
            }
            else
            {
                Random RandomNumber = new Random();
                int Zahl = RandomNumber.Next(1, Model.DataModel.JobFallbackList.Count);

                AppModel.Instance.AllProperties[4].Content = Model.DataModel.JobFallbackList[Zahl];
            }
        }

    }
}
