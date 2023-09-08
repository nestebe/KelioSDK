
//.ImportTransportTicketsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importTransportTicketsResponse")]
  public class ImportTransportTicketsResponse
  {
    [XmlArray(ElementName = "transportTicketsInError", IsNullable = false, Order = 0)]
    public List<TransportTicket> TransportTicketsInError { get; set; }
  }
}
