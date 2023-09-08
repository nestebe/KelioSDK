
//.ImportAnnualizedHourSchedulesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importAnnualizedHourSchedulesResponse")]
  public class ImportAnnualizedHourSchedulesResponse
  {
    [XmlArray(ElementName = "annualizedHourSchedulesInError", IsNullable = false, Order = 0)]
    public List<AnnualizedHourSchedule> AnnualizedHourSchedulesInError { get; set; }
  }
}
