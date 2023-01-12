namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");

            string subject = Console.ReadLine();    

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("Gross, I hate math!");
                    break;

                case "english":
                    Console.WriteLine("Oh cool, yeah English is pretty easy.");
                    break;

                case "history":
                    Console.WriteLine("I LOVE History!");
                    break;

                case "science":
                    Console.WriteLine("Science is very cool.");
                    break;

                default:
                    Console.WriteLine("I don't think I took that class.");
                    break;

            }











        }
    }
}