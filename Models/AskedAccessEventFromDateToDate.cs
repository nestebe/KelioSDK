
// Type: KelioSDK.Models.AskedAccessEventFromDateToDate




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "askedAccessEventFromDateToDate")]
  public class AskedAccessEventFromDateToDate : AskedAccessEvent
  {
    [XmlElement(DataType = "date", ElementName = "startDate", IsNullable = true)]
    public DateTime? StartDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "endDate", IsNullable = true)]
    public DateTime? EndDate { get; set; }
  }
}
