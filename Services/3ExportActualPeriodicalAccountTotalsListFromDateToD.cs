
//.ExportActualPeriodicalAccountTotalsListFromDateToDateResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportActualPeriodicalAccountTotalsListFromDateToDateResponse")]
  public class ExportActualPeriodicalAccountTotalsListFromDateToDateResponse
  {
    [XmlArray(ElementName = "exportedPeriodicalAccountTotals", IsNullable = false, Order = 0)]
    public List<PeriodicTotal> ExportedPeriodicalAccountTotals { get; set; }
  }
}
