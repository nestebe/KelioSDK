
// Type: KelioSDK.Models.TransportTicket




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "TransportTicket")]
  public class TransportTicket : EmployeeInformation
  {
    [XmlElement(DataType = "string", ElementName = "transportTicketComment", IsNullable = true)]
    public string TransportTicketComment { get; set; }

    [XmlElement(DataType = "string", ElementName = "transportTicketDescription", IsNullable = true)]
    public string TransportTicketDescription { get; set; }

    [XmlElement(DataType = "date", ElementName = "transportTicketValidityEndDate", IsNullable = true)]
    public DateTime? TransportTicketValidityEndDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "transportTicketValidityStartDate", IsNullable = true)]
    public DateTime? TransportTicketValidityStartDate { get; set; }

    [XmlElement(DataType = "int", ElementName = "transportTicketKey", IsNullable = true)]
    public int? TransportTicketKey { get; set; }
  }
}
