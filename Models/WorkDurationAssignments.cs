
// Type: KelioSDK.Models.WorkDurationAssignments




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "WorkDurationAssignments")]
  public class WorkDurationAssignments : EmployeeInformation
  {
    [XmlElement(DataType = "date", ElementName = "populationStartDate", IsNullable = true)]
    public DateTime? PopulationStartDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "hourlyBasisDistributionAbbreviation", IsNullable = true)]
    public string HourlyBasisDistributionAbbreviation { get; set; }

    [XmlElement(DataType = "int", ElementName = "hourlyBasisDistributionKey", IsNullable = true)]
    public int? HourlyBasisDistributionKey { get; set; }

    [XmlElement(DataType = "int", ElementName = "workDurationAssignmentKey", IsNullable = true)]
    public int? WorkDurationAssignmentKey { get; set; }

    [XmlElement(DataType = "date", ElementName = "populationEndDate", IsNullable = true)]
    public DateTime? PopulationEndDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "hourlyBasisDistributionDescription", IsNullable = true)]
    public string HourlyBasisDistributionDescription { get; set; }

    [XmlElement(DataType = "date", ElementName = "startDate", IsNullable = true)]
    public DateTime? StartDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "endDate", IsNullable = true)]
    public DateTime? EndDate { get; set; }

    [XmlElement(DataType = "int", ElementName = "startOffset", IsNullable = true)]
    public int? StartOffset { get; set; }

    [XmlElement(DataType = "int", ElementName = "endOffset", IsNullable = true)]
    public int? EndOffset { get; set; }

    [XmlElement(DataType = "double", ElementName = "hourlyBasis", IsNullable = true)]
    public double? HourlyBasis { get; set; }

    [XmlElement(DataType = "string", ElementName = "populationFilter", IsNullable = true)]
    public string PopulationFilter { get; set; }

    [XmlElement(DataType = "int", ElementName = "hourlyBasisType", IsNullable = true)]
    public int? HourlyBasisType { get; set; }

    [XmlElement(DataType = "short", ElementName = "populationMode", IsNullable = true)]
    public short? PopulationMode { get; set; }

    [XmlElement(DataType = "string", ElementName = "rateDescription", IsNullable = true)]
    public string RateDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "rateKey", IsNullable = true)]
    public int? RateKey { get; set; }

    [XmlElement(DataType = "int", ElementName = "dateMode", IsNullable = true)]
    public int? DateMode { get; set; }

    [XmlElement(DataType = "string", ElementName = "groupFilter", IsNullable = true)]
    public string GroupFilter { get; set; }

    [XmlElement(DataType = "string", ElementName = "rateAbbreviation", IsNullable = true)]
    public string RateAbbreviation { get; set; }
  }
}
