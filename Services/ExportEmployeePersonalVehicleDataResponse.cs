
//.ExportEmployeePersonalVehicleDataResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEmployeePersonalVehicleDataResponse")]
  public class ExportEmployeePersonalVehicleDataResponse
  {
    [XmlArray(ElementName = "exportedEmployeePersonalVehicleData", IsNullable = false, Order = 0)]
    public List<PersonalVehicle> ExportedEmployeePersonalVehicleData { get; set; }
  }
}
