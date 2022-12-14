using OpenClosedPrinciple.Interfaces;
using System.Collections.Generic;

namespace OpenClosedPrinciple
{
    public class InMemoryDataProvider : IDataProvider
    {
        private List<ReportEntry> _entries;

        public InMemoryDataProvider()
        {
            _entries = new List<ReportEntry>();
        }

        public List<ReportEntry> GetData()
        {
            _entries.Add(new ReportEntry()
            {
                ColumnOne = "Column One Value",
                ColumnTwo = "Column Two Value"
            });

            return _entries;
        }
    }
}
