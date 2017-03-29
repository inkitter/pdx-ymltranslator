namespace pdx_ymltranslator
{
    partial class frmTranslator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTranslator));
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.labFROM = new System.Windows.Forms.Label();
            this.labTo = new System.Windows.Forms.Label();
            this.dfData = new System.Windows.Forms.DataGridView();
            this.txtENG = new System.Windows.Forms.TextBox();
            this.txtCHN = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.labAPI = new System.Windows.Forms.Label();
            this.btnAPItochnBox = new System.Windows.Forms.Button();
            this.btnOpenFileTranslated = new System.Windows.Forms.Button();
            this.btnOpenFileOriginal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dfData)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtLog.Location = new System.Drawing.Point(12, 715);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(888, 77);
            this.txtLog.TabIndex = 3;
            this.txtLog.DoubleClick += new System.EventHandler(this.Logtxtbox_DoubleClick);
            this.txtLog.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Logtxtbox_KeyDown);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(988, 757);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 34);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save (Ctrl+S)";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // lstFiles
            // 
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.ItemHeight = 12;
            this.lstFiles.Location = new System.Drawing.Point(12, 6);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(184, 532);
            this.lstFiles.TabIndex = 4;
            this.lstFiles.TabStop = false;
            this.lstFiles.SelectedIndexChanged += new System.EventHandler(this.FilesListbox_SelectedIndexChanged);
            // 
            // labFROM
            // 
            this.labFROM.AutoSize = true;
            this.labFROM.Location = new System.Drawing.Point(906, 550);
            this.labFROM.Name = "labFROM";
            this.labFROM.Size = new System.Drawing.Size(29, 12);
            this.labFROM.TabIndex = 6;
            this.labFROM.Text = "FROM";
            // 
            // labTo
            // 
            this.labTo.AutoSize = true;
            this.labTo.Location = new System.Drawing.Point(906, 635);
            this.labTo.Name = "labTo";
            this.labTo.Size = new System.Drawing.Size(53, 12);
            this.labTo.TabIndex = 7;
            this.labTo.Text = "Trans To";
            // 
            // dfData
            // 
            this.dfData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dfData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dfData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dfData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dfData.Location = new System.Drawing.Point(202, 6);
            this.dfData.MultiSelect = false;
            this.dfData.Name = "dfData";
            this.dfData.ReadOnly = true;
            this.dfData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dfData.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dfData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dfData.RowTemplate.Height = 23;
            this.dfData.RowTemplate.ReadOnly = true;
            this.dfData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dfData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dfData.Size = new System.Drawing.Size(880, 532);
            this.dfData.TabIndex = 1;
            this.dfData.SelectionChanged += new System.EventHandler(this.DataGridALL_SelectionChanged);
            this.dfData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridALL_KeyDown);
            // 
            // txtENG
            // 
            this.txtENG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtENG.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtENG.Location = new System.Drawing.Point(12, 549);
            this.txtENG.Multiline = true;
            this.txtENG.Name = "txtENG";
            this.txtENG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtENG.Size = new System.Drawing.Size(888, 77);
            this.txtENG.TabIndex = 9;
            this.txtENG.TabStop = false;
            this.txtENG.DoubleClick += new System.EventHandler(this.txtENG_DoubleClick);
            this.txtENG.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtENG_KeyDown);
            // 
            // txtCHN
            // 
            this.txtCHN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCHN.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCHN.Location = new System.Drawing.Point(12, 632);
            this.txtCHN.Multiline = true;
            this.txtCHN.Name = "txtCHN";
            this.txtCHN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCHN.Size = new System.Drawing.Size(888, 77);
            this.txtCHN.TabIndex = 2;
            this.txtCHN.DoubleClick += new System.EventHandler(this.txtCHN_DoubleClick);
            this.txtCHN.Enter += new System.EventHandler(this.txtCHN_Enter);
            this.txtCHN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCHN_KeyDown);
            this.txtCHN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCHN_KeyPress);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(906, 656);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(94, 34);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "Apply (Ctrl+Enter)";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.Applybtn_Click);
            // 
            // labAPI
            // 
            this.labAPI.AutoSize = true;
            this.labAPI.Location = new System.Drawing.Point(904, 777);
            this.labAPI.Name = "labAPI";
            this.labAPI.Size = new System.Drawing.Size(59, 12);
            this.labAPI.TabIndex = 12;
            this.labAPI.Text = "Baidu API";
            // 
            // btnAPItochnBox
            // 
            this.btnAPItochnBox.Location = new System.Drawing.Point(906, 700);
            this.btnAPItochnBox.Name = "btnAPItochnBox";
            this.btnAPItochnBox.Size = new System.Drawing.Size(94, 34);
            this.btnAPItochnBox.TabIndex = 13;
            this.btnAPItochnBox.Text = "Copy(Ctrl+↑)";
            this.btnAPItochnBox.UseVisualStyleBackColor = true;
            this.btnAPItochnBox.Click += new System.EventHandler(this.btnAPItochnBox_Click);
            // 
            // btnOpenFileTranslated
            // 
            this.btnOpenFileTranslated.Location = new System.Drawing.Point(979, 592);
            this.btnOpenFileTranslated.Name = "btnOpenFileTranslated";
            this.btnOpenFileTranslated.Size = new System.Drawing.Size(103, 34);
            this.btnOpenFileTranslated.TabIndex = 14;
            this.btnOpenFileTranslated.Text = "Open Translated";
            this.btnOpenFileTranslated.UseVisualStyleBackColor = true;
            this.btnOpenFileTranslated.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnOpenFileOriginal
            // 
            this.btnOpenFileOriginal.Location = new System.Drawing.Point(979, 552);
            this.btnOpenFileOriginal.Name = "btnOpenFileOriginal";
            this.btnOpenFileOriginal.Size = new System.Drawing.Size(103, 34);
            this.btnOpenFileOriginal.TabIndex = 15;
            this.btnOpenFileOriginal.Text = "Open Original";
            this.btnOpenFileOriginal.UseVisualStyleBackColor = true;
            this.btnOpenFileOriginal.Click += new System.EventHandler(this.btnOpenFileOriginal_Click);
            // 
            // frmTranslator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 794);
            this.Controls.Add(this.btnOpenFileOriginal);
            this.Controls.Add(this.btnOpenFileTranslated);
            this.Controls.Add(this.btnAPItochnBox);
            this.Controls.Add(this.labAPI);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.txtCHN);
            this.Controls.Add(this.txtENG);
            this.Controls.Add(this.dfData);
            this.Controls.Add(this.labTo);
            this.Controls.Add(this.labFROM);
            this.Controls.Add(this.lstFiles);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmTranslator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDX Game YML Merger";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mainfrm_FormClosed);
            this.Load += new System.EventHandler(this.Mainfrm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Translatorfrm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dfData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.Label labFROM;
        private System.Windows.Forms.Label labTo;
        private System.Windows.Forms.DataGridView dfData;
        private System.Windows.Forms.TextBox txtENG;
        private System.Windows.Forms.TextBox txtCHN;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label labAPI;
        private System.Windows.Forms.Button btnAPItochnBox;
        private System.Windows.Forms.Button btnOpenFileTranslated;
        private System.Windows.Forms.Button btnOpenFileOriginal;
    }
}

