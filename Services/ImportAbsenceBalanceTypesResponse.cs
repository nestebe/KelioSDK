
//.ImportAbsenceBalanceTypesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importAbsenceBalanceTypesResponse")]
  public class ImportAbsenceBalanceTypesResponse
  {
    [XmlArray(ElementName = "absenceBalanceTypesInError", IsNullable = false, Order = 0)]
    public List<AbsenceBalanceType> AbsenceBalanceTypesInError { get; set; }
  }
}
