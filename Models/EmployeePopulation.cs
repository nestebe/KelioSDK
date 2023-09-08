
// Type: KelioSDK.Models.EmployeePopulation




using KelioSDK.Common;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "EmployeePopulation")]
  public class EmployeePopulation : ObjectBase
  {
    [XmlElement(DataType = "string", ElementName = "populationComment", IsNullable = true)]
    public string PopulationComment { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "populationSubstitute", IsNullable = true)]
    public bool? PopulationSubstitute { get; set; }

    [XmlElement(DataType = "string", ElementName = "populationDescription", IsNullable = true)]
    public string PopulationDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "populationKey", IsNullable = true)]
    public int? PopulationKey { get; set; }
  }
}
