
//.ImportTransportTickets




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importTransportTickets")]
  public class ImportTransportTickets
  {
    [XmlArray(ElementName = "transportTicketsToImport", IsNullable = false, Order = 0)]
    public List<TransportTicket> TransportTicketsToImport { get; set; }
  }
}
