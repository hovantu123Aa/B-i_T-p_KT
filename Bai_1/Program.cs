using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1
{
    class Program
    {
        static void Main(string[] args)
        {
            HinhTron HTRON = new HinhTron();
            Console.Write("nhap ban kinh hinh tron:");
            double bankinh = double.Parse(Console.ReadLine());
            HTRON.setBanKinh(bankinh);
            Console.WriteLine(" dien tich:{0}  chu vi:{1}", HTRON.tinhdientich(), HTRON.tinhchuvi());


            HinhTru Htru = new HinhTru();
            Console.Write("nhap chieu cao hinh tru:");
            double chieucao = double.Parse(Console.ReadLine());
            Htru.setchieucao(chieucao);
            //Htru.setBanKinh(bankinh);
            Console.WriteLine(" thetich:{0} dientich:{1} chuvi:{2}", Htru.tinhthetich(),Htru.tinhdientich(),Htru.tinhchuvi());
            Console.ReadLine();
        }
    }
}
