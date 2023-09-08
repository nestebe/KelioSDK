
//.ImportAutoAbsenceWindows




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importAutoAbsenceWindows")]
  public class ImportAutoAbsenceWindows
  {
    [XmlArray(ElementName = "autoAbsenceWindowsToImport", IsNullable = false, Order = 0)]
    public List<AutoAbsenceWindow> AutoAbsenceWindowsToImport { get; set; }
  }
}
