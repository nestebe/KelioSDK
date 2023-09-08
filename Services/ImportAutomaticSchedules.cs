
//.ImportAutomaticSchedules




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importAutomaticSchedules")]
  public class ImportAutomaticSchedules
  {
    [XmlArray(ElementName = "automaticSchedulesToImport", IsNullable = false, Order = 0)]
    public List<AutomaticSchedule> AutomaticSchedulesToImport { get; set; }
  }
}
