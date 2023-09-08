
//.DeleteTakenIntoAccountPeriods




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteTakenIntoAccountPeriods")]
  public class DeleteTakenIntoAccountPeriods
  {
    [XmlArray(ElementName = "takenIntoAccountPeriodsToDelete", IsNullable = false, Order = 0)]
    public List<TakenIntoAccountPeriod> TakenIntoAccountPeriodsToDelete { get; set; }
  }
}
