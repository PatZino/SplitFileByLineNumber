namespace SplitFileByLineNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			//var filePath = @"C:\PProjects\TestFiles\cacheClear.txt";
			var filePath = @"C:\Store\Downloads\ItemDescription\ItemDescription_1.csv";
			var numOfLines = 30000;
			SplitFile.Execute(filePath, numOfLines);
		}
	}
}
