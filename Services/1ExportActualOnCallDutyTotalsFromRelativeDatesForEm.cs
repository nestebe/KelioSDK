
//.ExportActualOnCallDutyTotalsFromRelativeDatesForEmployeeListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportActualOnCallDutyTotalsFromRelativeDatesForEmployeeListResponse")]
  public class ExportActualOnCallDutyTotalsFromRelativeDatesForEmployeeListResponse
  {
    [XmlArray(ElementName = "exportedFromDateToDateOnCallDutyTotals", IsNullable = false, Order = 0)]
    public List<FromDateToDateOnCallDutyTotal> ExportedFromDateToDateOnCallDutyTotals { get; set; }
  }
}
