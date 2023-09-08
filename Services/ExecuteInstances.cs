
//.ExecuteInstances




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "executeInstances")]
  public class ExecuteInstances
  {
    [XmlArray(ElementName = "instanceList", IsNullable = false, Order = 0)]
    public List<Instance> InstanceList { get; set; }
  }
}
