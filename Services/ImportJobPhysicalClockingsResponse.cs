
//.ImportJobPhysicalClockingsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importJobPhysicalClockingsResponse")]
  public class ImportJobPhysicalClockingsResponse
  {
    [XmlArray(ElementName = "jobPhysicalClockingsInError", IsNullable = false, Order = 0)]
    public List<JobPhysicalClocking> JobPhysicalClockingsInError { get; set; }
  }
}
