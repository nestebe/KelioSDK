
//.ImportPredefinedFieldsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importPredefinedFieldsResponse")]
  public class ImportPredefinedFieldsResponse
  {
    [XmlArray(ElementName = "predefinedFieldsInError", IsNullable = false, Order = 0)]
    public List<PredefinedField> PredefinedFieldsInError { get; set; }
  }
}
