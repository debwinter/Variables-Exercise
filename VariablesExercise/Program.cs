namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* This isn't exactly what y'all are asking for, but I hope it's ok!
            I'd been working on this with W3 schools and it seemed like a decent
            time to use it, considering the example includes dogName & age :) */


            Console.WriteLine("How many pets do you have?");
            int? pets = Convert.ToInt32(Console.ReadLine());

            if (pets > 1)
            {
                Console.WriteLine("What is the name of one of your pets?");
                string? petName = Console.ReadLine();

                Console.WriteLine("What type of animal is " + petName + "?");
                Console.Write($"{petName} is a: ");
                string? petType = Console.ReadLine();

                Console.WriteLine("How old is " + petName + "?");
                int? petAge = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{petAge} is a great age! I bet {petName} the {petType} is really cute!");
            }
            else if (pets >= 1)
            {
                Console.WriteLine("What type of pet do you have?");
                Console.Write("I have a: ");
                string? petType = Console.ReadLine();

                Console.WriteLine("What is your " + petType + "'s name?");
                string? petName = Console.ReadLine();

                Console.WriteLine("How old is " + petName + "?");
                int? petAge = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{petAge} is a great age! I bet {petName} the {petType} is really cute!");
            }
            else
            {
                Console.WriteLine("Wow, I bet your house is so clean!");
            }
        }
    }
}
