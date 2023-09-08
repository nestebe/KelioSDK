
//.ImportAbsenceWindowsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importAbsenceWindowsResponse")]
  public class ImportAbsenceWindowsResponse
  {
    [XmlArray(ElementName = "absenceWindowsInError", IsNullable = false, Order = 0)]
    public List<AbsenceWindow> AbsenceWindowsInError { get; set; }
  }
}
