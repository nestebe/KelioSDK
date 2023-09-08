
// Type: KelioSDK.Models.PersonalVehicle




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "PersonalVehicle")]
  public class PersonalVehicle : EmployeeInformation
  {
    [XmlElement(DataType = "string", ElementName = "vehicleRegistrationNumber", IsNullable = true)]
    public string VehicleRegistrationNumber { get; set; }

    [XmlElement(DataType = "int", ElementName = "vehicleKey", IsNullable = true)]
    public int? VehicleKey { get; set; }
  }
}
