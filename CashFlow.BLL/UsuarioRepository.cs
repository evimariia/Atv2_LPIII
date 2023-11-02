//using MyProject.DAL.DBContext;
using CashFlow.MODEL;

namespace MyProject.BLL
{
    public static class UsuarioRepository
    {
        public static void Add(Usuario _usuario)
        {
            using (var dbContext = new CGerenciadordefinancasCashflowDalDatabaseDatabaseMdfContext())
            {
                dbContext.Add(_usuario);
                dbContext.SaveChanges();
            }
        }

        public static Usuario GetById(int Id)
        {
            using (var dbContext = new CGerenciadordefinancasCashflowDalDatabaseDatabaseMdfContext())
            {
                var usuario = dbContext.Usuarios.Single(p => p.Id == Id);
                return usuario;
            }
        }

        public static Usuario GetByLogin(String login)
        {
            using (var dbContext = new CGerenciadordefinancasCashflowDalDatabaseDatabaseMdfContext())
            {
                var usuario = dbContext.Usuarios.Single(p => p.Login == login);
                return usuario;
            }
        }

        public static Boolean AutenticaUsuario(String login, String senha)
        {
            using (var dbContext = new CGerenciadordefinancasCashflowDalDatabaseDatabaseMdfContext())
            {
                var usuario = dbContext.Usuarios.Single(p => p.Login == login);
                if (usuario.Login == login && usuario.Senha == senha)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
        }

        public static List<Usuario> GetAll()
        {
            using (var dbContext = new CGerenciadordefinancasCashflowDalDatabaseDatabaseMdfContext())
            {
                var usuario = dbContext.Usuarios.ToList();
                return usuario;
            }

        }

        public static void Update(Usuario _usuario)
        {

            using (var dbContext = new CGerenciadordefinancasCashflowDalDatabaseDatabaseMdfContext())
            {
                var usuario = dbContext.Usuarios.Single(p => p.Id == _usuario.Id);
                usuario.Nome = _usuario.Nome;
                usuario.Login = _usuario.Login;
                usuario.Senha = _usuario.Senha;
                dbContext.SaveChanges();
            }

        }

        public static void Excluir(Usuario _usuario)
        {
            using (var dbContext = new CGerenciadordefinancasCashflowDalDatabaseDatabaseMdfContext())
            {
                var usuario = dbContext.Usuarios.Single(p => p.Id == _usuario.Id);
                dbContext.Remove(usuario);
                dbContext.SaveChanges();
            }
        }

    }
}