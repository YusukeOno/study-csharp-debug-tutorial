namespace Csv2DataGridView
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.csvFilePath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "CSV";
            // 
            // csvFilePath
            // 
            this.csvFilePath.Location = new System.Drawing.Point(80, 30);
            this.csvFilePath.Name = "csvFilePath";
            this.csvFilePath.Size = new System.Drawing.Size(297, 19);
            this.csvFilePath.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "選択";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(464, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "開始";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnA,
            this.ColumnB,
            this.ColumnC,
            this.ColumnD,
            this.ColumnE,
            this.ColumnF,
            this.ColumnG,
            this.ColumnH,
            this.ColumnI,
            this.ColumnJ,
            this.ColumnK,
            this.ColumnL,
            this.ColumnM,
            this.ColumnN,
            this.ColumnO,
            this.ColumnP});
            this.dataGridView1.Location = new System.Drawing.Point(41, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(498, 208);
            this.dataGridView1.TabIndex = 4;
            // 
            // ColumnA
            // 
            this.ColumnA.HeaderText = "ColumnA";
            this.ColumnA.Name = "ColumnA";
            // 
            // ColumnB
            // 
            this.ColumnB.HeaderText = "ColumnB";
            this.ColumnB.Name = "ColumnB";
            // 
            // ColumnC
            // 
            this.ColumnC.HeaderText = "ColumnC";
            this.ColumnC.Name = "ColumnC";
            // 
            // ColumnD
            // 
            this.ColumnD.HeaderText = "ColumnD";
            this.ColumnD.Name = "ColumnD";
            // 
            // ColumnE
            // 
            this.ColumnE.HeaderText = "ColumnE";
            this.ColumnE.Name = "ColumnE";
            // 
            // ColumnF
            // 
            this.ColumnF.HeaderText = "ColumnF";
            this.ColumnF.Name = "ColumnF";
            // 
            // ColumnG
            // 
            this.ColumnG.HeaderText = "ColumnG";
            this.ColumnG.Name = "ColumnG";
            // 
            // ColumnH
            // 
            this.ColumnH.HeaderText = "ColumnH";
            this.ColumnH.Name = "ColumnH";
            // 
            // ColumnI
            // 
            this.ColumnI.HeaderText = "ColumnI";
            this.ColumnI.Name = "ColumnI";
            // 
            // ColumnJ
            // 
            this.ColumnJ.HeaderText = "ColumnJ";
            this.ColumnJ.Name = "ColumnJ";
            // 
            // ColumnK
            // 
            this.ColumnK.HeaderText = "ColumnK";
            this.ColumnK.Name = "ColumnK";
            // 
            // ColumnL
            // 
            this.ColumnL.HeaderText = "ColumnL";
            this.ColumnL.Name = "ColumnL";
            // 
            // ColumnM
            // 
            this.ColumnM.HeaderText = "ColumnM";
            this.ColumnM.Name = "ColumnM";
            // 
            // ColumnN
            // 
            this.ColumnN.HeaderText = "ColumnN";
            this.ColumnN.Name = "ColumnN";
            // 
            // ColumnO
            // 
            this.ColumnO.HeaderText = "ColumnO";
            this.ColumnO.Name = "ColumnO";
            // 
            // ColumnP
            // 
            this.ColumnP.HeaderText = "ColumnP";
            this.ColumnP.Name = "ColumnP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 338);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.csvFilePath);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox csvFilePath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnG;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnK;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnP;
    }
}

