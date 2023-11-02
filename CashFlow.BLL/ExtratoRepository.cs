//using MyProject.DAL.DBContext;
using CashFlow.MODEL;

namespace MyProject.BLL
{
    public static class ExtratoRepository
    {
        public static void Add(Extrato _extrato)
        {
            using (var dbContext = new CGerenciadordefinancasCashflowDalDatabaseDatabaseMdfContext())
            {
                dbContext.Add(_extrato);
                dbContext.SaveChanges();
            }
        }

        public static Extrato GetById(int Id)
        {
            using (var dbContext = new CGerenciadordefinancasCashflowDalDatabaseDatabaseMdfContext())
            {
                var extrato = dbContext.Extratos.Single(p => p.Id == Id);
                return extrato;
            }
        }

        public static List<Extrato> GetAll()
        {
            using (var dbContext = new CGerenciadordefinancasCashflowDalDatabaseDatabaseMdfContext())
            {
                var extrato = dbContext.Extratos.ToList();
                return extrato;
            }

        }

        public static decimal GetSoma(Extrato _extrato)
        {
            using (var dbContext = new CGerenciadordefinancasCashflowDalDatabaseDatabaseMdfContext())
            {
                decimal total = 0;
                var e = dbContext.Extratos.Single(p => p.Id == _extrato.Id);

                if(e.Tipo == "D")
                {
                    total -= e.Valor;
                }
                else if(e.Tipo == "R")
                {
                    total += e.Valor;
                }

                return total;
            }
        }

        public static void Update(Extrato _extrato)
        {

            using (var dbContext = new CGerenciadordefinancasCashflowDalDatabaseDatabaseMdfContext())
            {
                var extrato = dbContext.Extratos.Single(p => p.Id == _extrato.Id);
                extrato.Tipo = _extrato.Tipo;
                extrato.Valor = _extrato.Valor;
                extrato.Data = _extrato.Data;
                extrato.IdCategoria = _extrato.IdCategoria;
                extrato.IdUsuario = _extrato.IdUsuario;

                dbContext.SaveChanges();
            }

        }

        public static void Excluir(Extrato _extrato)
        {
            using (var dbContext = new CGerenciadordefinancasCashflowDalDatabaseDatabaseMdfContext())
            {
                var extrato = dbContext.Extratos.Single(p => p.Id == _extrato.Id);
                dbContext.Remove(extrato);
                dbContext.SaveChanges();
            }
        }

    }
}