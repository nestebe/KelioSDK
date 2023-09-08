
//.ImportPenaltyWindowsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importPenaltyWindowsResponse")]
  public class ImportPenaltyWindowsResponse
  {
    [XmlArray(ElementName = "penaltyWindowsInError", IsNullable = false, Order = 0)]
    public List<PenaltyWindow> PenaltyWindowsInError { get; set; }
  }
}
