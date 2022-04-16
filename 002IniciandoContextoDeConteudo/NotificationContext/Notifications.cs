using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002IniciandoContextoDeConteudo.NotificationContext
{
    public sealed class Notifications
    {
        public string Property { get; set; }
        public string Message { get; set; }

        public Notifications()
        {
        }

        public Notifications(string property, string message)
        {
            Property = property;
            Message = message;
        }
    }
}
