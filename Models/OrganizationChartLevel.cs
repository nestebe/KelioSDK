
// Type: KelioSDK.Models.OrganizationChartLevel




using KelioSDK.Common;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "OrganizationChartLevel")]
  public class OrganizationChartLevel : ObjectBase
  {
    [XmlElement(DataType = "string", ElementName = "subDepartmentDescription", IsNullable = true)]
    public string SubDepartmentDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "departmentManager", IsNullable = true)]
    public string DepartmentManager { get; set; }

    [XmlElement(DataType = "string", ElementName = "subDepartmentManager", IsNullable = true)]
    public string SubDepartmentManager { get; set; }

    [XmlElement(DataType = "string", ElementName = "companyFileNumber", IsNullable = true)]
    public string CompanyFileNumber { get; set; }

    [XmlElement(DataType = "string", ElementName = "companyPhoneNumber", IsNullable = true)]
    public string CompanyPhoneNumber { get; set; }

    [XmlElement(DataType = "string", ElementName = "levels", IsNullable = true)]
    public string Levels { get; set; }

    [XmlElement(DataType = "string", ElementName = "manager", IsNullable = true)]
    public string Manager { get; set; }

    [XmlElement(DataType = "int", ElementName = "sectionKey", IsNullable = true)]
    public int? SectionKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "level4Manager", IsNullable = true)]
    public string Level4Manager { get; set; }

    [XmlElement(DataType = "string", ElementName = "companyWebAddress", IsNullable = true)]
    public string CompanyWebAddress { get; set; }

    [XmlElement(DataType = "string", ElementName = "level8Manager", IsNullable = true)]
    public string Level8Manager { get; set; }

    [XmlElement(DataType = "string", ElementName = "fullDescription", IsNullable = true)]
    public string FullDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "sectionManager", IsNullable = true)]
    public string SectionManager { get; set; }

    [XmlElement(DataType = "string", ElementName = "level7Manager", IsNullable = true)]
    public string Level7Manager { get; set; }

    [XmlElement(DataType = "string", ElementName = "level6Manager", IsNullable = true)]
    public string Level6Manager { get; set; }

    [XmlElement(DataType = "string", ElementName = "firmManager", IsNullable = true)]
    public string FirmManager { get; set; }

    [XmlElement(DataType = "string", ElementName = "companyAddress", IsNullable = true)]
    public string CompanyAddress { get; set; }

    [XmlElement(DataType = "string", ElementName = "level5Manager", IsNullable = true)]
    public string Level5Manager { get; set; }

    [XmlElement(DataType = "string", ElementName = "companyFaxNumber", IsNullable = true)]
    public string CompanyFaxNumber { get; set; }

    [XmlElement(DataType = "string", ElementName = "companyMailAddress", IsNullable = true)]
    public string CompanyMailAddress { get; set; }

    [XmlElement(DataType = "int", ElementName = "organizationChartLevelKey", IsNullable = true)]
    public int? OrganizationChartLevelKey { get; set; }

    [XmlElement(DataType = "short", ElementName = "organizationChartLevelDescriptionType", IsNullable = true)]
    public short? OrganizationChartLevelDescriptionType { get; set; }

    [XmlElement(DataType = "int", ElementName = "departmentKey", IsNullable = true)]
    public int? DepartmentKey { get; set; }

    [XmlElement(DataType = "int", ElementName = "subDepartmentKey", IsNullable = true)]
    public int? SubDepartmentKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "companyDescription", IsNullable = true)]
    public string CompanyDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "level6Description", IsNullable = true)]
    public string Level6Description { get; set; }

    [XmlElement(DataType = "string", ElementName = "level8Description", IsNullable = true)]
    public string Level8Description { get; set; }

    [XmlElement(DataType = "string", ElementName = "level7Description", IsNullable = true)]
    public string Level7Description { get; set; }

    [XmlElement(DataType = "string", ElementName = "level5Description", IsNullable = true)]
    public string Level5Description { get; set; }

    [XmlElement(DataType = "string", ElementName = "level4Description", IsNullable = true)]
    public string Level4Description { get; set; }

    [XmlElement(DataType = "string", ElementName = "departmentDescription", IsNullable = true)]
    public string DepartmentDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "firmDescription", IsNullable = true)]
    public string FirmDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "sectionDescription", IsNullable = true)]
    public string SectionDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "sectionAbbreviation", IsNullable = true)]
    public string SectionAbbreviation { get; set; }

    [XmlElement(DataType = "int", ElementName = "companyKey", IsNullable = true)]
    public int? CompanyKey { get; set; }

    [XmlElement(DataType = "int", ElementName = "level4Key", IsNullable = true)]
    public int? Level4Key { get; set; }

    [XmlElement(DataType = "int", ElementName = "level5Key", IsNullable = true)]
    public int? Level5Key { get; set; }

    [XmlElement(DataType = "int", ElementName = "level7Key", IsNullable = true)]
    public int? Level7Key { get; set; }

    [XmlElement(DataType = "int", ElementName = "firmKey", IsNullable = true)]
    public int? FirmKey { get; set; }

    [XmlElement(DataType = "int", ElementName = "level6Key", IsNullable = true)]
    public int? Level6Key { get; set; }

    [XmlElement(DataType = "int", ElementName = "level8Key", IsNullable = true)]
    public int? Level8Key { get; set; }

    [XmlElement(DataType = "short", ElementName = "levelType", IsNullable = true)]
    public short? LevelType { get; set; }
  }
}
