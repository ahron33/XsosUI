namespace Xsos
{
    partial class OptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.mainpnl = new System.Windows.Forms.Panel();
            this.xsospic = new System.Windows.Forms.PictureBox();
            this.minbtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.closebtn = new System.Windows.Forms.Button();
            this.mainlbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkedit = new System.Windows.Forms.CheckBox();
            this.mainpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xsospic)).BeginInit();
            this.SuspendLayout();
            // 
            // mainpnl
            // 
            this.mainpnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.mainpnl.Controls.Add(this.xsospic);
            this.mainpnl.Controls.Add(this.minbtn);
            this.mainpnl.Controls.Add(this.panel3);
            this.mainpnl.Controls.Add(this.closebtn);
            this.mainpnl.Controls.Add(this.mainlbl);
            this.mainpnl.Controls.Add(this.panel2);
            this.mainpnl.Location = new System.Drawing.Point(0, 0);
            this.mainpnl.Name = "mainpnl";
            this.mainpnl.Size = new System.Drawing.Size(170, 19);
            this.mainpnl.TabIndex = 53;
            this.mainpnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainpnl_MouseDown);
            // 
            // xsospic
            // 
            this.xsospic.Image = ((System.Drawing.Image)(resources.GetObject("xsospic.Image")));
            this.xsospic.Location = new System.Drawing.Point(2, 1);
            this.xsospic.Name = "xsospic";
            this.xsospic.Size = new System.Drawing.Size(16, 16);
            this.xsospic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.xsospic.TabIndex = 30;
            this.xsospic.TabStop = false;
            this.xsospic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.xsospic_MouseDown);
            // 
            // minbtn
            // 
            this.minbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.minbtn.CausesValidation = false;
            this.minbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.minbtn.FlatAppearance.BorderSize = 0;
            this.minbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minbtn.Font = new System.Drawing.Font("Unispace", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minbtn.ForeColor = System.Drawing.Color.White;
            this.minbtn.Location = new System.Drawing.Point(105, 0);
            this.minbtn.Name = "minbtn";
            this.minbtn.Size = new System.Drawing.Size(30, 19);
            this.minbtn.TabIndex = 8;
            this.minbtn.TabStop = false;
            this.minbtn.Text = "-";
            this.minbtn.UseVisualStyleBackColor = false;
            this.minbtn.Click += new System.EventHandler(this.minbtn_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(763, 292);
            this.panel3.TabIndex = 3;
            // 
            // closebtn
            // 
            this.closebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.closebtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.closebtn.FlatAppearance.BorderSize = 0;
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.Font = new System.Drawing.Font("Unispace", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebtn.ForeColor = System.Drawing.Color.White;
            this.closebtn.Location = new System.Drawing.Point(138, 0);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(30, 19);
            this.closebtn.TabIndex = 7;
            this.closebtn.TabStop = false;
            this.closebtn.Text = "X";
            this.closebtn.UseVisualStyleBackColor = false;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // mainlbl
            // 
            this.mainlbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mainlbl.AutoSize = true;
            this.mainlbl.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainlbl.ForeColor = System.Drawing.Color.DarkGray;
            this.mainlbl.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.mainlbl.Location = new System.Drawing.Point(21, 3);
            this.mainlbl.Name = "mainlbl";
            this.mainlbl.Size = new System.Drawing.Size(34, 13);
            this.mainlbl.TabIndex = 29;
            this.mainlbl.Text = "Xsos";
            this.mainlbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainlbl_MouseDown);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 292);
            this.panel2.TabIndex = 16;
            // 
            // checkedit
            // 
            this.checkedit.AutoSize = true;
            this.checkedit.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedit.ForeColor = System.Drawing.Color.White;
            this.checkedit.Location = new System.Drawing.Point(6, 29);
            this.checkedit.Name = "checkedit";
            this.checkedit.Size = new System.Drawing.Size(83, 21);
            this.checkedit.TabIndex = 55;
            this.checkedit.Text = "Anti-Virus";
            this.checkedit.UseVisualStyleBackColor = true;
            this.checkedit.CheckedChanged += new System.EventHandler(this.checkedit_CheckedChanged_1);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(168, 190);
            this.Controls.Add(this.checkedit);
            this.Controls.Add(this.mainpnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OptionsForm";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OptionsForm_FormClosing);
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.mainpnl.ResumeLayout(false);
            this.mainpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xsospic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainpnl;
        private System.Windows.Forms.PictureBox xsospic;
        private System.Windows.Forms.Button minbtn;
        private System.Windows.Forms.Label mainlbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkedit;
    }
}