using DependencyInversionPrinciple.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class SimpleInMemoryDataProvider : IDataProvider
    {
        private List<ReportEntry> _entries;

        public SimpleInMemoryDataProvider()
        {
            _entries = new List<ReportEntry>();
        }

        public List<ReportEntry> GetData()
        {
            var simpleEntry = new SimpleReportEntry()
            {
                ColumnOne = "Column One Value",
                ColumnTwo = "Column Two Value",
                ColumnThree = "Column Three Value"
            };

            _entries.Add(simpleEntry);

            return _entries;
        }
    }
}
