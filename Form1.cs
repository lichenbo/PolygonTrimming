using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolygonTrimming
{
    public partial class Form1 : Form
    {
        Bitmap bmpImg;
        Bitmap bmpWindow;
        Bitmap bmpResult;
        List<Point> lpImg;
        List<Point> lpWindow;
        List<Point> lpResult;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClip_Click(object sender, EventArgs e)
        {

        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            foreach (string str in txtImg.Lines) 
            {
                string[] linepoint = str.Split(',');
                Point p = new Point(Convert.ToInt32(linepoint[0]), Convert.ToInt32(linepoint[1]));
                lpImg.Add(p);
            }
        }

        private void btnWindow_Click(object sender, EventArgs e)
        {
            foreach (string str in txtWindow.Lines) 
            {
                string[] linepoint = str.Split(',');
                Point p = new Point(Convert.ToInt32(linepoint[0]), Convert.ToInt32(linepoint[1]));
                lpWindow.Add(p);
            }

        }

    }
}
