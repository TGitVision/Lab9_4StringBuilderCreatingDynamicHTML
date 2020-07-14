using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab9_4StringBuilderCreatingDynamicHTML
{

    class HtmlPageBuilder
    {

        private StringBuilder htmlText = new StringBuilder();

        private string bodyOpen { get; set; } = "<body>";
        private string bodyClose { get; set; } = "</body>";
        private string htmlParaOpen { get; set; } = "<p>";
        private string htmlParaClose { get; set; } = "</p>";
        private string htmlHeader1Open { get; set; } = "<h1>";
        private string htmlHeader1Close { get; set; } = "</h1>";
        private string htmlUnorderedOpen { get; set; } = "<ul>";
        private string htmlUnorderedClose { get; set; } = "</ul>";
        private string htmlLIOpen { get; set; } = "<li>";
        private string htmlLIClose { get; set; } = "</li>";
        private string dynamicHtml { get; set; } = string.Empty;

        public HtmlPageBuilder() 
        { 
        
        }

        public HtmlPageBuilder(string bodyOpen, string bodyClose, string htmlParaOpen, 
                                string htmlParaClose, string htmlHeader1Open, string htmlHeader1Close,
                                string htmlUnorderedOpen, string htmlUnorderedClose,
                                string htmlLIOpen, string htmlLIClose)
        {
           
            this.bodyOpen = bodyOpen;
            this.bodyClose = bodyClose;
            this.htmlParaOpen = htmlParaOpen;
            this.htmlParaClose = htmlParaClose;
            this.htmlUnorderedOpen = htmlUnorderedOpen;
            this.htmlUnorderedClose = htmlUnorderedClose;
            this.htmlLIOpen = htmlLIOpen;
            this.htmlLIClose = htmlLIClose;

        }

        public void CollectThenCreateHTML() 
        {

            // htmlText = new StringBuilder();

            htmlText.Append(bodyOpen);

            htmlText.Append(htmlHeader1Open);
            Console.WriteLine("Enter text for the HTML header.");
            dynamicHtml = Console.ReadLine();
            htmlText.Append(dynamicHtml);
            htmlText.Append(htmlHeader1Close);

            Console.WriteLine("Time to build our unordered list...");

            htmlText.Append(htmlLIOpen);
            Console.WriteLine("Add an item to the list.");
            dynamicHtml = Console.ReadLine();
            htmlText.Append(dynamicHtml);
            htmlText.Append(htmlLIClose);

            htmlText.Append(htmlLIOpen);
            Console.WriteLine("Add another item to the list.");
            dynamicHtml = Console.ReadLine();
            htmlText.Append(dynamicHtml);
            htmlText.Append(htmlLIClose);

            htmlText.Append(htmlLIOpen);
            Console.WriteLine("Add another item to the list.");
            dynamicHtml = Console.ReadLine();
            htmlText.Append(dynamicHtml);
            htmlText.Append(htmlLIClose);

            htmlText.Append(bodyClose);

            if (htmlText.ToString().Length > 0) 
            {
                WriteFile();
            }

        }

        public void WriteFile() 
        {   
            FileWriter fw = new FileWriter(@"C:\CSharpLabs\Lab9_4.html", htmlText.ToString());
            fw.WriteThisFile();
        }

    }
}
