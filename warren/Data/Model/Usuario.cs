namespace Data.Model
{
    public class Usuario : BaseModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
    }
}
