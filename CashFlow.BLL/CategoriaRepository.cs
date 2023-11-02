//using CashFlow.DAL.DBContext;
using CashFlow.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BLL
{
    public class CategoriaRepository
    {
        public static void Add(Categoria _categoria)
        {
            using (var dbContext = new CGerenciadordefinancasCashflowDalDatabaseDatabaseMdfContext())
            {
                dbContext.Add(_categoria);
                dbContext.SaveChanges();
            }
        }

        public static Categoria GetById(int Id)
        {
            using (var dbContext = new CGerenciadordefinancasCashflowDalDatabaseDatabaseMdfContext())
            {
                var Categorium = dbContext.Categorias.Single(p => p.Id == Id);
                return Categorium;
            }
        }

        public static Categoria GetByNome(String nome)
        {
            using (var dbContext = new CGerenciadordefinancasCashflowDalDatabaseDatabaseMdfContext())
            {
                var Categorium = dbContext.Categorias.Single(p => p.Nome == nome);
                return Categorium;
            }
        }

        public static List<Categoria> GetAll()
        {
            using (var dbContext = new CGerenciadordefinancasCashflowDalDatabaseDatabaseMdfContext())
            {
                var Categorium = dbContext.Categorias.ToList();
                return Categorium;
            }
        }

        public static void Update(Categoria _categoria)
        {

            using (var dbContext = new CGerenciadordefinancasCashflowDalDatabaseDatabaseMdfContext())
            {
                var Categorium = dbContext.Categorias.Single(p => p.Id == _categoria.Id);
                Categorium.Nome = _categoria.Nome;
                Categorium.Descricao = _categoria.Descricao;
                Categorium.Id = _categoria.Id;
                dbContext.SaveChanges();
            }
        }

        public static void Excluir(Categoria _categoria)
        {
            using (var dbContext = new CGerenciadordefinancasCashflowDalDatabaseDatabaseMdfContext())
            {
                var Categorium = dbContext.Categorias.Single(p => p.Id == _categoria.Id);
                dbContext.Remove(Categorium);
                dbContext.SaveChanges();
            }
        }
    }
}