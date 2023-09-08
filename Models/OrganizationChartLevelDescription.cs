
// Type: KelioSDK.Models.OrganizationChartLevelDescription




using KelioSDK.Common;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "OrganizationChartLevelDescription")]
  public class OrganizationChartLevelDescription : ObjectBase
  {
    [XmlElement(DataType = "int", ElementName = "organizationChartLevelDescriptionType", IsNullable = true)]
    public int? OrganizationChartLevelDescriptionType { get; set; }

    [XmlElement(DataType = "string", ElementName = "organizationChartLevelDescriptionDescription", IsNullable = true)]
    public string OrganizationChartLevelDescriptionDescription { get; set; }

    [XmlElement(DataType = "short", ElementName = "organizationChartLevelDescriptionLevel", IsNullable = true)]
    public short? OrganizationChartLevelDescriptionLevel { get; set; }

    [XmlElement(DataType = "int", ElementName = "organizationChartLevelDescriptionKey", IsNullable = true)]
    public int? OrganizationChartLevelDescriptionKey { get; set; }
  }
}
