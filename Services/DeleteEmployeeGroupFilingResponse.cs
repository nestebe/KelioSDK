
//.DeleteEmployeeGroupFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteEmployeeGroupFilingResponse")]
  public class DeleteEmployeeGroupFilingResponse
  {
    [XmlArray(ElementName = "employeeGroupFilingInError", IsNullable = false, Order = 0)]
    public List<Filing> EmployeeGroupFilingInError { get; set; }
  }
}
