namespace ServiceLayer;

using System.Runtime.Serialization;

[DataContract]
public record SchemaInfo
{
    [DataMember]
    public string Name { get; set; }
}