
//.ImportPredefinedFields




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importPredefinedFields")]
  public class ImportPredefinedFields
  {
    [XmlArray(ElementName = "predefinedFieldsToImport", IsNullable = false, Order = 0)]
    public List<PredefinedField> PredefinedFieldsToImport { get; set; }
  }
}
