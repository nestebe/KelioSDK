
//.ImportAutomaticSchedulesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importAutomaticSchedulesResponse")]
  public class ImportAutomaticSchedulesResponse
  {
    [XmlArray(ElementName = "automaticSchedulesInError", IsNullable = false, Order = 0)]
    public List<AutomaticSchedule> AutomaticSchedulesInError { get; set; }
  }
}
