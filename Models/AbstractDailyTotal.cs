
// Type: KelioSDK.Models.AbstractDailyTotal




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AbstractDailyTotal")]
  public class AbstractDailyTotal : AbstractTotal
  {
    [XmlElement(DataType = "date", ElementName = "date", IsNullable = true)]
    public DateTime? Date { get; set; }
  }
}
