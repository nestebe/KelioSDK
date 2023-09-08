
//.ExportFireReportPeoplePresentResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportFireReportPeoplePresentResponse")]
  public class ExportFireReportPeoplePresentResponse
  {
    [XmlArray(ElementName = "exportedFireReportPeoplePresent", IsNullable = false, Order = 0)]
    public List<FireReportPeoplePresent> ExportedFireReportPeoplePresent { get; set; }
  }
}
