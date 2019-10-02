using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;



namespace ToanHinhHoc
{
    class HinhTron:HinhHoc
    {        
        protected HinhTron(float stDT,float stCV)
            : base(stDT, stCV)
        {

        }

        private float r;
        public float R
        {
            get { return r; }
            set { r = value; }
        }
        public HinhTron() { }
        public HinhTron(float stR)
        {           
            r = stR;             
        }

        public override void talk()
        {
            MessageBox.Show("Dien tich: "+(3.14*r*r)+"\nChu vi: "+(3.14*2*r));
            
        }
    }
}
