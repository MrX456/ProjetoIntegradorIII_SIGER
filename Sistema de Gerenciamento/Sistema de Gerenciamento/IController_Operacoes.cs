using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sistema_de_Gerenciamento
{
    interface IController_Operacoes
    {
        bool Validar(string nome, string login, string senha);
    }
}
