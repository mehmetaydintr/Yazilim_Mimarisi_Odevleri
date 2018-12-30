using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MasterCard : IProduct
    {
        public string Isim { get; set; }
        public DateTime SonKullanmaTarihi { get; set; }
        private string kartNo;
        public string KartNo
        {
            get
            {
                return kartNo;
            }
            set
            {

            }
        }
        public MasterCard(string kartNo,string Isim)
        {
            this.Isim = Isim;
            this.kartNo = kartNo;
            this.SonKullanmaTarihi = DateTime.Now.AddYears(4);
        }
    }
}
