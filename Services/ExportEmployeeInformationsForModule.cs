
//.ExportEmployeeInformationsForModule




using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEmployeeInformationsForModule")]
  public class ExportEmployeeInformationsForModule
  {
    [XmlElement(DataType = "string", ElementName = "populationFilter", IsNullable = true, Order = 0)]
    public string PopulationFilter { get; set; }

    [XmlElement(DataType = "string", ElementName = "groupFilter", IsNullable = true, Order = 1)]
    public string GroupFilter { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "includeTandAModuleEmployees", IsNullable = false, Order = 2)]
    public bool IncludeTandAModuleEmployees { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "includeAccessModuleEmployees", IsNullable = false, Order = 3)]
    public bool IncludeAccessModuleEmployees { get; set; }
  }
}
