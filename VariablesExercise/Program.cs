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
        }
    }
}
