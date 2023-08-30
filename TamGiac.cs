using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3
{
    class TamGiac
    {
        double ca, cb, cc;
        public double canha
        {
            get { return ca; }
            set { 
                if (ca > 0) 
                {
                    ca = value;
                }
            }
        }
        public double canhb
        {
            get { return cb; }
            set {
                if (cb > 0)
                {
                    cb = value;
                }
            }
        }

        public double canhc
        {
            get { return cc; }
            set {
                if (cc > 0)
                {
                    cc = value;
                }
            }
        }
        public TamGiac()
        {
            ca = 10;
            cb = 10;
            cc = 15;
        }
        public TamGiac(double ca, double cb, double cc)
        {
            if(ca < 0 || cb < 0|| cc < 0 || (ca + cb < cc) || (cb + cc < ca) || (ca + cc < cb))
            {
                ca = 0;
                cb = 0;
                cc = 0;
            }
            else
            {
                canha = ca;
                canhb = cb;
                canhc = cc;
            }
        }
        public double ChuVi()
        {
            return ca + cb + cc;
        }
        public double DienTich()
        {
            double p = ChuVi()/2;
            return Math.Sqrt(p* (p - ca) * (p - cb) * (p - cc));
        }
        public void XacDinhTG()
        {
            if((ca + cb < cc) || (cb + cc < ca) || (ca + cc < cb))
            {
                Console.WriteLine("Khong la tam giac");
            }
            else if((ca == cb) || (ca == cc) || (cb == cc))
            {
                Console.WriteLine("Tam giac can");
            }
            else if((ca == cb) && (ca == cc) && (cb == cc))
            {
                Console.WriteLine("Tam giac deu");
            }
            else
            {
                Console.WriteLine("Tam giac thuong");
            }
        }
        public void ToString()
        {
            Console.WriteLine("Chi so ba canh lan luot la: " + ca + " " + cb + " " + cc + "\n" + "Chu vi tam giac: " + ChuVi() + "\n" + "Dien tich tam giac: " + DienTich());
            XacDinhTG();
        }
    }
}
