using System.Collections.Generic;

namespace DependencyInversionPrinciple
{
    public class ComplexReportEntry : ReportEntry
    {
        public IEnumerable<int> SpecialNumbers { get; set; }
    }
}
