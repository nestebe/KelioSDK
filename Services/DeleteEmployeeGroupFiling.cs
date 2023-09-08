
//.DeleteEmployeeGroupFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteEmployeeGroupFiling")]
  public class DeleteEmployeeGroupFiling
  {
    [XmlArray(ElementName = "employeeGroupFilingToDelete", IsNullable = false, Order = 0)]
    public List<Filing> EmployeeGroupFilingToDelete { get; set; }
  }
}
