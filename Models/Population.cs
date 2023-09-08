
// Type: KelioSDK.Models.Population




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "Population")]
  public class Population : EmployeeInformation
  {
    [XmlElement(DataType = "string", ElementName = "login", IsNullable = true)]
    public string Login { get; set; }

    [XmlElement(DataType = "string", ElementName = "password", IsNullable = true)]
    public string Password { get; set; }

    [XmlElement(DataType = "date", ElementName = "startDate", IsNullable = true)]
    public DateTime? StartDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "endDate", IsNullable = true)]
    public DateTime? EndDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "operatorFirstName", IsNullable = true)]
    public string OperatorFirstName { get; set; }

    [XmlElement(DataType = "string", ElementName = "operatorSurname", IsNullable = true)]
    public string OperatorSurname { get; set; }

    [XmlElement(DataType = "int", ElementName = "operatorKey", IsNullable = true)]
    public int? OperatorKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "populationDescription", IsNullable = true)]
    public string PopulationDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "populationKey", IsNullable = true)]
    public int? PopulationKey { get; set; }
  }
}
