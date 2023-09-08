
//.ExportValueCustomizableFieldFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportValueCustomizableFieldFilingResponse")]
  public class ExportValueCustomizableFieldFilingResponse
  {
    [XmlArray(ElementName = "exportedValueCustomizableFieldFiling", IsNullable = false, Order = 0)]
    public List<Filing> ExportedValueCustomizableFieldFiling { get; set; }
  }
}
