
//.ImportShiftScheduleDistribution




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importShiftScheduleDistribution")]
  public class ImportShiftScheduleDistribution
  {
    [XmlArray(ElementName = "shiftScheduleDistributionToImport", IsNullable = false, Order = 0)]
    public List<ShiftScheduleDistribution> ShiftScheduleDistributionToImport { get; set; }
  }
}
