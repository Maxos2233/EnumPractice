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


        public Allergies(string name)
        {
            Name = name;
        }

        public Allergies(string name, int score) : this(name)
        {
            Score = score;
        }

        public Allergies(string name, string allergies) : this(name)
        {
            var allergens = Enum.GetValues<Allergen>();
            foreach (var allergy in allergies.Split(" "))
            {
                foreach (var allergen in allergens)
                {
                    if (allergen.ToString() == allergy)
                    {
                        Score += (int)allergen;
                    }
                }
                
            }
        }

        public override string ToString()
        {
            return Score == 0 ? $"{Name} has no allergies" : $"{Name} is allergic to {(Allergen)Score}";
        }
    }
}
