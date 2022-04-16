using _002IniciandoContextoDeConteudo.ContentContext.Enums;
using _002IniciandoContextoDeConteudo.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002IniciandoContextoDeConteudo.ContentContext
{
    public class Lecture : Base
    {
        public int Order { get; set; }
        public string Title { get; set; }
        public double DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}
