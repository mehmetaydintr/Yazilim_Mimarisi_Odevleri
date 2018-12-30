using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazılım_Mimarisi_Ödev2
{
    class DusmanRobotu : IDusmanRobotu
    {
        public void RobotIsim(string isim)
        {
            Console.WriteLine("Robot Adı : " + isim);
        }

        public void YumrukAt()
        {
            Console.WriteLine("Robot Yumruk Attı..!");
        }

        public void Yuru( )
        {
            Console.WriteLine("Robot Yürüdü..!");
        }
    }
}
