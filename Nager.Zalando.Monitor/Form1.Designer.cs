namespace Nager.Zalando.Monitor
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
            this.buttonGetArticle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSeason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSeasonYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewImages = new System.Windows.Forms.DataGridView();
            this.pictureBoxProduct = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxShopUrl = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelModelId = new System.Windows.Forms.Label();
            this.textBoxModelId = new System.Windows.Forms.TextBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFullText = new System.Windows.Forms.TextBox();
            this.comboBoxAgeGroup = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.ColumnOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGetArticle
            // 
            this.buttonGetArticle.Location = new System.Drawing.Point(89, 107);
            this.buttonGetArticle.Name = "buttonGetArticle";
            this.buttonGetArticle.Size = new System.Drawing.Size(75, 23);
            this.buttonGetArticle.TabIndex = 0;
            this.buttonGetArticle.Text = "Get Article";
            this.buttonGetArticle.UseVisualStyleBackColor = true;
            this.buttonGetArticle.Click += new System.EventHandler(this.buttonGetArticle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnColor,
            this.ColumnSeason,
            this.ColumnSeasonYear});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(400, 338);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnName.DataPropertyName = "Name";
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnColor
            // 
            this.ColumnColor.DataPropertyName = "Color";
            this.ColumnColor.HeaderText = "Color";
            this.ColumnColor.Name = "ColumnColor";
            this.ColumnColor.ReadOnly = true;
            this.ColumnColor.Width = 80;
            // 
            // ColumnSeason
            // 
            this.ColumnSeason.DataPropertyName = "Season";
            this.ColumnSeason.HeaderText = "Season";
            this.ColumnSeason.Name = "ColumnSeason";
            this.ColumnSeason.ReadOnly = true;
            this.ColumnSeason.Width = 80;
            // 
            // ColumnSeasonYear
            // 
            this.ColumnSeasonYear.DataPropertyName = "SeasonYear";
            this.ColumnSeasonYear.HeaderText = "Season Year";
            this.ColumnSeasonYear.Name = "ColumnSeasonYear";
            this.ColumnSeasonYear.ReadOnly = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1067, 338);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewImages, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxProduct, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxLogo, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(663, 338);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridViewImages
            // 
            this.dataGridViewImages.AllowUserToAddRows = false;
            this.dataGridViewImages.AllowUserToDeleteRows = false;
            this.dataGridViewImages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewImages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnOrderNumber,
            this.ColumnType});
            this.dataGridViewImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewImages.Location = new System.Drawing.Point(3, 103);
            this.dataGridViewImages.Name = "dataGridViewImages";
            this.dataGridViewImages.ReadOnly = true;
            this.dataGridViewImages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewImages.Size = new System.Drawing.Size(244, 232);
            this.dataGridViewImages.TabIndex = 4;
            this.dataGridViewImages.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // pictureBoxProduct
            // 
            this.pictureBoxProduct.BackColor = System.Drawing.Color.White;
            this.pictureBoxProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxProduct.Location = new System.Drawing.Point(253, 103);
            this.pictureBoxProduct.Name = "pictureBoxProduct";
            this.pictureBoxProduct.Size = new System.Drawing.Size(407, 232);
            this.pictureBoxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProduct.TabIndex = 2;
            this.pictureBoxProduct.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxShopUrl);
            this.panel1.Controls.Add(this.textBoxId);
            this.panel1.Controls.Add(this.labelId);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.labelModelId);
            this.panel1.Controls.Add(this.textBoxModelId);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 94);
            this.panel1.TabIndex = 5;
            // 
            // textBoxShopUrl
            // 
            this.textBoxShopUrl.Location = new System.Drawing.Point(68, 64);
            this.textBoxShopUrl.Name = "textBoxShopUrl";
            this.textBoxShopUrl.Size = new System.Drawing.Size(159, 20);
            this.textBoxShopUrl.TabIndex = 5;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(68, 12);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(159, 20);
            this.textBoxId.TabIndex = 1;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(43, 15);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(19, 13);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "Id:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "ShopUrl:";
            // 
            // labelModelId
            // 
            this.labelModelId.AutoSize = true;
            this.labelModelId.Location = new System.Drawing.Point(14, 41);
            this.labelModelId.Name = "labelModelId";
            this.labelModelId.Size = new System.Drawing.Size(48, 13);
            this.labelModelId.TabIndex = 2;
            this.labelModelId.Text = "ModelId:";
            // 
            // textBoxModelId
            // 
            this.textBoxModelId.Location = new System.Drawing.Point(68, 38);
            this.textBoxModelId.Name = "textBoxModelId";
            this.textBoxModelId.Size = new System.Drawing.Size(159, 20);
            this.textBoxModelId.TabIndex = 3;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.White;
            this.pictureBoxLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLogo.Location = new System.Drawing.Point(253, 3);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(407, 94);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.comboBoxGender);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.textBoxFullText);
            this.splitContainer2.Panel1.Controls.Add(this.comboBoxAgeGroup);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.comboBoxColor);
            this.splitContainer2.Panel1.Controls.Add(this.buttonGetArticle);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Size = new System.Drawing.Size(1067, 492);
            this.splitContainer2.SplitterDistance = 150;
            this.splitContainer2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gender:";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Location = new System.Drawing.Point(89, 84);
            this.comboBoxGender.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(117, 21);
            this.comboBoxGender.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "FullText:";
            // 
            // textBoxFullText
            // 
            this.textBoxFullText.Location = new System.Drawing.Point(89, 63);
            this.textBoxFullText.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFullText.Name = "textBoxFullText";
            this.textBoxFullText.Size = new System.Drawing.Size(160, 20);
            this.textBoxFullText.TabIndex = 5;
            // 
            // comboBoxAgeGroup
            // 
            this.comboBoxAgeGroup.FormattingEnabled = true;
            this.comboBoxAgeGroup.Location = new System.Drawing.Point(89, 41);
            this.comboBoxAgeGroup.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxAgeGroup.Name = "comboBoxAgeGroup";
            this.comboBoxAgeGroup.Size = new System.Drawing.Size(117, 21);
            this.comboBoxAgeGroup.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "AgeGroup:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Color:";
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(89, 19);
            this.comboBoxColor.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(117, 21);
            this.comboBoxColor.TabIndex = 1;
            // 
            // ColumnOrderNumber
            // 
            this.ColumnOrderNumber.DataPropertyName = "OrderNumber";
            this.ColumnOrderNumber.HeaderText = "OrderNumber";
            this.ColumnOrderNumber.Name = "ColumnOrderNumber";
            this.ColumnOrderNumber.ReadOnly = true;
            // 
            // ColumnType
            // 
            this.ColumnType.DataPropertyName = "Type";
            this.ColumnType.HeaderText = "Type";
            this.ColumnType.Name = "ColumnType";
            this.ColumnType.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 492);
            this.Controls.Add(this.splitContainer2);
            this.Name = "Form1";
            this.Text = "change by code";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGetArticle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBoxProduct;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dataGridViewImages;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAgeGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFullText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxShopUrl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxModelId;
        private System.Windows.Forms.Label labelModelId;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSeason;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSeasonYear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
    }
}

