
//.ExportPlannedPerpetualAbsenceTotalsFromRelativeDates




using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportPlannedPerpetualAbsenceTotalsFromRelativeDates")]
  public class ExportPlannedPerpetualAbsenceTotalsFromRelativeDates
  {
    [XmlElement(DataType = "string", ElementName = "populationFilter", IsNullable = true, Order = 0)]
    public string PopulationFilter { get; set; }

    [XmlElement(DataType = "string", ElementName = "groupFilter", IsNullable = true, Order = 1)]
    public string GroupFilter { get; set; }

    [XmlElement(DataType = "int", ElementName = "startOffset", IsNullable = true, Order = 2)]
    public int? StartOffset { get; set; }

    [XmlElement(DataType = "int", ElementName = "endOffset", IsNullable = true, Order = 3)]
    public int? EndOffset { get; set; }
  }
}
