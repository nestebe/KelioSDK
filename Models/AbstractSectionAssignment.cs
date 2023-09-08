
// Type: KelioSDK.Models.AbstractSectionAssignment




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AbstractSectionAssignment")]
  public class AbstractSectionAssignment : EmployeeInformation
  {
    [XmlElement(DataType = "string", ElementName = "subDepartmentDescription", IsNullable = true)]
    public string SubDepartmentDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "sectionKey", IsNullable = true)]
    public int? SectionKey { get; set; }

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

    [XmlElement(DataType = "string", ElementName = "sectionFullDescription", IsNullable = true)]
    public string SectionFullDescription { get; set; }

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
  }
}
