using Newtonsoft.Json;
using LiskovSubstitutionPrinciple.Interfaces;
using System.Collections.Generic;

namespace LiskovSubstitutionPrinciple
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
