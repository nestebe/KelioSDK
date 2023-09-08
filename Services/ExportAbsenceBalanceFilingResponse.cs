
//.ExportAbsenceBalanceFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportAbsenceBalanceFilingResponse")]
  public class ExportAbsenceBalanceFilingResponse
  {
    [XmlArray(ElementName = "exportedAbsenceBalanceFiling", IsNullable = false, Order = 0)]
    public List<Filing> ExportedAbsenceBalanceFiling { get; set; }
  }
}
