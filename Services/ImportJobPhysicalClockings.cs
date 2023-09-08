
//.ImportJobPhysicalClockings




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importJobPhysicalClockings")]
  public class ImportJobPhysicalClockings
  {
    [XmlArray(ElementName = "jobPhysicalClockingsToImport", IsNullable = false, Order = 0)]
    public List<JobPhysicalClocking> JobPhysicalClockingsToImport { get; set; }
  }
}
