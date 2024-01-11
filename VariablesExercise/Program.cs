namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string dogName = "Frisco";
            int dogAge = 6;
            char firstLetter = 'F';
            bool areDogsCute = false;
            bool isFriscoCute = true;
            double randomNumber = 436218.4231684512378;
            decimal biggerRandomNumber = 4512794631289654.423561794638573489547m;

            string[] petType = new string[] { "dog", "cat", "bird", "hamster", "snake" };

            Console.WriteLine($"I have a {dogAge}-year-old {petType[0]} named {dogName}, which begins with the letter {firstLetter}.");
            Console.WriteLine($"If you asked me if all dogs are cute, I might say {areDogsCute}, but if you asked me if {dogName} is cute I would say {isFriscoCute}.");
            Console.WriteLine($"{randomNumber} is a random number.");
            Console.WriteLine($"{biggerRandomNumber} is a bigger random number.");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("What is your name?");
            string? name = Console.ReadLine();

            Console.WriteLine($"Nice to meet you, {name}. How old are you?");
            int? age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"I remember being {age}. Now I have gained all the wisdom of the universe.");
            Console.WriteLine($"Is there anything you want to do before turning {age + 1}?");
            string? goal = Console.ReadLine();

            Console.WriteLine($"{goal} is a great goal!");
        }
    }
}
