namespace ServiceLayer;

using System.Runtime.Serialization;

[DataContract]
public record TableInfo
{
    [DataMember]
    public List<ColumnInfo> Columns { get; set; }

    [DataMember]
    public string Name { get; set; }
}