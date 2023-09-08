
//.ImportProfileFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importProfileFiling")]
  public class ImportProfileFiling
  {
    [XmlArray(ElementName = "profileFilingToImport", IsNullable = false, Order = 0)]
    public List<Filing> ProfileFilingToImport { get; set; }
  }
}
