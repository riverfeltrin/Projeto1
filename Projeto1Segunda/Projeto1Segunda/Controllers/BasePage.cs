using Projeto1Segunda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto1Segunda.Controllers
{
    public class BasePage : System.Web.UI.Page
    {
        protected static BancoProjetoContainer contexto = new BancoProjetoContainer();
    }
}