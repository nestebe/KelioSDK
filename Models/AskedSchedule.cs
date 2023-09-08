
// Type: KelioSDK.Models.AskedSchedule




using KelioSDK.Common;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AskedSchedule")]
  public class AskedSchedule : ObjectBase
  {
    [XmlElement(DataType = "int", ElementName = "schedulesTypeFilter", IsNullable = true)]
    public int? SchedulesTypeFilter { get; set; }
  }
}
