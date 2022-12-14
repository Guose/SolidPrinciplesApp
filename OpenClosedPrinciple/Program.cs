using System;

namespace OpenClosedPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var generator = new ReportGenerator();
            var inMemoryDataProvider = new InMemoryDataProvider();
            var reportFormatter = new JsonReportFormatter();
            var formattedResult = generator.GenerateReportAsString(inMemoryDataProvider, reportFormatter);

            Console.WriteLine(formattedResult);
            Console.ReadLine();
        }
    }
}
