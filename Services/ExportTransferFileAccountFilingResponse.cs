
//.ExportTransferFileAccountFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportTransferFileAccountFilingResponse")]
  public class ExportTransferFileAccountFilingResponse
  {
    [XmlArray(ElementName = "exportedTransferFileAccountFiling", IsNullable = false, Order = 0)]
    public List<Filing> ExportedTransferFileAccountFiling { get; set; }
  }
}
