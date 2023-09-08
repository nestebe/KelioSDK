
//.ImportShiftScheduleDistributionResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importShiftScheduleDistributionResponse")]
  public class ImportShiftScheduleDistributionResponse
  {
    [XmlArray(ElementName = "shiftScheduleDistributionInError", IsNullable = false, Order = 0)]
    public List<ShiftScheduleDistribution> ShiftScheduleDistributionInError { get; set; }
  }
}
