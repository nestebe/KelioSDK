
//.ExportCustomizableFieldFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportCustomizableFieldFilingResponse")]
  public class ExportCustomizableFieldFilingResponse
  {
    [XmlArray(ElementName = "exportedCustomizableFieldFiling", IsNullable = false, Order = 0)]
    public List<Filing> ExportedCustomizableFieldFiling { get; set; }
  }
}
