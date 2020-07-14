using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab9_4StringBuilderCreatingDynamicHTML
{
    class FileWriter
    {
        // private const string userLogFile = @"C:\weblogs\userlog.txt";

        private string fileNameWithPath;
        private string inputTextData;

        public FileWriter(string fileNameWithPath, string inputTextData) 
        {
            this.fileNameWithPath = fileNameWithPath;
            this.inputTextData = inputTextData;
        }

        public void WriteThisFile() 
        {
            //string fileName = userLogFile;
            //string data = "Print this info to a log. \n";

            string fileName = fileNameWithPath;
            string data = inputTextData;
            File.AppendAllText(fileName, data);
            
        }

    }
}
