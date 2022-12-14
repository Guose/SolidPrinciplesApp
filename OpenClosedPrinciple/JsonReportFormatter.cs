using Newtonsoft.Json;
using OpenClosedPrinciple.Interfaces;
using System.Collections.Generic;

namespace OpenClosedPrinciple
{
    public class JsonReportFormatter : IReportFormatter
    {
        public string FormatEntriesAsString(List<ReportEntry> entries)
        {
            return JsonConvert.SerializeObject(entries);
        }
    }
}
