using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002IniciandoContextoDeConteudo.ContentContext
{
    public class Carrer : Content
    {
        public IList<CarreirItem>Items { get; set; }
        public int TotalCourses => Items.Count; // Expression Body
        //Obs.:
        #region Maneira mais Complexa
        //public int TotalCourses 
        //{ 
        //    get
        //    {
        //        return Items.Count;
        //    } 
        //}
        #endregion

        public Carrer(string title, string ulr) : base(title, ulr)
        {
            Items = new List<CarreirItem>();
        }
    }
}
