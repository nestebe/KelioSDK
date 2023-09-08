
// Type: KelioSDK.Models.AskedRequirements




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AskedRequirements")]
  public class AskedRequirements
  {
    [XmlElement(DataType = "date", ElementName = "startDate", IsNullable = true)]
    public DateTime? StartDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "endDate", IsNullable = true)]
    public DateTime? EndDate { get; set; }

    [XmlElement(DataType = "int", ElementName = "startOffset", IsNullable = true)]
    public int? StartOffset { get; set; }

    [XmlElement(DataType = "int", ElementName = "endOffset", IsNullable = true)]
    public int? EndOffset { get; set; }

    [XmlElement(DataType = "string", ElementName = "populationFilter", IsNullable = true)]
    public string PopulationFilter { get; set; }

    [XmlElement(DataType = "string", ElementName = "postFilter", IsNullable = true)]
    public string PostFilter { get; set; }

    [XmlElement(DataType = "int", ElementName = "dateMode", IsNullable = true)]
    public int? DateMode { get; set; }
  }
}
