using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazılım_Mimarisi_Ödev2
{
    public class SavasAdapter : IDusman
    {
        IDusmanRobotu dusmanrobotu = new DusmanRobotu();
        

        public void DusmanAdi(string ad)
        {
            dusmanrobotu.RobotIsim(ad);
        }

        public void Hizlan(string ad)
        {
            dusmanrobotu.Yuru();
        }

        public void SilahKullan(string ad)
        {
            dusmanrobotu.YumrukAt();
        }
    }
}
