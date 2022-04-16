using _002IniciandoContextoDeConteudo.NotificationContext;
using _002IniciandoContextoDeConteudo.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002IniciandoContextoDeConteudo.ContentContext
{
    public class CarreirItem : Base
    {
        public int Order { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }

        public CarreirItem(int order, string title, string description, Course course)
        {
            if(course == null)
            {
                AddNotification(new Notifications("Course","Curso invalido"));
            }
            Order = order;
            Title = title;
            Description = description;
            Course = course;
        }
    }
}
