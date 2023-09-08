
// Type: KelioSDK.Models.AbstractPerpetualTotal




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AbstractPerpetualTotal")]
  public class AbstractPerpetualTotal : AbstractTotal
  {
    [XmlElement(DataType = "date", ElementName = "date", IsNullable = true)]
    public DateTime? Date { get; set; }
  }
}
