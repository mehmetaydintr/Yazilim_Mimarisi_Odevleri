using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IProduct
    {
        string Isim { get; set; }
        string KartNo { get; set; }
        DateTime SonKullanmaTarihi { get; set; }
    }
}
