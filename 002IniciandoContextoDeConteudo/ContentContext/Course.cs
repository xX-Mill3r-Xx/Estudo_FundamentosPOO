using _002IniciandoContextoDeConteudo.ContentContext.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002IniciandoContextoDeConteudo.ContentContext
{
    public class Course : Content
    {
        public string Tag { get; set; }
        public IList<Module> Modules { get; set; }
        public double DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }

        public Course(string title, string url) : base(title, url)
        {
            //Sempre lembrar de iniciar os modulos;
            Modules = new List<Module>();
        }
    }

}
