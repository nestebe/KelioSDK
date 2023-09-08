
//.ImportEmployeeGroupFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importEmployeeGroupFiling")]
  public class ImportEmployeeGroupFiling
  {
    [XmlArray(ElementName = "employeeGroupFilingToImport", IsNullable = false, Order = 0)]
    public List<Filing> EmployeeGroupFilingToImport { get; set; }
  }
}
