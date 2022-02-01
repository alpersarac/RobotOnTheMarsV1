using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotOnTheMars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Mars MarsObject;
        int X;
        int Y;
        
        public void ShowCoordinates()
        {
            X_Lbl.Text = "X: " + (MarsObject.getX()+1);
            y_Lbl.Text = "Y: " + (MarsObject.getY()+1);
        }

        RectangleF rec;
        private void Form1_Load(object sender, EventArgs e)
        {
            Image img = pictureBox1.Image;
            img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Image = img;
            X = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["X"]);
            Y = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["Y"]);

            MarsObject = new Mars(X, Y);
            MarsObject.CreateTheMarsSurface();
            panel1.Refresh();
            ShowCoordinates();

        }
        public void DrawRobot()
        {
            
            
            rec = new Rectangle();
            rec.Width = 500/ X;
            rec.Height = 500/ X;
            using (Graphics g = panel1.CreateGraphics())
            {
               
               rec.X = MarsObject.getX() * 500/X;
               rec.Y = MarsObject.getY() * 500/Y;
                HatchBrush myHatchBrush =
                new HatchBrush(HatchStyle.Vertical, Color.Blue, Color.Green);
                g.FillRectangle(myHatchBrush, rec);
                
              
            }
            ShowCoordinates();
        }
        public void DrawMarsTerrain()
        {
            Rectangle rec = new Rectangle();
            rec.Width = 500/X;
            rec.Height = 500/Y;
            using (Graphics g = panel1.CreateGraphics())
            {
                for (int i = 0; i < MarsObject.getMarsMatrix().GetLength(0); i++)
                {
                    for (int w = 0; w < MarsObject.getMarsMatrix().GetLength(1); w++)
                    {
                        rec.X = i * 500/X;
                        rec.Y = w * 500/Y;

                        g.DrawRectangle(new Pen(Color.Red, 3), rec);
                    }
                }

            }
            DrawRobot();
        }
        private void btn_left_Click(object sender, EventArgs e)
        {
            MarsObject.Move(Mars.InputEnum.L);
            panel1.Refresh();

        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            MarsObject.Move(Mars.InputEnum.R);
            panel1.Refresh();

        }

        private void btn_frwd_Click(object sender, EventArgs e)
        {
            MarsObject.Move(Mars.InputEnum.F);
            panel1.Refresh();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DrawMarsTerrain();
            DrawRobot();
            
        }
    }
}
