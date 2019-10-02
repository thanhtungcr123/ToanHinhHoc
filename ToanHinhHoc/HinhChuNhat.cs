using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ToanHinhHoc
{
    class HinhChuNhat:HinhHoc
    {
        protected HinhChuNhat(float stDT,float stCV)
            : base(stDT, stCV)
        {
           
        }       
        private float cd;
        private float cr;
        public float CD
        {
            get { return cd; }
            set { cd = value; }
        }
        public float CR
        {
            get { return cr; }
            set { cr = value; }
        }
        public HinhChuNhat() { }    
        public HinhChuNhat(int stCD, int stCR) 
        {
            CD = stCD;
            CR = stCR;
        }
        public override void talk()
        {
            MessageBox.Show("Chu vi: " + ((cd + cr) * 2)+"\nDien tich: "+(cd*cr));
            
        }
    }
}
