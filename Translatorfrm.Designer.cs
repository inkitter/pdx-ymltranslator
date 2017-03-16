namespace pdx_ymltranslator
{
    partial class Translatorfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Translatorfrm));
            this.Logtxtbox = new System.Windows.Forms.TextBox();
            this.Savebtn = new System.Windows.Forms.Button();
            this.FilesListbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DataGridALL = new System.Windows.Forms.DataGridView();
            this.txtENG = new System.Windows.Forms.TextBox();
            this.txtCHN = new System.Windows.Forms.TextBox();
            this.Applybtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridALL)).BeginInit();
            this.SuspendLayout();
            // 
            // Logtxtbox
            // 
            this.Logtxtbox.Location = new System.Drawing.Point(12, 715);
            this.Logtxtbox.Multiline = true;
            this.Logtxtbox.Name = "Logtxtbox";
            this.Logtxtbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Logtxtbox.Size = new System.Drawing.Size(856, 77);
            this.Logtxtbox.TabIndex = 1;
            // 
            // Savebtn
            // 
            this.Savebtn.Location = new System.Drawing.Point(935, 758);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(68, 34);
            this.Savebtn.TabIndex = 2;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // FilesListbox
            // 
            this.FilesListbox.FormattingEnabled = true;
            this.FilesListbox.ItemHeight = 12;
            this.FilesListbox.Location = new System.Drawing.Point(12, 30);
            this.FilesListbox.Name = "FilesListbox";
            this.FilesListbox.Size = new System.Drawing.Size(184, 496);
            this.FilesListbox.TabIndex = 4;
            this.FilesListbox.SelectedIndexChanged += new System.EventHandler(this.FilesListbox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Files";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(906, 547);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "ENG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(906, 626);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "CHN";
            // 
            // DataGridALL
            // 
            this.DataGridALL.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridALL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridALL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridALL.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridALL.Location = new System.Drawing.Point(202, 30);
            this.DataGridALL.MultiSelect = false;
            this.DataGridALL.Name = "DataGridALL";
            this.DataGridALL.ReadOnly = true;
            this.DataGridALL.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridALL.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridALL.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.DataGridALL.RowTemplate.Height = 23;
            this.DataGridALL.RowTemplate.ReadOnly = true;
            this.DataGridALL.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridALL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridALL.Size = new System.Drawing.Size(801, 496);
            this.DataGridALL.TabIndex = 8;
            this.DataGridALL.SelectionChanged += new System.EventHandler(this.DataGridALL_SelectionChanged);
            // 
            // txtENG
            // 
            this.txtENG.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtENG.Location = new System.Drawing.Point(12, 544);
            this.txtENG.Multiline = true;
            this.txtENG.Name = "txtENG";
            this.txtENG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtENG.Size = new System.Drawing.Size(888, 77);
            this.txtENG.TabIndex = 9;
            // 
            // txtCHN
            // 
            this.txtCHN.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCHN.Location = new System.Drawing.Point(12, 626);
            this.txtCHN.Multiline = true;
            this.txtCHN.Name = "txtCHN";
            this.txtCHN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCHN.Size = new System.Drawing.Size(888, 77);
            this.txtCHN.TabIndex = 10;
            // 
            // Applybtn
            // 
            this.Applybtn.Location = new System.Drawing.Point(906, 641);
            this.Applybtn.Name = "Applybtn";
            this.Applybtn.Size = new System.Drawing.Size(68, 34);
            this.Applybtn.TabIndex = 11;
            this.Applybtn.Text = "Apply";
            this.Applybtn.UseVisualStyleBackColor = true;
            this.Applybtn.Click += new System.EventHandler(this.Applybtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(874, 718);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "Baidu API";
            // 
            // Translatorfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 794);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Applybtn);
            this.Controls.Add(this.txtCHN);
            this.Controls.Add(this.txtENG);
            this.Controls.Add(this.DataGridALL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilesListbox);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.Logtxtbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Translatorfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDX Game YML Merger";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mainfrm_FormClosed);
            this.Load += new System.EventHandler(this.Mainfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridALL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Logtxtbox;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.ListBox FilesListbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DataGridALL;
        private System.Windows.Forms.TextBox txtENG;
        private System.Windows.Forms.TextBox txtCHN;
        private System.Windows.Forms.Button Applybtn;
        private System.Windows.Forms.Label label4;
    }
}

