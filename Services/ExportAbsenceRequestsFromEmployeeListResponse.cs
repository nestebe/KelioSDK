
//.ExportAbsenceRequestsFromEmployeeListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportAbsenceRequestsFromEmployeeListResponse")]
  public class ExportAbsenceRequestsFromEmployeeListResponse
  {
    [XmlArray(ElementName = "exportedAbsenceRequests", IsNullable = false, Order = 0)]
    public List<AbsenceRequest> ExportedAbsenceRequests { get; set; }
  }
}
