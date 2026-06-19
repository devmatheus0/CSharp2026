namespace ProjetoAPI01.Classes.DTO
{
    public class ResponseAdminDTO
    {
        public int id { get; set; }
        public int RA { get; set; }
        public string StatusWIFI { get; set; } = string.Empty;
        public string StatusAction { get; set; } = string.Empty;
        public int CursoID { get; set; }
        public int Regra { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
    }
}
