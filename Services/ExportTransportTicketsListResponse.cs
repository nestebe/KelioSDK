
//.ExportTransportTicketsListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportTransportTicketsListResponse")]
  public class ExportTransportTicketsListResponse
  {
    [XmlArray(ElementName = "exportedTransportTickets", IsNullable = false, Order = 0)]
    public List<TransportTicket> ExportedTransportTickets { get; set; }
  }
}
