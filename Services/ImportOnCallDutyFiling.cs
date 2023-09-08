
//.ImportOnCallDutyFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importOnCallDutyFiling")]
  public class ImportOnCallDutyFiling
  {
    [XmlArray(ElementName = "onCallDutyFilingToImport", IsNullable = false, Order = 0)]
    public List<Filing> OnCallDutyFilingToImport { get; set; }
  }
}
