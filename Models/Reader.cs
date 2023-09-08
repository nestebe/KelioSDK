
// Type: KelioSDK.Models.Reader




using KelioSDK.Common;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "reader")]
  public class Reader : ObjectBase
  {
    [XmlElement(DataType = "string", ElementName = "readerConfig2Description", IsNullable = true)]
    public string ReaderConfig2Description { get; set; }

    [XmlElement(DataType = "int", ElementName = "terminalKey", IsNullable = true)]
    public int? TerminalKey { get; set; }

    [XmlElement(DataType = "short", ElementName = "readerType", IsNullable = true)]
    public short? ReaderType { get; set; }

    [XmlElement(DataType = "string", ElementName = "readerDescription", IsNullable = true)]
    public string ReaderDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "readerConfigKey", IsNullable = true)]
    public int? ReaderConfigKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "readerIpAddress", IsNullable = true)]
    public string ReaderIpAddress { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "useInCensus", IsNullable = true)]
    public bool? UseInCensus { get; set; }

    [XmlElement(DataType = "string", ElementName = "readerConfigDescription", IsNullable = true)]
    public string ReaderConfigDescription { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "allowAccessIfClockingOut", IsNullable = true)]
    public bool? AllowAccessIfClockingOut { get; set; }

    [XmlElement(DataType = "string", ElementName = "readerIdentifier", IsNullable = true)]
    public string ReaderIdentifier { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "allowAccessIfClockingIn", IsNullable = true)]
    public bool? AllowAccessIfClockingIn { get; set; }

    [XmlElement(DataType = "int", ElementName = "readerConfig2Key", IsNullable = true)]
    public int? ReaderConfig2Key { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "useInAlarmManagement", IsNullable = true)]
    public bool? UseInAlarmManagement { get; set; }

    [XmlElement(DataType = "int", ElementName = "readerModelKey", IsNullable = true)]
    public int? ReaderModelKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "readerModelDescription", IsNullable = true)]
    public string ReaderModelDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "terminalDescription", IsNullable = true)]
    public string TerminalDescription { get; set; }

    [XmlElement(DataType = "short", ElementName = "readerNumber", IsNullable = true)]
    public short? ReaderNumber { get; set; }

    [XmlElement(DataType = "string", ElementName = "readerAbbreviation", IsNullable = true)]
    public string ReaderAbbreviation { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "useInAccessControl", IsNullable = true)]
    public bool? UseInAccessControl { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "allowClockingsOut", IsNullable = true)]
    public bool? AllowClockingsOut { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "allowClockingsIn", IsNullable = true)]
    public bool? AllowClockingsIn { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "useInTandA", IsNullable = true)]
    public bool? UseInTandA { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "authorizeSeveralAccessPoints", IsNullable = true)]
    public bool? AuthorizeSeveralAccessPoints { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "useInJobCosting", IsNullable = true)]
    public bool? UseInJobCosting { get; set; }

    [XmlElement(DataType = "int", ElementName = "readerKey", IsNullable = true)]
    public int? ReaderKey { get; set; }
  }
}
