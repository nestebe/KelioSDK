
//.ExportShiftScheduleDistributionResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportShiftScheduleDistributionResponse")]
  public class ExportShiftScheduleDistributionResponse
  {
    [XmlArray(ElementName = "exportedShiftScheduleDistribution", IsNullable = false, Order = 0)]
    public List<ShiftScheduleDistribution> ExportedShiftScheduleDistribution { get; set; }
  }
}
