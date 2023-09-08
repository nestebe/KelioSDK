
//.ExportEstimatedOvertimeHourTotalsFromDateToDateForEmployeeListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEstimatedOvertimeHourTotalsFromDateToDateForEmployeeListResponse")]
  public class ExportEstimatedOvertimeHourTotalsFromDateToDateForEmployeeListResponse
  {
    [XmlArray(ElementName = "exportedFromDateToDateOvertimeHourTotals", IsNullable = false, Order = 0)]
    public List<FromDateToDateOvertimeHourTotal> ExportedFromDateToDateOvertimeHourTotals { get; set; }
  }
}
