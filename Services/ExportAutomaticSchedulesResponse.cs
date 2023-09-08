
//.ExportAutomaticSchedulesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportAutomaticSchedulesResponse")]
  public class ExportAutomaticSchedulesResponse
  {
    [XmlArray(ElementName = "exportedAutomaticSchedules", IsNullable = false, Order = 0)]
    public List<AutomaticSchedule> ExportedAutomaticSchedules { get; set; }
  }
}
