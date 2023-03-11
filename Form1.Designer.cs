
namespace Mandelbrot_Set
{
    partial class Fractal_Viewer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fractal_Viewer));
            this.Image = new System.Windows.Forms.PictureBox();
            this.XYReader = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.ZoomReader = new System.Windows.Forms.Label();
            this.ColorInside = new System.Windows.Forms.CheckBox();
            this.Fractal = new System.Windows.Forms.ComboBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.HSV_coloring = new System.Windows.Forms.CheckBox();
            this.ColorOffset = new System.Windows.Forms.TextBox();
            this.DwellTime = new System.Windows.Forms.NumericUpDown();
            this.QualityLabel = new System.Windows.Forms.Label();
            this.RenderTime = new System.Windows.Forms.Label();
            this.ThreadsLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LocatorButton = new System.Windows.Forms.Button();
            this.Transforms = new System.Windows.Forms.GroupBox();
            this.InputZoom = new System.Windows.Forms.TextBox();
            this.inputZlabel = new System.Windows.Forms.Label();
            this.InputY = new System.Windows.Forms.TextBox();
            this.inputYlabel = new System.Windows.Forms.Label();
            this.InputX = new System.Windows.Forms.TextBox();
            this.inputXlabel = new System.Windows.Forms.Label();
            this.WaitLabel = new System.Windows.Forms.Label();
            this.HighQualityRender = new System.Windows.Forms.CheckBox();
            this.FourKRender = new System.Windows.Forms.CheckBox();
            this.Detail_inside = new System.Windows.Forms.CheckBox();
            this.FractalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DwellTime)).BeginInit();
            this.Transforms.SuspendLayout();
            this.SuspendLayout();
            // 
            // Image
            // 
            this.Image.Location = new System.Drawing.Point(0, 0);
            this.Image.Margin = new System.Windows.Forms.Padding(0);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(760, 760);
            this.Image.TabIndex = 0;
            this.Image.TabStop = false;
            this.Image.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.Image.MouseEnter += new System.EventHandler(this.Image_MouseEnter);
            this.Image.MouseLeave += new System.EventHandler(this.Image_MouseLeave);
            // 
            // XYReader
            // 
            this.XYReader.AutoSize = true;
            this.XYReader.BackColor = System.Drawing.SystemColors.ControlDark;
            this.XYReader.Location = new System.Drawing.Point(0, 0);
            this.XYReader.Name = "XYReader";
            this.XYReader.Size = new System.Drawing.Size(30, 15);
            this.XYReader.TabIndex = 1;
            this.XYReader.Text = "X | Y";
            // 
            // Label
            // 
            this.Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label.AutoSize = true;
            this.Label.BackColor = System.Drawing.Color.Black;
            this.Label.ForeColor = System.Drawing.Color.White;
            this.Label.Location = new System.Drawing.Point(479, 0);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(270, 30);
            this.Label.TabIndex = 2;
            this.Label.Text = "Click on the part of the set you wish to zoom into \r\nand right click to zoom out";
            // 
            // ZoomReader
            // 
            this.ZoomReader.AutoSize = true;
            this.ZoomReader.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ZoomReader.Location = new System.Drawing.Point(262, 0);
            this.ZoomReader.Name = "ZoomReader";
            this.ZoomReader.Size = new System.Drawing.Size(39, 15);
            this.ZoomReader.TabIndex = 3;
            this.ZoomReader.Text = "Zoom";
            // 
            // ColorInside
            // 
            this.ColorInside.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorInside.AutoSize = true;
            this.ColorInside.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ColorInside.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ColorInside.Location = new System.Drawing.Point(649, 33);
            this.ColorInside.Name = "ColorInside";
            this.ColorInside.Size = new System.Drawing.Size(94, 19);
            this.ColorInside.TabIndex = 4;
            this.ColorInside.Text = "Color Inside?";
            this.ColorInside.UseVisualStyleBackColor = false;
            this.ColorInside.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Fractal
            // 
            this.Fractal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Fractal.FormattingEnabled = true;
            this.Fractal.Items.AddRange(new object[] {
            "Mandelbrot Set",
            "Perpendicular Mandelbrot Set",
            "Celtic Mandelbrot",
            "Perpendicular Celtic Mandelbrot",
            "Burning Ship Fractal",
            "Perpendicular Burning Ship",
            "Buffalo Fractal",
            "Perpendicular Buffalo",
            "Mandelship Fractal",
            "Perpendicular  Mandelship",
            "Airship Fractal",
            "Bull Fractal",
            "Crown Fractal",
            "Doubble Sector Fractal",
            "Arrowhead Fractal",
            "Blob Fractal"});
            this.Fractal.Location = new System.Drawing.Point(477, 33);
            this.Fractal.Name = "Fractal";
            this.Fractal.Size = new System.Drawing.Size(167, 23);
            this.Fractal.TabIndex = 5;
            this.Fractal.SelectedIndexChanged += new System.EventHandler(this.Fractal_SelectedIndexChanged);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(180, 18);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(121, 23);
            this.ResetButton.TabIndex = 6;
            this.ResetButton.Text = "Reset Position";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // HSV_coloring
            // 
            this.HSV_coloring.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HSV_coloring.AutoSize = true;
            this.HSV_coloring.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HSV_coloring.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.HSV_coloring.Location = new System.Drawing.Point(649, 71);
            this.HSV_coloring.Name = "HSV_coloring";
            this.HSV_coloring.Size = new System.Drawing.Size(100, 19);
            this.HSV_coloring.TabIndex = 7;
            this.HSV_coloring.Text = "HSV coloring?";
            this.HSV_coloring.UseVisualStyleBackColor = false;
            this.HSV_coloring.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // ColorOffset
            // 
            this.ColorOffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorOffset.Location = new System.Drawing.Point(649, 97);
            this.ColorOffset.Name = "ColorOffset";
            this.ColorOffset.Size = new System.Drawing.Size(100, 23);
            this.ColorOffset.TabIndex = 8;
            this.ColorOffset.TextChanged += new System.EventHandler(this.ColorOffset_TextChanged);
            // 
            // DwellTime
            // 
            this.DwellTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DwellTime.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.DwellTime.Location = new System.Drawing.Point(636, 732);
            this.DwellTime.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.DwellTime.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.DwellTime.Name = "DwellTime";
            this.DwellTime.Size = new System.Drawing.Size(120, 23);
            this.DwellTime.TabIndex = 9;
            this.DwellTime.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.DwellTime.ValueChanged += new System.EventHandler(this.DwellTime_ValueChanged);
            // 
            // QualityLabel
            // 
            this.QualityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.QualityLabel.AutoSize = true;
            this.QualityLabel.BackColor = System.Drawing.Color.Black;
            this.QualityLabel.ForeColor = System.Drawing.Color.White;
            this.QualityLabel.Location = new System.Drawing.Point(582, 734);
            this.QualityLabel.Name = "QualityLabel";
            this.QualityLabel.Size = new System.Drawing.Size(48, 15);
            this.QualityLabel.TabIndex = 10;
            this.QualityLabel.Text = "Quality:";
            // 
            // RenderTime
            // 
            this.RenderTime.AutoSize = true;
            this.RenderTime.BackColor = System.Drawing.SystemColors.ControlDark;
            this.RenderTime.Location = new System.Drawing.Point(0, 18);
            this.RenderTime.Name = "RenderTime";
            this.RenderTime.Size = new System.Drawing.Size(79, 15);
            this.RenderTime.TabIndex = 11;
            this.RenderTime.Text = "Render Time: ";
            // 
            // ThreadsLabel
            // 
            this.ThreadsLabel.AutoSize = true;
            this.ThreadsLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ThreadsLabel.Location = new System.Drawing.Point(0, 36);
            this.ThreadsLabel.Name = "ThreadsLabel";
            this.ThreadsLabel.Size = new System.Drawing.Size(54, 15);
            this.ThreadsLabel.TabIndex = 12;
            this.ThreadsLabel.Text = "Threads: ";
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(646, 678);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(103, 23);
            this.SaveButton.TabIndex = 13;
            this.SaveButton.Text = "Save as picture";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_click);
            // 
            // LocatorButton
            // 
            this.LocatorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LocatorButton.Location = new System.Drawing.Point(12, 730);
            this.LocatorButton.Name = "LocatorButton";
            this.LocatorButton.Size = new System.Drawing.Size(112, 23);
            this.LocatorButton.TabIndex = 14;
            this.LocatorButton.Text = "Manualy Move";
            this.LocatorButton.UseVisualStyleBackColor = true;
            this.LocatorButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Transforms
            // 
            this.Transforms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Transforms.BackColor = System.Drawing.SystemColors.Control;
            this.Transforms.Controls.Add(this.InputZoom);
            this.Transforms.Controls.Add(this.inputZlabel);
            this.Transforms.Controls.Add(this.InputY);
            this.Transforms.Controls.Add(this.inputYlabel);
            this.Transforms.Controls.Add(this.InputX);
            this.Transforms.Controls.Add(this.inputXlabel);
            this.Transforms.Location = new System.Drawing.Point(12, 574);
            this.Transforms.Name = "Transforms";
            this.Transforms.Size = new System.Drawing.Size(112, 150);
            this.Transforms.TabIndex = 15;
            this.Transforms.TabStop = false;
            // 
            // InputZoom
            // 
            this.InputZoom.Location = new System.Drawing.Point(6, 117);
            this.InputZoom.Name = "InputZoom";
            this.InputZoom.Size = new System.Drawing.Size(100, 23);
            this.InputZoom.TabIndex = 5;
            this.InputZoom.TextChanged += new System.EventHandler(this.InputZoom_TextChanged);
            // 
            // inputZlabel
            // 
            this.inputZlabel.AutoSize = true;
            this.inputZlabel.Location = new System.Drawing.Point(6, 99);
            this.inputZlabel.Name = "inputZlabel";
            this.inputZlabel.Size = new System.Drawing.Size(42, 15);
            this.inputZlabel.TabIndex = 4;
            this.inputZlabel.Text = "Zoom:";
            // 
            // InputY
            // 
            this.InputY.Location = new System.Drawing.Point(6, 73);
            this.InputY.Name = "InputY";
            this.InputY.Size = new System.Drawing.Size(100, 23);
            this.InputY.TabIndex = 3;
            this.InputY.TextChanged += new System.EventHandler(this.InputY_TextChanged);
            // 
            // inputYlabel
            // 
            this.inputYlabel.AutoSize = true;
            this.inputYlabel.Location = new System.Drawing.Point(6, 55);
            this.inputYlabel.Name = "inputYlabel";
            this.inputYlabel.Size = new System.Drawing.Size(17, 15);
            this.inputYlabel.TabIndex = 2;
            this.inputYlabel.Text = "Y:";
            // 
            // InputX
            // 
            this.InputX.Location = new System.Drawing.Point(6, 29);
            this.InputX.Name = "InputX";
            this.InputX.Size = new System.Drawing.Size(100, 23);
            this.InputX.TabIndex = 1;
            this.InputX.TextChanged += new System.EventHandler(this.InputX_TextChanged);
            // 
            // inputXlabel
            // 
            this.inputXlabel.AutoSize = true;
            this.inputXlabel.Location = new System.Drawing.Point(6, 10);
            this.inputXlabel.Name = "inputXlabel";
            this.inputXlabel.Size = new System.Drawing.Size(17, 15);
            this.inputXlabel.TabIndex = 0;
            this.inputXlabel.Text = "X:";
            // 
            // WaitLabel
            // 
            this.WaitLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WaitLabel.Font = new System.Drawing.Font("Consolas", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WaitLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.WaitLabel.Location = new System.Drawing.Point(13, 303);
            this.WaitLabel.Name = "WaitLabel";
            this.WaitLabel.Size = new System.Drawing.Size(10, 10);
            this.WaitLabel.TabIndex = 16;
            this.WaitLabel.Text = "Please wait...\r\nImmage Rendering";
            // 
            // HighQualityRender
            // 
            this.HighQualityRender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.HighQualityRender.AutoSize = true;
            this.HighQualityRender.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HighQualityRender.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.HighQualityRender.Location = new System.Drawing.Point(572, 707);
            this.HighQualityRender.Name = "HighQualityRender";
            this.HighQualityRender.Size = new System.Drawing.Size(179, 19);
            this.HighQualityRender.TabIndex = 17;
            this.HighQualityRender.Text = "Higher saved picture quality?";
            this.HighQualityRender.UseVisualStyleBackColor = false;
            // 
            // FourKRender
            // 
            this.FourKRender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FourKRender.AutoSize = true;
            this.FourKRender.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FourKRender.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FourKRender.Location = new System.Drawing.Point(559, 681);
            this.FourKRender.Name = "FourKRender";
            this.FourKRender.Size = new System.Drawing.Size(83, 19);
            this.FourKRender.TabIndex = 18;
            this.FourKRender.Text = "Save in 4k?";
            this.FourKRender.UseVisualStyleBackColor = false;
            // 
            // Detail_inside
            // 
            this.Detail_inside.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Detail_inside.AutoSize = true;
            this.Detail_inside.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Detail_inside.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Detail_inside.Location = new System.Drawing.Point(649, 52);
            this.Detail_inside.Name = "Detail_inside";
            this.Detail_inside.Size = new System.Drawing.Size(95, 19);
            this.Detail_inside.TabIndex = 19;
            this.Detail_inside.Text = "Detail Inside?";
            this.Detail_inside.UseVisualStyleBackColor = false;
            this.Detail_inside.CheckedChanged += new System.EventHandler(this.Detail_inside_CheckedChanged);
            // 
            // FractalLabel
            // 
            this.FractalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FractalLabel.AutoSize = true;
            this.FractalLabel.BackColor = System.Drawing.Color.Black;
            this.FractalLabel.ForeColor = System.Drawing.Color.White;
            this.FractalLabel.Location = new System.Drawing.Point(430, 36);
            this.FractalLabel.Name = "FractalLabel";
            this.FractalLabel.Size = new System.Drawing.Size(45, 15);
            this.FractalLabel.TabIndex = 20;
            this.FractalLabel.Text = "Fractal:";
            // 
            // Fractal_Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 756);
            this.Controls.Add(this.FractalLabel);
            this.Controls.Add(this.Detail_inside);
            this.Controls.Add(this.FourKRender);
            this.Controls.Add(this.HighQualityRender);
            this.Controls.Add(this.WaitLabel);
            this.Controls.Add(this.Transforms);
            this.Controls.Add(this.LocatorButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ThreadsLabel);
            this.Controls.Add(this.RenderTime);
            this.Controls.Add(this.QualityLabel);
            this.Controls.Add(this.DwellTime);
            this.Controls.Add(this.ColorOffset);
            this.Controls.Add(this.HSV_coloring);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.Fractal);
            this.Controls.Add(this.ColorInside);
            this.Controls.Add(this.ZoomReader);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.XYReader);
            this.Controls.Add(this.Image);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fractal_Viewer";
            this.Text = "Fractal Viewer";
            this.SizeChanged += new System.EventHandler(this.Fractal_Viewer_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DwellTime)).EndInit();
            this.Transforms.ResumeLayout(false);
            this.Transforms.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Image;
        private System.Windows.Forms.Label XYReader;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label ZoomReader;
        private System.Windows.Forms.CheckBox ColorInside;
        private System.Windows.Forms.ComboBox Fractal;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.CheckBox HSV_coloring;
        private System.Windows.Forms.TextBox ColorOffset;
        private System.Windows.Forms.NumericUpDown DwellTime;
        private System.Windows.Forms.Label QualityLabel;
        private System.Windows.Forms.Label RenderTime;
        private System.Windows.Forms.Label ThreadsLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LocatorButton;
        private System.Windows.Forms.GroupBox Transforms;
        private System.Windows.Forms.TextBox InputZoom;
        private System.Windows.Forms.Label inputZlabel;
        private System.Windows.Forms.TextBox InputY;
        private System.Windows.Forms.Label inputYlabel;
        private System.Windows.Forms.TextBox InputX;
        private System.Windows.Forms.Label inputXlabel;
        private System.Windows.Forms.Label WaitLabel;
        private System.Windows.Forms.CheckBox HighQualityRender;
        private System.Windows.Forms.CheckBox FourKRender;
        private System.Windows.Forms.CheckBox Detail_inside;
        private System.Windows.Forms.Label FractalLabel;
    }
}

