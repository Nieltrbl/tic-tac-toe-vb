namespace Aviador_TicTacToe_BSCOE_1_4
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.D1 = new System.Windows.Forms.Button();
            this.D2 = new System.Windows.Forms.Button();
            this.D3 = new System.Windows.Forms.Button();
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.N1 = new System.Windows.Forms.Button();
            this.N2 = new System.Windows.Forms.Button();
            this.N3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(529, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.helpToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.helpToolStripMenuItem.Text = " Start New Game";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(204, 26);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // D1
            // 
            this.D1.Font = new System.Drawing.Font("MS Reference Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D1.Image = ((System.Drawing.Image)(resources.GetObject("D1.Image")));
            this.D1.Location = new System.Drawing.Point(108, 57);
            this.D1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.D1.Name = "D1";
            this.D1.Size = new System.Drawing.Size(100, 109);
            this.D1.TabIndex = 2;
            this.D1.UseVisualStyleBackColor = true;
            this.D1.Click += new System.EventHandler(this.button1_Click);
            // 
            // D2
            // 
            this.D2.Font = new System.Drawing.Font("MS Reference Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D2.Image = ((System.Drawing.Image)(resources.GetObject("D2.Image")));
            this.D2.Location = new System.Drawing.Point(207, 57);
            this.D2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.D2.Name = "D2";
            this.D2.Size = new System.Drawing.Size(100, 109);
            this.D2.TabIndex = 3;
            this.D2.UseVisualStyleBackColor = true;
            this.D2.Click += new System.EventHandler(this.button1_Click);
            // 
            // D3
            // 
            this.D3.Font = new System.Drawing.Font("MS Reference Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D3.Image = ((System.Drawing.Image)(resources.GetObject("D3.Image")));
            this.D3.Location = new System.Drawing.Point(305, 57);
            this.D3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.D3.Name = "D3";
            this.D3.Size = new System.Drawing.Size(100, 109);
            this.D3.TabIndex = 4;
            this.D3.UseVisualStyleBackColor = true;
            this.D3.Click += new System.EventHandler(this.button1_Click);
            // 
            // A1
            // 
            this.A1.Font = new System.Drawing.Font("MS Reference Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.Image = ((System.Drawing.Image)(resources.GetObject("A1.Image")));
            this.A1.Location = new System.Drawing.Point(108, 162);
            this.A1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(100, 109);
            this.A1.TabIndex = 5;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.button1_Click);
            // 
            // A2
            // 
            this.A2.Font = new System.Drawing.Font("MS Reference Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.Image = ((System.Drawing.Image)(resources.GetObject("A2.Image")));
            this.A2.Location = new System.Drawing.Point(207, 162);
            this.A2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(100, 109);
            this.A2.TabIndex = 6;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.button1_Click);
            // 
            // A3
            // 
            this.A3.Font = new System.Drawing.Font("MS Reference Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3.Image = ((System.Drawing.Image)(resources.GetObject("A3.Image")));
            this.A3.Location = new System.Drawing.Point(305, 162);
            this.A3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(100, 109);
            this.A3.TabIndex = 7;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.button1_Click);
            // 
            // N1
            // 
            this.N1.Font = new System.Drawing.Font("MS Reference Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N1.Image = ((System.Drawing.Image)(resources.GetObject("N1.Image")));
            this.N1.Location = new System.Drawing.Point(108, 266);
            this.N1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.N1.Name = "N1";
            this.N1.Size = new System.Drawing.Size(100, 109);
            this.N1.TabIndex = 8;
            this.N1.UseVisualStyleBackColor = true;
            this.N1.Click += new System.EventHandler(this.button1_Click);
            // 
            // N2
            // 
            this.N2.Font = new System.Drawing.Font("MS Reference Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N2.Image = ((System.Drawing.Image)(resources.GetObject("N2.Image")));
            this.N2.Location = new System.Drawing.Point(207, 266);
            this.N2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.N2.Name = "N2";
            this.N2.Size = new System.Drawing.Size(100, 109);
            this.N2.TabIndex = 9;
            this.N2.UseVisualStyleBackColor = true;
            this.N2.Click += new System.EventHandler(this.button1_Click);
            // 
            // N3
            // 
            this.N3.Font = new System.Drawing.Font("MS Reference Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.N3.Image = ((System.Drawing.Image)(resources.GetObject("N3.Image")));
            this.N3.Location = new System.Drawing.Point(305, 266);
            this.N3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.N3.Name = "N3";
            this.N3.Size = new System.Drawing.Size(100, 109);
            this.N3.TabIndex = 10;
            this.N3.UseVisualStyleBackColor = true;
            this.N3.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(529, 426);
            this.Controls.Add(this.N3);
            this.Controls.Add(this.N2);
            this.Controls.Add(this.N1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.D3);
            this.Controls.Add(this.D2);
            this.Controls.Add(this.D1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "TIK TAC TOE";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Black;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button D1;
        private System.Windows.Forms.Button D2;
        private System.Windows.Forms.Button D3;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button N1;
        private System.Windows.Forms.Button N2;
        private System.Windows.Forms.Button N3;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

