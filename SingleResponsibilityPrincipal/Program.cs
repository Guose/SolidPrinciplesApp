﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrincipal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var generator = new ReportGenerator();
            var formattedResult = generator.GenerateReportAsString();

            Console.WriteLine(formattedResult);
            Console.ReadLine();
        }
    }
}