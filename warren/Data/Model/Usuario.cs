using System.Text.Json.Serialization;

namespace Data.Model
{
    public class Usuario : BaseModel
    {
        public string Email { get; set; }
        [JsonIgnore]
        public string Password { get; set; }
        public string Name { get; set; }
    }
}
