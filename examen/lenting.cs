using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    class lenting
    {


     
            public lenting(string id, string movie)
            {
                set(id,movie);
            }

            public string Id { set; get; }
        
            public string Movie { set; get; }

        public void set(string id, string movie)
            {
                Id = id;
                    
                 Movie = Movie;
             
            }
        
    }
}
