
// Type: KelioSDK.Models.AskedEmployeeDocument




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AskedEmployeeDocument")]
  public class AskedEmployeeDocument : AskedPopulation
  {
    [XmlElement(DataType = "date", ElementName = "startDate", IsNullable = true)]
    public DateTime? StartDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "endDate", IsNullable = true)]
    public DateTime? EndDate { get; set; }

    [XmlElement(DataType = "short", ElementName = "documentLocation", IsNullable = true)]
    public short? DocumentLocation { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "enableDataExport", IsNullable = true)]
    public bool? EnableDataExport { get; set; }

    [XmlElement(DataType = "string", ElementName = "trainingTitle", IsNullable = true)]
    public string TrainingTitle { get; set; }

    [XmlElement(DataType = "date", ElementName = "trainingStartDate", IsNullable = true)]
    public DateTime? TrainingStartDate { get; set; }

    [XmlElement(DataType = "int", ElementName = "trainingKey", IsNullable = true)]
    public int? TrainingKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "documentTitle", IsNullable = true)]
    public string DocumentTitle { get; set; }
  }
}
