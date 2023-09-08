
//.ImportTransferFileAccountFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importTransferFileAccountFilingResponse")]
  public class ImportTransferFileAccountFilingResponse
  {
    [XmlArray(ElementName = "transferFileAccountFilingInError", IsNullable = false, Order = 0)]
    public List<Filing> TransferFileAccountFilingInError { get; set; }
  }
}
