
//.ExportOnCallDutyFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportOnCallDutyFilingResponse")]
  public class ExportOnCallDutyFilingResponse
  {
    [XmlArray(ElementName = "exportedOnCallDutyFiling", IsNullable = false, Order = 0)]
    public List<Filing> ExportedOnCallDutyFiling { get; set; }
  }
}
