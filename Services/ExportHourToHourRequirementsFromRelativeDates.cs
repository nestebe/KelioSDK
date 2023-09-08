
//.ExportHourToHourRequirementsFromRelativeDates




using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportHourToHourRequirementsFromRelativeDates")]
  public class ExportHourToHourRequirementsFromRelativeDates
  {
    [XmlElement(DataType = "string", ElementName = "populationFilter", IsNullable = true, Order = 0)]
    public string PopulationFilter { get; set; }

    [XmlElement(DataType = "string", ElementName = "postFilter", IsNullable = true, Order = 1)]
    public string PostFilter { get; set; }

    [XmlElement(DataType = "int", ElementName = "startOffset", IsNullable = true, Order = 2)]
    public int? StartOffset { get; set; }

    [XmlElement(DataType = "int", ElementName = "endOffset", IsNullable = true, Order = 3)]
    public int? EndOffset { get; set; }
  }
}
