namespace Task7
{
    internal class Program
    {
        static bool checkCharacter(char character)
        {
            if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a character: ");
            char c = char.Parse(Console.ReadLine());
            Console.WriteLine(checkCharacter(c));
        }
    }
}
