
//.ImportJobTypes




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importJobTypes")]
  public class ImportJobTypes
  {
    [XmlArray(ElementName = "JobTypesToImport", IsNullable = false, Order = 0)]
    public List<JobType> JobTypesToImport { get; set; }
  }
}
