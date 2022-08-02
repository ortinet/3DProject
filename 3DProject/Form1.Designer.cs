namespace _3DProject
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.создатьФигуруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кубToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пирамидуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.другуюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.другуюToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьФигуруToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // создатьФигуруToolStripMenuItem
            // 
            this.создатьФигуруToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.кубToolStripMenuItem,
            this.пирамидуToolStripMenuItem,
            this.другуюToolStripMenuItem,
            this.другуюToolStripMenuItem1});
            this.создатьФигуруToolStripMenuItem.Name = "создатьФигуруToolStripMenuItem";
            this.создатьФигуруToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.создатьФигуруToolStripMenuItem.Text = "Создать фигуру";
            // 
            // кубToolStripMenuItem
            // 
            this.кубToolStripMenuItem.Name = "кубToolStripMenuItem";
            this.кубToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.кубToolStripMenuItem.Text = "Куб";
            this.кубToolStripMenuItem.Click += new System.EventHandler(this.кубToolStripMenuItem_Click);
            // 
            // пирамидуToolStripMenuItem
            // 
            this.пирамидуToolStripMenuItem.Name = "пирамидуToolStripMenuItem";
            this.пирамидуToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.пирамидуToolStripMenuItem.Text = "Пирамиду";
            this.пирамидуToolStripMenuItem.Click += new System.EventHandler(this.пирамидуToolStripMenuItem_Click);
            // 
            // другуюToolStripMenuItem
            // 
            this.другуюToolStripMenuItem.Name = "другуюToolStripMenuItem";
            this.другуюToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.другуюToolStripMenuItem.Text = "Додекаэдр";
            this.другуюToolStripMenuItem.Click += new System.EventHandler(this.OtherToolStripMenuItem_Click);
            // 
            // другуюToolStripMenuItem1
            // 
            this.другуюToolStripMenuItem1.Name = "другуюToolStripMenuItem1";
            this.другуюToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.другуюToolStripMenuItem1.Text = "Другую...";
            this.другуюToolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 420);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem создатьФигуруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кубToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пирамидуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem другуюToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem другуюToolStripMenuItem1;
    }
}

