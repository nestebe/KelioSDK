
// Type: KelioSDK.Models.AskedAbsence




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AskedAbsence")]
  public class AskedAbsence : AskedPopulationWithPeriod
  {
    [XmlElement(DataType = "boolean", ElementName = "limitedToAPeriod", IsNullable = true)]
    public bool? LimitedToAPeriod { get; set; }

    [XmlElement(DataType = "int", ElementName = "absenceFileKey", IsNullable = true)]
    public int? AbsenceFileKey { get; set; }
  }
}
