
namespace TakasbankTeminatCek
{
    partial class FormOption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOption));
            this.labelHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonAddTime = new System.Windows.Forms.Button();
            this.buttonDeleteTime = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAddPath = new System.Windows.Forms.Button();
            this.buttonDeletePath = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.listBoxTime = new System.Windows.Forms.ListBox();
            this.listBoxPaths = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.BackColor = System.Drawing.Color.Teal;
            this.labelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelHeader.Location = new System.Drawing.Point(0, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.labelHeader.Size = new System.Drawing.Size(718, 47);
            this.labelHeader.TabIndex = 1;
            this.labelHeader.Text = "Ayarlar";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 32);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(49, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(669, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kontrol Saatleri";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonAddTime);
            this.panel2.Controls.Add(this.buttonDeleteTime);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(718, 29);
            this.panel2.TabIndex = 23;
            // 
            // buttonAddTime
            // 
            this.buttonAddTime.BackColor = System.Drawing.Color.Teal;
            this.buttonAddTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonAddTime.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAddTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTime.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonAddTime.Location = new System.Drawing.Point(568, 0);
            this.buttonAddTime.Name = "buttonAddTime";
            this.buttonAddTime.Size = new System.Drawing.Size(75, 29);
            this.buttonAddTime.TabIndex = 4;
            this.buttonAddTime.Text = "Ekle";
            this.buttonAddTime.UseVisualStyleBackColor = false;
            this.buttonAddTime.Click += new System.EventHandler(this.buttonAddTime_Click);
            // 
            // buttonDeleteTime
            // 
            this.buttonDeleteTime.BackColor = System.Drawing.Color.Teal;
            this.buttonDeleteTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonDeleteTime.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDeleteTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteTime.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonDeleteTime.Location = new System.Drawing.Point(643, 0);
            this.buttonDeleteTime.Name = "buttonDeleteTime";
            this.buttonDeleteTime.Size = new System.Drawing.Size(75, 29);
            this.buttonDeleteTime.TabIndex = 3;
            this.buttonDeleteTime.Text = "Sil";
            this.buttonDeleteTime.UseVisualStyleBackColor = false;
            this.buttonDeleteTime.Click += new System.EventHandler(this.buttonDeleteTime_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.CustomFormat = "HH:mm";
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(568, 29);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.buttonAddPath);
            this.panel4.Controls.Add(this.buttonDeletePath);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 324);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(718, 26);
            this.panel4.TabIndex = 31;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Dosya yolunu giriniz...";
            this.textBox1.Size = new System.Drawing.Size(568, 26);
            this.textBox1.TabIndex = 20;
            // 
            // buttonAddPath
            // 
            this.buttonAddPath.BackColor = System.Drawing.Color.Teal;
            this.buttonAddPath.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonAddPath.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAddPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddPath.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonAddPath.Location = new System.Drawing.Point(568, 0);
            this.buttonAddPath.Name = "buttonAddPath";
            this.buttonAddPath.Size = new System.Drawing.Size(75, 26);
            this.buttonAddPath.TabIndex = 2;
            this.buttonAddPath.Text = "Ekle";
            this.buttonAddPath.UseVisualStyleBackColor = false;
            this.buttonAddPath.Click += new System.EventHandler(this.buttonAddPath_Click);
            // 
            // buttonDeletePath
            // 
            this.buttonDeletePath.BackColor = System.Drawing.Color.Teal;
            this.buttonDeletePath.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonDeletePath.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDeletePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeletePath.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonDeletePath.Location = new System.Drawing.Point(643, 0);
            this.buttonDeletePath.Name = "buttonDeletePath";
            this.buttonDeletePath.Size = new System.Drawing.Size(75, 26);
            this.buttonDeletePath.TabIndex = 1;
            this.buttonDeletePath.Text = "Sil";
            this.buttonDeletePath.UseVisualStyleBackColor = false;
            this.buttonDeletePath.Click += new System.EventHandler(this.buttonDeletePath_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 292);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(718, 32);
            this.panel5.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(49, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(669, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dosya Yolları";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // listBoxTime
            // 
            this.listBoxTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBoxTime.FormattingEnabled = true;
            this.listBoxTime.ItemHeight = 15;
            this.listBoxTime.Location = new System.Drawing.Point(0, 108);
            this.listBoxTime.Name = "listBoxTime";
            this.listBoxTime.Size = new System.Drawing.Size(718, 184);
            this.listBoxTime.TabIndex = 28;
            // 
            // listBoxPaths
            // 
            this.listBoxPaths.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxPaths.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPaths.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxPaths.FormattingEnabled = true;
            this.listBoxPaths.ItemHeight = 21;
            this.listBoxPaths.Location = new System.Drawing.Point(0, 350);
            this.listBoxPaths.Name = "listBoxPaths";
            this.listBoxPaths.Size = new System.Drawing.Size(718, 222);
            this.listBoxPaths.TabIndex = 33;
            // 
            // FormOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(718, 572);
            this.Controls.Add(this.listBoxPaths);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.listBoxTime);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelHeader);
            this.Name = "FormOption";
            this.Text = "FormOption";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonAddPath;
        private System.Windows.Forms.Button buttonDeletePath;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox listBoxTime;
        private System.Windows.Forms.Button buttonAddTime;
        private System.Windows.Forms.Button buttonDeleteTime;
        private System.Windows.Forms.ListBox listBoxPaths;
    }
}