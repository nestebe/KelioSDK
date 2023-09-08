
// Type: KelioSDK.Models.JobType




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "JobType")]
  public class JobType : Type
  {
    [XmlElement(DataType = "string", ElementName = "comment", IsNullable = true)]
    public string Comment { get; set; }

    [XmlElement(DataType = "string", ElementName = "code", IsNullable = true)]
    public string Code { get; set; }

    [XmlElement(DataType = "int", ElementName = "colour", IsNullable = true)]
    public int? Colour { get; set; }

    [XmlElement(DataType = "short", ElementName = "grid", IsNullable = true)]
    public short? Grid { get; set; }

    [XmlElement(DataType = "date", ElementName = "usabilityEndDate", IsNullable = true)]
    public DateTime? UsabilityEndDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "usabilityStartDate", IsNullable = true)]
    public DateTime? UsabilityStartDate { get; set; }

    [XmlElement(DataType = "short", ElementName = "costCentreLink", IsNullable = true)]
    public short? CostCentreLink { get; set; }

    [XmlElement(DataType = "short", ElementName = "customerLink", IsNullable = true)]
    public short? CustomerLink { get; set; }

    [XmlElement(DataType = "int", ElementName = "iconKey", IsNullable = true)]
    public int? IconKey { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "toBeScheduled", IsNullable = true)]
    public bool? ToBeScheduled { get; set; }
  }
}
