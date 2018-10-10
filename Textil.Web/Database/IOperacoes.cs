using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Textil.Web.Models;

namespace Textil.Web.Database
{
    public interface IOperacoes <T>
    {
        void Adicionar(T model);

        void Remover(T model);

        void Editar(T model, T model2);

        T Consultar(T model);
    }
}