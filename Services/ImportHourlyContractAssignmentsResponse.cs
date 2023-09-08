
//.ImportHourlyContractAssignmentsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importHourlyContractAssignmentsResponse")]
  public class ImportHourlyContractAssignmentsResponse
  {
    [XmlArray(ElementName = "hourlyContractAssignmentsInError", IsNullable = false, Order = 0)]
    public List<HourlyContractAssignment> HourlyContractAssignmentsInError { get; set; }
  }
}
