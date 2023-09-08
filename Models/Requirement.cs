
// Type: KelioSDK.Models.Requirement




using KelioSDK.Common;
using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "Requirement")]
  public class Requirement : ObjectBase
  {
    [XmlElement(DataType = "short", ElementName = "DayMode", IsNullable = true)]
    public short? DayMode { get; set; }

    [XmlElement(DataType = "date", ElementName = "applicationDate", IsNullable = true)]
    public DateTime? ApplicationDate { get; set; }

    [XmlElement(DataType = "double", ElementName = "number", IsNullable = true)]
    public double? Number { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "blockingRequirement", IsNullable = true)]
    public bool? BlockingRequirement { get; set; }

    [XmlElement(DataType = "double", ElementName = "hours", IsNullable = true)]
    public double? Hours { get; set; }

    [XmlElement(DataType = "string", ElementName = "postInColumnDescription", IsNullable = true)]
    public string PostInColumnDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "postInLineKey", IsNullable = true)]
    public int? PostInLineKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "postInLineDescription", IsNullable = true)]
    public string PostInLineDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "postInColumnKey", IsNullable = true)]
    public int? PostInColumnKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "populationDescription", IsNullable = true)]
    public string PopulationDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "populationKey", IsNullable = true)]
    public int? PopulationKey { get; set; }

    [XmlElement(DataType = "int", ElementName = "requirementKey", IsNullable = true)]
    public int? RequirementKey { get; set; }
  }
}
