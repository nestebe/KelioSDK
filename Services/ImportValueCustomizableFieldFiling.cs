
//.ImportValueCustomizableFieldFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importValueCustomizableFieldFiling")]
  public class ImportValueCustomizableFieldFiling
  {
    [XmlArray(ElementName = "valueCustomizableFieldFilingToImport", IsNullable = false, Order = 0)]
    public List<Filing> ValueCustomizableFieldFilingToImport { get; set; }
  }
}
