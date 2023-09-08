
//.ExportCorrelationTableRiskAccountResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportCorrelationTableRiskAccountResponse")]
  public class ExportCorrelationTableRiskAccountResponse
  {
    [XmlArray(ElementName = "exportedCorrelationTableRiskAccount", IsNullable = false, Order = 0)]
    public List<CorrelationTableRiskAccount> ExportedCorrelationTableRiskAccount { get; set; }
  }
}
