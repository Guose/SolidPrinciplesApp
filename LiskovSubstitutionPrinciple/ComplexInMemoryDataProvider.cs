using LiskovSubstitutionPrinciple.Interfaces;
using System.Collections.Generic;

namespace LiskovSubstitutionPrinciple
{
    public class ComplexInMemoryDataProvider : IDataProvider
    {
        private List<ReportEntry> _entries;

        public ComplexInMemoryDataProvider()
        {
            _entries = new List<ReportEntry>();
        }

        public List<ReportEntry> GetData()
        {
            var simpleEntry = new ComplexReportEntry()
            {
                ColumnOne = "Column One Value",
                ColumnTwo = "Column Two Value",
                SpecialNumbers = new List<int>() { 1,2,4,5,6,7,8,}
            };

            _entries.Add(simpleEntry);

            return _entries;
        }
    }
}
