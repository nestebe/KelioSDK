
//.DeletedHourlyContractAssignmentsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deletedHourlyContractAssignmentsResponse")]
  public class DeletedHourlyContractAssignmentsResponse
  {
    [XmlArray(ElementName = "deletedHourlyContractAssignmentsInError", IsNullable = false, Order = 0)]
    public List<HourlyContractAssignment> DeletedHourlyContractAssignmentsInError { get; set; }
  }
}
