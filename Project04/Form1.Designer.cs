namespace Project04
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
            this.SideA = new System.Windows.Forms.TextBox();
            this.SideB = new System.Windows.Forms.TextBox();
            this.AngleC = new System.Windows.Forms.TextBox();
            this.SideC = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.AngleA = new System.Windows.Forms.TextBox();
            this.AngleB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SideA
            // 
            this.SideA.Location = new System.Drawing.Point(143, 42);
            this.SideA.Name = "SideA";
            this.SideA.Size = new System.Drawing.Size(100, 20);
            this.SideA.TabIndex = 0;
            // 
            // SideB
            // 
            this.SideB.Location = new System.Drawing.Point(143, 68);
            this.SideB.Name = "SideB";
            this.SideB.Size = new System.Drawing.Size(100, 20);
            this.SideB.TabIndex = 1;
            // 
            // AngleC
            // 
            this.AngleC.Location = new System.Drawing.Point(143, 94);
            this.AngleC.Name = "AngleC";
            this.AngleC.Size = new System.Drawing.Size(100, 20);
            this.AngleC.TabIndex = 2;
            // 
            // SideC
            // 
            this.SideC.Location = new System.Drawing.Point(143, 171);
            this.SideC.Name = "SideC";
            this.SideC.Size = new System.Drawing.Size(100, 20);
            this.SideC.TabIndex = 3;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(169, 128);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 4;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(168, 279);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Side A";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(52, 71);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(38, 13);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "Side B";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(52, 94);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(44, 13);
            this.Label3.TabIndex = 8;
            this.Label3.Text = "Angle C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Calculate the Value of";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "the Opposite Side.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Side C";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(313, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project04.Properties.Resources.Triangle;
            this.pictureBox1.Location = new System.Drawing.Point(84, 308);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 128);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Given the two sides and the angle between";
            // 
            // AngleA
            // 
            this.AngleA.Location = new System.Drawing.Point(143, 197);
            this.AngleA.Name = "AngleA";
            this.AngleA.Size = new System.Drawing.Size(100, 20);
            this.AngleA.TabIndex = 15;
            // 
            // AngleB
            // 
            this.AngleB.Location = new System.Drawing.Point(142, 224);
            this.AngleB.Name = "AngleB";
            this.AngleB.Size = new System.Drawing.Size(100, 20);
            this.AngleB.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Angle A";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Angle B";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 447);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AngleB);
            this.Controls.Add(this.AngleA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.SideC);
            this.Controls.Add(this.AngleC);
            this.Controls.Add(this.SideB);
            this.Controls.Add(this.SideA);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Triangle Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SideA;
        private System.Windows.Forms.TextBox SideB;
        private System.Windows.Forms.TextBox AngleC;
        private System.Windows.Forms.TextBox SideC;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AngleA;
        private System.Windows.Forms.TextBox AngleB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

