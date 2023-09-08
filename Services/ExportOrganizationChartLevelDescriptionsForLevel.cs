
//.ExportOrganizationChartLevelDescriptionsForLevel




using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportOrganizationChartLevelDescriptionsForLevel")]
  public class ExportOrganizationChartLevelDescriptionsForLevel
  {
    [XmlElement(DataType = "short", ElementName = "levelFilter", IsNullable = true, Order = 0)]
    public short? LevelFilter { get; set; }
  }
}
