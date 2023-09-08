
//.ImportTakenIntoAccountPeriodsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importTakenIntoAccountPeriodsResponse")]
  public class ImportTakenIntoAccountPeriodsResponse
  {
    [XmlArray(ElementName = "takenIntoAccountPeriodsInError", IsNullable = false, Order = 0)]
    public List<TakenIntoAccountPeriod> TakenIntoAccountPeriodsInError { get; set; }
  }
}
