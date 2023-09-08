
// Type: KelioSDK.Models.Coefficient




using KelioSDK.Common;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "Coefficient")]
  public class Coefficient : ObjectBase
  {
    [XmlElement(DataType = "string", ElementName = "coefficientDescription", IsNullable = true)]
    public string CoefficientDescription { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "searchCoefficientUsingAbbreviation", IsNullable = true)]
    public bool? SearchCoefficientUsingAbbreviation { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "searchCoefficientUsingDescription", IsNullable = true)]
    public bool? SearchCoefficientUsingDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "coefficientAbbreviation", IsNullable = true)]
    public string CoefficientAbbreviation { get; set; }

    [XmlElement(DataType = "int", ElementName = "coefficientKey", IsNullable = true)]
    public int? CoefficientKey { get; set; }
  }
}
