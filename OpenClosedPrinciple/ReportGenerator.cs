using OpenClosedPrinciple.Interfaces;

namespace OpenClosedPrinciple
{
    public class ReportGenerator
    {
        public string GenerateReportAsString(IDataProvider dataProvider, IReportFormatter reportFormatter)
        {
            var entries = dataProvider.GetData();
            return reportFormatter.FormatEntriesAsString(entries);
        }
    }
}
