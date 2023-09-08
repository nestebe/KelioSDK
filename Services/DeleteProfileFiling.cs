
//.DeleteProfileFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteProfileFiling")]
  public class DeleteProfileFiling
  {
    [XmlArray(ElementName = "profileFilingToDelete", IsNullable = false, Order = 0)]
    public List<Filing> ProfileFilingToDelete { get; set; }
  }
}
