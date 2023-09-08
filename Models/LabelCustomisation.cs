
// Type: KelioSDK.Models.LabelCustomisation




using KelioSDK.Common;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "LabelCustomisation")]
  public class LabelCustomisation : ObjectBase
  {
    [XmlElement(DataType = "string", ElementName = "customisedLabelValue", IsNullable = true)]
    public string CustomisedLabelValue { get; set; }

    [XmlElement(DataType = "int", ElementName = "customisedLabelType", IsNullable = true)]
    public int? CustomisedLabelType { get; set; }
  }
}
