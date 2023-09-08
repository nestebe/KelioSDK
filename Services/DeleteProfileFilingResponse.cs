
//.DeleteProfileFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteProfileFilingResponse")]
  public class DeleteProfileFilingResponse
  {
    [XmlArray(ElementName = "profileFilingInError", IsNullable = false, Order = 0)]
    public List<Filing> ProfileFilingInError { get; set; }
  }
}
