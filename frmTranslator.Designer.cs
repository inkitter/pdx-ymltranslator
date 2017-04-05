namespace pdx_ymltranslator
{
    partial class FrmTranslator
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTranslator));
            this.TxtLog = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.LstFiles = new System.Windows.Forms.ListBox();
            this.LabFROM = new System.Windows.Forms.Label();
            this.LabTo = new System.Windows.Forms.Label();
            this.DfData = new System.Windows.Forms.DataGridView();
            this.TxtENG = new System.Windows.Forms.TextBox();
            this.TxtCHN = new System.Windows.Forms.TextBox();
            this.BtnApply = new System.Windows.Forms.Button();
            this.LabAPI = new System.Windows.Forms.Label();
            this.BtnAPItochnBox = new System.Windows.Forms.Button();
            this.BtnOpenFileTranslated = new System.Windows.Forms.Button();
            this.BtnOpenFileOriginal = new System.Windows.Forms.Button();
            this.BtnOpenBrowser = new System.Windows.Forms.Button();
            this.RadioGoogle = new System.Windows.Forms.RadioButton();
            this.RadioBaidu = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DfData)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtLog
            // 
            this.TxtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtLog.Location = new System.Drawing.Point(12, 715);
            this.TxtLog.Multiline = true;
            this.TxtLog.Name = "TxtLog";
            this.TxtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtLog.Size = new System.Drawing.Size(838, 77);
            this.TxtLog.TabIndex = 3;
            this.TxtLog.TabStop = false;
            this.TxtLog.DoubleClick += new System.EventHandler(this.Logtxtbox_DoubleClick);
            this.TxtLog.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Logtxtbox_KeyDown);
            // 
            // BtnSave
            // 
            this.BtnSave.Enabled = false;
            this.BtnSave.Location = new System.Drawing.Point(989, 757);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(97, 34);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.TabStop = false;
            this.BtnSave.Text = "Save (Ctrl+S)";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // LstFiles
            // 
            this.LstFiles.FormattingEnabled = true;
            this.LstFiles.ItemHeight = 12;
            this.LstFiles.Location = new System.Drawing.Point(12, 6);
            this.LstFiles.Name = "LstFiles";
            this.LstFiles.Size = new System.Drawing.Size(184, 532);
            this.LstFiles.TabIndex = 4;
            this.LstFiles.TabStop = false;
            this.LstFiles.SelectedIndexChanged += new System.EventHandler(this.LstFiles_SelectedIndexChanged);
            // 
            // LabFROM
            // 
            this.LabFROM.AutoSize = true;
            this.LabFROM.Location = new System.Drawing.Point(857, 550);
            this.LabFROM.Name = "LabFROM";
            this.LabFROM.Size = new System.Drawing.Size(29, 12);
            this.LabFROM.TabIndex = 6;
            this.LabFROM.Text = "FROM";
            // 
            // LabTo
            // 
            this.LabTo.AutoSize = true;
            this.LabTo.Location = new System.Drawing.Point(857, 635);
            this.LabTo.Name = "LabTo";
            this.LabTo.Size = new System.Drawing.Size(53, 12);
            this.LabTo.TabIndex = 7;
            this.LabTo.Text = "Trans To";
            // 
            // DfData
            // 
            this.DfData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DfData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DfData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DfData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DfData.Location = new System.Drawing.Point(202, 6);
            this.DfData.MultiSelect = false;
            this.DfData.Name = "DfData";
            this.DfData.ReadOnly = true;
            this.DfData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DfData.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DfData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.DfData.RowTemplate.Height = 23;
            this.DfData.RowTemplate.ReadOnly = true;
            this.DfData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DfData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DfData.Size = new System.Drawing.Size(880, 532);
            this.DfData.TabIndex = 1;
            this.DfData.SelectionChanged += new System.EventHandler(this.DfData_SelectionChanged);
            this.DfData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridALL_KeyDown);
            // 
            // TxtENG
            // 
            this.TxtENG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtENG.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtENG.Location = new System.Drawing.Point(12, 549);
            this.TxtENG.Multiline = true;
            this.TxtENG.Name = "TxtENG";
            this.TxtENG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtENG.Size = new System.Drawing.Size(838, 77);
            this.TxtENG.TabIndex = 9;
            this.TxtENG.TabStop = false;
            this.TxtENG.DoubleClick += new System.EventHandler(this.TxtENG_DoubleClick);
            this.TxtENG.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtENG_KeyDown);
            // 
            // TxtCHN
            // 
            this.TxtCHN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtCHN.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtCHN.Location = new System.Drawing.Point(12, 632);
            this.TxtCHN.Multiline = true;
            this.TxtCHN.Name = "TxtCHN";
            this.TxtCHN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtCHN.Size = new System.Drawing.Size(838, 77);
            this.TxtCHN.TabIndex = 2;
            this.TxtCHN.DoubleClick += new System.EventHandler(this.TxtCHN_DoubleClick);
            this.TxtCHN.Enter += new System.EventHandler(this.TxtCHN_Enter);
            this.TxtCHN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCHN_KeyDown);
            this.TxtCHN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCHN_KeyPress);
            // 
            // BtnApply
            // 
            this.BtnApply.Location = new System.Drawing.Point(857, 657);
            this.BtnApply.Name = "BtnApply";
            this.BtnApply.Size = new System.Drawing.Size(94, 34);
            this.BtnApply.TabIndex = 0;
            this.BtnApply.TabStop = false;
            this.BtnApply.Text = "Apply (Ctrl+Enter)";
            this.BtnApply.UseVisualStyleBackColor = true;
            this.BtnApply.Click += new System.EventHandler(this.Applybtn_Click);
            // 
            // LabAPI
            // 
            this.LabAPI.AutoSize = true;
            this.LabAPI.Location = new System.Drawing.Point(855, 777);
            this.LabAPI.Name = "LabAPI";
            this.LabAPI.Size = new System.Drawing.Size(59, 12);
            this.LabAPI.TabIndex = 12;
            this.LabAPI.Text = "Baidu API";
            // 
            // BtnAPItochnBox
            // 
            this.BtnAPItochnBox.Location = new System.Drawing.Point(856, 715);
            this.BtnAPItochnBox.Name = "BtnAPItochnBox";
            this.BtnAPItochnBox.Size = new System.Drawing.Size(122, 34);
            this.BtnAPItochnBox.TabIndex = 13;
            this.BtnAPItochnBox.TabStop = false;
            this.BtnAPItochnBox.Text = "Paste API text to Translate(Ctrl+↑)";
            this.BtnAPItochnBox.UseVisualStyleBackColor = true;
            this.BtnAPItochnBox.Click += new System.EventHandler(this.BtnAPItochnBox_Click);
            // 
            // BtnOpenFileTranslated
            // 
            this.BtnOpenFileTranslated.Location = new System.Drawing.Point(980, 592);
            this.BtnOpenFileTranslated.Name = "BtnOpenFileTranslated";
            this.BtnOpenFileTranslated.Size = new System.Drawing.Size(103, 34);
            this.BtnOpenFileTranslated.TabIndex = 14;
            this.BtnOpenFileTranslated.TabStop = false;
            this.BtnOpenFileTranslated.Text = "Open Translated";
            this.BtnOpenFileTranslated.UseVisualStyleBackColor = true;
            this.BtnOpenFileTranslated.Click += new System.EventHandler(this.BtnOpenFile_Click);
            // 
            // BtnOpenFileOriginal
            // 
            this.BtnOpenFileOriginal.Location = new System.Drawing.Point(980, 552);
            this.BtnOpenFileOriginal.Name = "BtnOpenFileOriginal";
            this.BtnOpenFileOriginal.Size = new System.Drawing.Size(103, 34);
            this.BtnOpenFileOriginal.TabIndex = 15;
            this.BtnOpenFileOriginal.TabStop = false;
            this.BtnOpenFileOriginal.Text = "Open Original";
            this.BtnOpenFileOriginal.UseVisualStyleBackColor = true;
            this.BtnOpenFileOriginal.Click += new System.EventHandler(this.BtnOpenFileOriginal_Click);
            // 
            // BtnOpenBrowser
            // 
            this.BtnOpenBrowser.Location = new System.Drawing.Point(857, 573);
            this.BtnOpenBrowser.Name = "BtnOpenBrowser";
            this.BtnOpenBrowser.Size = new System.Drawing.Size(56, 34);
            this.BtnOpenBrowser.TabIndex = 16;
            this.BtnOpenBrowser.TabStop = false;
            this.BtnOpenBrowser.Text = "Open Browser";
            this.BtnOpenBrowser.UseVisualStyleBackColor = true;
            this.BtnOpenBrowser.Click += new System.EventHandler(this.BtnOpenBrowser_Click);
            // 
            // RadioGoogle
            // 
            this.RadioGoogle.AutoSize = true;
            this.RadioGoogle.Location = new System.Drawing.Point(920, 574);
            this.RadioGoogle.Name = "RadioGoogle";
            this.RadioGoogle.Size = new System.Drawing.Size(59, 16);
            this.RadioGoogle.TabIndex = 17;
            this.RadioGoogle.Text = "Google";
            this.RadioGoogle.UseVisualStyleBackColor = true;
            // 
            // RadioBaidu
            // 
            this.RadioBaidu.AutoSize = true;
            this.RadioBaidu.Checked = true;
            this.RadioBaidu.Location = new System.Drawing.Point(920, 592);
            this.RadioBaidu.Name = "RadioBaidu";
            this.RadioBaidu.Size = new System.Drawing.Size(53, 16);
            this.RadioBaidu.TabIndex = 18;
            this.RadioBaidu.TabStop = true;
            this.RadioBaidu.Text = "Baidu";
            this.RadioBaidu.UseVisualStyleBackColor = true;
            // 
            // FrmTranslator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 794);
            this.Controls.Add(this.RadioBaidu);
            this.Controls.Add(this.RadioGoogle);
            this.Controls.Add(this.BtnOpenBrowser);
            this.Controls.Add(this.BtnOpenFileOriginal);
            this.Controls.Add(this.BtnOpenFileTranslated);
            this.Controls.Add(this.BtnAPItochnBox);
            this.Controls.Add(this.LabAPI);
            this.Controls.Add(this.BtnApply);
            this.Controls.Add(this.TxtCHN);
            this.Controls.Add(this.TxtENG);
            this.Controls.Add(this.DfData);
            this.Controls.Add(this.LabTo);
            this.Controls.Add(this.LabFROM);
            this.Controls.Add(this.LstFiles);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmTranslator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDX Game YML Merger";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mainfrm_FormClosed);
            this.Load += new System.EventHandler(this.Mainfrm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Translatorfrm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.DfData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtLog;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ListBox LstFiles;
        private System.Windows.Forms.Label LabFROM;
        private System.Windows.Forms.Label LabTo;
        private System.Windows.Forms.DataGridView DfData;
        private System.Windows.Forms.TextBox TxtENG;
        private System.Windows.Forms.TextBox TxtCHN;
        private System.Windows.Forms.Button BtnApply;
        private System.Windows.Forms.Label LabAPI;
        private System.Windows.Forms.Button BtnAPItochnBox;
        private System.Windows.Forms.Button BtnOpenFileTranslated;
        private System.Windows.Forms.Button BtnOpenFileOriginal;
        private System.Windows.Forms.Button BtnOpenBrowser;
        private System.Windows.Forms.RadioButton RadioGoogle;
        private System.Windows.Forms.RadioButton RadioBaidu;
    }
}

