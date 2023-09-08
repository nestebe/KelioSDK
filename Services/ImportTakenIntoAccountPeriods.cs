
//.ImportTakenIntoAccountPeriods




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importTakenIntoAccountPeriods")]
  public class ImportTakenIntoAccountPeriods
  {
    [XmlArray(ElementName = "takenIntoAccountPeriodsToImport", IsNullable = false, Order = 0)]
    public List<TakenIntoAccountPeriod> TakenIntoAccountPeriodsToImport { get; set; }
  }
}
