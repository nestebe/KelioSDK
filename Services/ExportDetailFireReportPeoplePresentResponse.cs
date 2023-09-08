
//.ExportDetailFireReportPeoplePresentResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportDetailFireReportPeoplePresentResponse")]
  public class ExportDetailFireReportPeoplePresentResponse
  {
    [XmlArray(ElementName = "exportedDetailFireReportPeoplePresent", IsNullable = false, Order = 0)]
    public List<DetailFireReportPeoplePresent> ExportedDetailFireReportPeoplePresent { get; set; }
  }
}
