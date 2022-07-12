using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    internal class Autor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Autor()
        {
            Ksiazki = new List<Ksiazka>();
        }
        public List<Ksiazka> Ksiazki { get; set; }
    }
}
