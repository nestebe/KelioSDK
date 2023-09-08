
// Type: KelioSDK.Models.EmployeeTrainingHistory




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "EmployeeTrainingHistory")]
  public class EmployeeTrainingHistory : EmployeeInformation
  {
    [XmlElement(DataType = "string", ElementName = "trainingDescription", IsNullable = true)]
    public string TrainingDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "trainingStatus", IsNullable = true)]
    public string TrainingStatus { get; set; }

    [XmlElement(DataType = "date", ElementName = "trainingStartDate", IsNullable = true)]
    public DateTime? TrainingStartDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "trainingEndDate", IsNullable = true)]
    public DateTime? TrainingEndDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "trainingTitle", IsNullable = true)]
    public string TrainingTitle { get; set; }

    [XmlElement(DataType = "int", ElementName = "trainingHistoryKey", IsNullable = true)]
    public int? TrainingHistoryKey { get; set; }

    [XmlElement(DataType = "date", ElementName = "creationDate", IsNullable = true)]
    public DateTime? CreationDate { get; set; }
  }
}
