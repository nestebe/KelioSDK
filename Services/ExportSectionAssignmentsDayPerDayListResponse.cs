
//.ExportSectionAssignmentsDayPerDayListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportSectionAssignmentsDayPerDayListResponse")]
  public class ExportSectionAssignmentsDayPerDayListResponse
  {
    [XmlArray(ElementName = "exportedSectionAssignmentsDayPerDay", IsNullable = false, Order = 0)]
    public List<SectionAssignmentDayPerDay> ExportedSectionAssignmentsDayPerDay { get; set; }
  }
}
