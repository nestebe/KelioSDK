
// Type: KelioSDK.Models.SkillAssignment




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "SkillAssignment")]
  public class SkillAssignment : EmployeeInformation
  {
    [XmlElement(DataType = "int", ElementName = "skillAssignmentKey", IsNullable = true)]
    public int? SkillAssignmentKey { get; set; }

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

    [XmlElement(DataType = "string", ElementName = "level", IsNullable = true)]
    public string Level { get; set; }

    [XmlElement(DataType = "string", ElementName = "skillAbbreviation", IsNullable = true)]
    public string SkillAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "skillDescription", IsNullable = true)]
    public string SkillDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "populationMode", IsNullable = true)]
    public int? PopulationMode { get; set; }

    [XmlElement(DataType = "int", ElementName = "skillKey", IsNullable = true)]
    public int? SkillKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "populationFilter", IsNullable = true)]
    public string PopulationFilter { get; set; }

    [XmlElement(DataType = "int", ElementName = "dateMode", IsNullable = true)]
    public int? DateMode { get; set; }

    [XmlElement(DataType = "string", ElementName = "groupFilter", IsNullable = true)]
    public string GroupFilter { get; set; }
  }
}
