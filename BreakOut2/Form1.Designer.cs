namespace BreakOut2
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
            this.components = new System.ComponentModel.Container();
            this.ball = new System.Windows.Forms.Panel();
            this.timercursorder = new System.Windows.Forms.Timer(this.components);
            this.timercursorizq = new System.Windows.Forms.Timer(this.components);
            this.timercursor = new System.Windows.Forms.Timer(this.components);
            this.timerball = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timerrevive = new System.Windows.Forms.Timer(this.components);
            this.bloque3 = new System.Windows.Forms.PictureBox();
            this.bloque2 = new System.Windows.Forms.PictureBox();
            this.bloque1 = new System.Windows.Forms.PictureBox();
            this.cursor = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bloque3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloque2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloque1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursor)).BeginInit();
            this.SuspendLayout();
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Red;
            this.ball.Location = new System.Drawing.Point(258, 175);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(14, 15);
            this.ball.TabIndex = 1;
            this.ball.Tag = "3";
            // 
            // timercursorder
            // 
            this.timercursorder.Interval = 1;
            this.timercursorder.Tick += new System.EventHandler(this.timercursorder_Tick);
            // 
            // timercursorizq
            // 
            this.timercursorizq.Interval = 1;
            this.timercursorizq.Tick += new System.EventHandler(this.timercursorizq_Tick);
            // 
            // timercursor
            // 
            this.timercursor.Enabled = true;
            this.timercursor.Interval = 1;
            this.timercursor.Tick += new System.EventHandler(this.timercursor_Tick);
            // 
            // timerball
            // 
            this.timerball.Interval = 10;
            this.timerball.Tick += new System.EventHandler(this.timerball_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 30);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(397, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "SCORE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(11, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "VIDA";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(1, 391);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(558, 34);
            this.panel2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(145, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 26);
            this.label6.TabIndex = 1;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "REVIVIENDO";
            // 
            // timerrevive
            // 
            this.timerrevive.Interval = 1000;
            this.timerrevive.Tick += new System.EventHandler(this.timerrevive_Tick);
            // 
            // bloque3
            // 
            this.bloque3.Image = global::BreakOut2.Properties.Resources.bloque;
            this.bloque3.Location = new System.Drawing.Point(423, 74);
            this.bloque3.Name = "bloque3";
            this.bloque3.Size = new System.Drawing.Size(55, 54);
            this.bloque3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bloque3.TabIndex = 6;
            this.bloque3.TabStop = false;
            // 
            // bloque2
            // 
            this.bloque2.Image = global::BreakOut2.Properties.Resources.bloque;
            this.bloque2.Location = new System.Drawing.Point(240, 74);
            this.bloque2.Name = "bloque2";
            this.bloque2.Size = new System.Drawing.Size(55, 54);
            this.bloque2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bloque2.TabIndex = 5;
            this.bloque2.TabStop = false;
            // 
            // bloque1
            // 
            this.bloque1.Image = global::BreakOut2.Properties.Resources.bloque;
            this.bloque1.Location = new System.Drawing.Point(73, 74);
            this.bloque1.Name = "bloque1";
            this.bloque1.Size = new System.Drawing.Size(55, 54);
            this.bloque1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bloque1.TabIndex = 4;
            this.bloque1.TabStop = false;
            // 
            // cursor
            // 
            this.cursor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cursor.Image = global::BreakOut2.Properties.Resources.barra4;
            this.cursor.Location = new System.Drawing.Point(210, 316);
            this.cursor.Name = "cursor";
            this.cursor.Size = new System.Drawing.Size(85, 22);
            this.cursor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cursor.TabIndex = 0;
            this.cursor.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(559, 425);
            this.Controls.Add(this.bloque3);
            this.Controls.Add(this.bloque2);
            this.Controls.Add(this.bloque1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.cursor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bloque3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloque2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloque1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cursor;
        private System.Windows.Forms.Panel ball;
        private System.Windows.Forms.Timer timercursorder;
        private System.Windows.Forms.Timer timercursorizq;
        private System.Windows.Forms.Timer timercursor;
        private System.Windows.Forms.Timer timerball;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox bloque1;
        private System.Windows.Forms.PictureBox bloque2;
        private System.Windows.Forms.PictureBox bloque3;
        private System.Windows.Forms.Timer timerrevive;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

