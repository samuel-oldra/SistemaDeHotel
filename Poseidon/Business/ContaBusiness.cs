using Poseidon.Base;
using Poseidon.Entity;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;

namespace Poseidon.Business
{
    public class ContaBusiness
    {
        internal static ContaEntity GetConta(int id)
        {
            return BuscarConta(id);
        }

        internal static List<ContaEntity> GetContas()
        {
            return BuscarContas();
        }

        internal static bool Remover(ContaEntity conta)
        {
            return DeleteConta(conta.ID);
        }

        internal static bool Salvar(ContaEntity conta)
        {
            if (conta.ID == null)
                return InsertConta(conta);
            else
                return UpdateConta(conta);
        }

        private static ContaEntity BuscarConta(int id)
        {
            try
            {
                Table<ContaEntity> contas = Settings.dataContext.GetTable<ContaEntity>();
                Settings.dataContext.Refresh(RefreshMode.OverwriteCurrentValues, Settings.dataContext.GetTable<ContaEntity>());
                return contas.SingleOrDefault(c => c.ID == id);
            }
            catch
            { return null; }
        }

        private static List<ContaEntity> BuscarContas()
        {
            try
            {
                var contasList = new List<ContaEntity>();
                Table<ContaEntity> contas = Settings.dataContext.GetTable<ContaEntity>();
                Settings.dataContext.Refresh(RefreshMode.OverwriteCurrentValues, Settings.dataContext.GetTable<ContaEntity>());
                IEnumerable<ContaEntity> contasQuery = from c in contas.ToList() where c.Flag != 'D' select c;
                contasList.AddRange(contasQuery);
                return contasList;
            }
            catch
            { return null; }
        }

        private static bool DeleteConta(int? id)
        {
            if (id == null) return false;

            try
            {
                Table<ContaEntity> contas = Settings.dataContext.GetTable<ContaEntity>();
                ContaEntity contaDb = contas.SingleOrDefault(c => c.ID == id);
                contaDb.Flag = 'D';
                contaDb.Update = DateTime.Now;
                Settings.dataContext.SubmitChanges();
                return true;
            }
            catch
            { return false; }
        }

        private static bool InsertConta(ContaEntity conta)
        {
            try
            {
                Table<ContaEntity> contas = Settings.dataContext.GetTable<ContaEntity>();
                conta.ID = contas.Count() + 1;
                conta.Flag = 'I';
                conta.Update = DateTime.Now;
                contas.InsertOnSubmit(conta);
                Settings.dataContext.SubmitChanges();
                return true;
            }
            catch
            { return false; }
        }

        private static bool UpdateConta(ContaEntity conta)
        {
            try
            {
                Table<ContaEntity> contas = Settings.dataContext.GetTable<ContaEntity>();
                ContaEntity contaDb = contas.SingleOrDefault(c => c.ID == conta.ID);
                contaDb = conta;
                contaDb.Flag = 'U';
                contaDb.Update = DateTime.Now;
                Settings.dataContext.SubmitChanges();
                return true;
            }
            catch
            { return false; }
        }
    }
}