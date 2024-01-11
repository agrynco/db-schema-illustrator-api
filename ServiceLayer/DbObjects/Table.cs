namespace ServiceLayer;

using System.Runtime.Serialization;

[DataContract]
public record Table
{
    [DataMember]
    public string Name { get; set; }
}