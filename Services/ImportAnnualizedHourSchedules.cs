
//.ImportAnnualizedHourSchedules




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importAnnualizedHourSchedules")]
  public class ImportAnnualizedHourSchedules
  {
    [XmlArray(ElementName = "annualizedHourSchedulesToImport", IsNullable = false, Order = 0)]
    public List<AnnualizedHourSchedule> AnnualizedHourSchedulesToImport { get; set; }
  }
}
