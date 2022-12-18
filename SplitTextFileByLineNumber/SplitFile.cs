using System;
using System.IO;
using System.Text;

namespace SplitFileByLineNumber
{
	public static class SplitFile
	{
        public static void Execute(string inputFilePath, int numOfLines)
        {
            try 
            {
                if (numOfLines < 1) 
                {
                    Console.WriteLine("Number of lines should be a value greater than 0");
                    return;
                }
                int counter = 0, totalcounter = 0, countFileGroup = 1;
                var splitFilePath = inputFilePath.Split('\\');
                var fileName = (splitFilePath[splitFilePath.Length - 1]).Split('.');
                var newFileName = fileName[0] + "_";
                var fileExtension = fileName[1];
                var outputPath = @"C:\PProjects\TestFiles\OutputFile\{0}."+ fileExtension;
                var newFile = new StringBuilder();
 
                foreach (string line in File.ReadLines(inputFilePath))
                {
                    newFile.AppendLine(line);
                    counter++;
                    totalcounter++;

                    if (counter == numOfLines)
                    {
                        var outputFilePath = String.Format(outputPath, newFileName + countFileGroup);
                        File.WriteAllText(outputFilePath, newFile.ToString());
                        counter = 0;
                        countFileGroup++;
                        newFile = new StringBuilder();
                    }
                }

                if (counter > 0)
                {
                    var outputFilePath = String.Format(outputPath, newFileName + countFileGroup);
                    File.WriteAllText(outputFilePath, newFile.ToString());
                }

                Console.WriteLine("There were {0} lines.", totalcounter);
            
                Console.ReadLine(); // Suspend the screen. 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
