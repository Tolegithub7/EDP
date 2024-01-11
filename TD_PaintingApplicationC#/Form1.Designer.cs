namespace TD_PaintingApplicationC_
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.color_picker = new System.Windows.Forms.PictureBox();
            this.button9 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button18 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.btn_color_click = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.color_picker);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 104);
            this.panel1.TabIndex = 0;
            // 
            // btn_save
            // 
            this.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_save.Location = new System.Drawing.Point(741, 12);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(80, 28);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_clear.Location = new System.Drawing.Point(741, 46);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(80, 28);
            this.btn_clear.TabIndex = 8;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // color_picker
            // 
            this.color_picker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color_picker.Image = global::TD_PaintingApplicationC_.Properties.Resources.color_palette;
            this.color_picker.Location = new System.Drawing.Point(3, 3);
            this.color_picker.Name = "color_picker";
            this.color_picker.Size = new System.Drawing.Size(175, 98);
            this.color_picker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.color_picker.TabIndex = 2;
            this.color_picker.TabStop = false;
            this.color_picker.Click += new System.EventHandler(this.color_picker_Click);
            this.color_picker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.color_picker_MouseClick);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(184, 32);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(44, 40);
            this.button9.TabIndex = 2;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.button18);
            this.panel3.Controls.Add(this.button11);
            this.panel3.Controls.Add(this.btn_color_click);
            this.panel3.Controls.Add(this.button16);
            this.panel3.Controls.Add(this.button12);
            this.panel3.Controls.Add(this.button15);
            this.panel3.Controls.Add(this.button13);
            this.panel3.Controls.Add(this.button14);
            this.panel3.Location = new System.Drawing.Point(234, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(501, 65);
            this.panel3.TabIndex = 2;
            // 
            // button18
            // 
            this.button18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button18.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button18.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.ForeColor = System.Drawing.Color.White;
            this.button18.Image = global::TD_PaintingApplicationC_.Properties.Resources.line;
            this.button18.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button18.Location = new System.Drawing.Point(437, 3);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(52, 57);
            this.button18.TabIndex = 7;
            this.button18.Text = "Line";
            this.button18.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button11
            // 
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Image = global::TD_PaintingApplicationC_.Properties.Resources.bucket;
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button11.Location = new System.Drawing.Point(75, 3);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(52, 57);
            this.button11.TabIndex = 1;
            this.button11.Text = "Fill";
            this.button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // btn_color_click
            // 
            this.btn_color_click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_color_click.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_color_click.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_color_click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_color_click.ForeColor = System.Drawing.Color.White;
            this.btn_color_click.Image = global::TD_PaintingApplicationC_.Properties.Resources.color;
            this.btn_color_click.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_color_click.Location = new System.Drawing.Point(17, 3);
            this.btn_color_click.Name = "btn_color_click";
            this.btn_color_click.Size = new System.Drawing.Size(52, 57);
            this.btn_color_click.TabIndex = 0;
            this.btn_color_click.Text = "Color";
            this.btn_color_click.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_color_click.UseVisualStyleBackColor = true;
            this.btn_color_click.Click += new System.EventHandler(this.btn_color_click_Click);
            // 
            // button16
            // 
            this.button16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.ForeColor = System.Drawing.Color.White;
            this.button16.Image = global::TD_PaintingApplicationC_.Properties.Resources.color;
            this.button16.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button16.Location = new System.Drawing.Point(379, 3);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(52, 57);
            this.button16.TabIndex = 6;
            this.button16.Text = "Color";
            this.button16.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Image = global::TD_PaintingApplicationC_.Properties.Resources.pencil;
            this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button12.Location = new System.Drawing.Point(133, 3);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(52, 57);
            this.button12.TabIndex = 2;
            this.button12.Text = "Pencil";
            this.button12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button15
            // 
            this.button15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.ForeColor = System.Drawing.Color.White;
            this.button15.Image = global::TD_PaintingApplicationC_.Properties.Resources.rectangle;
            this.button15.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button15.Location = new System.Drawing.Point(307, 3);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(66, 57);
            this.button15.TabIndex = 5;
            this.button15.Text = "Rectangle";
            this.button15.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button13
            // 
            this.button13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Image = global::TD_PaintingApplicationC_.Properties.Resources.eraser;
            this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button13.Location = new System.Drawing.Point(191, 3);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(52, 57);
            this.button13.TabIndex = 3;
            this.button13.Text = "Eraser";
            this.button13.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.btn_eraser_Click);
            // 
            // button14
            // 
            this.button14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Image = global::TD_PaintingApplicationC_.Properties.Resources.circle;
            this.button14.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button14.Location = new System.Drawing.Point(249, 3);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(52, 57);
            this.button14.TabIndex = 4;
            this.button14.Text = "Ellipse";
            this.button14.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 636);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 25);
            this.panel2.TabIndex = 1;
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(884, 661);
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Window Painting Application in C# Visual Studio By Tolosa Diriba";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btn_color_click;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.PictureBox color_picker;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_clear;
    }
}

