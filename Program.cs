using System;

class Program
{
    static void Main(string[] args)
    {
        DiceRoll1();
    }

    static void DiceRoll1()
    {
        List<int> numberrolls = new List<int>();
        Random random = new Random();


        for (int i = 0; i < 100; i++)
        {
            int roll = random.Next(1, 7); // Generates a random number between 1 and 6
            numberrolls.Add(roll); // Adds the roll to the list
        }

        if (numberrolls.Contains(7))
        {
            List<int> sevens = new List<int>();
            foreach (int roll in numberrolls)
            {
                if (roll == 7)
                {
                    sevens.Add(roll);
                }
            }
            return sevens.Count; // Returns the number of sevens in the list
        }

    }

   static void Main2(string[] args)
    {
        DiceRoll2();
    }

    static void DiceRoll2()
    {
        List<int> numberrolls2 = new List<int>();
        Random random = new Random();


        for (int i = 0; i < 100; i++)
        {
            int roll = random.Next(1, 7); // Generates a random number between 1 and 6
            numberrolls2.Add(roll); // Adds the roll to the list
        }
        if (numberrolls2.Contains(7))
        {
            List<int> sevens2 = new List<int>();
            foreach (int roll in numberrolls2)
            {
                if (roll == 7)
                {
                    sevens2.Add(roll);
                }
            }
            return sevens2.Count; // Returns the number of sevens in the list

            
        }
    }
 
}
