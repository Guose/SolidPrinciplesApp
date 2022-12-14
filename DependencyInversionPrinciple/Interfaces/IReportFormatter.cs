using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.Interfaces
{
    public interface IReportFormatter
    {
        string FormatEntriesAsString(List<ReportEntry> entries);
    }
}
