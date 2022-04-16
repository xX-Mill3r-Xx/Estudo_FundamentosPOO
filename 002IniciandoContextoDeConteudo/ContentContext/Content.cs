using _002IniciandoContextoDeConteudo.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002IniciandoContextoDeConteudo.ContentContext
{
    public abstract class Content : Base
    {
        //SPOF
        #region Comentario
        /*O id sempre é gerado dentro do construtor desta classe,
         se algum dia precisar mudar a forma como o id é gerado, precisaremos mexer apenas aqui;*/
        #endregion

        
        public string Title { get; set; }
        public string Url { get; set; }

        public Content(string title, string url)
        {
            Title = title;
            Url = url;
        }
    }
}
