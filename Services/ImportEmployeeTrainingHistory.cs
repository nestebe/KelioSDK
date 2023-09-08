
//.ImportEmployeeTrainingHistory




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importEmployeeTrainingHistory")]
  public class ImportEmployeeTrainingHistory
  {
    [XmlArray(ElementName = "employeeTrainingHistoryToImport", IsNullable = false, Order = 0)]
    public List<EmployeeTrainingHistory> EmployeeTrainingHistoryToImport { get; set; }
  }
}
