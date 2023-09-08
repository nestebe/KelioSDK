
//.ExportTransferFileTemplateFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportTransferFileTemplateFilingResponse")]
  public class ExportTransferFileTemplateFilingResponse
  {
    [XmlArray(ElementName = "exportedTransferFileTemplateFiling", IsNullable = false, Order = 0)]
    public List<Filing> ExportedTransferFileTemplateFiling { get; set; }
  }
}
