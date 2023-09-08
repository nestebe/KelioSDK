
// Type: KelioSDK.Models.AskedJobAssignments




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AskedJobAssignments")]
  public class AskedJobAssignments : AskedPopulationWithPeriod
  {
    [XmlElement(DataType = "int", ElementName = "calculationMode", IsNullable = true)]
    public int? CalculationMode { get; set; }
  }
}
