using System.Collections.Generic;

namespace SingleResponsibilityPrincipal
{
    public class DataProvider
    {
        private List<ReportEntry> _entries;

        public DataProvider()
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
