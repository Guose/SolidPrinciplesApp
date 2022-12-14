﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var generator = new ReportGenerator();
            var simpleInMemoryDataProvider = new SimpleInMemoryDataProvider();
            var complexInMemoryDataProvider = new ComplexInMemoryDataProvider();
            var jsonReportFormatter = new JsonReportFormatter();

            var simpleFormattedResult = generator.GenerateReportAsString(simpleInMemoryDataProvider, jsonReportFormatter);

            Console.WriteLine(simpleFormattedResult);

            var complexFormattedResult = generator.GenerateReportAsString(complexInMemoryDataProvider, jsonReportFormatter);

            Console.WriteLine(complexFormattedResult);
            Console.ReadLine();
        }
    }
}
