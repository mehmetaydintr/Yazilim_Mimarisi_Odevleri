using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Banka
    {
        public enum enProduct
        {
            enMasterCard,
            enVisa,
            enAmericanExpress
        }
        private string kartNo = "";
        private string Isim = "";
        private ulong countMaster = 10000000000000;
        private ulong countVisa1 = 100000000000000;
        private ulong countVisa2 = 100000000000;
        private ulong countAmerican = 1000000000000;
        
        private string kartNoUret(enProduct kartTipi)
        {
            Random random = new Random();
            int x;
            switch(kartTipi)
            {
                case enProduct.enMasterCard:
                    countMaster++;
                    x = random.Next(1, 5);
                    return "5" + x.ToString() + countMaster.ToString();
                case enProduct.enVisa:
                    x = random.Next(1, 2);
                    if(x==1)
                    {
                        countVisa1++;
                        return "4" + countVisa1.ToString();
                    }
                    else
                    {
                        countVisa2++;
                        return "4" + countVisa2.ToString();
                    }
                case enProduct.enAmericanExpress:
                    countAmerican++;
                    x = random.Next(1, 2);
                    if(x==1)
                    {
                        return "3" + "4" + countAmerican.ToString();
                    }
                    else
                    {
                        return "3" + "7" + countAmerican.ToString();
                    }
                default:
                    return "";
            }
        }
        public IProduct KartiAl(enProduct kartTipi, string Isim)
        {
            this.Isim=Isim;
            kartNo = kartNoUret(kartTipi);
            switch(kartTipi)
            {
                case enProduct.enMasterCard:
                    return new MasterCard(kartNo, Isim);
                case enProduct.enVisa:
                    return new Visa(kartNo, Isim);
                case enProduct.enAmericanExpress:
                    return new AmericanExpress(kartNo, Isim);
                default:
                    return null;
            }
        }
    }
}
