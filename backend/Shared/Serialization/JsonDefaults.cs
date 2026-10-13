using System.Text.Json;

namespace Shared.Serialization;

public static class JsonDefaults
{
    public static readonly JsonSerializerOptions Options =
        new(JsonSerializerDefaults.Web);
}