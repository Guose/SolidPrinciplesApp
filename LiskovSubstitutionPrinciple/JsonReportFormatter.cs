using Newtonsoft.Json;
using LiskovSubstitutionPrinciple.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
