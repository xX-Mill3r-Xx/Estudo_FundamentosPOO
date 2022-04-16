using _002IniciandoContextoDeConteudo.NotificationContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002IniciandoContextoDeConteudo.SharedContext
{
    public abstract class Base : Notifiable
    {
        public Guid Id { get; set; }

        public Base()
        {
            Id = new Guid();
        }
    }
}
