using System.Collections.Generic;

namespace LiskovSubstitutionPrinciple
{
    public class ComplexReportEntry : ReportEntry
    {
        public IEnumerable<int> SpecialNumbers { get; set; }
    }
}
