
//.DeleteAbsenceBalanceFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteAbsenceBalanceFiling")]
  public class DeleteAbsenceBalanceFiling
  {
    [XmlArray(ElementName = "absenceBalanceFilingToDelete", IsNullable = false, Order = 0)]
    public List<Filing> AbsenceBalanceFilingToDelete { get; set; }
  }
}
