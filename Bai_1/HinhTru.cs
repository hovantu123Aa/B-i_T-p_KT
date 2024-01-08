using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1
{
    class HinhTru:HinhTron
    {
        private double chieucao;
        public HinhTru():base()
        {
            chieucao = 1.0;
        }
        public HinhTru(double bankinh,double chieucao) : base(bankinh) 
        {
            setchieucao(chieucao);
        }
        public void setchieucao(double chieucao)
        {
            this.chieucao = Math.Abs(chieucao);
        }
        public double getchieucao()
        {
            return chieucao;
        }
       
        public new double tinhdientich()
        {
            return 2*base.tinhdientich()+tinhchuvi()*chieucao;
        }
        public double tinhthetich()
        {
            return base.tinhdientich() * chieucao;
        }

    }
}
