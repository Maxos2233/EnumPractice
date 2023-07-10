using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Allergies
    {
        [Flags]
        public enum Allergen
        {
            Eggs = 1,
            Peanuts = 2,
            Shellfish = 4,
            Strawberries = 8,
            Tomatoes = 16,
            Chocolate = 32,
            Pollen = 64,
            Cats = 128
        }

        public string Name { get; private set; }
        public int Score { get; private set; }
        public string allergen { get; private set; }
        public Allergies(string name)
        {
            Name = name;
        }

        public Allergies(string name, int score)
        {
            Name = name;
            Score = score;
        }

        public Allergies(string name, string allergenName)
        {
            Name = name;
            allergen = allergenName;
        }

        public override string ToString()
        {
            if (Score == 0 && allergen == null)
            {
                return $"{Name} has no allergies";
            }
            if (Score > 1)
            {
                return $"{Name} is allergic to {(Allergen)Score}";
            }
            if (allergen != null)
            {
                return $"{Name} is allergic to {stringToAllergen()}";
            }
            else
            {
                return "";
            }
        }

        public Allergen stringToAllergen()
        {
            Allergen score = 0;
            string[] words = allergen.Split(' ');
            foreach (string s in words)
            {
                if (s == "Eggs")
                {
                    score += 1;
                }

                if (s == "Peanuts")
                {
                    score += 2;
                }

                if (s == "Shellfish")
                {
                    score += 4;
                }

                if (s == "Strawberries")
                {
                    score += 8;
                }

                if (s == "Tomatoes")
                {
                    score += 16;
                }

                if (s == "Chocolate")
                {
                    score += 32;
                }

                if (s == "Pollen")
                {
                    score += 64;
                }

                if (s == "Cats")
                {
                    score += 128;
                }
            }
            return score;
        }



    }
}
