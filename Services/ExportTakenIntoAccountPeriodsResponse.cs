
//.ExportTakenIntoAccountPeriodsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportTakenIntoAccountPeriodsResponse")]
  public class ExportTakenIntoAccountPeriodsResponse
  {
    [XmlArray(ElementName = "exportedTakenIntoAccountPeriods", IsNullable = false, Order = 0)]
    public List<TakenIntoAccountPeriod> ExportedTakenIntoAccountPeriods { get; set; }
  }
}
