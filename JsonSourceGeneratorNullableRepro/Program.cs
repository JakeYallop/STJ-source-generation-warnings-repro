using System.Text.Json.Serialization;

Console.WriteLine("JSON Source Generator repro");

public class Class
{
    public Uri? NullableUri { get; set; }
    public byte[]? ByteArray { get; set; }
}

[JsonSourceGenerationOptions(PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase)]
[JsonSerializable(typeof(Class))]
internal partial class Context : JsonSerializerContext
{

}