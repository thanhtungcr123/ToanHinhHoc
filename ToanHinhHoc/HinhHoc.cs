using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace ToanHinhHoc
{
    class HinhHoc
    {
        private float CV;
        private float DT;

        public float cv
        {
            get { return CV; }
            set { CV = value; }
        }        
        public float dt
        {
            get { return DT; }
            set { DT = value; }
        }
        public HinhHoc() { }
        public HinhHoc(float stDT,float stCV)
        {
            DT = stDT;
            CV = stCV;
        }
        public virtual void talk()
        {
                      
        }
    }
}
