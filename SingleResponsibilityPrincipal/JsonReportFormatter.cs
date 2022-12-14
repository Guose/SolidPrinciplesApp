using Newtonsoft.Json;
using System.Collections.Generic;

namespace SingleResponsibilityPrincipal
{
    public class JsonReportFormatter
    {
        public string FormatEntriesAsString(List<ReportEntry> entries)
        {
            return JsonConvert.SerializeObject(entries);
        }
    }
}
