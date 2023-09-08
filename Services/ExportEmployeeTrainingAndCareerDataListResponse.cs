
//.ExportEmployeeTrainingAndCareerDataListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEmployeeTrainingAndCareerDataListResponse")]
  public class ExportEmployeeTrainingAndCareerDataListResponse
  {
    [XmlArray(ElementName = "exportedEmployeeTrainingAndCareerData", IsNullable = false, Order = 0)]
    public List<EmployeeTrainingAndCareerData> ExportedEmployeeTrainingAndCareerData { get; set; }
  }
}
