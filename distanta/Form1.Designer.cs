namespace distanta
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
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dotctrl2 = new distanta.dotctrl();
            this.dotctrl1 = new distanta.dotctrl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "0:0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dotctrl2
            // 
            this.dotctrl2.BackColor = System.Drawing.Color.Blue;
            this.dotctrl2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.dotctrl2.Location = new System.Drawing.Point(374, 312);
            this.dotctrl2.Name = "dotctrl2";
            this.dotctrl2.Size = new System.Drawing.Size(5, 5);
            this.dotctrl2.TabIndex = 1;
            // 
            // dotctrl1
            // 
            this.dotctrl1.BackColor = System.Drawing.Color.Red;
            this.dotctrl1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.dotctrl1.Location = new System.Drawing.Point(66, 60);
            this.dotctrl1.Name = "dotctrl1";
            this.dotctrl1.Size = new System.Drawing.Size(5, 5);
            this.dotctrl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(554, 454);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dotctrl2);
            this.Controls.Add(this.dotctrl1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.White;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dotctrl dotctrl1;
        private dotctrl dotctrl2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

