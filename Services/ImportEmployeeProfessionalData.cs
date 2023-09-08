
//.ImportEmployeeProfessionalData




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importEmployeeProfessionalData")]
  public class ImportEmployeeProfessionalData
  {
    [XmlArray(ElementName = "employeeProfessionalToImport", IsNullable = false, Order = 0)]
    public List<EmployeeProfessionalData> EmployeeProfessionalToImport { get; set; }
  }
}
