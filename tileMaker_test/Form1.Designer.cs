namespace tileMaker_test
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.numericResolution = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTileMake = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAreaName = new System.Windows.Forms.TextBox();
            this.tbAreaDesc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxTiles = new System.Windows.Forms.ListBox();
            this.btnAddArea = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.listBoxAreas = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericResolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(581, 38);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(100, 23);
            this.btnLoadImage.TabIndex = 0;
            this.btnLoadImage.Text = "Load map";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // numericResolution
            // 
            this.numericResolution.Location = new System.Drawing.Point(687, 36);
            this.numericResolution.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericResolution.Name = "numericResolution";
            this.numericResolution.Size = new System.Drawing.Size(120, 25);
            this.numericResolution.TabIndex = 1;
            this.numericResolution.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(684, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Resolution";
            // 
            // btnTileMake
            // 
            this.btnTileMake.Location = new System.Drawing.Point(810, 38);
            this.btnTileMake.Name = "btnTileMake";
            this.btnTileMake.Size = new System.Drawing.Size(176, 23);
            this.btnTileMake.TabIndex = 3;
            this.btnTileMake.Text = "make tiles";
            this.btnTileMake.UseVisualStyleBackColor = true;
            this.btnTileMake.Click += new System.EventHandler(this.btnTileMake_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(992, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "-";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(581, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Area list";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Area Name";
            // 
            // tbAreaName
            // 
            this.tbAreaName.Location = new System.Drawing.Point(12, 117);
            this.tbAreaName.Name = "tbAreaName";
            this.tbAreaName.Size = new System.Drawing.Size(376, 25);
            this.tbAreaName.TabIndex = 9;
            // 
            // tbAreaDesc
            // 
            this.tbAreaDesc.Location = new System.Drawing.Point(12, 169);
            this.tbAreaDesc.Multiline = true;
            this.tbAreaDesc.Name = "tbAreaDesc";
            this.tbAreaDesc.Size = new System.Drawing.Size(376, 98);
            this.tbAreaDesc.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Area Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Selected Tile(s)";
            // 
            // listBoxTiles
            // 
            this.listBoxTiles.FormattingEnabled = true;
            this.listBoxTiles.ItemHeight = 15;
            this.listBoxTiles.Location = new System.Drawing.Point(12, 320);
            this.listBoxTiles.Name = "listBoxTiles";
            this.listBoxTiles.Size = new System.Drawing.Size(376, 214);
            this.listBoxTiles.TabIndex = 14;
            // 
            // btnAddArea
            // 
            this.btnAddArea.Location = new System.Drawing.Point(15, 556);
            this.btnAddArea.Name = "btnAddArea";
            this.btnAddArea.Size = new System.Drawing.Size(75, 23);
            this.btnAddArea.TabIndex = 15;
            this.btnAddArea.Text = "Add Area";
            this.btnAddArea.UseVisualStyleBackColor = true;
            this.btnAddArea.Click += new System.EventHandler(this.btnAddArea_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(96, 560);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "-";
            // 
            // listBoxAreas
            // 
            this.listBoxAreas.FormattingEnabled = true;
            this.listBoxAreas.ItemHeight = 15;
            this.listBoxAreas.Location = new System.Drawing.Point(12, 38);
            this.listBoxAreas.Name = "listBoxAreas";
            this.listBoxAreas.Size = new System.Drawing.Size(376, 49);
            this.listBoxAreas.TabIndex = 17;
            this.listBoxAreas.SelectedIndexChanged += new System.EventHandler(this.listBoxAreas_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 636);
            this.Controls.Add(this.listBoxAreas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAddArea);
            this.Controls.Add(this.listBoxTiles);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbAreaDesc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbAreaName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTileMake);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericResolution);
            this.Controls.Add(this.btnLoadImage);
            this.Name = "Form1";
            this.Text = "s";
            ((System.ComponentModel.ISupportInitialize)(this.numericResolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.NumericUpDown numericResolution;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTileMake;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAreaName;
        private System.Windows.Forms.TextBox tbAreaDesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxTiles;
        private System.Windows.Forms.Button btnAddArea;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBoxAreas;
    }
}

