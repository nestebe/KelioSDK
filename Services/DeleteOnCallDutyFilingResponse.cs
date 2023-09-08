
//.DeleteOnCallDutyFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteOnCallDutyFilingResponse")]
  public class DeleteOnCallDutyFilingResponse
  {
    [XmlArray(ElementName = "onCallDutyFilingInError", IsNullable = false, Order = 0)]
    public List<Filing> OnCallDutyFilingInError { get; set; }
  }
}
