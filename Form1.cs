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
        int bmpWidth = 200;
        int bmpHeight = 200;
        List<Point> lpImg = new List<Point>();
        List<Point> lpWindow = new List<Point>();
        List<Point> lpResult = new List<Point>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClip_Click(object sender, EventArgs e)
        {
            Bitmap bmpClip = new Bitmap(bmpWidth, bmpHeight);
            if (comboAlgo.Text != "")
            {
                AlgorithmBuilder algo = new AlgorithmBuilder(comboAlgo.Text);
                algo.getAlgo().apply(bmpClip);
            }
        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            Bitmap bmpImg = new Bitmap(bmpWidth,bmpHeight);
            Graphics gImg = Graphics.FromImage(bmpImg);
            foreach (string str in txtImg.Lines) 
            {
                string[] linepoint = str.Split(',');
                Point p = new Point(Convert.ToInt32(linepoint[0]), Convert.ToInt32(linepoint[1]));
                lpImg.Add(p);
            }
            drawLine(gImg, lpImg);
            picImg.Image = bmpImg;
        }

        private void btnWindow_Click(object sender, EventArgs e)
        {
            Bitmap bmpWindow = new Bitmap(bmpWidth,bmpHeight);
            Graphics gWindow = Graphics.FromImage(bmpWindow);
            foreach (string str in txtWindow.Lines) 
            {
                string[] linepoint = str.Split(',');
                Point p = new Point(Convert.ToInt32(linepoint[0]), Convert.ToInt32(linepoint[1]));
                lpWindow.Add(p);
            }
            drawLine(gWindow, lpWindow);
            picWindow.Image = bmpWindow;
        }
        private void drawLine(Graphics g, List<Point> lp)
        {
            Pen blackPen = new Pen(Color.Black);
            foreach (Line l in getLinesFromPoints(lp))
            {
                g.DrawLine(blackPen, l.p1, l.p2);
            }
        }

        private List<Line> getLinesFromPoints(List<Point> lp)
        {
            List<Line> ll = new List<Line>();
            for (int i = 0; i < lp.Count; i++)
            {
                int nextI = (i == lp.Count - 1) ? 0 : i + 1;
                Line l = new Line(lp[i], lp[nextI]);
                ll.Add(l);
            }
            return ll;
        }
    }

    public class Line
    {
        public Point p1 { get; set; }
        public Point p2 { get; set; }
        public Line(Point p1, Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }
    }

    public class AlgorithmBuilder
    {
        Algorithm algo;
        public AlgorithmBuilder(string strAlgo)
        {
            if (strAlgo == "Weilerr-Atherton")
                algo = new WeilerrAtherton();
            else if (strAlgo == "Liang-Barsky")
                algo = new LiangBarsky();
        }
        public Algorithm getAlgo()
        {
            return algo;
        }
    
    }

    public interface Algorithm 
    {
        void apply(Bitmap bmp);   
    }

    public class WeilerrAtherton : Algorithm
    {
        public void apply(Bitmap bmp)
        {
            Console.WriteLine("WeilerrAtherton Algorithm");
        
        }
    }

    public class LiangBarsky: Algorithm
    {
        public void apply(Bitmap bmp)
        {
            Console.WriteLine("LiangBarsky Algorithm");
        }
    }
}
