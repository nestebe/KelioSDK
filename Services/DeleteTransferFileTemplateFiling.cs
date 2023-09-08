
//.DeleteTransferFileTemplateFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteTransferFileTemplateFiling")]
  public class DeleteTransferFileTemplateFiling
  {
    [XmlArray(ElementName = "transferFileTemplateFilingToDelete", IsNullable = false, Order = 0)]
    public List<Filing> TransferFileTemplateFilingToDelete { get; set; }
  }
}
