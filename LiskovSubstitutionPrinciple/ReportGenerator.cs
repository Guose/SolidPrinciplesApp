using LiskovSubstitutionPrinciple.Interfaces;

namespace LiskovSubstitutionPrinciple
{
    public class ReportGenerator
    {
        public string GenerateReportAsString(IDataProvider dataProvider, IReportFormatter jsonReportFormatter)
        {
            var entries = dataProvider.GetData();

            return jsonReportFormatter.FormatEntriesAsString(entries);
        }
    }
}
