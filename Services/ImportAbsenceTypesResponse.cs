
//.ImportAbsenceTypesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importAbsenceTypesResponse")]
  public class ImportAbsenceTypesResponse
  {
    [XmlArray(ElementName = "absenceTypesInError", IsNullable = false, Order = 0)]
    public List<AbsenceType> AbsenceTypesInError { get; set; }
  }
}
