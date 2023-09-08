
//.ExecuteInstancesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "executeInstancesResponse")]
  public class ExecuteInstancesResponse
  {
    [XmlArray(ElementName = "executedInstances", IsNullable = false, Order = 0)]
    public List<Instance> ExecutedInstances { get; set; }
  }
}
