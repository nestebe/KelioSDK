
//.DeletedHourlyContractAssignments




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deletedHourlyContractAssignments")]
  public class DeletedHourlyContractAssignments
  {
    [XmlArray(ElementName = "filterToDelete", IsNullable = false, Order = 0)]
    public List<HourlyContractAssignment> FilterToDelete { get; set; }
  }
}
