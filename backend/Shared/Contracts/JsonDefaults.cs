using System.Text.Json;

namespace Shared.Contracts;

public static class JsonDefaults
{
    public static readonly JsonSerializerOptions Options =
        new(JsonSerializerDefaults.Web);
}