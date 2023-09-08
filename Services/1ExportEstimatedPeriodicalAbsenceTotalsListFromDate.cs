
//.ExportEstimatedPeriodicalAbsenceTotalsListFromDateToDateForEmployeeListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEstimatedPeriodicalAbsenceTotalsListFromDateToDateForEmployeeListResponse")]
  public class ExportEstimatedPeriodicalAbsenceTotalsListFromDateToDateForEmployeeListResponse
  {
    [XmlArray(ElementName = "exportedPeriodicalAbsenceTotals", IsNullable = false, Order = 0)]
    public List<PeriodicAbsenceTotal> ExportedPeriodicalAbsenceTotals { get; set; }
  }
}
