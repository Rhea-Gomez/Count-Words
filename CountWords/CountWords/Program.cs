namespace CountWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfWords;
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            var words = sentence.Split(' ');

            numberOfWords = words.Length;

            Console.WriteLine("Total words: " + numberOfWords);
            
        }
    }
}
