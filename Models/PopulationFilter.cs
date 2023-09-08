
// Type: KelioSDK.Models.PopulationFilter




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "PopulationFilter")]
  public class PopulationFilter : EmployeeInformation
  {
    [XmlElement(DataType = "date", ElementName = "populationStartDate", IsNullable = true)]
    public DateTime? PopulationStartDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "populationEndDate", IsNullable = true)]
    public DateTime? PopulationEndDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "startDate", IsNullable = true)]
    public DateTime? StartDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "endDate", IsNullable = true)]
    public DateTime? EndDate { get; set; }

    [XmlElement(DataType = "int", ElementName = "startOffset", IsNullable = true)]
    public int? StartOffset { get; set; }

    [XmlElement(DataType = "int", ElementName = "endOffset", IsNullable = true)]
    public int? EndOffset { get; set; }

    [XmlElement(DataType = "int", ElementName = "populationMode", IsNullable = true)]
    public int? PopulationMode { get; set; }

    [XmlElement(DataType = "string", ElementName = "populationFilter", IsNullable = true)]
    public string PopulationFilterProperty { get; set; }

    [XmlElement(DataType = "int", ElementName = "dateMode", IsNullable = true)]
    public int? DateMode { get; set; }

    [XmlElement(DataType = "string", ElementName = "groupFilter", IsNullable = true)]
    public string GroupFilter { get; set; }
  }
}
