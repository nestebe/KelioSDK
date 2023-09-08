
//.ImportAbsenceFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importAbsenceFiling")]
  public class ImportAbsenceFiling
  {
    [XmlArray(ElementName = "absenceFilingToImport", IsNullable = false, Order = 0)]
    public List<Filing> AbsenceFilingToImport { get; set; }
  }
}
