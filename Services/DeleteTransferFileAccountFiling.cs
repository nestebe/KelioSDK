
//.DeleteTransferFileAccountFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteTransferFileAccountFiling")]
  public class DeleteTransferFileAccountFiling
  {
    [XmlArray(ElementName = "transferFileAccountFilingToDelete", IsNullable = false, Order = 0)]
    public List<Filing> TransferFileAccountFilingToDelete { get; set; }
  }
}
