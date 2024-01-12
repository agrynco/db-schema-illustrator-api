namespace ServiceLayer;

using System.Runtime.Serialization;

[DataContract]
public record ForeignKeyInfo
{
    [DataMember]
    public string ConstraintName { get; set; }

    [DataMember]
    public string ForeignKeyColumnName { get; set; }

    [DataMember]
    public string ForeignKeyTableName { get; set; }

    [DataMember]
    public string PrimaryKeyColumnName { get; set; }

    [DataMember]
    public string PrimaryKeyTableName { get; set; }
}