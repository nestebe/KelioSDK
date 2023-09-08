
//.ExportActualPerpetualLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeList




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportActualPerpetualLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeList")]
  public class ExportActualPerpetualLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeList
  {
    [XmlArray(ElementName = "employeeList", IsNullable = false, Order = 0)]
    public List<AskedEmployeeWithRelativeDates> EmployeeList { get; set; }
  }
}
