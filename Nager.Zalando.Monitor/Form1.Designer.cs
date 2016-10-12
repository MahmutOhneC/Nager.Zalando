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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainerProduct = new System.Windows.Forms.SplitContainer();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.splitContainerImage = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFullText = new System.Windows.Forms.TextBox();
            this.comboBoxAgeGroup = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerProduct)).BeginInit();
            this.splitContainerProduct.Panel1.SuspendLayout();
            this.splitContainerProduct.Panel2.SuspendLayout();
            this.splitContainerProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerImage)).BeginInit();
            this.splitContainerImage.Panel1.SuspendLayout();
            this.splitContainerImage.Panel2.SuspendLayout();
            this.splitContainerImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGetArticle
            // 
            this.buttonGetArticle.Location = new System.Drawing.Point(134, 158);
            this.buttonGetArticle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGetArticle.Name = "buttonGetArticle";
            this.buttonGetArticle.Size = new System.Drawing.Size(112, 35);
            this.buttonGetArticle.TabIndex = 0;
            this.buttonGetArticle.Text = "Get Article";
            this.buttonGetArticle.UseVisualStyleBackColor = true;
            this.buttonGetArticle.Click += new System.EventHandler(this.buttonGetArticle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(628, 553);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainerProduct);
            this.splitContainer1.Size = new System.Drawing.Size(1382, 553);
            this.splitContainer1.SplitterDistance = 628;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 2;
            // 
            // splitContainerProduct
            // 
            this.splitContainerProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerProduct.Location = new System.Drawing.Point(0, 0);
            this.splitContainerProduct.Name = "splitContainerProduct";
            // 
            // splitContainerProduct.Panel1
            // 
            this.splitContainerProduct.Panel1.Controls.Add(this.propertyGrid1);
            // 
            // splitContainerProduct.Panel2
            // 
            this.splitContainerProduct.Panel2.Controls.Add(this.splitContainerImage);
            this.splitContainerProduct.Size = new System.Drawing.Size(748, 553);
            this.splitContainerProduct.SplitterDistance = 249;
            this.splitContainerProduct.TabIndex = 5;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(249, 553);
            this.propertyGrid1.TabIndex = 3;
            // 
            // splitContainerImage
            // 
            this.splitContainerImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerImage.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerImage.IsSplitterFixed = true;
            this.splitContainerImage.Location = new System.Drawing.Point(0, 0);
            this.splitContainerImage.Name = "splitContainerImage";
            this.splitContainerImage.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerImage.Panel1
            // 
            this.splitContainerImage.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainerImage.Panel2
            // 
            this.splitContainerImage.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainerImage.Size = new System.Drawing.Size(495, 553);
            this.splitContainerImage.SplitterDistance = 302;
            this.splitContainerImage.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(495, 302);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(495, 247);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.splitContainer2.Size = new System.Drawing.Size(1382, 757);
            this.splitContainer2.SplitterDistance = 198;
            this.splitContainer2.SplitterWidth = 6;
            this.splitContainer2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "FullText:";
            // 
            // textBoxFullText
            // 
            this.textBoxFullText.Location = new System.Drawing.Point(134, 97);
            this.textBoxFullText.Name = "textBoxFullText";
            this.textBoxFullText.Size = new System.Drawing.Size(238, 26);
            this.textBoxFullText.TabIndex = 5;
            // 
            // comboBoxAgeGroup
            // 
            this.comboBoxAgeGroup.FormattingEnabled = true;
            this.comboBoxAgeGroup.Location = new System.Drawing.Point(134, 63);
            this.comboBoxAgeGroup.Name = "comboBoxAgeGroup";
            this.comboBoxAgeGroup.Size = new System.Drawing.Size(173, 28);
            this.comboBoxAgeGroup.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "AgeGroup:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Color:";
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(134, 29);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(173, 28);
            this.comboBoxColor.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gender:";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Location = new System.Drawing.Point(134, 129);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(173, 28);
            this.comboBoxGender.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 757);
            this.Controls.Add(this.splitContainer2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "change by code";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainerProduct.Panel1.ResumeLayout(false);
            this.splitContainerProduct.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerProduct)).EndInit();
            this.splitContainerProduct.ResumeLayout(false);
            this.splitContainerImage.Panel1.ResumeLayout(false);
            this.splitContainerImage.Panel1.PerformLayout();
            this.splitContainerImage.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerImage)).EndInit();
            this.splitContainerImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainerProduct;
        private System.Windows.Forms.SplitContainer splitContainerImage;
        private System.Windows.Forms.ComboBox comboBoxAgeGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFullText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxGender;
    }
}

