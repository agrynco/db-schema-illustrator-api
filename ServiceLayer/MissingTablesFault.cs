namespace ServiceLayer;

using System.Runtime.Serialization;

[DataContract]
public record MissingTablesFault([property: DataMember] string Message);