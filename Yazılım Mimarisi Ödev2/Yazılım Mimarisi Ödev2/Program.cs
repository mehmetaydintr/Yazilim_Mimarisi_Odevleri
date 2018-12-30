using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazılım_Mimarisi_Ödev2
{
    class Program
    {
        static void Main(string[] args)
        {
            DusmanTank dusmanTank = new DusmanTank();
            dusmanTank.DusmanAdi("Tank");
            dusmanTank.SilahKullan("Tank");
            dusmanTank.Hizlan("Tank");
            Console.WriteLine();
            dusmanTank.DusmanAdi("Robot");
            dusmanTank.SilahKullan("Robot");
            dusmanTank.Hizlan("Robot");

            Console.ReadLine();
        }
    }
}
