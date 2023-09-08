
//.DeleteTransferFileTemplateFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteTransferFileTemplateFilingResponse")]
  public class DeleteTransferFileTemplateFilingResponse
  {
    [XmlArray(ElementName = "transferFileTemplateFilingInError", IsNullable = false, Order = 0)]
    public List<Filing> TransferFileTemplateFilingInError { get; set; }
  }
}
