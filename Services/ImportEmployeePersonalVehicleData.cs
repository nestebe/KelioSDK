
//.ImportEmployeePersonalVehicleData




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importEmployeePersonalVehicleData")]
  public class ImportEmployeePersonalVehicleData
  {
    [XmlArray(ElementName = "employeePersonalVehicleDataToImport", IsNullable = false, Order = 0)]
    public List<PersonalVehicle> EmployeePersonalVehicleDataToImport { get; set; }
  }
}
