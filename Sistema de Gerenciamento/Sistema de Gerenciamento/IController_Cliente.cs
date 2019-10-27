using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Tools;

namespace Sistema_de_Gerenciamento
{
    public interface IController_Cliente
    {
        DataTable GetCliente(string nomeLike);
    }
}
