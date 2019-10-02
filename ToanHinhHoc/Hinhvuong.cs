using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ToanHinhHoc
{
    class Hinhvuong:HinhChuNhat
    {
        protected Hinhvuong(float stDT, float stCV)
            : base(stDT, stCV)
        {

        }
        private string a;
        public string A
        {
            get { return a; }
            set { a = value; }
        }
        public Hinhvuong() { }
        public Hinhvuong(double stA)
        {
            
        }
        public override void talk()
        {
            MessageBox.Show("Dien tich: " + (3*3)+"\nChu vi: "+(3*4));
        }
    }
}
