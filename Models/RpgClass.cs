using System.Text.Json.Serialization;

namespace DOtNetRPG.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight,
        Mage,
        Cleric

    }
}