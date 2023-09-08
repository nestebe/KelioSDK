
// Type: KelioSDK.Models.DetailFireReportPeoplePresent




using KelioSDK.Common;
using System;
using System.Globalization;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "DetailFireReportPeoplePresent")]
  public class DetailFireReportPeoplePresent : ObjectBase
  {
    [XmlElement(DataType = "string", ElementName = "readerUsedForSignaturePresentPerson", IsNullable = true)]
    public string ReaderUsedForSignaturePresentPerson { get; set; }

    [XmlElement(DataType = "string", ElementName = "presentPersonFirstNameSurName", IsNullable = true)]
    public string PresentPersonFirstNameSurName { get; set; }

    [XmlElement(DataType = "string", ElementName = "userWhoRegisteredPresentPerson", IsNullable = true)]
    public string UserWhoRegisteredPresentPerson { get; set; }

    [XmlElement(DataType = "int", ElementName = "usedFireReportConfigurationKey", IsNullable = true)]
    public int? UsedFireReportConfigurationKey { get; set; }

    [XmlElement(DataType = "int", ElementName = "presentPersonStatus", IsNullable = true)]
    public int? PresentPersonStatus { get; set; }

    [XmlElement(DataType = "string", ElementName = "usedFireReportConfigurationDescription", IsNullable = true)]
    public string UsedFireReportConfigurationDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "fireReportMonitoringKey", IsNullable = true)]
    public int? FireReportMonitoringKey { get; set; }

    [XmlElement(DataType = "date", ElementName = "censusDate", IsNullable = true)]
    public DateTime? CensusDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "deltaBetweenPresentPersonAndReportStartDate", IsNullable = true)]
    public string DeltaBetweenPresentPersonAndReportStartDate { get; set; }

    [XmlIgnore]
    public TimeSpan? CensusHour { get; set; }

    [XmlElement(DataType = "string", ElementName = "censusHour", IsNullable = true)]
    public string CensusHourField
    {
      get
      {
        return !this.CensusHour.HasValue ? (string) null : this.CensusHour.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.CensusHour = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }
  }
}
