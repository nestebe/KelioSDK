
//.ImportCustomizableFieldFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importCustomizableFieldFiling")]
  public class ImportCustomizableFieldFiling
  {
    [XmlArray(ElementName = "customizableFieldFilingToImport", IsNullable = false, Order = 0)]
    public List<Filing> CustomizableFieldFilingToImport { get; set; }
  }
}
