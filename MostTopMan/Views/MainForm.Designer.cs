﻿namespace TopMostMan
{
    partial class MainForm
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
            this.TopMostButton = new System.Windows.Forms.Button();
            this.ReleaseButton = new System.Windows.Forms.Button();
            this.ProcessGrid = new System.Windows.Forms.DataGridView();
            this.LoadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TopMostButton
            // 
            this.TopMostButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TopMostButton.Location = new System.Drawing.Point(272, 213);
            this.TopMostButton.Name = "TopMostButton";
            this.TopMostButton.Size = new System.Drawing.Size(125, 46);
            this.TopMostButton.TabIndex = 3;
            this.TopMostButton.Text = "最前面";
            this.TopMostButton.UseVisualStyleBackColor = true;
            // 
            // ReleaseButton
            // 
            this.ReleaseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ReleaseButton.Location = new System.Drawing.Point(141, 213);
            this.ReleaseButton.Name = "ReleaseButton";
            this.ReleaseButton.Size = new System.Drawing.Size(125, 46);
            this.ReleaseButton.TabIndex = 2;
            this.ReleaseButton.Text = "解除";
            this.ReleaseButton.UseVisualStyleBackColor = true;
            // 
            // ProcessGrid
            // 
            this.ProcessGrid.AllowUserToAddRows = false;
            this.ProcessGrid.AllowUserToDeleteRows = false;
            this.ProcessGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProcessGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProcessGrid.Location = new System.Drawing.Point(12, 12);
            this.ProcessGrid.MultiSelect = false;
            this.ProcessGrid.Name = "ProcessGrid";
            this.ProcessGrid.RowHeadersVisible = false;
            this.ProcessGrid.RowTemplate.Height = 21;
            this.ProcessGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProcessGrid.Size = new System.Drawing.Size(385, 195);
            this.ProcessGrid.TabIndex = 0;
            // 
            // LoadButton
            // 
            this.LoadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoadButton.Location = new System.Drawing.Point(10, 213);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(125, 46);
            this.LoadButton.TabIndex = 1;
            this.LoadButton.Text = "読み込み";
            this.LoadButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 271);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.ProcessGrid);
            this.Controls.Add(this.ReleaseButton);
            this.Controls.Add(this.TopMostButton);
            this.Name = "MainForm";
            this.Text = "最前面アプリ";
            ((System.ComponentModel.ISupportInitialize)(this.ProcessGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView ProcessGrid;
        internal System.Windows.Forms.Button TopMostButton;
        internal System.Windows.Forms.Button ReleaseButton;
        internal System.Windows.Forms.Button LoadButton;
    }
}

