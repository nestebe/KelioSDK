
//.ImportHourToHourRequirementsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importHourToHourRequirementsResponse")]
  public class ImportHourToHourRequirementsResponse
  {
    [XmlArray(ElementName = "hourToHourRequirementsInError", IsNullable = false, Order = 0)]
    public List<HourToHourRequirement> HourToHourRequirementsInError { get; set; }
  }
}
