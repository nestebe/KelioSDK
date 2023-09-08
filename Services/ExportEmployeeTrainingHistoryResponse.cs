
//.ExportEmployeeTrainingHistoryResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEmployeeTrainingHistoryResponse")]
  public class ExportEmployeeTrainingHistoryResponse
  {
    [XmlArray(ElementName = "exportedEmployeeTrainingHistory", IsNullable = false, Order = 0)]
    public List<EmployeeTrainingHistory> ExportedEmployeeTrainingHistory { get; set; }
  }
}
