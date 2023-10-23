using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace alpha_naf_poc.Domain.Constants;

[JsonConverter(typeof(StringEnumConverter))]
public enum Categories
{
    Business,
    Entertainment,
    Health,
    Science,
    Sports,
    Technology
}
