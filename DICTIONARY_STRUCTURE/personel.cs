using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICTIONARY_STRUCTURE
{
    internal class personel
    {
        public personel(string adı, string soyadı, int maas)
        {
            this.adı = adı;
            this.soyadı = soyadı;
            this.maas = maas;
        }

        public int sicil_no { get; set; }
        public string adı { get; set; }
        public string soyadı { get; set; }
        public int maas { get; set; }

        public override string? ToString()
        {
            return $"  {adı,-5} - {soyadı,-10} - {maas,-5}";  
        }
    }
}
