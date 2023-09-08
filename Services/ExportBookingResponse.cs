
//.ExportBookingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportBookingResponse")]
  public class ExportBookingResponse
  {
    [XmlArray(ElementName = "exportedBooking", IsNullable = false, Order = 0)]
    public List<Booking> ExportedBooking { get; set; }
  }
}
