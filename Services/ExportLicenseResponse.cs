
//.ExportLicenseResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportLicenseResponse")]
  public class ExportLicenseResponse
  {
    [XmlArray(ElementName = "exportedLicense", IsNullable = false, Order = 0)]
    public List<License> ExportedLicense { get; set; }
  }
}
