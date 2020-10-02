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
            this.ipLabel = new System.Windows.Forms.Label();
            this.drivesBox = new System.Windows.Forms.ListBox();
            this.totalRam = new System.Windows.Forms.Label();
            this.drivesInfo = new System.Windows.Forms.Label();
            this.infoAV = new System.Windows.Forms.Label();
            this.antiVirusBox = new System.Windows.Forms.ListBox();
            this.domain = new System.Windows.Forms.Label();
            this.osVer = new System.Windows.Forms.Label();
            this.portsBox = new System.Windows.Forms.ListBox();
            this.ports = new System.Windows.Forms.Label();
            this.objectsDomain = new System.Windows.Forms.ListBox();
            this.objectsInDomain = new System.Windows.Forms.Label();
            this.SaveButt = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.pathDir = new System.Windows.Forms.Label();
            this.format = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(-2, 319);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(15, 13);
            this.ipLabel.TabIndex = 15;
            this.ipLabel.Text = "ip";
            // 
            // drivesBox
            // 
            this.drivesBox.BackColor = System.Drawing.SystemColors.Control;
            this.drivesBox.FormattingEnabled = true;
            this.drivesBox.Location = new System.Drawing.Point(1, 18);
            this.drivesBox.Name = "drivesBox";
            this.drivesBox.Size = new System.Drawing.Size(459, 30);
            this.drivesBox.TabIndex = 16;
            // 
            // totalRam
            // 
            this.totalRam.AutoSize = true;
            this.totalRam.Location = new System.Drawing.Point(-2, 274);
            this.totalRam.Name = "totalRam";
            this.totalRam.Size = new System.Drawing.Size(51, 13);
            this.totalRam.TabIndex = 17;
            this.totalRam.Text = "totalRAM";
            // 
            // drivesInfo
            // 
            this.drivesInfo.AutoSize = true;
            this.drivesInfo.Location = new System.Drawing.Point(-2, 2);
            this.drivesInfo.Name = "drivesInfo";
            this.drivesInfo.Size = new System.Drawing.Size(40, 13);
            this.drivesInfo.TabIndex = 18;
            this.drivesInfo.Text = "Диски";
            // 
            // infoAV
            // 
            this.infoAV.AutoSize = true;
            this.infoAV.Location = new System.Drawing.Point(-2, 60);
            this.infoAV.Name = "infoAV";
            this.infoAV.Size = new System.Drawing.Size(68, 13);
            this.infoAV.TabIndex = 19;
            this.infoAV.Text = "Антивирусы";
            // 
            // antiVirusBox
            // 
            this.antiVirusBox.BackColor = System.Drawing.SystemColors.Control;
            this.antiVirusBox.FormattingEnabled = true;
            this.antiVirusBox.Location = new System.Drawing.Point(1, 76);
            this.antiVirusBox.Name = "antiVirusBox";
            this.antiVirusBox.Size = new System.Drawing.Size(459, 30);
            this.antiVirusBox.TabIndex = 20;
            // 
            // domain
            // 
            this.domain.AutoSize = true;
            this.domain.Location = new System.Drawing.Point(-2, 345);
            this.domain.Name = "domain";
            this.domain.Size = new System.Drawing.Size(43, 13);
            this.domain.TabIndex = 21;
            this.domain.Text = "Domain";
            // 
            // osVer
            // 
            this.osVer.AutoSize = true;
            this.osVer.Location = new System.Drawing.Point(-2, 297);
            this.osVer.Name = "osVer";
            this.osVer.Size = new System.Drawing.Size(53, 13);
            this.osVer.TabIndex = 22;
            this.osVer.Text = "osVersion";
            // 
            // portsBox
            // 
            this.portsBox.BackColor = System.Drawing.SystemColors.Control;
            this.portsBox.FormattingEnabled = true;
            this.portsBox.Location = new System.Drawing.Point(1, 196);
            this.portsBox.Name = "portsBox";
            this.portsBox.Size = new System.Drawing.Size(459, 56);
            this.portsBox.TabIndex = 25;
            // 
            // ports
            // 
            this.ports.AutoSize = true;
            this.ports.BackColor = System.Drawing.SystemColors.Control;
            this.ports.Location = new System.Drawing.Point(-2, 180);
            this.ports.Name = "ports";
            this.ports.Size = new System.Drawing.Size(98, 13);
            this.ports.TabIndex = 26;
            this.ports.Text = "Свободные порты";
            // 
            // objectsDomain
            // 
            this.objectsDomain.BackColor = System.Drawing.SystemColors.Control;
            this.objectsDomain.FormattingEnabled = true;
            this.objectsDomain.Location = new System.Drawing.Point(1, 137);
            this.objectsDomain.Name = "objectsDomain";
            this.objectsDomain.Size = new System.Drawing.Size(459, 30);
            this.objectsDomain.TabIndex = 27;
            // 
            // objectsInDomain
            // 
            this.objectsInDomain.AutoSize = true;
            this.objectsInDomain.Location = new System.Drawing.Point(-2, 121);
            this.objectsInDomain.Name = "objectsInDomain";
            this.objectsInDomain.Size = new System.Drawing.Size(103, 13);
            this.objectsInDomain.TabIndex = 28;
            this.objectsInDomain.Text = "Объекты в домене";
            // 
            // SaveButt
            // 
            this.SaveButt.Location = new System.Drawing.Point(4, 430);
            this.SaveButt.Name = "SaveButt";
            this.SaveButt.Size = new System.Drawing.Size(65, 23);
            this.SaveButt.TabIndex = 29;
            this.SaveButt.Text = "Отчёт";
            this.SaveButt.UseVisualStyleBackColor = true;
            this.SaveButt.Visible = false;
            this.SaveButt.Click += new System.EventHandler(this.SaveButt_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(1, 456);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(59, 13);
            this.result.TabIndex = 30;
            this.result.Text = "Результат";
            this.result.Visible = false;
            // 
            // pathDir
            // 
            this.pathDir.AutoSize = true;
            this.pathDir.Location = new System.Drawing.Point(1, 469);
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
            "txt",
            "doc",
            "pdf",
            "rtf",
            "csv",
            "xml"});
            this.format.Location = new System.Drawing.Point(4, 388);
            this.format.Name = "format";
            this.format.Size = new System.Drawing.Size(456, 21);
            this.format.TabIndex = 32;
            this.format.Text = "Выбрать формат сохранения";
            this.format.SelectedIndexChanged += new System.EventHandler(this.Format_SelectedIndexChanged);
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(472, 574);
            this.Controls.Add(this.format);
            this.Controls.Add(this.pathDir);
            this.Controls.Add(this.result);
            this.Controls.Add(this.SaveButt);
            this.Controls.Add(this.objectsInDomain);
            this.Controls.Add(this.objectsDomain);
            this.Controls.Add(this.ports);
            this.Controls.Add(this.portsBox);
            this.Controls.Add(this.osVer);
            this.Controls.Add(this.domain);
            this.Controls.Add(this.antiVirusBox);
            this.Controls.Add(this.infoAV);
            this.Controls.Add(this.drivesInfo);
            this.Controls.Add(this.totalRam);
            this.Controls.Add(this.drivesBox);
            this.Controls.Add(this.ipLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InfoForm";
            this.Text = "Системная информация";
            this.Load += new System.EventHandler(this.InfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.ListBox drivesBox;
        private System.Windows.Forms.Label totalRam;
        private System.Windows.Forms.Label drivesInfo;
        private System.Windows.Forms.Label infoAV;
        private System.Windows.Forms.ListBox antiVirusBox;
        private System.Windows.Forms.Label domain;
        private System.Windows.Forms.Label osVer;
        private System.Windows.Forms.ListBox portsBox;
        private System.Windows.Forms.Label ports;
        private System.Windows.Forms.ListBox objectsDomain;
        private System.Windows.Forms.Label objectsInDomain;
        private System.Windows.Forms.Button SaveButt;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label pathDir;
        private System.Windows.Forms.ComboBox format;
    }
}

