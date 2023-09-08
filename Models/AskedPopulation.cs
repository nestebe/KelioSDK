
// Type: KelioSDK.Models.AskedPopulation




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AskedPopulation")]
  public class AskedPopulation : EmployeeInformation
  {
    [XmlElement(DataType = "date", ElementName = "populationStartDate", IsNullable = true)]
    public DateTime? PopulationStartDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "populationEndDate", IsNullable = true)]
    public DateTime? PopulationEndDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "populationFilter", IsNullable = true)]
    public string PopulationFilter { get; set; }

    [XmlElement(DataType = "int", ElementName = "populationMode", IsNullable = true)]
    public int? PopulationMode { get; set; }

    [XmlElement(DataType = "string", ElementName = "groupFilter", IsNullable = true)]
    public string GroupFilter { get; set; }
  }
}
