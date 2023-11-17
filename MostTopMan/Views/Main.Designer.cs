namespace MostTopMan
{
    partial class Main
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
            this.MostTopButton = new System.Windows.Forms.Button();
            this.ReleaseButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LoadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MostTopButton
            // 
            this.MostTopButton.Location = new System.Drawing.Point(272, 213);
            this.MostTopButton.Name = "MostTopButton";
            this.MostTopButton.Size = new System.Drawing.Size(125, 46);
            this.MostTopButton.TabIndex = 0;
            this.MostTopButton.Text = "最前面";
            this.MostTopButton.UseVisualStyleBackColor = true;
            this.MostTopButton.Click += new System.EventHandler(this.MostTopButton_Click);
            // 
            // ReleaseButton
            // 
            this.ReleaseButton.Location = new System.Drawing.Point(141, 213);
            this.ReleaseButton.Name = "ReleaseButton";
            this.ReleaseButton.Size = new System.Drawing.Size(125, 46);
            this.ReleaseButton.TabIndex = 1;
            this.ReleaseButton.Text = "解除";
            this.ReleaseButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect;
            this.dataGridView1.Size = new System.Drawing.Size(385, 195);
            this.dataGridView1.TabIndex = 2;
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(10, 213);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(125, 46);
            this.LoadButton.TabIndex = 3;
            this.LoadButton.Text = "読み込み";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 271);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ReleaseButton);
            this.Controls.Add(this.MostTopButton);
            this.Name = "Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MostTopButton;
        private System.Windows.Forms.Button ReleaseButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button LoadButton;
    }
}

