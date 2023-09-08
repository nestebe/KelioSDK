
//.ExportActualWeeklyAbsenceTotalsListFromDateToDateResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportActualWeeklyAbsenceTotalsListFromDateToDateResponse")]
  public class ExportActualWeeklyAbsenceTotalsListFromDateToDateResponse
  {
    [XmlArray(ElementName = "exportedWeeklyAbsenceTotals", IsNullable = false, Order = 0)]
    public List<WeeklyAbsenceTotal> ExportedWeeklyAbsenceTotals { get; set; }
  }
}
