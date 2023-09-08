
//.ExportEmployeeInformationsForModuleResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEmployeeInformationsForModuleResponse")]
  public class ExportEmployeeInformationsForModuleResponse
  {
    [XmlArray(ElementName = "exportedEmployeeInformations", IsNullable = false, Order = 0)]
    public List<EmployeeInformation> ExportedEmployeeInformations { get; set; }
  }
}
