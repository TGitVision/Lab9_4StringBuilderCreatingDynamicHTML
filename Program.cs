using System;

namespace Lab9_4StringBuilderCreatingDynamicHTML
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from Lab9_4StringBuilderCreatingDynamicHTML!");

            HtmlPageBuilder htmlPageBuilder = new HtmlPageBuilder();
            htmlPageBuilder.CollectThenCreateHTML();

        }
    }
}
