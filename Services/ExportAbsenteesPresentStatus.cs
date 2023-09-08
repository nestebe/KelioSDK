
//.ExportAbsenteesPresentStatus




using System;
using System.Globalization;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportAbsenteesPresentStatus")]
  public class ExportAbsenteesPresentStatus
  {
    [XmlElement(DataType = "string", ElementName = "populationFilter", IsNullable = true, Order = 0)]
    public string PopulationFilter { get; set; }

    [XmlElement(DataType = "string", ElementName = "groupFilter", IsNullable = true, Order = 1)]
    public string GroupFilter { get; set; }

    [XmlElement(DataType = "date", ElementName = "date", IsNullable = true, Order = 2)]
    public DateTime? Date { get; set; }

    [XmlIgnore]
    public TimeSpan? Time { get; set; }

    [XmlElement(DataType = "string", ElementName = "time", IsNullable = true, Order = 4)]
    public string TimeField
    {
      get
      {
        return !this.Time.HasValue ? (string) null : this.Time.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.Time = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }
  }
}
