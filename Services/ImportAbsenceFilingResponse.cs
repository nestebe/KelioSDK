
//.ImportAbsenceFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importAbsenceFilingResponse")]
  public class ImportAbsenceFilingResponse
  {
    [XmlArray(ElementName = "absenceFilingInError", IsNullable = false, Order = 0)]
    public List<Filing> AbsenceFilingInError { get; set; }
  }
}
