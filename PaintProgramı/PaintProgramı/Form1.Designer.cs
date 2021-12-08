namespace PaintProgramı
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.renkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şekilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dikdörtgenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(314, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 276);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renkToolStripMenuItem,
            this.şekilToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(314, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // renkToolStripMenuItem
            // 
            this.renkToolStripMenuItem.Name = "renkToolStripMenuItem";
            this.renkToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.renkToolStripMenuItem.Text = "Renk";
            this.renkToolStripMenuItem.Click += new System.EventHandler(this.renkToolStripMenuItem_Click);
            // 
            // şekilToolStripMenuItem
            // 
            this.şekilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çemberToolStripMenuItem,
            this.dikdörtgenToolStripMenuItem,
            this.kareToolStripMenuItem});
            this.şekilToolStripMenuItem.Name = "şekilToolStripMenuItem";
            this.şekilToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.şekilToolStripMenuItem.Text = "Şekil";
            this.şekilToolStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.şekilToolStripMenuItem_MouseDown);
            // 
            // çemberToolStripMenuItem
            // 
            this.çemberToolStripMenuItem.Name = "çemberToolStripMenuItem";
            this.çemberToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.çemberToolStripMenuItem.Text = "Çember";
            this.çemberToolStripMenuItem.Click += new System.EventHandler(this.çemberToolStripMenuItem_Click);
            // 
            // dikdörtgenToolStripMenuItem
            // 
            this.dikdörtgenToolStripMenuItem.Name = "dikdörtgenToolStripMenuItem";
            this.dikdörtgenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dikdörtgenToolStripMenuItem.Text = "Dikdörtgen";
            // 
            // kareToolStripMenuItem
            // 
            this.kareToolStripMenuItem.Name = "kareToolStripMenuItem";
            this.kareToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kareToolStripMenuItem.Text = "Kare";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 299);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem renkToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem şekilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dikdörtgenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kareToolStripMenuItem;
    }
}

