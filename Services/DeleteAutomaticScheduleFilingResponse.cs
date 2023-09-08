
//.DeleteAutomaticScheduleFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteAutomaticScheduleFilingResponse")]
  public class DeleteAutomaticScheduleFilingResponse
  {
    [XmlArray(ElementName = "automaticScheduleFilingInError", IsNullable = false, Order = 0)]
    public List<Filing> AutomaticScheduleFilingInError { get; set; }
  }
}
