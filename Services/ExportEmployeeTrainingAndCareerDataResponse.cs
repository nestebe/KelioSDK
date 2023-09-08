
//.ExportEmployeeTrainingAndCareerDataResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEmployeeTrainingAndCareerDataResponse")]
  public class ExportEmployeeTrainingAndCareerDataResponse
  {
    [XmlArray(ElementName = "exportedEmployeeTrainingAndCareerData", IsNullable = false, Order = 0)]
    public List<EmployeeTrainingAndCareerData> ExportedEmployeeTrainingAndCareerData { get; set; }
  }
}
