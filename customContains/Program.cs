namespace customContains
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string sentence = "Bu bir bur custom"; // custom contains methodudur

            Console.WriteLine(sentence.customContains("bur"));

        }
    }
}