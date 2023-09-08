
//.ImportJobTypesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importJobTypesResponse")]
  public class ImportJobTypesResponse
  {
    [XmlArray(ElementName = "JobTypesInError", IsNullable = false, Order = 0)]
    public List<JobType> JobTypesInError { get; set; }
  }
}
