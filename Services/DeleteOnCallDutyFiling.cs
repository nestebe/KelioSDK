
//.DeleteOnCallDutyFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteOnCallDutyFiling")]
  public class DeleteOnCallDutyFiling
  {
    [XmlArray(ElementName = "onCallDutyFilingToDelete", IsNullable = false, Order = 0)]
    public List<Filing> OnCallDutyFilingToDelete { get; set; }
  }
}
