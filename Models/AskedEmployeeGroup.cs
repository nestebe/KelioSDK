
// Type: KelioSDK.Models.AskedEmployeeGroup




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AskedEmployeeGroup")]
  public class AskedEmployeeGroup
  {
    [XmlElement(DataType = "date", ElementName = "populationStartDate", IsNullable = true)]
    public DateTime? PopulationStartDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "populationEndDate", IsNullable = true)]
    public DateTime? PopulationEndDate { get; set; }

    [XmlElement(DataType = "int", ElementName = "employeeGroupKey", IsNullable = true)]
    public int? EmployeeGroupKey { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "includeArchivedEmployees", IsNullable = true)]
    public bool? IncludeArchivedEmployees { get; set; }

    [XmlElement(DataType = "string", ElementName = "populationFilter", IsNullable = true)]
    public string PopulationFilter { get; set; }

    [XmlElement(DataType = "string", ElementName = "employeeGroupDescription", IsNullable = true)]
    public string EmployeeGroupDescription { get; set; }
  }
}
