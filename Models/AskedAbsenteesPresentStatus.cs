
// Type: KelioSDK.Models.AskedAbsenteesPresentStatus




using KelioSDK.Common;
using System;
using System.Globalization;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AskedAbsenteesPresentStatus")]
  public class AskedAbsenteesPresentStatus : ObjectBase
  {
    [XmlElement(DataType = "date", ElementName = "date", IsNullable = true)]
    public DateTime? Date { get; set; }

    [XmlIgnore]
    public TimeSpan? Time { get; set; }

    [XmlElement(DataType = "string", ElementName = "time", IsNullable = true)]
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

    [XmlElement(DataType = "date", ElementName = "populationStartDate", IsNullable = true)]
    public DateTime? PopulationStartDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "populationEndDate", IsNullable = true)]
    public DateTime? PopulationEndDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "populationFilter", IsNullable = true)]
    public string PopulationFilter { get; set; }

    [XmlElement(DataType = "string", ElementName = "groupFilter", IsNullable = true)]
    public string GroupFilter { get; set; }
  }
}
