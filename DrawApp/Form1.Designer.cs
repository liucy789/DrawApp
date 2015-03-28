namespace DrawApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.triangle_radioBtn = new System.Windows.Forms.RadioButton();
            this.circle_radioBtn = new System.Windows.Forms.RadioButton();
            this.ellipse_radioBtn = new System.Windows.Forms.RadioButton();
            this.square_radioBtn = new System.Windows.Forms.RadioButton();
            this.rectangle_radioBtn = new System.Windows.Forms.RadioButton();
            this.line_radioBtn = new System.Windows.Forms.RadioButton();
            this.boxForDrawing = new System.Windows.Forms.PictureBox();
            this.colorPanel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.boxForDrawing)).BeginInit();
            this.SuspendLayout();
            // 
            // triangle_radioBtn
            // 
            this.triangle_radioBtn.AutoSize = true;
            this.triangle_radioBtn.BackColor = System.Drawing.Color.Transparent;
            this.triangle_radioBtn.Font = new System.Drawing.Font("DengXian", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.triangle_radioBtn.Location = new System.Drawing.Point(938, 6);
            this.triangle_radioBtn.Margin = new System.Windows.Forms.Padding(4);
            this.triangle_radioBtn.Name = "triangle_radioBtn";
            this.triangle_radioBtn.Size = new System.Drawing.Size(137, 38);
            this.triangle_radioBtn.TabIndex = 17;
            this.triangle_radioBtn.Text = "Triangle";
            this.triangle_radioBtn.UseVisualStyleBackColor = false;
            this.triangle_radioBtn.CheckedChanged += new System.EventHandler(this.triangle_radioBtn_CheckedChanged);
            // 
            // circle_radioBtn
            // 
            this.circle_radioBtn.AutoSize = true;
            this.circle_radioBtn.BackColor = System.Drawing.Color.Transparent;
            this.circle_radioBtn.Font = new System.Drawing.Font("DengXian", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circle_radioBtn.Location = new System.Drawing.Point(824, 6);
            this.circle_radioBtn.Margin = new System.Windows.Forms.Padding(4);
            this.circle_radioBtn.Name = "circle_radioBtn";
            this.circle_radioBtn.Size = new System.Drawing.Size(106, 38);
            this.circle_radioBtn.TabIndex = 16;
            this.circle_radioBtn.Text = "Circle";
            this.circle_radioBtn.UseVisualStyleBackColor = false;
            this.circle_radioBtn.CheckedChanged += new System.EventHandler(this.circle_radioBtn_CheckedChanged);
            // 
            // ellipse_radioBtn
            // 
            this.ellipse_radioBtn.AutoSize = true;
            this.ellipse_radioBtn.BackColor = System.Drawing.Color.Transparent;
            this.ellipse_radioBtn.Font = new System.Drawing.Font("DengXian", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ellipse_radioBtn.Location = new System.Drawing.Point(703, 6);
            this.ellipse_radioBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ellipse_radioBtn.Name = "ellipse_radioBtn";
            this.ellipse_radioBtn.Size = new System.Drawing.Size(113, 38);
            this.ellipse_radioBtn.TabIndex = 15;
            this.ellipse_radioBtn.Text = "Ellipse";
            this.ellipse_radioBtn.UseVisualStyleBackColor = false;
            this.ellipse_radioBtn.CheckedChanged += new System.EventHandler(this.ellipse_radioBtn_CheckedChanged);
            // 
            // square_radioBtn
            // 
            this.square_radioBtn.AutoSize = true;
            this.square_radioBtn.BackColor = System.Drawing.Color.Transparent;
            this.square_radioBtn.Font = new System.Drawing.Font("DengXian", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.square_radioBtn.Location = new System.Drawing.Point(571, 6);
            this.square_radioBtn.Margin = new System.Windows.Forms.Padding(4);
            this.square_radioBtn.Name = "square_radioBtn";
            this.square_radioBtn.Size = new System.Drawing.Size(124, 38);
            this.square_radioBtn.TabIndex = 14;
            this.square_radioBtn.Text = "Square";
            this.square_radioBtn.UseVisualStyleBackColor = false;
            this.square_radioBtn.CheckedChanged += new System.EventHandler(this.square_radioBtn_CheckedChanged);
            // 
            // rectangle_radioBtn
            // 
            this.rectangle_radioBtn.AutoSize = true;
            this.rectangle_radioBtn.BackColor = System.Drawing.Color.Transparent;
            this.rectangle_radioBtn.Checked = true;
            this.rectangle_radioBtn.Font = new System.Drawing.Font("DengXian", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rectangle_radioBtn.Location = new System.Drawing.Point(403, 6);
            this.rectangle_radioBtn.Margin = new System.Windows.Forms.Padding(4);
            this.rectangle_radioBtn.Name = "rectangle_radioBtn";
            this.rectangle_radioBtn.Size = new System.Drawing.Size(160, 38);
            this.rectangle_radioBtn.TabIndex = 13;
            this.rectangle_radioBtn.TabStop = true;
            this.rectangle_radioBtn.Text = "Rectangle";
            this.rectangle_radioBtn.UseVisualStyleBackColor = false;
            this.rectangle_radioBtn.CheckedChanged += new System.EventHandler(this.rectangle_radioBtn_CheckedChanged);
            // 
            // line_radioBtn
            // 
            this.line_radioBtn.AutoSize = true;
            this.line_radioBtn.BackColor = System.Drawing.Color.Transparent;
            this.line_radioBtn.Font = new System.Drawing.Font("DengXian", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line_radioBtn.Location = new System.Drawing.Point(308, 6);
            this.line_radioBtn.Margin = new System.Windows.Forms.Padding(4);
            this.line_radioBtn.Name = "line_radioBtn";
            this.line_radioBtn.Size = new System.Drawing.Size(87, 38);
            this.line_radioBtn.TabIndex = 12;
            this.line_radioBtn.Text = "Line";
            this.line_radioBtn.UseVisualStyleBackColor = false;
            this.line_radioBtn.CheckedChanged += new System.EventHandler(this.line_radioBtn_CheckedChanged);
            // 
            // boxForDrawing
            // 
            this.boxForDrawing.Image = ((System.Drawing.Image)(resources.GetObject("boxForDrawing.Image")));
            this.boxForDrawing.Location = new System.Drawing.Point(12, 48);
            this.boxForDrawing.Name = "boxForDrawing";
            this.boxForDrawing.Size = new System.Drawing.Size(1157, 629);
            this.boxForDrawing.TabIndex = 11;
            this.boxForDrawing.TabStop = false;
            this.boxForDrawing.Paint += new System.Windows.Forms.PaintEventHandler(this.boxForDrawing_Paint);
            this.boxForDrawing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.boxForDrawing_MouseMove);
            this.boxForDrawing.MouseUp += new System.Windows.Forms.MouseEventHandler(this.boxForDrawing_MouseUp);
            // 
            // colorPanel1
            // 
            this.colorPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.colorPanel1.Location = new System.Drawing.Point(0, 0);
            this.colorPanel1.Name = "colorPanel1";
            this.colorPanel1.Size = new System.Drawing.Size(301, 42);
            this.colorPanel1.TabIndex = 18;
            this.colorPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colorPanel1_MouseClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("DengXian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1082, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 36);
            this.button1.TabIndex = 19;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1181, 689);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.colorPanel1);
            this.Controls.Add(this.triangle_radioBtn);
            this.Controls.Add(this.circle_radioBtn);
            this.Controls.Add(this.ellipse_radioBtn);
            this.Controls.Add(this.square_radioBtn);
            this.Controls.Add(this.rectangle_radioBtn);
            this.Controls.Add(this.line_radioBtn);
            this.Controls.Add(this.boxForDrawing);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.boxForDrawing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton triangle_radioBtn;
        private System.Windows.Forms.RadioButton circle_radioBtn;
        private System.Windows.Forms.RadioButton ellipse_radioBtn;
        private System.Windows.Forms.RadioButton square_radioBtn;
        private System.Windows.Forms.RadioButton rectangle_radioBtn;
        private System.Windows.Forms.RadioButton line_radioBtn;
        private System.Windows.Forms.PictureBox boxForDrawing;
        private System.Windows.Forms.Panel colorPanel1;
        private System.Windows.Forms.Button button1;
    }
}

