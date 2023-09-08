
// Type: KelioSDK.Models.EmployeePicture




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "EmployeePicture")]
  public class EmployeePicture : EmployeeInformation
  {
    [XmlElement(DataType = "string", ElementName = "filePath", IsNullable = true)]
    public string FilePath { get; set; }
  }
}
