using Poseidon.Base;
using Poseidon.Entity;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;

namespace Poseidon.Business
{
    public class ClienteBusiness
    {
        #region Internal Methods

        internal static ClienteEntity GetCliente(int id)
        {
            return BuscarCliente(id);
        }

        internal static List<ClienteEntity> GetClientes()
        {
            return BuscarClientes();
        }

        internal static bool Remover(ClienteEntity cliente)
        {
            return DeleteCliente(cliente.ID);
        }

        internal static bool Salvar(ClienteEntity cliente)
        {
            if (cliente.ID == null)
                return InsertCliente(cliente);
            else
                return UpdateCliente(cliente);
        }

        #endregion Internal Methods

        #region Private Methods

        private static ClienteEntity BuscarCliente(int id)
        {
            try
            {
                Table<ClienteEntity> clientes = Settings.dataContext.GetTable<ClienteEntity>();
                Settings.dataContext.Refresh(RefreshMode.OverwriteCurrentValues, Settings.dataContext.GetTable<ClienteEntity>());
                return clientes.SingleOrDefault(c => c.ID == id);
            }
            catch
            { return null; }
        }

        private static List<ClienteEntity> BuscarClientes()
        {
            try
            {
                var clientesList = new List<ClienteEntity>();
                Table<ClienteEntity> clientes = Settings.dataContext.GetTable<ClienteEntity>();
                Settings.dataContext.Refresh(RefreshMode.OverwriteCurrentValues, Settings.dataContext.GetTable<ClienteEntity>());
                IEnumerable<ClienteEntity> clientesQuery = from c in clientes.ToList() where c.Flag != 'D' select c;
                clientesList.AddRange(clientesQuery);
                return clientesList;
            }
            catch
            { return null; }
        }

        private static bool DeleteCliente(int? id)
        {
            if (id == null) return false;

            try
            {
                Table<ClienteEntity> clientes = Settings.dataContext.GetTable<ClienteEntity>();
                ClienteEntity clienteDb = clientes.SingleOrDefault(c => c.ID == id);
                clienteDb.Flag = 'D';
                clienteDb.Update = DateTime.Now;
                Settings.dataContext.SubmitChanges();
                return true;
            }
            catch
            { return false; }
        }

        private static bool InsertCliente(ClienteEntity cliente)
        {
            try
            {
                Table<ClienteEntity> clientes = Settings.dataContext.GetTable<ClienteEntity>();
                cliente.ID = clientes.Count() + 1;
                cliente.Flag = 'I';
                cliente.Update = DateTime.Now;
                clientes.InsertOnSubmit(cliente);
                Settings.dataContext.SubmitChanges();
                Settings.Cliente = cliente;
                return true;
            }
            catch
            { return false; }
        }

        private static bool UpdateCliente(ClienteEntity cliente)
        {
            try
            {
                Table<ClienteEntity> clientes = Settings.dataContext.GetTable<ClienteEntity>();
                ClienteEntity clienteDb = clientes.SingleOrDefault(c => c.ID == cliente.ID);
                clienteDb = cliente;
                clienteDb.Flag = 'U';
                clienteDb.Update = DateTime.Now;
                Settings.dataContext.SubmitChanges();
                Settings.Cliente = clienteDb;
                return true;
            }
            catch
            { return false; }
        }

        #endregion Private Methods
    }
}