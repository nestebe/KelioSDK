
//.ExportHourlyContractAssignmentsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportHourlyContractAssignmentsResponse")]
  public class ExportHourlyContractAssignmentsResponse
  {
    [XmlArray(ElementName = "exportedHourlyContractAssignments", IsNullable = false, Order = 0)]
    public List<HourlyContractAssignment> ExportedHourlyContractAssignments { get; set; }
  }
}
