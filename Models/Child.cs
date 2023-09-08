
// Type: KelioSDK.Models.Child




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "Child")]
  public class Child : EmployeeInformation
  {
    [XmlElement(DataType = "string", ElementName = "childFirstName", IsNullable = true)]
    public string ChildFirstName { get; set; }

    [XmlElement(DataType = "date", ElementName = "childBirthDate", IsNullable = true)]
    public DateTime? ChildBirthDate { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "dependentChild", IsNullable = true)]
    public bool? DependentChild { get; set; }

    [XmlElement(DataType = "string", ElementName = "childSurname", IsNullable = true)]
    public string ChildSurname { get; set; }

    [XmlElement(DataType = "int", ElementName = "childKey", IsNullable = true)]
    public int? ChildKey { get; set; }

    [XmlElement(DataType = "int", ElementName = "sex", IsNullable = true)]
    public int? Sex { get; set; }
  }
}
