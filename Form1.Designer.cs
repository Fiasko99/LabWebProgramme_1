namespace LabWebProgramme_1
{
    partial class InfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
            this.drivesBox = new System.Windows.Forms.ListBox();
            this.antiVirusBox = new System.Windows.Forms.ListBox();
            this.portsBox = new System.Windows.Forms.ListBox();
            this.objectsDomain = new System.Windows.Forms.ListBox();
            this.SaveButt = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.pathDir = new System.Windows.Forms.Label();
            this.format = new System.Windows.Forms.ComboBox();
            this.totalRam = new System.Windows.Forms.CheckBox();
            this.osVer = new System.Windows.Forms.CheckBox();
            this.ipLabel = new System.Windows.Forms.CheckBox();
            this.domain = new System.Windows.Forms.CheckBox();
            this.drivesInfo = new System.Windows.Forms.CheckBox();
            this.infoAV = new System.Windows.Forms.CheckBox();
            this.objectsInDomain = new System.Windows.Forms.CheckBox();
            this.ports = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // drivesBox
            // 
            this.drivesBox.BackColor = System.Drawing.SystemColors.Control;
            this.drivesBox.FormattingEnabled = true;
            this.drivesBox.Location = new System.Drawing.Point(1, 27);
            this.drivesBox.Name = "drivesBox";
            this.drivesBox.Size = new System.Drawing.Size(459, 30);
            this.drivesBox.TabIndex = 16;
            // 
            // antiVirusBox
            // 
            this.antiVirusBox.BackColor = System.Drawing.SystemColors.Control;
            this.antiVirusBox.FormattingEnabled = true;
            this.antiVirusBox.Location = new System.Drawing.Point(1, 88);
            this.antiVirusBox.Name = "antiVirusBox";
            this.antiVirusBox.Size = new System.Drawing.Size(459, 30);
            this.antiVirusBox.TabIndex = 20;
            // 
            // portsBox
            // 
            this.portsBox.BackColor = System.Drawing.SystemColors.Control;
            this.portsBox.FormattingEnabled = true;
            this.portsBox.Location = new System.Drawing.Point(1, 157);
            this.portsBox.Name = "portsBox";
            this.portsBox.Size = new System.Drawing.Size(459, 56);
            this.portsBox.TabIndex = 25;
            // 
            // objectsDomain
            // 
            this.objectsDomain.BackColor = System.Drawing.SystemColors.Control;
            this.objectsDomain.FormattingEnabled = true;
            this.objectsDomain.Location = new System.Drawing.Point(2, 249);
            this.objectsDomain.Name = "objectsDomain";
            this.objectsDomain.Size = new System.Drawing.Size(458, 30);
            this.objectsDomain.TabIndex = 27;
            // 
            // SaveButt
            // 
            this.SaveButt.Location = new System.Drawing.Point(0, 470);
            this.SaveButt.Name = "SaveButt";
            this.SaveButt.Size = new System.Drawing.Size(65, 23);
            this.SaveButt.TabIndex = 29;
            this.SaveButt.Text = "Экспорт";
            this.SaveButt.UseVisualStyleBackColor = true;
            this.SaveButt.Visible = false;
            this.SaveButt.Click += new System.EventHandler(this.SaveButt_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(-3, 496);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(59, 13);
            this.result.TabIndex = 30;
            this.result.Text = "Результат";
            this.result.Visible = false;
            // 
            // pathDir
            // 
            this.pathDir.AutoSize = true;
            this.pathDir.Location = new System.Drawing.Point(-3, 509);
            this.pathDir.Name = "pathDir";
            this.pathDir.Size = new System.Drawing.Size(31, 13);
            this.pathDir.TabIndex = 31;
            this.pathDir.Text = "Путь";
            this.pathDir.Visible = false;
            // 
            // format
            // 
            this.format.FormattingEnabled = true;
            this.format.Items.AddRange(new object[] {
            "Текстовые файлы | *.txt",
            "документы Word|*.doc",
            "PDF|*.pdf",
            "Rich text format|*.rtf",
            "CSV UTF-8 (разделитель - запятая)|*.csv",
            "Язык разметки XML|*.xml"});
            this.format.Location = new System.Drawing.Point(2, 443);
            this.format.Name = "format";
            this.format.Size = new System.Drawing.Size(458, 21);
            this.format.TabIndex = 32;
            this.format.Text = "Выбрать формат отчёта";
            this.format.SelectedIndexChanged += new System.EventHandler(this.Format_SelectedIndexChanged);
            // 
            // totalRam
            // 
            this.totalRam.AutoSize = true;
            this.totalRam.Location = new System.Drawing.Point(2, 330);
            this.totalRam.Name = "totalRam";
            this.totalRam.Size = new System.Drawing.Size(68, 17);
            this.totalRam.TabIndex = 33;
            this.totalRam.Text = "totalRam";
            this.totalRam.UseVisualStyleBackColor = true;
            // 
            // osVer
            // 
            this.osVer.AutoSize = true;
            this.osVer.Location = new System.Drawing.Point(2, 353);
            this.osVer.Name = "osVer";
            this.osVer.Size = new System.Drawing.Size(72, 17);
            this.osVer.TabIndex = 34;
            this.osVer.Text = "osVersion";
            this.osVer.UseVisualStyleBackColor = true;
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(2, 376);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(34, 17);
            this.ipLabel.TabIndex = 35;
            this.ipLabel.Text = "ip";
            this.ipLabel.UseVisualStyleBackColor = true;
            // 
            // domain
            // 
            this.domain.AutoSize = true;
            this.domain.Location = new System.Drawing.Point(2, 399);
            this.domain.Name = "domain";
            this.domain.Size = new System.Drawing.Size(62, 17);
            this.domain.TabIndex = 36;
            this.domain.Text = "Domain";
            this.domain.UseVisualStyleBackColor = true;
            // 
            // drivesInfo
            // 
            this.drivesInfo.AutoSize = true;
            this.drivesInfo.Location = new System.Drawing.Point(1, 4);
            this.drivesInfo.Name = "drivesInfo";
            this.drivesInfo.Size = new System.Drawing.Size(59, 17);
            this.drivesInfo.TabIndex = 37;
            this.drivesInfo.Text = "Диски";
            this.drivesInfo.UseVisualStyleBackColor = true;
            // 
            // infoAV
            // 
            this.infoAV.AutoSize = true;
            this.infoAV.Location = new System.Drawing.Point(1, 65);
            this.infoAV.Name = "infoAV";
            this.infoAV.Size = new System.Drawing.Size(87, 17);
            this.infoAV.TabIndex = 38;
            this.infoAV.Text = "Антивирусы";
            this.infoAV.UseVisualStyleBackColor = true;
            // 
            // objectsInDomain
            // 
            this.objectsInDomain.AutoSize = true;
            this.objectsInDomain.Location = new System.Drawing.Point(1, 134);
            this.objectsInDomain.Name = "objectsInDomain";
            this.objectsInDomain.Size = new System.Drawing.Size(69, 17);
            this.objectsInDomain.TabIndex = 39;
            this.objectsInDomain.Text = "Домены";
            this.objectsInDomain.UseVisualStyleBackColor = true;
            // 
            // ports
            // 
            this.ports.AutoSize = true;
            this.ports.Location = new System.Drawing.Point(2, 226);
            this.ports.Name = "ports";
            this.ports.Size = new System.Drawing.Size(117, 17);
            this.ports.TabIndex = 40;
            this.ports.Text = "Свободные порты";
            this.ports.UseVisualStyleBackColor = true;
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(472, 574);
            this.Controls.Add(this.ports);
            this.Controls.Add(this.objectsInDomain);
            this.Controls.Add(this.infoAV);
            this.Controls.Add(this.drivesInfo);
            this.Controls.Add(this.domain);
            this.Controls.Add(this.ipLabel);
            this.Controls.Add(this.osVer);
            this.Controls.Add(this.totalRam);
            this.Controls.Add(this.format);
            this.Controls.Add(this.pathDir);
            this.Controls.Add(this.result);
            this.Controls.Add(this.SaveButt);
            this.Controls.Add(this.objectsDomain);
            this.Controls.Add(this.portsBox);
            this.Controls.Add(this.antiVirusBox);
            this.Controls.Add(this.drivesBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InfoForm";
            this.Text = "Системная информация";
            this.Load += new System.EventHandler(this.InfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox drivesBox;
        private System.Windows.Forms.ListBox antiVirusBox;
        private System.Windows.Forms.ListBox portsBox;
        private System.Windows.Forms.ListBox objectsDomain;
        private System.Windows.Forms.Button SaveButt;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label pathDir;
        private System.Windows.Forms.ComboBox format;
        private System.Windows.Forms.CheckBox totalRam;
        private System.Windows.Forms.CheckBox osVer;
        private System.Windows.Forms.CheckBox ipLabel;
        private System.Windows.Forms.CheckBox domain;
        private System.Windows.Forms.CheckBox drivesInfo;
        private System.Windows.Forms.CheckBox infoAV;
        private System.Windows.Forms.CheckBox objectsInDomain;
        private System.Windows.Forms.CheckBox ports;
    }
}

