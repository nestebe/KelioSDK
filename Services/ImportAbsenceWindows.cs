
//.ImportAbsenceWindows




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importAbsenceWindows")]
  public class ImportAbsenceWindows
  {
    [XmlArray(ElementName = "absenceWindowsToImport", IsNullable = false, Order = 0)]
    public List<AbsenceWindow> AbsenceWindowsToImport { get; set; }
  }
}
