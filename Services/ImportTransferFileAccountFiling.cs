
//.ImportTransferFileAccountFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importTransferFileAccountFiling")]
  public class ImportTransferFileAccountFiling
  {
    [XmlArray(ElementName = "transferFileAccountFilingToImport", IsNullable = false, Order = 0)]
    public List<Filing> TransferFileAccountFilingToImport { get; set; }
  }
}
