using _002IniciandoContextoDeConteudo.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002IniciandoContextoDeConteudo.SubscriptionContext
{
    public class Plan : Base
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
    }
}
