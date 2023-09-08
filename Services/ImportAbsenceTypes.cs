
//.ImportAbsenceTypes




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importAbsenceTypes")]
  public class ImportAbsenceTypes
  {
    [XmlArray(ElementName = "absenceTypesToImport", IsNullable = false, Order = 0)]
    public List<AbsenceType> AbsenceTypesToImport { get; set; }
  }
}
