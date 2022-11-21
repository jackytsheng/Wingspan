using System.Text.Json;

namespace Wingspan;

public class SnakeCasePolicy : JsonNamingPolicy
{
    public override string ConvertName(string name) => new NamingHelper().ToSnakeCase(name);
}
