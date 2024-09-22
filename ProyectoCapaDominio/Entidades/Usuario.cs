using DB.Domian.Base;


namespace DB.Domian.Entidades
{
    public class Usuario : BaseEntity
    {
        public string Nombre { get; set; }
        public string Email { get; set; }
        public int RolId { get; set; }
        public int Edad { get; internal set; }
    }
}
