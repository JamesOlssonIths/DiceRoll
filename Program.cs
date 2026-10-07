namespace DiceRoll;

class Program
{
    static void Main()
    {
        try // coden är såpass simple att det aldrig används men visar att jag kan :)
        {
            var rnd = new Random();
            System.Console.WriteLine("---Dice-Roll---");
            System.Console.WriteLine("To start press y if not pressed game will end");
            
                while (Checkinput())
                { 
                    int firstDice = rnd.Next(1,7);
                    int secondDice = rnd.Next(1,7);
                    int sum = firstDice + secondDice;

                    System.Console.WriteLine("-------------------------------");
                    System.Console.WriteLine($"First dice roll: {firstDice}");
                    System.Console.WriteLine("First dice roll: {0}", secondDice);
                    System.Console.WriteLine("-------------------------------");
                    System.Console.WriteLine($"The sum: {sum}");
                    System.Console.WriteLine("-------------------------------");

                    System.Console.WriteLine(WinnerOrNot(sum));

                    System.Console.WriteLine("Wanna play agian press y else any other button");
                } 
             
            System.Console.WriteLine("Welcome back");
           
        }
        catch (Exception ex)
        {    
            System.Console.WriteLine(ex.Message);
        }
    
        static bool Checkinput() // skulle kunna göra return Cosnole.readline() == "y"
        {
            if(Console.ReadLine() == "y"){return true;}
            else {return false;}
    
        }
        static string WinnerOrNot(int sum) // Skulle kunna göra return sum == 12 ? Conqrats : loser
        {
            if(sum == 12)
            {
                return "Conqrats you won";
                
            }
            return "Loser!!";

        }
    }
}
