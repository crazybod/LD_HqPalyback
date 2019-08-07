namespace HqPlayback
{
    partial class frmHqPlayback
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStockNo = new System.Windows.Forms.TextBox();
            this.trvStockInfo = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.pbShow = new System.Windows.Forms.PictureBox();
            this.txtCurrentStock = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUpLimitPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDownLimitPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbShow)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtStockNo);
            this.splitContainer1.Panel1.Controls.Add(this.trvStockInfo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.txtDownLimitPrice);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.txtUpLimitPrice);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.txtCurrentStock);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.txtDelay);
            this.splitContainer1.Panel2.Controls.Add(this.btnPause);
            this.splitContainer1.Panel2.Controls.Add(this.btnRun);
            this.splitContainer1.Panel2.Controls.Add(this.btnStart);
            this.splitContainer1.Panel2.Controls.Add(this.pbShow);
            this.splitContainer1.Size = new System.Drawing.Size(1079, 600);
            this.splitContainer1.SplitterDistance = 332;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(227, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 25);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "证券代码";
            // 
            // txtStockNo
            // 
            this.txtStockNo.Location = new System.Drawing.Point(85, 19);
            this.txtStockNo.Multiline = true;
            this.txtStockNo.Name = "txtStockNo";
            this.txtStockNo.Size = new System.Drawing.Size(124, 25);
            this.txtStockNo.TabIndex = 1;
            // 
            // trvStockInfo
            // 
            this.trvStockInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.trvStockInfo.Location = new System.Drawing.Point(3, 86);
            this.trvStockInfo.Name = "trvStockInfo";
            this.trvStockInfo.Size = new System.Drawing.Size(299, 505);
            this.trvStockInfo.TabIndex = 0;
            this.trvStockInfo.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TrvStockInfo_AfterSelect);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "延时毫秒";
            // 
            // txtDelay
            // 
            this.txtDelay.Location = new System.Drawing.Point(114, 19);
            this.txtDelay.Multiline = true;
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(68, 25);
            this.txtDelay.TabIndex = 4;
            this.txtDelay.Text = "0";
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(618, 258);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(82, 31);
            this.btnPause.TabIndex = 3;
            this.btnPause.Text = "暂停";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(618, 189);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(82, 31);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "运行";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(618, 106);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(82, 31);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // pbShow
            // 
            this.pbShow.Location = new System.Drawing.Point(18, 103);
            this.pbShow.Name = "pbShow";
            this.pbShow.Size = new System.Drawing.Size(549, 485);
            this.pbShow.TabIndex = 0;
            this.pbShow.TabStop = false;
            // 
            // txtCurrentStock
            // 
            this.txtCurrentStock.Location = new System.Drawing.Point(312, 19);
            this.txtCurrentStock.Multiline = true;
            this.txtCurrentStock.Name = "txtCurrentStock";
            this.txtCurrentStock.Size = new System.Drawing.Size(100, 25);
            this.txtCurrentStock.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "当前券码";
            // 
            // txtUpLimitPrice
            // 
            this.txtUpLimitPrice.Location = new System.Drawing.Point(114, 63);
            this.txtUpLimitPrice.Multiline = true;
            this.txtUpLimitPrice.Name = "txtUpLimitPrice";
            this.txtUpLimitPrice.Size = new System.Drawing.Size(68, 25);
            this.txtUpLimitPrice.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "涨停价格";
            // 
            // txtDownLimitPrice
            // 
            this.txtDownLimitPrice.Location = new System.Drawing.Point(312, 63);
            this.txtDownLimitPrice.Multiline = true;
            this.txtDownLimitPrice.Name = "txtDownLimitPrice";
            this.txtDownLimitPrice.Size = new System.Drawing.Size(100, 25);
            this.txtDownLimitPrice.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "跌停价格";
            // 
            // frmHqPlayback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 600);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmHqPlayback";
            this.Text = "行情回放软件";
            this.Load += new System.EventHandler(this.FrmHqPlayback_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView trvStockInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStockNo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pbShow;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDelay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCurrentStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDownLimitPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUpLimitPrice;
    }
}

