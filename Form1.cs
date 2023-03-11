using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mandelbrot_Set
{
    public partial class Fractal_Viewer : Form
    {
        private static object _sync = new object();

        public Fractal_Viewer()
        {
            InitializeComponent();
            //SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            ColorOffset.Visible = false;
            Transforms.Visible = false;
            inputXlabel.Visible = false;
            inputYlabel.Visible = false;
            inputZlabel.Visible = false;
            InputZoom.Visible = false;
            InputX.Visible = false;
            inputYlabel.Visible = false;
            WaitLabel.AutoSize = true;
            WaitLabel.Visible = false;
            Detail_inside.Visible = false;

            Fractal.SelectedIndex = 0;
            ThreadsLabel.Text = ThreadsLabel.Text + Environment.ProcessorCount;

            generate();

           // System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
        }

        long zoom = 1;
        double Xoffset = 0;
        double Yoffset = 0;
        int Quality = 100;
        int FractalIndex = 0;
        string path = @".\";
        bool save = false;
        int s;
        private void generate()
        {
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            Stopwatch Time = new Stopwatch();
            Time.Start();
            int ColorChange = 0;
            try
            { ColorChange = Convert.ToInt32(ColorOffset.Text); }
            catch { }
            XYReader.Text = (Xoffset + " | " + Yoffset);
            ZoomReader.Text = "Zoom: " + zoom.ToString();
            {
                Bitmap Im = new Bitmap(Image.Width, Image.Height);

                ParallelOptions options = new ParallelOptions();
                options.MaxDegreeOfParallelism = Environment.ProcessorCount;
                //for (int x = 0; x < Image.Width; x++)
                Parallel.For(0, Image.Width, options, x =>
                {
                    for (int y = 0; y < Image.Height; y++)
                    {
                        double r = (double)(((x - (Image.Width / 2)) / (Image.Width / 4.0)) / zoom);
                        double i = (double)(((y - (Image.Height / 2)) / (Image.Height / 4.0)) / zoom);
                        r += Xoffset - 0.5;
                        i += Yoffset;
                        ComplexNumbers c = new ComplexNumbers(r, i);
                        ComplexNumbers z = new ComplexNumbers(0, 0);
                        {
                            
                            int iteration = (int)Equation(z, c);
                            double color = iteration;
                            if (!HSV_coloring.Checked)
                            {
                                    this.SmartSetPixel(Im, x, y, Color.FromArgb(0, (int)(iteration * (255.0 / Quality))%255, 0));
                            }
                            else
                            {
                                if (color == 0)
                                {
                                    this.SmartSetPixel(Im, x, y,Color.Black);
                                }
                                else
                                {
                                    color--;
                                    color = ((255 * color) / Quality) + ColorChange;
                                    color = color % 255;
                                    //Im.SetPixel(x, y, HSVtoColor((float)color, 1, 1));
                                    this.SmartSetPixel(Im, x, y, HSVtoColor((float)color, 1, 1));
                                }
                            }
                        }
                    }
                });
                if (save == true)
                {
                    Im.Save(path, System.Drawing.Imaging.ImageFormat.Png);
                }
                Image.Image = Im;
                Time.Stop();
            }
            RenderTime.Text = "Render Time: " + Time.Elapsed;
            this.Cursor = System.Windows.Forms.Cursors.Cross;
        }

        private void SmartSetPixel(Bitmap bm, int x, int y, Color color)
        {
            lock(_sync)
            {
                bm.SetPixel(x, y, color);
            }
        }
     
        private double Equation(ComplexNumbers z, ComplexNumbers c)
        {
            double it = 0;

            switch (FractalIndex)
            {
                case 0:
                    {
                        //iteration = 0;
                        do
                        {
                            it++;
                            z.square();
                            z.add(c);
                            if (z.MagnatuideGreaterThan(2)) break;
                        }
                        while (it < Quality);
                    }
                    break;
                case 1:
                    {
                        //iteration = 0;
                        do
                        {
                            it++;
                            z.r = Math.Abs(z.r);
                            z.ne_square();
                            z.add(c);
                            if (z.MagnatuideGreaterThan(2)) break;
                        }
                        while (it < Quality);
                    }
                    break;
                case 2:
                    {
                        //iteration = 0;
                        do
                        {
                            it++;
                            z.square(); 
                            z.r = Math.Abs(z.r);
                            z.add(c);
                            if (z.MagnatuideGreaterThan(2)) break;
                        }
                        while (it < Quality);
                    }
                    break;
                case 3:
                    {
                        //iteration = 0;
                        do
                        {
                            it++;
                            z.in_ne_square();
                            z.r = Math.Abs(z.r);
                            z.add(c);
                            if (z.MagnatuideGreaterThan(2)) break;
                        }
                        while (it < Quality);
                    }
                    break;
                case 4:
                    {
                        //iteration = 0;
                        do
                        {
                            it++;
                            z.abs();
                            z.square();
                            z.add(c);
                            if (z.MagnatuideGreaterThan(2)) break;
                        }
                        while (it < Quality);
                    }
                    break;
                case 5:
                    {
                        //iteration = 0;
                        do
                        {
                            it++;
                            z.i = Math.Abs(z.i);
                            z.ne_square();
                            z.add(c);
                            if (z.MagnatuideGreaterThan(2)) break;
                        }
                        while (it < Quality);
                    }
                    break;
                case 6:
                    {
                        //iteration = 0;
                        do
                        {
                            it++;
                            z.in_square();
                            z.r = Math.Abs(z.r);
                            z.add(c);
                            if (z.MagnatuideGreaterThan(2)) break;
                        }
                        while (it < Quality);
                    }
                    break;
                case 7:
                    {
                        //iteration = 0;
                        do
                        {
                            it++;
                            z.ne_in_square();
                            z.r = Math.Abs(z.r);
                            z.add(c);
                            if (z.MagnatuideGreaterThan(2)) break;
                        }
                        while (it < Quality);
                    }
                    break;
                case 8:
                    {
                        //iteration = 0;
                        do
                        {
                            it++;
                            z.square();
                            z.add(c);
                            z.abs();
                            z.square();
                            z.add(c);
                            if (z.MagnatuideGreaterThan(2)) break;
                        }
                        while (it < Quality);
                    }
                    break;
                case 9:
                    {
                        //iteration = 0;
                        do
                        {
                            it++;
                            z.abs();
                            z.square();
                            z.add(c);
                            z.square();
                            z.add(c);
                            if (z.MagnatuideGreaterThan(2)) break;
                        }
                        while (it < Quality);
                    }
                    break;
                case 10:
                    {
                        //iteration = 0;
                        c.i *= -1;
                        do
                        {
                            it++;
                            z.i_square();
                            z.add(c);
                            if (z.MagnatuideGreaterThan(2)) break;
                        }
                        while (it < Quality);
                    }
                    break;
                case 11:
                    {
                        //iteration = 0;
                        c.i *= -1;
                        do
                        {
                            it++;
                            z.in_pos_square();
                            z.r = Math.Abs(z.r);
                            z.add(c);
                            if (z.MagnatuideGreaterThan(2)) break;
                        }
                        while (it < Quality);
                    }
                    break;
                case 12:
                    {
                        //iteration = 0;
                        do
                        {
                            it++;
                            z.in_r_square();
                            z.r = Math.Abs(z.r);
                            z.add(c);
                            if (z.MagnatuideGreaterThan(2)) break;
                        }
                        while (it < Quality);
                    }
                    break;
                case 13:
                    {
                        //iteration = 0;
                        do
                        {
                            it++;
                            z.in_1r_square();
                            z.r = Math.Abs(z.r);
                            z.add(c);
                            if (z.MagnatuideGreaterThan(2)) break;
                        }
                        while (it < Quality);
                    }
                    break;
                case 14:
                    {
                        //iteration = 0;
                        do
                        {
                            it++;
                            z.pos_1r_square();
                            z.r = Math.Abs(z.r);
                            z.add(c);
                            if (z.MagnatuideGreaterThan(2)) break;
                        }
                        while (it < Quality);
                    }
                    break;
                case 15:
                    {
                        c.r = c.r + 0.5;
                        //iteration = 0;
                        do
                        {
                            it++;
                            z.s_r_i_square();
                            z.add(c);
                            if (z.MagnatuideGreaterThan(2)) break;
                        }
                        while (it < Quality);
                    }
                    break;
            }
            if (!ColorInside.Checked)
            {
                if (it == Quality)
                {
                        it = 0;
                }
            }
            else
            {
                if (it == Quality & Detail_inside.Checked)
                {
                    it = Math.Sqrt(Math.Pow((c.r - z.r), 2) + Math.Pow((c.i - z.i), 2)) * ((Quality - 1) / 4);
                    it++;
                }
            }
            return it;
        }

        public Color HSVtoColor(float H, float S, float V)
        {
            float R = 0; float G = 0; float B = 0;
            float C = V * S;
            float X = C * (1 - Math.Abs(((H / 60) % 2) - 1));
            float M = V - C;
            if(H < 360)
            {
                R = C;
                G = 0;
                B = X;
            }
            if(H < 300)
            {
                R = X;
                G = 0;
                B = C;
            }
            if (H < 180)
            {
                R = 0;
                G = X;
                B = C;
            }
            if (H < 120)
            {
                R = X;
                G = C;
                B = 0;
            }
            if (H < 60)
            {
                R = C;
                G = X;
                B = 0;
            }
            R += M;
            G += M;
            B += M;
            R *= 255;
            G *= 255;
            B *= 255;
            R = Math.Abs(R);
            G = Math.Abs(G);
            B = Math.Abs(B);
            return (Color.FromArgb((int)(R), (int)(G), (int)(B)));
        }
        //private void Zoomin()
        //{
        //    var relativePoint = this.PointToClient(Cursor.Position);

        //    double X = (double)(relativePoint.X - pictureBox1.Width / 2.0) / pictureBox1.Width * 4.0;
        //    double Y = (double)(relativePoint.Y - pictureBox1.Height / 2.0) / pictureBox1.Width * 4.0;
        //    label1.Text = (double)((X * -1)) + " | " + (double)((Y * -1));
        //    int zoom = 1;
        //    for (int c = 0; c < 20; c++)
        //    {
        //        zoom += 2;
        //        generate((double)((X * -1.0)) + 0.4, (double)((Y * -1.0)), zoom);
        //        ();
        //        label3.Text = zoom.ToString();
        //    }
        //    generate(0.4, 0, 1);
        //}

        private void Zoomin(MouseEventArgs e)
        {
            var relativePoint = this.PointToClient(Cursor.Position);

            double X = (double)((relativePoint.X - Image.Width / 2.0) / Image.Width * 4.0);
            double Y = (double)((relativePoint.Y - Image.Height / 2.0) / Image.Width * 4.0);
            if (e.Button != MouseButtons.Middle)
            {
                if (e.Button == MouseButtons.Left)
                { zoom *= 2; }
                if (e.Button == MouseButtons.Right & zoom - 1 != 0)
                { zoom /= 2; }
            }
            X /= zoom;
            Y /= zoom;
            Yoffset += Y;
            Xoffset += X;
            generate();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            generate();
            if(ColorInside.Checked)
            {
                Detail_inside.Visible = true;
            }
            else
            {
                Detail_inside.Visible = false;
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Zoomin(e);
        }
            
        private void Fractal_SelectedIndexChanged(object sender, EventArgs e)
        {
            zoom = 1;
            Xoffset = 0;
            Yoffset = 0;
            FractalIndex = Fractal.SelectedIndex;
            generate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zoom = 1;
            Xoffset = 0;
            Yoffset = 0;
            generate();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(HSV_coloring.Checked == true)
            {
                ColorOffset.Text = "120";
                ColorOffset.Visible = true;
            }
            else
            {
                ColorOffset.Visible = false;
            }
            generate();
        }

        private void ColorOffset_TextChanged(object sender, EventArgs e)
        {
            generate();
        }

        private void DwellTime_ValueChanged(object sender, EventArgs e)
        {
            Quality = (int)DwellTime.Value;
            generate();
        }

        private void PowerMorph_ValueChanged(object sender, EventArgs e)
        {
            generate();
        }

        private void Image_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void Image_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Cross;
        }

        private void SaveButton_click(object sender, EventArgs e)
        {
            string t = string.Empty;
            save = true;
            int H = Image.Height;
            int W = Image.Width;
            WaitLabel.Location = new Point((Image.Width - WaitLabel.Size.Width)/2, (Image.Height - WaitLabel.Size.Height) / 2);

            if (HighQualityRender.Checked)
            { Quality = (int)(Quality * 2); }

            if (FourKRender.Checked)
            {
                Image.Height = 4096;
                Image.Width = 4096;
            }
            else
            {
                Image.Height = 1024;
                Image.Width = 1024;
            }

            SaveFileDialog ofd = new SaveFileDialog();
            ofd.InitialDirectory = path;
            ofd.FileName = "fractal.png";
            DialogResult result = ofd.ShowDialog();
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            if (result == DialogResult.OK)
            {
                WaitLabel.Visible = true;
                path = ofd.FileName;
                generate();
                t = RenderTime.Text;
            }

            save = false;

            if (HighQualityRender.Checked)
            { Quality = (int)(Quality / 2); }

            Image.Height = H;
            Image.Width = W;

            generate();
            RenderTime.Text = t;
            WaitLabel.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(Transforms.Visible == true)
            {
                Transforms.Visible = false;
                inputXlabel.Visible = false;
                inputYlabel.Visible = false;
                inputZlabel.Visible = false;
                InputZoom.Visible = false;
                InputX.Visible = false;
                inputYlabel.Visible = false;
            }
            else
            {
                InputZoom.Text = string.Empty;
                InputX.Text = string.Empty;
                InputY.Text = string.Empty;
                Transforms.Visible = true;
                inputXlabel.Visible = true;
                inputYlabel.Visible = true;
                inputZlabel.Visible = true;
                InputZoom.Visible = true;
                InputX.Visible = true;
                inputYlabel.Visible = true;
            }
        }

        private void InputX_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Xoffset = Convert.ToDouble(InputX.Text);
            }
            catch { }
            generate();
        }

        private void InputY_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Yoffset = Convert.ToDouble(InputY.Text);
            }
            catch { }
            generate();
        }

        private void InputZoom_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt64(InputZoom.Text) >= 1)
                {
                    zoom = Convert.ToInt64(InputZoom.Text);
                }
            }
            catch { }
            generate();
        }

        private void Fractal_Viewer_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Minimized)
            {
                Image.Height = this.Height;
                Image.Width = this.Height;
                this.Size = new Size(this.Height - 30, this.Height);
                if (s != this.Size.Height)
                { generate(); }
                s = this.Size.Height;
                FormBorderStyle = FormBorderStyle.Sizable;
            }
        }

        private void Detail_inside_CheckedChanged(object sender, EventArgs e)
        {
            generate();
        }
    }
}
