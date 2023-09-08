
// Type: KelioSDK.Models.EmergencyContact




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "EmergencyContact")]
  public class EmergencyContact : EmployeeInformation
  {
    [XmlElement(DataType = "string", ElementName = "emergencyContactPhoneNumber", IsNullable = true)]
    public string EmergencyContactPhoneNumber { get; set; }

    [XmlElement(DataType = "string", ElementName = "emergencyContactPerson", IsNullable = true)]
    public string EmergencyContactPerson { get; set; }
  }
}
