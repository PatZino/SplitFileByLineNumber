using System;
using SplitTextFileByLineNumber;
using Xunit;

namespace TestSplitTextFileByLineNumber
{
	public class UnitTest1
	{
		[Fact]
		public void Test1()
		{
			var filePath = @"C:\PProjects\TestFiles\cacheClear.txt";
			var numOfLines = 12;
			SplitFile.Execute(filePath, numOfLines);
		}
	}
}
