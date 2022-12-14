using Newtonsoft.Json;
using System.Collections.Generic;

namespace SingleResponsibilityPrincipal
{
    public class ReportGenerator
    {
        private readonly DataProvider _dataProvider = new DataProvider();
        private readonly JsonReportFormatter _jsonReportFormatter = new JsonReportFormatter();

        public string GenerateReportAsString()
        {
            var entries = _dataProvider.GetData();
            return _jsonReportFormatter.FormatEntriesAsString(entries);
        }
    }
}
