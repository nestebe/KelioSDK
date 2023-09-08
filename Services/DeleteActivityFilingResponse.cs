
//.DeleteActivityFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteActivityFilingResponse")]
  public class DeleteActivityFilingResponse
  {
    [XmlArray(ElementName = "activityFilingInError", IsNullable = false, Order = 0)]
    public List<Filing> ActivityFilingInError { get; set; }
  }
}
