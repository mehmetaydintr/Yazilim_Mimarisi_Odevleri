using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazılım_Mimarisi_Ödev2
{
    public class DusmanTank : IDusman
    {
        SavasAdapter savasAdapter;
        public void DusmanAdi(string Ad)
        {
            if (Ad == "Tank")
            {
                Console.WriteLine("Tank Adı : " + Ad);
            }
            else if(Ad=="Robot")
            {
                savasAdapter = new SavasAdapter();
                savasAdapter.DusmanAdi(Ad);
            }
            else
            {
                Console.WriteLine("");
            }
        }

        public void Hizlan(string Ad)
        {
            if (Ad == "Tank")
            {
                Console.WriteLine("Tank Hızlandı..!");
            }
            else if (Ad == "Robot")
            {
                savasAdapter = new SavasAdapter();
                savasAdapter.Hizlan(Ad);
            }
            else
            {
                Console.WriteLine("");
            }
        }

        public void SilahKullan(string Ad)
        {
            
            if (Ad == "Tank")
            {
                Console.WriteLine("Tankın Silahı Kullanılıyor..!");
            }
            else if (Ad == "Robot")
            {
                savasAdapter = new SavasAdapter();
                savasAdapter.SilahKullan(Ad);
            }
            else
            {
                Console.WriteLine("");
            }
        }
    }
}
