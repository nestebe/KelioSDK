
//.ImportAbsenceBalanceFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importAbsenceBalanceFiling")]
  public class ImportAbsenceBalanceFiling
  {
    [XmlArray(ElementName = "absenceBalanceFilingToImport", IsNullable = false, Order = 0)]
    public List<Filing> AbsenceBalanceFilingToImport { get; set; }
  }
}
