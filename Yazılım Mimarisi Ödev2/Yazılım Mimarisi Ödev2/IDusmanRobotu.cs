using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazılım_Mimarisi_Ödev2
{
    public interface IDusmanRobotu
    {
        void RobotIsim(string isim);

        void YumrukAt();
        void Yuru();
    }
}
