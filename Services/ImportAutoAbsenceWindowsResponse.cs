
//.ImportAutoAbsenceWindowsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importAutoAbsenceWindowsResponse")]
  public class ImportAutoAbsenceWindowsResponse
  {
    [XmlArray(ElementName = "autoAbsenceWindowsInError", IsNullable = false, Order = 0)]
    public List<AutoAbsenceWindow> AutoAbsenceWindowsInError { get; set; }
  }
}
