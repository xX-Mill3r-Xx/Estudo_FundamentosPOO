using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002IniciandoContextoDeConteudo.NotificationContext
{
    public abstract class Notifiable
    {
        public List<Notifications> Notifications { get; set; }
        public bool IsInvalid => Notifications.Any();

        protected Notifiable()
        {
            Notifications = new List<Notifications>();
        }

        public void AddNotification(Notifications notifications)
        {
            Notifications.Add(notifications);
        }

        public void AddNotifications(IEnumerable<Notifications> notifications)
        {
            Notifications.AddRange(notifications);
        }
    }
}
