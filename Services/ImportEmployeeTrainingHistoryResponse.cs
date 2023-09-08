
//.ImportEmployeeTrainingHistoryResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importEmployeeTrainingHistoryResponse")]
  public class ImportEmployeeTrainingHistoryResponse
  {
    [XmlArray(ElementName = "employeeTrainingHistoryInError", IsNullable = false, Order = 0)]
    public List<EmployeeTrainingHistory> EmployeeTrainingHistoryInError { get; set; }
  }
}
