using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHANSO
{
    public class phanso
    {
        private int iTuSo, iMauSo;
        public int TuSo {
            get { return iTuSo; }
            set { iTuSo = value; }
        }
        public int MauSo{
            get { return iMauSo;}
            set
            {
                if (value == 0)
                    iMauSo = 1;
                else
                    iMauSo = value;
            }
        }
        public phanso()
        {
            iTuSo = 0;
            iMauSo = 1;
        }
        public phanso(int paraTuSo, int paraMauSo)
        {
            TuSo = paraTuSo;
            MauSo = paraMauSo;
        }
        private int USCLN(int a, int b)
        {
            while(a != b){
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }
        public void ToiGian()
        {
            int LiUSCLN = USCLN(iTuSo, iMauSo);
            iTuSo = iTuSo / LiUSCLN;
            iMauSo = iMauSo / LiUSCLN;
        }
        public static phanso Cong(phanso a, phanso b)
        {
            phanso c = new phanso();
            c.iTuSo = (a.iTuSo * b.iMauSo) + (b.iTuSo * a.iMauSo);
            c.iMauSo = a.iMauSo * b.iMauSo;
            c.ToiGian();
            return c;
        }
        public static phanso Tru(phanso a, phanso b)
        {
            phanso c = new phanso();
            c.iTuSo = a.iTuSo * b.iMauSo - b.iTuSo * a.iMauSo;
            c.iMauSo = a.iMauSo * b.iMauSo;
            c.ToiGian();
            return c;
        }
        public static phanso Nhan(phanso a, phanso b)
        {
            phanso c = new phanso();
            c.iTuSo = a.iTuSo * b.iTuSo;
            c.iMauSo = a.iMauSo * b.iMauSo;
            c.ToiGian();
            return c;
        }
        public static phanso Chia(phanso a, phanso b)
        {
            phanso c = new phanso();
            c.iTuSo = a.iTuSo * b.iMauSo;
            c.iMauSo = a.iMauSo * b.iTuSo;
            c.ToiGian();
            return c;
        }
    }
}
