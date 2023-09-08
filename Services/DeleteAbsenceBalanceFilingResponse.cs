
//.DeleteAbsenceBalanceFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteAbsenceBalanceFilingResponse")]
  public class DeleteAbsenceBalanceFilingResponse
  {
    [XmlArray(ElementName = "absenceBalanceFilingInError", IsNullable = false, Order = 0)]
    public List<Filing> AbsenceBalanceFilingInError { get; set; }
  }
}
