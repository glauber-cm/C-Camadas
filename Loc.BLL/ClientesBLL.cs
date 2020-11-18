using Loc.DAL;
using Loc.DTO;
using System;

namespace Loc.BLL
{
   public class ClientesBLL
    {
        public void InserirCliente(Clientes cli)
        {
            try
            {
                new ClientesDAL().Salvar(cli);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
