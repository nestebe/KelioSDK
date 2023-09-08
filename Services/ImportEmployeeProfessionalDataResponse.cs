
//.ImportEmployeeProfessionalDataResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importEmployeeProfessionalDataResponse")]
  public class ImportEmployeeProfessionalDataResponse
  {
    [XmlArray(ElementName = "employeeProfessionalInError", IsNullable = false, Order = 0)]
    public List<EmployeeProfessionalData> EmployeeProfessionalInError { get; set; }
  }
}
