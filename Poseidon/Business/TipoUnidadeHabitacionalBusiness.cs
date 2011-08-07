using Poseidon.Base;
using Poseidon.Entity;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;

namespace Poseidon.Business
{
    public class TipoUnidadeHabitacionalBusiness
    {
        #region Internal Methods

        internal static List<TipoUnidadeHabitacionalEntity> GetTiposUnidadesHabitacionais()
        {
            return BuscarTiposUnidadesHabitacionais();
        }

        internal static TipoUnidadeHabitacionalEntity GetTipoUnidadeHabitacional(int id)
        {
            return BuscarTipoUnidadeHabitacional(id);
        }

        internal static bool Remover(TipoUnidadeHabitacionalEntity tipoUnidadeHabitacional)
        {
            return DeleteTipoUnidadeHabitacional(tipoUnidadeHabitacional.ID);
        }

        internal static bool Salvar(TipoUnidadeHabitacionalEntity tipoUnidadeHabitacional)
        {
            if (tipoUnidadeHabitacional.ID == null)
                return InsertTipoUnidadeHabitacional(tipoUnidadeHabitacional);
            else
                return UpdateTipoUnidadeHabitacional(tipoUnidadeHabitacional);
        }

        #endregion Internal Methods

        #region Private Methods

        private static List<TipoUnidadeHabitacionalEntity> BuscarTiposUnidadesHabitacionais()
        {
            try
            {
                var tiposUnidadesHabitacionaisList = new List<TipoUnidadeHabitacionalEntity>();
                Table<TipoUnidadeHabitacionalEntity> tiposUnidadesHabitacionais = Settings.dataContext.GetTable<TipoUnidadeHabitacionalEntity>();
                Settings.dataContext.Refresh(RefreshMode.OverwriteCurrentValues, Settings.dataContext.GetTable<TipoUnidadeHabitacionalEntity>());
                IEnumerable<TipoUnidadeHabitacionalEntity> tiposUnidadesHabitacionaisQuery = from tu in tiposUnidadesHabitacionais.ToList() where tu.Flag != 'D' select tu;
                tiposUnidadesHabitacionaisList.AddRange(tiposUnidadesHabitacionaisQuery);
                return tiposUnidadesHabitacionaisList;
            }
            catch
            { return null; }
        }

        private static TipoUnidadeHabitacionalEntity BuscarTipoUnidadeHabitacional(int id)
        {
            try
            {
                Table<TipoUnidadeHabitacionalEntity> tiposUnidadesHabitacionais = Settings.dataContext.GetTable<TipoUnidadeHabitacionalEntity>();
                Settings.dataContext.Refresh(RefreshMode.OverwriteCurrentValues, Settings.dataContext.GetTable<TipoUnidadeHabitacionalEntity>());
                return tiposUnidadesHabitacionais.SingleOrDefault(tu => tu.ID == id);
            }
            catch
            { return null; }
        }

        private static bool DeleteTipoUnidadeHabitacional(int? id)
        {
            if (id == null) return false;

            try
            {
                Table<TipoUnidadeHabitacionalEntity> tiposUnidadesHabitacionais = Settings.dataContext.GetTable<TipoUnidadeHabitacionalEntity>();
                TipoUnidadeHabitacionalEntity tipoUnidadeHabitacionalDb = tiposUnidadesHabitacionais.SingleOrDefault(tu => tu.ID == id);
                tipoUnidadeHabitacionalDb.Flag = 'D';
                tipoUnidadeHabitacionalDb.Update = DateTime.Now;
                Settings.dataContext.SubmitChanges();
                return true;
            }
            catch
            { return false; }
        }

        private static bool InsertTipoUnidadeHabitacional(TipoUnidadeHabitacionalEntity tipoUnidadeHabitacional)
        {
            try
            {
                Table<TipoUnidadeHabitacionalEntity> tiposUnidadesHabitacionais = Settings.dataContext.GetTable<TipoUnidadeHabitacionalEntity>();
                tipoUnidadeHabitacional.ID = tiposUnidadesHabitacionais.Count() + 1;
                tipoUnidadeHabitacional.Flag = 'I';
                tipoUnidadeHabitacional.Update = DateTime.Now;
                tiposUnidadesHabitacionais.InsertOnSubmit(tipoUnidadeHabitacional);
                Settings.dataContext.SubmitChanges();
                return true;
            }
            catch
            { return false; }
        }

        private static bool UpdateTipoUnidadeHabitacional(TipoUnidadeHabitacionalEntity tipoUnidadeHabitacional)
        {
            try
            {
                Table<TipoUnidadeHabitacionalEntity> tiposUnidadesHabitacionais = Settings.dataContext.GetTable<TipoUnidadeHabitacionalEntity>();
                TipoUnidadeHabitacionalEntity tipoUnidadeHabitacionalDb = tiposUnidadesHabitacionais.SingleOrDefault(tu => tu.ID == tipoUnidadeHabitacional.ID);
                tipoUnidadeHabitacionalDb = tipoUnidadeHabitacional;
                tipoUnidadeHabitacionalDb.Flag = 'U';
                tipoUnidadeHabitacionalDb.Update = DateTime.Now;
                Settings.dataContext.SubmitChanges();
                return true;
            }
            catch
            { return false; }
        }

        #endregion Private Methods
    }
}