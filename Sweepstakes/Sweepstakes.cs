﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        Dictionary<int, Contestant> dictionary;
        private string name;
        private int registrationNumber;
        private Random random;
        ISweepstakesManager tool;

        public string Name { get => name; set => name = value; }
        public int RegistrationNumber { get => registrationNumber; set => registrationNumber = value; }

        public Sweepstakes()
        {
            dictionary = new Dictionary<int, Contestant>();
            name = null;
            random = new Random();
        }

        public void SweepstakesMenu()
        {
            string input = UserInterface.SweepstakeMenuOptions();

            switch (input)
            {
                case "1":
                    AddContestantMenu();
                    break;
                case "2":
                    RetreiveContestant();
                    break;
                case "3":
                    PrintDictionary();
                    break;
                case "4":
                    StartSweepstake();
                    break;
            }
        }

        public void AddContestantMenu()
        {
            CreateContestant();

            string input = UserInterface.AddMoreContestants();

            if (input.ToLower().Trim() == "y")
            {
                while (input.ToLower().Trim() == "y")
                {
                    CreateContestant();
                    input = UserInterface.MakeMoreSweepstakes();
                }
            }
            else if (input.ToLower().Trim() == "n")
            {
                SweepstakesMenu();
            }
            else
            {
                throw new ApplicationException("That input was not valid!");
            }
        }

        private void RegisterContestant(Contestant contestant)
        {
            RegistrationNumber = dictionary.Count();
            dictionary.Add(RegistrationNumber, contestant);
        }
        private void CreateContestant()
        {
            Contestant contestant = new Contestant();
            contestant = contestant.ContestantInfo();
            RegisterContestant(contestant);
            Console.Clear();
        }

        private void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(" First Name: {0} \n Last Name: {1} \n Email: {2} ", contestant.FirstName, contestant.LastName, contestant.Email);
            Console.ReadLine();
        }

        private void RetreiveContestant()
        {
            int input = Convert.ToInt32(Console.ReadLine());
            bool person = dictionary.TryGetValue(input - 1, out Contestant contestant);

            if (person == true)
            {
                PrintContestantInfo(contestant);
            }
            else if (person == false)
            {
                Console.WriteLine("No contestant was found found with that Registraiton number please try again!");
                SweepstakesMenu();
            }
        }

        private void PrintDictionary()
        {
            foreach (KeyValuePair<int, Contestant> contastant in dictionary)
            {
                Console.WriteLine("Registration Number: {0}, \n First Name: {1} \n Last Name: {2} \n Email: {3}",contastant.Key, contastant.Value.FirstName, contastant.Value.LastName, contastant.Value.Email);
                Console.ReadLine();
            }
        }

        private void StartSweepstake()
        {
            Sweepstakes sweepstakes = tool.GetSweepstakes();
            //string nameOfSweepstakes = sweepstakes.Name;
            string winner = PickWinner();
            Console.WriteLine(name + "is the winner of the", sweepstakes.Name);
            Console.ReadLine();
        }

        private string PickWinner()
        {
            int winningContestant;
            string name;

            winningContestant = random.Next(1, dictionary.Count());
            for (int i = 0; i < dictionary.Count(); i++)
            {
                if (winningContestant == dictionary.ElementAt(i).Key)
                {
                    name = dictionary.ElementAt(i).Value.FirstName + dictionary.ElementAt(i).Value.LastName;
                    return name;
                }
            }
            throw new ApplicationException("If you're seeing this....It's my fault sorry...");
        }
    }
}
