
//.ImportAutomaticScheduleFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importAutomaticScheduleFiling")]
  public class ImportAutomaticScheduleFiling
  {
    [XmlArray(ElementName = "automaticScheduleFilingToImport", IsNullable = false, Order = 0)]
    public List<Filing> AutomaticScheduleFilingToImport { get; set; }
  }
}
