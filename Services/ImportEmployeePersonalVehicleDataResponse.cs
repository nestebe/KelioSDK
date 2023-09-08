
//.ImportEmployeePersonalVehicleDataResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importEmployeePersonalVehicleDataResponse")]
  public class ImportEmployeePersonalVehicleDataResponse
  {
    [XmlArray(ElementName = "employeePersonalVehicleDataInError", IsNullable = false, Order = 0)]
    public List<PersonalVehicle> EmployeePersonalVehicleDataInError { get; set; }
  }
}
