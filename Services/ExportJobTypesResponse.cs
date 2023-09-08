
//.ExportJobTypesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportJobTypesResponse")]
  public class ExportJobTypesResponse
  {
    [XmlArray(ElementName = "exportedJobTypes", IsNullable = false, Order = 0)]
    public List<JobType> ExportedJobTypes { get; set; }
  }
}
