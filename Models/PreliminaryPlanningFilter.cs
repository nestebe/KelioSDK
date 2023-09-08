
// Type: KelioSDK.Models.PreliminaryPlanningFilter




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "PreliminaryPlanningFilter")]
  public class PreliminaryPlanningFilter
  {
    [XmlElement(DataType = "date", ElementName = "startDate", IsNullable = true)]
    public DateTime? StartDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "endDate", IsNullable = true)]
    public DateTime? EndDate { get; set; }

    [XmlElement(DataType = "int", ElementName = "startOffset", IsNullable = true)]
    public int? StartOffset { get; set; }

    [XmlElement(DataType = "int", ElementName = "endOffset", IsNullable = true)]
    public int? EndOffset { get; set; }

    [XmlElement(DataType = "string", ElementName = "userLastName", IsNullable = true)]
    public string UserLastName { get; set; }

    [XmlElement(DataType = "string", ElementName = "userFirstName", IsNullable = true)]
    public string UserFirstName { get; set; }

    [XmlElement(DataType = "string", ElementName = "userLogin", IsNullable = true)]
    public string UserLogin { get; set; }

    [XmlElement(DataType = "string", ElementName = "preliminaryPlanningPopulationDescription", IsNullable = true)]
    public string PreliminaryPlanningPopulationDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "preliminaryPlanningDescription", IsNullable = true)]
    public string PreliminaryPlanningDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "preliminaryPlanningKey", IsNullable = true)]
    public int? PreliminaryPlanningKey { get; set; }

    [XmlElement(DataType = "int", ElementName = "preliminaryPlanningPopulationKey", IsNullable = true)]
    public int? PreliminaryPlanningPopulationKey { get; set; }

    [XmlElement(DataType = "int", ElementName = "dateMode", IsNullable = true)]
    public int? DateMode { get; set; }
  }
}
