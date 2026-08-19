namespace Xsos
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainpnl = new System.Windows.Forms.Panel();
            this.xsospic = new System.Windows.Forms.PictureBox();
            this.minbtn = new System.Windows.Forms.Button();
            this.mainlbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.closebtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtbox = new ScintillaNET.Scintilla();
            this.exebtn = new System.Windows.Forms.Button();
            this.clrbtn = new System.Windows.Forms.Button();
            this.opnbtn = new System.Windows.Forms.Button();
            this.hookbtn = new System.Windows.Forms.Button();
            this.optionsbtn = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.mainpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xsospic)).BeginInit();
            this.SuspendLayout();
            // 
            // mainpnl
            // 
            this.mainpnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.mainpnl.Controls.Add(this.xsospic);
            this.mainpnl.Controls.Add(this.minbtn);
            this.mainpnl.Controls.Add(this.mainlbl);
            this.mainpnl.Controls.Add(this.panel3);
            this.mainpnl.Controls.Add(this.closebtn);
            this.mainpnl.Controls.Add(this.panel2);
            this.mainpnl.Location = new System.Drawing.Point(0, 0);
            this.mainpnl.Name = "mainpnl";
            this.mainpnl.Size = new System.Drawing.Size(301, 19);
            this.mainpnl.TabIndex = 52;
            this.mainpnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainpnl_MouseDown);
            this.mainpnl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainpnl_MouseMove);
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
            this.xsospic.Click += new System.EventHandler(this.xsospic_Click);
            this.xsospic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.xsospic_MouseDown);
            this.xsospic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.xsospic_MouseMove);
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
            this.minbtn.Location = new System.Drawing.Point(239, 1);
            this.minbtn.Name = "minbtn";
            this.minbtn.Size = new System.Drawing.Size(30, 19);
            this.minbtn.TabIndex = 8;
            this.minbtn.TabStop = false;
            this.minbtn.Text = "-";
            this.minbtn.UseVisualStyleBackColor = false;
            this.minbtn.Click += new System.EventHandler(this.minbtn_Click);
            // 
            // mainlbl
            // 
            this.mainlbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mainlbl.AutoSize = true;
            this.mainlbl.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainlbl.ForeColor = System.Drawing.Color.DarkGray;
            this.mainlbl.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.mainlbl.Location = new System.Drawing.Point(22, 3);
            this.mainlbl.Name = "mainlbl";
            this.mainlbl.Size = new System.Drawing.Size(34, 13);
            this.mainlbl.TabIndex = 29;
            this.mainlbl.Text = "Xsos";
            this.mainlbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainlbl_MouseDown);
            this.mainlbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainlbl_MouseMove);
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
            this.closebtn.Location = new System.Drawing.Point(272, 1);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(30, 19);
            this.closebtn.TabIndex = 7;
            this.closebtn.TabStop = false;
            this.closebtn.Text = "X";
            this.closebtn.UseVisualStyleBackColor = false;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 292);
            this.panel2.TabIndex = 16;
            // 
            // txtbox
            // 
            this.txtbox.AllowDrop = true;
            this.txtbox.Location = new System.Drawing.Point(3, 22);
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(295, 247);
            this.txtbox.TabIndex = 53;
            this.txtbox.WrapStartIndent = 5;
            this.txtbox.TextChanged += new System.EventHandler(this.txtbox_TextChanged);
            this.txtbox.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtbox_DragDrop);
            this.txtbox.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtbox_DragEnter);
            // 
            // exebtn
            // 
            this.exebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.exebtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.exebtn.FlatAppearance.BorderSize = 0;
            this.exebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exebtn.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exebtn.ForeColor = System.Drawing.Color.White;
            this.exebtn.Location = new System.Drawing.Point(3, 273);
            this.exebtn.Name = "exebtn";
            this.exebtn.Size = new System.Drawing.Size(55, 24);
            this.exebtn.TabIndex = 58;
            this.exebtn.TabStop = false;
            this.exebtn.Text = "Execute";
            this.exebtn.UseVisualStyleBackColor = false;
            this.exebtn.Click += new System.EventHandler(this.exebtn_Click);
            // 
            // clrbtn
            // 
            this.clrbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.clrbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.clrbtn.FlatAppearance.BorderSize = 0;
            this.clrbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clrbtn.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clrbtn.ForeColor = System.Drawing.Color.White;
            this.clrbtn.Location = new System.Drawing.Point(64, 273);
            this.clrbtn.Name = "clrbtn";
            this.clrbtn.Size = new System.Drawing.Size(50, 24);
            this.clrbtn.TabIndex = 59;
            this.clrbtn.TabStop = false;
            this.clrbtn.Text = "Clear";
            this.clrbtn.UseVisualStyleBackColor = false;
            this.clrbtn.Click += new System.EventHandler(this.clrbtn_Click);
            // 
            // opnbtn
            // 
            this.opnbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.opnbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.opnbtn.FlatAppearance.BorderSize = 0;
            this.opnbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.opnbtn.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opnbtn.ForeColor = System.Drawing.Color.White;
            this.opnbtn.Location = new System.Drawing.Point(120, 273);
            this.opnbtn.Name = "opnbtn";
            this.opnbtn.Size = new System.Drawing.Size(50, 24);
            this.opnbtn.TabIndex = 60;
            this.opnbtn.TabStop = false;
            this.opnbtn.Text = "Open";
            this.opnbtn.UseVisualStyleBackColor = false;
            this.opnbtn.Click += new System.EventHandler(this.opnbtn_Click);
            // 
            // hookbtn
            // 
            this.hookbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.hookbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.hookbtn.FlatAppearance.BorderSize = 0;
            this.hookbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hookbtn.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hookbtn.ForeColor = System.Drawing.Color.White;
            this.hookbtn.Location = new System.Drawing.Point(239, 273);
            this.hookbtn.Name = "hookbtn";
            this.hookbtn.Size = new System.Drawing.Size(59, 24);
            this.hookbtn.TabIndex = 61;
            this.hookbtn.TabStop = false;
            this.hookbtn.Text = "Hook";
            this.hookbtn.UseVisualStyleBackColor = false;
            this.hookbtn.Click += new System.EventHandler(this.hookbtn_Click);
            // 
            // optionsbtn
            // 
            this.optionsbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.optionsbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.optionsbtn.FlatAppearance.BorderSize = 0;
            this.optionsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionsbtn.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsbtn.ForeColor = System.Drawing.Color.White;
            this.optionsbtn.Location = new System.Drawing.Point(176, 273);
            this.optionsbtn.Name = "optionsbtn";
            this.optionsbtn.Size = new System.Drawing.Size(57, 24);
            this.optionsbtn.TabIndex = 62;
            this.optionsbtn.TabStop = false;
            this.optionsbtn.Text = "Options";
            this.optionsbtn.UseVisualStyleBackColor = false;
            this.optionsbtn.Click += new System.EventHandler(this.optionsbtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.optionsbtn);
            this.Controls.Add(this.hookbtn);
            this.Controls.Add(this.opnbtn);
            this.Controls.Add(this.clrbtn);
            this.Controls.Add(this.exebtn);
            this.Controls.Add(this.txtbox);
            this.Controls.Add(this.mainpnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_LoadAsync);
            this.mainpnl.ResumeLayout(false);
            this.mainpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xsospic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainpnl;
        private System.Windows.Forms.Button minbtn;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Label mainlbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private ScintillaNET.Scintilla txtbox;
        private System.Windows.Forms.Button exebtn;
        private System.Windows.Forms.Button clrbtn;
        private System.Windows.Forms.Button opnbtn;
        private System.Windows.Forms.Button hookbtn;
        private System.Windows.Forms.Button optionsbtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.PictureBox xsospic;
    }
}