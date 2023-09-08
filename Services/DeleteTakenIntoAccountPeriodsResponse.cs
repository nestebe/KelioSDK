
//.DeleteTakenIntoAccountPeriodsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteTakenIntoAccountPeriodsResponse")]
  public class DeleteTakenIntoAccountPeriodsResponse
  {
    [XmlArray(ElementName = "takenIntoAccountPeriodsInError", IsNullable = false, Order = 0)]
    public List<TakenIntoAccountPeriod> TakenIntoAccountPeriodsInError { get; set; }
  }
}
