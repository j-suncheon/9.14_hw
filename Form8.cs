using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9._14_hw
{
    public partial class Form8 : Form
    {
        COneCycles c0C;
        public Form8()
        {
            InitializeComponent();
        }
    }
    public class CBase
    {
        public string strName;

        protected Pen pen;
        public CBase()
        {
            pen = new Pen(Color.Aqua);
        }
    }
    class COneCycles : CBase
    {
        public Rectangle rtCircle1;
        public Rectangle rtSquare1;
        public COneCycles(string sName)
        {
            strName = sName;
            rtCircle1 = new Rectangle(120, 150, 120, 120);
            rtSquare1 = new Rectangle(150, 30, 60, 120);
        }
        public virtual void fMove(int iMove)
        {
            fCircle1Move(iMove);
            fSquare1Move(iMove);
        }
        protected void fCircle1Move(int iMove)
        {
            Point oPoint = rtCircle1.Location;
            oPoint.X = oPoint.X+iMove;
            rtCircle1.Location = oPoint;
        }
        protected void fSquare1Move(int iMove)
        {
            Point oPoint = rtSquare1.Location;
            oPoint.X += iMove;
            rtSquare1.Location = oPoint;
        }
    }
   
}
