
//.ExportEstimatedDailyJobTotalsFromPeriod




using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEstimatedDailyJobTotalsFromPeriod")]
  public class ExportEstimatedDailyJobTotalsFromPeriod
  {
    [XmlElement(DataType = "string", ElementName = "populationFilter", IsNullable = true, Order = 0)]
    public string PopulationFilter { get; set; }

    [XmlElement(DataType = "string", ElementName = "groupFilter", IsNullable = true, Order = 1)]
    public string GroupFilter { get; set; }

    [XmlElement(DataType = "int", ElementName = "offset", IsNullable = true, Order = 2)]
    public int? Offset { get; set; }
  }
}
