
namespace TakasbankTeminatCek
{
    partial class FormDataCek
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
            this.dateTimePickerSecond = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFirst = new System.Windows.Forms.DateTimePicker();
            this.panelTools = new System.Windows.Forms.Panel();
            this.buttonManuel = new System.Windows.Forms.Button();
            this.labelOutOfTime = new System.Windows.Forms.Label();
            this.labelHeader = new System.Windows.Forms.Label();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.dataGridViewSymbols = new System.Windows.Forms.DataGridView();
            this.timerPeriod = new System.Windows.Forms.Timer(this.components);
            this.panelTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSymbols)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerSecond
            // 
            this.dateTimePickerSecond.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerSecond.CustomFormat = "HH:mm";
            this.dateTimePickerSecond.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerSecond.Location = new System.Drawing.Point(460, 12);
            this.dateTimePickerSecond.Name = "dateTimePickerSecond";
            this.dateTimePickerSecond.ShowUpDown = true;
            this.dateTimePickerSecond.Size = new System.Drawing.Size(80, 23);
            this.dateTimePickerSecond.TabIndex = 4;
            this.dateTimePickerSecond.Value = new System.DateTime(2022, 3, 29, 9, 30, 0, 0);
            // 
            // dateTimePickerFirst
            // 
            this.dateTimePickerFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerFirst.CustomFormat = "HH:mm";
            this.dateTimePickerFirst.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFirst.Location = new System.Drawing.Point(374, 12);
            this.dateTimePickerFirst.Name = "dateTimePickerFirst";
            this.dateTimePickerFirst.ShowUpDown = true;
            this.dateTimePickerFirst.Size = new System.Drawing.Size(80, 23);
            this.dateTimePickerFirst.TabIndex = 4;
            this.dateTimePickerFirst.Value = new System.DateTime(2022, 3, 29, 18, 15, 0, 0);
            // 
            // panelTools
            // 
            this.panelTools.BackColor = System.Drawing.Color.Teal;
            this.panelTools.Controls.Add(this.buttonManuel);
            this.panelTools.Controls.Add(this.labelOutOfTime);
            this.panelTools.Controls.Add(this.dateTimePickerFirst);
            this.panelTools.Controls.Add(this.dateTimePickerSecond);
            this.panelTools.Controls.Add(this.labelHeader);
            this.panelTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTools.Location = new System.Drawing.Point(0, 0);
            this.panelTools.Name = "panelTools";
            this.panelTools.Size = new System.Drawing.Size(718, 47);
            this.panelTools.TabIndex = 5;
            // 
            // buttonManuel
            // 
            this.buttonManuel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonManuel.BackColor = System.Drawing.Color.White;
            this.buttonManuel.FlatAppearance.BorderSize = 0;
            this.buttonManuel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManuel.Location = new System.Drawing.Point(605, 13);
            this.buttonManuel.Name = "buttonManuel";
            this.buttonManuel.Size = new System.Drawing.Size(101, 23);
            this.buttonManuel.TabIndex = 6;
            this.buttonManuel.Text = "Manuel Oluştur";
            this.buttonManuel.UseVisualStyleBackColor = false;
            this.buttonManuel.Click += new System.EventHandler(this.buttonManuel_Click);
            // 
            // labelOutOfTime
            // 
            this.labelOutOfTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOutOfTime.AutoSize = true;
            this.labelOutOfTime.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOutOfTime.Location = new System.Drawing.Point(225, 11);
            this.labelOutOfTime.Name = "labelOutOfTime";
            this.labelOutOfTime.Size = new System.Drawing.Size(0, 23);
            this.labelOutOfTime.TabIndex = 5;
            // 
            // labelHeader
            // 
            this.labelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelHeader.Location = new System.Drawing.Point(0, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.labelHeader.Size = new System.Drawing.Size(718, 47);
            this.labelHeader.TabIndex = 7;
            this.labelHeader.Text = "Takasbank Data Çek";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBoxLog
            // 
            this.listBoxLog.BackColor = System.Drawing.Color.Gainsboro;
            this.listBoxLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.ItemHeight = 15;
            this.listBoxLog.Location = new System.Drawing.Point(0, 467);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(718, 105);
            this.listBoxLog.TabIndex = 6;
            // 
            // buttonRun
            // 
            this.buttonRun.BackColor = System.Drawing.Color.IndianRed;
            this.buttonRun.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonRun.FlatAppearance.BorderSize = 0;
            this.buttonRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRun.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRun.Location = new System.Drawing.Point(0, 437);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(718, 30);
            this.buttonRun.TabIndex = 7;
            this.buttonRun.Text = ">> ÇALIŞTIR <<";
            this.buttonRun.UseVisualStyleBackColor = false;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // dataGridViewSymbols
            // 
            this.dataGridViewSymbols.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSymbols.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewSymbols.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSymbols.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSymbols.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSymbols.GridColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridViewSymbols.Location = new System.Drawing.Point(0, 47);
            this.dataGridViewSymbols.Name = "dataGridViewSymbols";
            this.dataGridViewSymbols.RowTemplate.Height = 25;
            this.dataGridViewSymbols.Size = new System.Drawing.Size(718, 390);
            this.dataGridViewSymbols.TabIndex = 8;
            // 
            // timerPeriod
            // 
            this.timerPeriod.Tick += new System.EventHandler(this.timerPeriod_Tick);
            // 
            // FormDataCek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 572);
            this.Controls.Add(this.dataGridViewSymbols);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.listBoxLog);
            this.Controls.Add(this.panelTools);
            this.Name = "FormDataCek";
            this.Text = "FormDataCek";
            this.panelTools.ResumeLayout(false);
            this.panelTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSymbols)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePickerSecond;
        private System.Windows.Forms.DateTimePicker dateTimePickerFirst;
        private System.Windows.Forms.Panel panelTools;
        private System.Windows.Forms.Label labelOutOfTime;
        private System.Windows.Forms.Button buttonManuel;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.DataGridView dataGridViewSymbols;
        private System.Windows.Forms.Timer timerPeriod;
        private System.Windows.Forms.Label labelHeader;
    }
}