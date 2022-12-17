using System;
using System.IO;

namespace SplitFileByLineNumber
{
	public class SplitByLineNumber
	{
		public static void Execute() {
            Console.Write("> ");
            var maxLines = int.Parse(Console.ReadLine());

            var filename = "cacheClear.txt";
            //var filename = ofd.FileName;
            var fileStream = File.OpenRead(filename);
            var readStream = new StreamReader(fileStream);

            var nameBase = filename[0..^4]; //strip .txt

            var parts = 1;
            var notfinished = true;
            while (notfinished)
            {
                var part = File.OpenWrite($"{nameBase}-{parts}.txt");
                var writer = new StreamWriter(part);
                for (int i = 0; i < maxLines; i++)
                {
                    writer.WriteLine(readStream.ReadLine());
                    if (readStream.EndOfStream)
                    {
                        notfinished = false;
                        break;
                    }
                }
                writer.Close();
                parts++;
            }

            Console.WriteLine($"Done splitting the file into {parts} parts.");
        }
	}
}
