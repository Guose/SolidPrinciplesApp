using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.Interfaces
{
    public interface IReportFormatter
    {
        string FormatEntriesAsString(List<ReportEntry> entries);
    }
}
