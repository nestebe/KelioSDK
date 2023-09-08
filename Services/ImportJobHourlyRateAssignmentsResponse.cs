
//.ImportJobHourlyRateAssignmentsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importJobHourlyRateAssignmentsResponse")]
  public class ImportJobHourlyRateAssignmentsResponse
  {
    [XmlArray(ElementName = "jobHourlyRateAssignmentsInError", IsNullable = false, Order = 0)]
    public List<JobHourlyRateAssignment> JobHourlyRateAssignmentsInError { get; set; }
  }
}
