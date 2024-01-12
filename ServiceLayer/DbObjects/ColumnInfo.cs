namespace ServiceLayer;

using System.Runtime.Serialization;

[DataContract]
public record ColumnInfo
{
    [DataMember]
    public bool IsPrimary { get; set; }

    [DataMember]
    public string Name { get; set; }
}