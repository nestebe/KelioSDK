
//.ImportTransferFileTemplateFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importTransferFileTemplateFiling")]
  public class ImportTransferFileTemplateFiling
  {
    [XmlArray(ElementName = "transferFileTemplateFilingToImport", IsNullable = false, Order = 0)]
    public List<Filing> TransferFileTemplateFilingToImport { get; set; }
  }
}
