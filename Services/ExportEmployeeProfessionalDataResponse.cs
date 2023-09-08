
//.ExportEmployeeProfessionalDataResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEmployeeProfessionalDataResponse")]
  public class ExportEmployeeProfessionalDataResponse
  {
    [XmlArray(ElementName = "exportedEmployeeProfessionalData", IsNullable = false, Order = 0)]
    public List<EmployeeProfessionalData> ExportedEmployeeProfessionalData { get; set; }
  }
}
