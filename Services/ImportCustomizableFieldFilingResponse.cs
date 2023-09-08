
//.ImportCustomizableFieldFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importCustomizableFieldFilingResponse")]
  public class ImportCustomizableFieldFilingResponse
  {
    [XmlArray(ElementName = "customizableFieldFilingInError", IsNullable = false, Order = 0)]
    public List<Filing> CustomizableFieldFilingInError { get; set; }
  }
}
