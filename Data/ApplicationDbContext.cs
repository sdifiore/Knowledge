namespace Knowledge.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Plataforma>? Plataformas { get; set; }
        public DbSet<Framework> Frameworks { get; set; }
        public DbSet<Fonte> Fontes { get; set; }
        public DbSet<Erro> Erros { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Artigo> Artigos { get; set; }
    }
}
