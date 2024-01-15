namespace Lab1_Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a char: ");
            char character = char.Parse(Console.ReadLine());

            if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("consonant");
            }

            /*
             switch statement:
             Selection statement executes code of one of the conditions
             based on a conditional expression. It's an alternative to using the if
             else statement.
             The conditional expression can be a char or a number only.
             */
        }
    }
}
