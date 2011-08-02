using Poseidon.Base;
using Poseidon.Entity;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;

namespace Poseidon.Business
{
    public class UnidadeHabitacionalBusiness
    {
        #region Internal Methods

        internal static UnidadeHabitacionalEntity GetUnidadeHabitacional(int id)
        {
            return BuscarUnidadeHabitacional(id);
        }

        internal static List<UnidadeHabitacionalEntity> GetUnidadesHabitacionais()
        {
            return BuscarUnidadesHabitacionais();
        }

        internal static List<UnidadeHabitacionalEntity> GetUnidadesHabitacionais_Livres(DateTime dtEntrada, DateTime dtSaida)
        {
            return BuscarUnidadesHabitacionais_Livres(dtEntrada, dtSaida);
        }

        internal static bool Remover(UnidadeHabitacionalEntity unidadeHabitacional)
        {
            return DeleteUnidadeHabitacional(unidadeHabitacional.ID);
        }

        internal static bool Salvar(UnidadeHabitacionalEntity unidadeHabitacional)
        {
            if (unidadeHabitacional.ID == null)
                return InsertUnidadeHabitacional(unidadeHabitacional);
            else
                return UpdateUnidadeHabitacional(unidadeHabitacional);
        }

        #endregion Internal Methods



        #region Private Methods

        private static UnidadeHabitacionalEntity BuscarUnidadeHabitacional(int id)
        {
            try
            {
                Table<UnidadeHabitacionalEntity> unidadesHabitacionais = Settings.dataContext.GetTable<UnidadeHabitacionalEntity>();
                Settings.dataContext.Refresh(RefreshMode.OverwriteCurrentValues, Settings.dataContext.GetTable<UnidadeHabitacionalEntity>());
                return unidadesHabitacionais.SingleOrDefault(u => u.ID == id);
            }
            catch
            { return null; }
        }

        private static List<UnidadeHabitacionalEntity> BuscarUnidadesHabitacionais()
        {
            try
            {
                var unidadesHabitacionaisList = new List<UnidadeHabitacionalEntity>();
                Table<UnidadeHabitacionalEntity> unidadesHabitacionais = Settings.dataContext.GetTable<UnidadeHabitacionalEntity>();
                Settings.dataContext.Refresh(RefreshMode.OverwriteCurrentValues, Settings.dataContext.GetTable<UnidadeHabitacionalEntity>());
                IEnumerable<UnidadeHabitacionalEntity> unidadesHabitacionaisQuery = from u in unidadesHabitacionais.ToList() where u.Flag != 'D' select u;
                unidadesHabitacionaisList.AddRange(unidadesHabitacionaisQuery);
                return unidadesHabitacionaisList;
            }
            catch
            { return null; }
        }

        private static List<UnidadeHabitacionalEntity> BuscarUnidadesHabitacionais_Livres(DateTime dtEntrada, DateTime dtSaida)
        {
            try
            {
                var unidadesHabitacionaisList = new List<UnidadeHabitacionalEntity>();
                List<UnidadeHabitacionalEntity> unidadesHabitacionais = BuscarUnidadesHabitacionais();
                List<ContaEntity> contas = ContaBusiness.GetContas();

                unidadesHabitacionaisList.AddRange(unidadesHabitacionais);

                foreach (UnidadeHabitacionalEntity u in unidadesHabitacionais)
                {
                    foreach (ContaEntity c in contas)
                    {
                        if (c.ID_Unidade_Habitacional != u.ID) continue;

                        if (!(dtSaida <= c.Entrada || dtEntrada >= c.Saida))
                            if (unidadesHabitacionaisList.Contains(u))
                                unidadesHabitacionaisList.Remove(u);
                    }
                }
                return unidadesHabitacionaisList;
            }
            catch
            { return null; }
        }

        private static bool DeleteUnidadeHabitacional(int? id)
        {
            if (id == null) return false;

            try
            {
                Table<UnidadeHabitacionalEntity> unidadesHabitacionais = Settings.dataContext.GetTable<UnidadeHabitacionalEntity>();
                UnidadeHabitacionalEntity unidadeHabitacionalDb = unidadesHabitacionais.SingleOrDefault(u => u.ID == id);
                unidadeHabitacionalDb.Flag = 'D';
                unidadeHabitacionalDb.Update = DateTime.Now;
                Settings.dataContext.SubmitChanges();
                return true;
            }
            catch
            { return false; }
        }

        private static bool InsertUnidadeHabitacional(UnidadeHabitacionalEntity unidadeHabitacional)
        {
            try
            {
                Table<UnidadeHabitacionalEntity> unidadesHabitacionais = Settings.dataContext.GetTable<UnidadeHabitacionalEntity>();
                unidadeHabitacional.ID = unidadesHabitacionais.Count() + 1;
                unidadeHabitacional.Flag = 'I';
                unidadeHabitacional.Update = DateTime.Now;
                unidadesHabitacionais.InsertOnSubmit(unidadeHabitacional);
                Settings.dataContext.SubmitChanges();
                return true;
            }
            catch
            { return false; }
        }

        private static bool UpdateUnidadeHabitacional(UnidadeHabitacionalEntity unidadeHabitacional)
        {
            try
            {
                Table<UnidadeHabitacionalEntity> unidadesHabitacionais = Settings.dataContext.GetTable<UnidadeHabitacionalEntity>();
                UnidadeHabitacionalEntity unidadeHabitacionalDb = unidadesHabitacionais.SingleOrDefault(u => u.ID == unidadeHabitacional.ID);
                unidadeHabitacionalDb = unidadeHabitacional;
                unidadeHabitacionalDb.Flag = 'U';
                unidadeHabitacionalDb.Update = DateTime.Now;
                Settings.dataContext.SubmitChanges();
                return true;
            }
            catch
            { return false; }
        }

        #endregion Private Methods
    }
}