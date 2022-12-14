using DependencyInversionPrinciple.Interfaces;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DependencyInversionPrinciple
{
    public class JsonReportFormatter : IReportFormatter
    {
        public string FormatEntriesAsString(List<ReportEntry> entries)
        {
            return JsonConvert.SerializeObject(entries);
        }
    }
}
