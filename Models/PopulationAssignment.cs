
// Type: KelioSDK.Models.PopulationAssignment




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "PopulationAssignment")]
  public class PopulationAssignment : EmployeeInformation
  {
    [XmlElement(DataType = "string", ElementName = "organizationChartFullDescription", IsNullable = true)]
    public string OrganizationChartFullDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "subDepartmentDescription", IsNullable = true)]
    public string SubDepartmentDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "populationComment", IsNullable = true)]
    public string PopulationComment { get; set; }

    [XmlElement(DataType = "date", ElementName = "startDate", IsNullable = true)]
    public DateTime? StartDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "endDate", IsNullable = true)]
    public DateTime? EndDate { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "populationSubstitute", IsNullable = true)]
    public bool? PopulationSubstitute { get; set; }

    [XmlElement(DataType = "string", ElementName = "companyDescription", IsNullable = true)]
    public string CompanyDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "departmentDescription", IsNullable = true)]
    public string DepartmentDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "firmDescription", IsNullable = true)]
    public string FirmDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "sectionDescription", IsNullable = true)]
    public string SectionDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "sectionAbbreviation", IsNullable = true)]
    public string SectionAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "populationDescription", IsNullable = true)]
    public string PopulationDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "populationKey", IsNullable = true)]
    public int? PopulationKey { get; set; }
  }
}
