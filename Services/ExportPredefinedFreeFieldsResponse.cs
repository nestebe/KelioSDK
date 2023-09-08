
//.ExportPredefinedFreeFieldsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportPredefinedFreeFieldsResponse")]
  public class ExportPredefinedFreeFieldsResponse
  {
    [XmlArray(ElementName = "exportedPredefinedFreeFields", IsNullable = false, Order = 0)]
    public List<PredefinedField> ExportedPredefinedFreeFields { get; set; }
  }
}
