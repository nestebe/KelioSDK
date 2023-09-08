
// Type: KelioSDK.Models.AbstractTotal




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AbstractTotal")]
  public class AbstractTotal : EmployeeInformation
  {
    [XmlElement(DataType = "int", ElementName = "sectionKey", IsNullable = true)]
    public int? SectionKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "sectionDescription", IsNullable = true)]
    public string SectionDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "sectionAbbreviation", IsNullable = true)]
    public string SectionAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "typeDescription", IsNullable = true)]
    public string TypeDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "typeAbbreviation", IsNullable = true)]
    public string TypeAbbreviation { get; set; }

    [XmlElement(DataType = "int", ElementName = "typeKey", IsNullable = true)]
    public int? TypeKey { get; set; }
  }
}
