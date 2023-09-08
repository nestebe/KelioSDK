
// Type: KelioSDK.Models.JobAssignment




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "JobAssignment")]
  public class JobAssignment : ComputedJobAssignment
  {
    [XmlElement(DataType = "string", ElementName = "note", IsNullable = true)]
    public string Note { get; set; }

    [XmlElement(DataType = "float", ElementName = "longitude", IsNullable = true)]
    public float? Longitude { get; set; }

    [XmlElement(DataType = "int", ElementName = "durationMode", IsNullable = true)]
    public int? DurationMode { get; set; }

    [XmlElement(DataType = "float", ElementName = "quantity", IsNullable = true)]
    public float? Quantity { get; set; }

    [XmlElement(DataType = "float", ElementName = "latitude", IsNullable = true)]
    public float? Latitude { get; set; }

    [XmlElement(DataType = "int", ElementName = "jobAssignmentKey", IsNullable = true)]
    public int? JobAssignmentKey { get; set; }

    [XmlElement(DataType = "int", ElementName = "geolocationPrecision", IsNullable = true)]
    public int? GeolocationPrecision { get; set; }

    [XmlElement(DataType = "short", ElementName = "geolocationStatus", IsNullable = true)]
    public short? GeolocationStatus { get; set; }
  }
}
