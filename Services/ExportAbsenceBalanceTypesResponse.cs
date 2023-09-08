
//.ExportAbsenceBalanceTypesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportAbsenceBalanceTypesResponse")]
  public class ExportAbsenceBalanceTypesResponse
  {
    [XmlArray(ElementName = "exportedAbsenceBalanceTypes", IsNullable = false, Order = 0)]
    public List<AbsenceBalanceType> ExportedAbsenceBalanceTypes { get; set; }
  }
}
