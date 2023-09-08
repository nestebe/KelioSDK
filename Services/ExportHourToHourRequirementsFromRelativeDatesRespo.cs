
//.ExportHourToHourRequirementsFromRelativeDatesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportHourToHourRequirementsFromRelativeDatesResponse")]
  public class ExportHourToHourRequirementsFromRelativeDatesResponse
  {
    [XmlArray(ElementName = "exportedHourToHourRequirements", IsNullable = false, Order = 0)]
    public List<HourToHourRequirement> ExportedHourToHourRequirements { get; set; }
  }
}
