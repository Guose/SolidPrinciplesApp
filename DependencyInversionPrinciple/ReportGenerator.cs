using Newtonsoft.Json;
using DependencyInversionPrinciple.Interfaces;
using System.Collections.Generic;

namespace DependencyInversionPrinciple
{
    public class ReportGenerator
    {
        public string GenerateReportAsString(IDataProvider dataProvider, IReportFormatter jsonReportFormatter)
        {
            var entries = dataProvider.GetData();

            return jsonReportFormatter.FormatEntriesAsString(entries);
        }
    }
}
