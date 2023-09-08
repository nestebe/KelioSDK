
//.ExportJobHourlyRateAssignmentsListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportJobHourlyRateAssignmentsListResponse")]
  public class ExportJobHourlyRateAssignmentsListResponse
  {
    [XmlArray(ElementName = "exportedJobHourlyRateAssignments", IsNullable = false, Order = 0)]
    public List<JobHourlyRateAssignment> ExportedJobHourlyRateAssignments { get; set; }
  }
}
