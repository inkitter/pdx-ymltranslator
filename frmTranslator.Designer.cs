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
            this.TxtAPI = new System.Windows.Forms.TextBox();
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
            this.LabColorR = new System.Windows.Forms.Label();
            this.LabColorG = new System.Windows.Forms.Label();
            this.LabColorH = new System.Windows.Forms.Label();
            this.LabColorW = new System.Windows.Forms.Label();
            this.LabColorL = new System.Windows.Forms.Label();
            this.LabColorGx = new System.Windows.Forms.Label();
            this.LabColorB = new System.Windows.Forms.Label();
            this.LabColorM = new System.Windows.Forms.Label();
            this.LabColorY = new System.Windows.Forms.Label();
            this.LabColorE = new System.Windows.Forms.Label();
            this.LabColorS = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LabColorEnd = new System.Windows.Forms.Label();
            this.LabHelp = new System.Windows.Forms.Label();
            this.CombOldVersion = new System.Windows.Forms.ComboBox();
            this.ChkSaveOnlyTranslated = new System.Windows.Forms.CheckBox();
            this.ChkSimplifiedChinese = new System.Windows.Forms.CheckBox();
            this.ChkTraditionalChinese = new System.Windows.Forms.CheckBox();
            this.TxtFind = new System.Windows.Forms.TextBox();
            this.BtnAllToSimpChn = new System.Windows.Forms.Button();
            this.BtnMergeAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DfData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtAPI
            // 
            this.TxtAPI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtAPI.Font = new System.Drawing.Font("宋体", 10F);
            this.TxtAPI.Location = new System.Drawing.Point(3, 720);
            this.TxtAPI.Multiline = true;
            this.TxtAPI.Name = "TxtAPI";
            this.TxtAPI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtAPI.Size = new System.Drawing.Size(840, 80);
            this.TxtAPI.TabIndex = 3;
            this.TxtAPI.TabStop = false;
            this.TxtAPI.Text = "Baidu API";
            this.TxtAPI.DoubleClick += new System.EventHandler(this.TxtAPI_DoubleClick);
            this.TxtAPI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtAPI_KeyDown);
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.Enabled = false;
            this.BtnSave.Location = new System.Drawing.Point(985, 765);
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
            this.LstFiles.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstFiles.FormattingEnabled = true;
            this.LstFiles.ItemHeight = 12;
            this.LstFiles.Location = new System.Drawing.Point(3, 6);
            this.LstFiles.Name = "LstFiles";
            this.LstFiles.Size = new System.Drawing.Size(185, 544);
            this.LstFiles.TabIndex = 4;
            this.LstFiles.TabStop = false;
            this.LstFiles.SelectedIndexChanged += new System.EventHandler(this.LstFiles_SelectedIndexChanged);
            this.LstFiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LstFiles_KeyDown);
            this.LstFiles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LstFiles_KeyPress);
            this.LstFiles.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LstFiles_KeyUp);
            // 
            // LabFROM
            // 
            this.LabFROM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LabFROM.AutoSize = true;
            this.LabFROM.Location = new System.Drawing.Point(853, 561);
            this.LabFROM.Name = "LabFROM";
            this.LabFROM.Size = new System.Drawing.Size(29, 12);
            this.LabFROM.TabIndex = 6;
            this.LabFROM.Text = "FROM";
            // 
            // LabTo
            // 
            this.LabTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LabTo.AutoSize = true;
            this.LabTo.Location = new System.Drawing.Point(853, 636);
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
            this.DfData.Location = new System.Drawing.Point(193, 6);
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
            this.DfData.Size = new System.Drawing.Size(885, 545);
            this.DfData.TabIndex = 1;
            this.DfData.SelectionChanged += new System.EventHandler(this.DfData_SelectionChanged);
            this.DfData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dfdata_KeyDown);
            // 
            // TxtENG
            // 
            this.TxtENG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtENG.Font = new System.Drawing.Font("宋体", 10F);
            this.TxtENG.Location = new System.Drawing.Point(3, 555);
            this.TxtENG.Multiline = true;
            this.TxtENG.Name = "TxtENG";
            this.TxtENG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtENG.Size = new System.Drawing.Size(840, 80);
            this.TxtENG.TabIndex = 9;
            this.TxtENG.TabStop = false;
            this.TxtENG.Text = "From";
            this.TxtENG.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtENG_KeyDown);
            // 
            // TxtCHN
            // 
            this.TxtCHN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtCHN.Font = new System.Drawing.Font("宋体", 10F);
            this.TxtCHN.Location = new System.Drawing.Point(3, 637);
            this.TxtCHN.Multiline = true;
            this.TxtCHN.Name = "TxtCHN";
            this.TxtCHN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtCHN.Size = new System.Drawing.Size(840, 80);
            this.TxtCHN.TabIndex = 2;
            this.TxtCHN.Text = "To";
            this.TxtCHN.DoubleClick += new System.EventHandler(this.TxtCHN_DoubleClick);
            this.TxtCHN.Enter += new System.EventHandler(this.TxtCHN_Enter);
            this.TxtCHN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCHN_KeyDown);
            this.TxtCHN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCHN_KeyPress);
            // 
            // BtnApply
            // 
            this.BtnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnApply.Location = new System.Drawing.Point(853, 658);
            this.BtnApply.Name = "BtnApply";
            this.BtnApply.Size = new System.Drawing.Size(94, 34);
            this.BtnApply.TabIndex = 0;
            this.BtnApply.TabStop = false;
            this.BtnApply.Text = "Apply (Ctrl+Enter)";
            this.BtnApply.UseVisualStyleBackColor = true;
            this.BtnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // LabAPI
            // 
            this.LabAPI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LabAPI.AutoSize = true;
            this.LabAPI.Location = new System.Drawing.Point(851, 760);
            this.LabAPI.Name = "LabAPI";
            this.LabAPI.Size = new System.Drawing.Size(59, 12);
            this.LabAPI.TabIndex = 12;
            this.LabAPI.Text = "Baidu API";
            // 
            // BtnAPItochnBox
            // 
            this.BtnAPItochnBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAPItochnBox.Location = new System.Drawing.Point(852, 714);
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
            this.BtnOpenFileTranslated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOpenFileTranslated.Location = new System.Drawing.Point(976, 593);
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
            this.BtnOpenFileOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOpenFileOriginal.Location = new System.Drawing.Point(976, 553);
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
            this.BtnOpenBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOpenBrowser.Location = new System.Drawing.Point(853, 574);
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
            this.RadioGoogle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RadioGoogle.AutoSize = true;
            this.RadioGoogle.Location = new System.Drawing.Point(916, 575);
            this.RadioGoogle.Name = "RadioGoogle";
            this.RadioGoogle.Size = new System.Drawing.Size(59, 16);
            this.RadioGoogle.TabIndex = 17;
            this.RadioGoogle.Text = "Google";
            this.RadioGoogle.UseVisualStyleBackColor = true;
            // 
            // RadioBaidu
            // 
            this.RadioBaidu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RadioBaidu.AutoSize = true;
            this.RadioBaidu.Checked = true;
            this.RadioBaidu.Location = new System.Drawing.Point(916, 593);
            this.RadioBaidu.Name = "RadioBaidu";
            this.RadioBaidu.Size = new System.Drawing.Size(53, 16);
            this.RadioBaidu.TabIndex = 18;
            this.RadioBaidu.TabStop = true;
            this.RadioBaidu.Text = "Baidu";
            this.RadioBaidu.UseVisualStyleBackColor = true;
            // 
            // LabColorR
            // 
            this.LabColorR.AutoSize = true;
            this.LabColorR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(86)))), ((int)(((byte)(70)))));
            this.LabColorR.Font = new System.Drawing.Font("宋体", 10F);
            this.LabColorR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabColorR.Location = new System.Drawing.Point(4, 14);
            this.LabColorR.Name = "LabColorR";
            this.LabColorR.Size = new System.Drawing.Size(14, 14);
            this.LabColorR.TabIndex = 21;
            this.LabColorR.Text = "R";
            this.LabColorR.Click += new System.EventHandler(this.LabColorR_Click);
            // 
            // LabColorG
            // 
            this.LabColorG.AutoSize = true;
            this.LabColorG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(225)))), ((int)(((byte)(38)))));
            this.LabColorG.Font = new System.Drawing.Font("宋体", 10F);
            this.LabColorG.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabColorG.Location = new System.Drawing.Point(21, 14);
            this.LabColorG.Name = "LabColorG";
            this.LabColorG.Size = new System.Drawing.Size(14, 14);
            this.LabColorG.TabIndex = 22;
            this.LabColorG.Text = "G";
            this.LabColorG.Click += new System.EventHandler(this.LabColorG_Click);
            // 
            // LabColorH
            // 
            this.LabColorH.AutoSize = true;
            this.LabColorH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.LabColorH.Font = new System.Drawing.Font("宋体", 10F);
            this.LabColorH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabColorH.Location = new System.Drawing.Point(55, 14);
            this.LabColorH.Name = "LabColorH";
            this.LabColorH.Size = new System.Drawing.Size(14, 14);
            this.LabColorH.TabIndex = 23;
            this.LabColorH.Text = "H";
            this.LabColorH.Click += new System.EventHandler(this.LabColorH_Click);
            // 
            // LabColorW
            // 
            this.LabColorW.AutoSize = true;
            this.LabColorW.BackColor = System.Drawing.Color.White;
            this.LabColorW.Font = new System.Drawing.Font("宋体", 10F);
            this.LabColorW.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabColorW.Location = new System.Drawing.Point(38, 31);
            this.LabColorW.Name = "LabColorW";
            this.LabColorW.Size = new System.Drawing.Size(14, 14);
            this.LabColorW.TabIndex = 24;
            this.LabColorW.Text = "W";
            this.LabColorW.Click += new System.EventHandler(this.LabColorW_Click);
            // 
            // LabColorL
            // 
            this.LabColorL.AutoSize = true;
            this.LabColorL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(176)))), ((int)(((byte)(145)))));
            this.LabColorL.Font = new System.Drawing.Font("宋体", 10F);
            this.LabColorL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabColorL.Location = new System.Drawing.Point(72, 14);
            this.LabColorL.Name = "LabColorL";
            this.LabColorL.Size = new System.Drawing.Size(14, 14);
            this.LabColorL.TabIndex = 25;
            this.LabColorL.Text = "L";
            this.LabColorL.Click += new System.EventHandler(this.LabColorL_Click);
            // 
            // LabColorGx
            // 
            this.LabColorGx.AutoSize = true;
            this.LabColorGx.BackColor = System.Drawing.Color.Gray;
            this.LabColorGx.Font = new System.Drawing.Font("宋体", 10F);
            this.LabColorGx.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabColorGx.Location = new System.Drawing.Point(21, 31);
            this.LabColorGx.Name = "LabColorGx";
            this.LabColorGx.Size = new System.Drawing.Size(14, 14);
            this.LabColorGx.TabIndex = 26;
            this.LabColorGx.Text = "g";
            this.LabColorGx.Click += new System.EventHandler(this.LabColorGx_Click);
            // 
            // LabColorB
            // 
            this.LabColorB.AutoSize = true;
            this.LabColorB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.LabColorB.Font = new System.Drawing.Font("宋体", 10F);
            this.LabColorB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabColorB.Location = new System.Drawing.Point(38, 14);
            this.LabColorB.Name = "LabColorB";
            this.LabColorB.Size = new System.Drawing.Size(14, 14);
            this.LabColorB.TabIndex = 27;
            this.LabColorB.Text = "B";
            this.LabColorB.Click += new System.EventHandler(this.LabColorB_Click);
            // 
            // LabColorM
            // 
            this.LabColorM.AutoSize = true;
            this.LabColorM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(53)))), ((int)(((byte)(238)))));
            this.LabColorM.Font = new System.Drawing.Font("宋体", 10F);
            this.LabColorM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabColorM.Location = new System.Drawing.Point(4, 31);
            this.LabColorM.Name = "LabColorM";
            this.LabColorM.Size = new System.Drawing.Size(14, 14);
            this.LabColorM.TabIndex = 28;
            this.LabColorM.Text = "M";
            this.LabColorM.Click += new System.EventHandler(this.LabColorM_Click);
            // 
            // LabColorY
            // 
            this.LabColorY.AutoSize = true;
            this.LabColorY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(52)))));
            this.LabColorY.Font = new System.Drawing.Font("宋体", 10F);
            this.LabColorY.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabColorY.Location = new System.Drawing.Point(55, 31);
            this.LabColorY.Name = "LabColorY";
            this.LabColorY.Size = new System.Drawing.Size(14, 14);
            this.LabColorY.TabIndex = 29;
            this.LabColorY.Text = "Y";
            this.LabColorY.Click += new System.EventHandler(this.LabColorY_Click);
            // 
            // LabColorE
            // 
            this.LabColorE.AutoSize = true;
            this.LabColorE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(255)))), ((int)(((byte)(207)))));
            this.LabColorE.Font = new System.Drawing.Font("宋体", 10F);
            this.LabColorE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabColorE.Location = new System.Drawing.Point(72, 31);
            this.LabColorE.Name = "LabColorE";
            this.LabColorE.Size = new System.Drawing.Size(14, 14);
            this.LabColorE.TabIndex = 30;
            this.LabColorE.Text = "E";
            this.LabColorE.Click += new System.EventHandler(this.LabColorE_Click);
            // 
            // LabColorS
            // 
            this.LabColorS.AutoSize = true;
            this.LabColorS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(156)))), ((int)(((byte)(42)))));
            this.LabColorS.Font = new System.Drawing.Font("宋体", 10F);
            this.LabColorS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabColorS.Location = new System.Drawing.Point(89, 14);
            this.LabColorS.Name = "LabColorS";
            this.LabColorS.Size = new System.Drawing.Size(14, 14);
            this.LabColorS.TabIndex = 31;
            this.LabColorS.Text = "S";
            this.LabColorS.Click += new System.EventHandler(this.LabColorS_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.MediumBlue;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.LabColorEnd);
            this.groupBox1.Controls.Add(this.LabColorS);
            this.groupBox1.Controls.Add(this.LabColorE);
            this.groupBox1.Controls.Add(this.LabColorY);
            this.groupBox1.Controls.Add(this.LabColorM);
            this.groupBox1.Controls.Add(this.LabColorB);
            this.groupBox1.Controls.Add(this.LabColorGx);
            this.groupBox1.Controls.Add(this.LabColorL);
            this.groupBox1.Controls.Add(this.LabColorW);
            this.groupBox1.Controls.Add(this.LabColorH);
            this.groupBox1.Controls.Add(this.LabColorG);
            this.groupBox1.Controls.Add(this.LabColorR);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(969, 636);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(108, 51);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Text Color";
            // 
            // LabColorEnd
            // 
            this.LabColorEnd.AutoSize = true;
            this.LabColorEnd.BackColor = System.Drawing.Color.White;
            this.LabColorEnd.Font = new System.Drawing.Font("宋体", 10F);
            this.LabColorEnd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabColorEnd.Location = new System.Drawing.Point(89, 31);
            this.LabColorEnd.Name = "LabColorEnd";
            this.LabColorEnd.Size = new System.Drawing.Size(14, 14);
            this.LabColorEnd.TabIndex = 32;
            this.LabColorEnd.Text = "!";
            this.LabColorEnd.Click += new System.EventHandler(this.LabColorEnd_Click);
            // 
            // LabHelp
            // 
            this.LabHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LabHelp.AutoSize = true;
            this.LabHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LabHelp.Location = new System.Drawing.Point(937, 636);
            this.LabHelp.Name = "LabHelp";
            this.LabHelp.Size = new System.Drawing.Size(29, 12);
            this.LabHelp.TabIndex = 33;
            this.LabHelp.Text = "Help";
            this.LabHelp.DoubleClick += new System.EventHandler(this.LabHelp_DoubleClick);
            // 
            // CombOldVersion
            // 
            this.CombOldVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CombOldVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CombOldVersion.Enabled = false;
            this.CombOldVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CombOldVersion.FormattingEnabled = true;
            this.CombOldVersion.Location = new System.Drawing.Point(988, 722);
            this.CombOldVersion.Name = "CombOldVersion";
            this.CombOldVersion.Size = new System.Drawing.Size(94, 20);
            this.CombOldVersion.TabIndex = 34;
            this.CombOldVersion.TabStop = false;
            this.CombOldVersion.SelectedIndexChanged += new System.EventHandler(this.CombOldVersion_SelectedIndexChanged);
            // 
            // ChkSaveOnlyTranslated
            // 
            this.ChkSaveOnlyTranslated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ChkSaveOnlyTranslated.AutoSize = true;
            this.ChkSaveOnlyTranslated.Location = new System.Drawing.Point(969, 748);
            this.ChkSaveOnlyTranslated.Name = "ChkSaveOnlyTranslated";
            this.ChkSaveOnlyTranslated.Size = new System.Drawing.Size(114, 16);
            this.ChkSaveOnlyTranslated.TabIndex = 35;
            this.ChkSaveOnlyTranslated.Text = "Only Translated";
            this.ChkSaveOnlyTranslated.UseVisualStyleBackColor = true;
            // 
            // ChkSimplifiedChinese
            // 
            this.ChkSimplifiedChinese.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ChkSimplifiedChinese.AutoSize = true;
            this.ChkSimplifiedChinese.Location = new System.Drawing.Point(948, 768);
            this.ChkSimplifiedChinese.Name = "ChkSimplifiedChinese";
            this.ChkSimplifiedChinese.Size = new System.Drawing.Size(36, 16);
            this.ChkSimplifiedChinese.TabIndex = 36;
            this.ChkSimplifiedChinese.Text = "简";
            this.ChkSimplifiedChinese.UseVisualStyleBackColor = true;
            this.ChkSimplifiedChinese.CheckedChanged += new System.EventHandler(this.ChkSimplifiedChinese_CheckedChanged);
            // 
            // ChkTraditionalChinese
            // 
            this.ChkTraditionalChinese.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ChkTraditionalChinese.AutoSize = true;
            this.ChkTraditionalChinese.Location = new System.Drawing.Point(948, 783);
            this.ChkTraditionalChinese.Name = "ChkTraditionalChinese";
            this.ChkTraditionalChinese.Size = new System.Drawing.Size(36, 16);
            this.ChkTraditionalChinese.TabIndex = 37;
            this.ChkTraditionalChinese.Text = "繁";
            this.ChkTraditionalChinese.UseVisualStyleBackColor = true;
            this.ChkTraditionalChinese.CheckedChanged += new System.EventHandler(this.ChkTraditionalChinese_CheckedChanged);
            // 
            // TxtFind
            // 
            this.TxtFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtFind.Font = new System.Drawing.Font("宋体", 10F);
            this.TxtFind.Location = new System.Drawing.Point(848, 776);
            this.TxtFind.Name = "TxtFind";
            this.TxtFind.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtFind.Size = new System.Drawing.Size(95, 23);
            this.TxtFind.TabIndex = 38;
            this.TxtFind.Text = "Find in Eng";
            this.TxtFind.WordWrap = false;
            this.TxtFind.Enter += new System.EventHandler(this.TxtFind_Enter);
            this.TxtFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtFind_KeyDown);
            this.TxtFind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtFind_KeyUp);
            // 
            // BtnAllToSimpChn
            // 
            this.BtnAllToSimpChn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAllToSimpChn.Location = new System.Drawing.Point(1050, 691);
            this.BtnAllToSimpChn.Name = "BtnAllToSimpChn";
            this.BtnAllToSimpChn.Size = new System.Drawing.Size(32, 23);
            this.BtnAllToSimpChn.TabIndex = 39;
            this.BtnAllToSimpChn.Text = "SC";
            this.BtnAllToSimpChn.UseVisualStyleBackColor = true;
            this.BtnAllToSimpChn.Click += new System.EventHandler(this.BtnAllToSimpChn_Click);
            // 
            // BtnMergeAll
            // 
            this.BtnMergeAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMergeAll.Location = new System.Drawing.Point(993, 690);
            this.BtnMergeAll.Name = "BtnMergeAll";
            this.BtnMergeAll.Size = new System.Drawing.Size(45, 23);
            this.BtnMergeAll.TabIndex = 40;
            this.BtnMergeAll.Text = "Merge";
            this.BtnMergeAll.UseVisualStyleBackColor = true;
            this.BtnMergeAll.Click += new System.EventHandler(this.BtnMergeAll_Click);
            // 
            // FrmTranslator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 801);
            this.Controls.Add(this.BtnMergeAll);
            this.Controls.Add(this.BtnAllToSimpChn);
            this.Controls.Add(this.TxtFind);
            this.Controls.Add(this.ChkTraditionalChinese);
            this.Controls.Add(this.ChkSimplifiedChinese);
            this.Controls.Add(this.ChkSaveOnlyTranslated);
            this.Controls.Add(this.CombOldVersion);
            this.Controls.Add(this.LabHelp);
            this.Controls.Add(this.groupBox1);
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
            this.Controls.Add(this.TxtAPI);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmTranslator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YML Translator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mainfrm_FormClosed);
            this.Load += new System.EventHandler(this.Mainfrm_Load);
            this.SizeChanged += new System.EventHandler(this.FrmTranslator_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Translatorfrm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.DfData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtAPI;
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
        private System.Windows.Forms.Label LabColorR;
        private System.Windows.Forms.Label LabColorG;
        private System.Windows.Forms.Label LabColorH;
        private System.Windows.Forms.Label LabColorW;
        private System.Windows.Forms.Label LabColorL;
        private System.Windows.Forms.Label LabColorGx;
        private System.Windows.Forms.Label LabColorB;
        private System.Windows.Forms.Label LabColorM;
        private System.Windows.Forms.Label LabColorY;
        private System.Windows.Forms.Label LabColorE;
        private System.Windows.Forms.Label LabColorS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LabColorEnd;
        private System.Windows.Forms.Label LabHelp;
        private System.Windows.Forms.ComboBox CombOldVersion;
        private System.Windows.Forms.CheckBox ChkSaveOnlyTranslated;
        private System.Windows.Forms.CheckBox ChkSimplifiedChinese;
        private System.Windows.Forms.CheckBox ChkTraditionalChinese;
        private System.Windows.Forms.TextBox TxtFind;
        private System.Windows.Forms.Button BtnAllToSimpChn;
        private System.Windows.Forms.Button BtnMergeAll;
    }
}

