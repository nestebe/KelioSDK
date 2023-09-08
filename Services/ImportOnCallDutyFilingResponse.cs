
//.ImportOnCallDutyFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importOnCallDutyFilingResponse")]
  public class ImportOnCallDutyFilingResponse
  {
    [XmlArray(ElementName = "onCallDutyFilingInError", IsNullable = false, Order = 0)]
    public List<Filing> OnCallDutyFilingInError { get; set; }
  }
}
