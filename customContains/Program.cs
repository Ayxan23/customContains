namespace customContains
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string sentence = "Bu bir custom contains methodudur";

            Console.WriteLine(sentence.customContains("Bu"));
            Console.WriteLine(sentence.customContains("bu"));
            Console.WriteLine(sentence.customContains("tains"));
            Console.WriteLine(sentence.customContains("ns Methodudur"));
            Console.WriteLine(sentence.customContains("bu bir custom"));

        }
    }
}