using Newtonsoft.Json;
using LiskovSubstitutionPrinciple.Interfaces;
using System.Collections.Generic;

namespace LiskovSubstitutionPrinciple
{
    public class JsonReportFormatter : IReportFormatter
    {
        public string FormatEntriesAsString(List<ReportEntry> entries)
        {
            return JsonConvert.SerializeObject(entries);
        }
    }
}
