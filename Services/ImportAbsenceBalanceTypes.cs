
//.ImportAbsenceBalanceTypes




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importAbsenceBalanceTypes")]
  public class ImportAbsenceBalanceTypes
  {
    [XmlArray(ElementName = "absenceBalanceTypesToImport", IsNullable = false, Order = 0)]
    public List<AbsenceBalanceType> AbsenceBalanceTypesToImport { get; set; }
  }
}
