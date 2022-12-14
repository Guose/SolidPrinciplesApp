using OpenClosedPrinciple.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
