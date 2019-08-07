﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HqPlayback.Functions;
using HqPlayback.Tools;
using LDBizTagDefine;
using LDsdkDefineEx;

namespace HqPlayback
{
    public partial class frmHqPlayback : Form
    {
        /// <summary>
        /// 是否暂停状态
        /// </summary>
        bool isPause = false;

        /// <summary>
        /// 阻塞线程句柄
        /// </summary>
        EventWaitHandle waitHandle = new EventWaitHandle(false, EventResetMode.AutoReset);

        /// <summary>
        /// 延迟时间(毫秒)
        /// </summary>
        int delay = 0;

        public frmHqPlayback()
        {
            InitializeComponent();
        }

        private void FrmHqPlayback_Load(object sender, EventArgs e)
        {
            trvStockInfo.Nodes.AddRange(LoadStockInfo.LoadSrcData());
        }

        /// <summary>
        /// 搜索节点功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string info = txtStockNo.Text;
                string exchNo = info.Substring(0, 1);//交易市场编号
                string stockNo = info.Substring(1, info.Length - 1);//证券代码
                                                                    //查找一级父节点
                TreeNode[] patentNodes = trvStockInfo.Nodes.Find(exchNo, false);
                if (patentNodes.Length == 0)
                {
                    MessageBox.Show("市场编号不存在！", "提示");
                    return;
                }
                TreeNode patentNode = patentNodes.First();
                //查找一级父节点下的子节点
                TreeNode[] selectNodes = patentNode.Nodes.Find(stockNo, false);
                if (selectNodes.Length == 0)
                {
                    MessageBox.Show("证券代码不存在！", "提示");
                    return;
                }
                TreeNode selectNode = selectNodes.First();
                trvStockInfo.Focus();//必须要先令TreeView控件获得焦点
                trvStockInfo.SelectedNode = selectNode;
            }
            catch (Exception error)
            {
                Log.WriteLog(error.Message);
            }
        }

        /// <summary>
        /// 发送数据并且绘制正弦曲线
        /// </summary>
        private void DrawSin(PaintEventArgs e)
        {
            try
            {
                int Zoom = 15;  //放大倍数
                Point center = new Point(0, pbShow.Height / 2); //原点

                float x1 = (float)(0 * Math.PI * Zoom / 180 + center.X);
                float y1 = (float)(Math.Sin(0 * Math.PI / 180) * 11 * Zoom + center.Y);

                e.Graphics.DrawLine(Pens.Black, 0, center.Y, pbShow.Width, center.Y);  //x坐标轴
                e.Graphics.DrawLine(Pens.Black, center.X, 0, center.X, pbShow.Height);  //y坐标轴

                for (double i = 0.004; i < 360 * 4; i += 0.004)   //角
                {
                    if (isPause)
                    {
                        waitHandle.WaitOne();
                    }
                    float x2 = (float)(i * Math.PI * Zoom / 180 + center.X);
                    float y2 = (float)Math.Sin(i * Math.PI / 180) * (-1) * 11 * Zoom + center.Y;

                    e.Graphics.DrawLine(Pens.Red, x1, y1, x2, y2);

                    #region 针对每个券码发送一个生成并发送一个数据包
                    int rows = LoadStockInfo.excelData.GetLength(0);
                    for (int j = 1; j < rows; j++)
                    {
                        //券码
                        string stockNo = LoadStockInfo.excelData[j, 1].ToString();
                        //涨停价
                        double upPrice = Convert.ToDouble(LoadStockInfo.excelData[j, 4]);
                        //跌停价
                        double downPrice = Convert.ToDouble(LoadStockInfo.excelData[j, 5]);
                        //初始价格
                        double price1 = (upPrice + downPrice) / 2.00;
                        double price2 = (upPrice - price1) * Math.Sin(i * Math.PI / 180) + price1;


                    }
                    #endregion

                    x1 = x2;
                    y1 = y2;
                    Thread.Sleep(delay);
                }

                this.btnStart.Invoke(new Action(() => { btnStart.Enabled = true; }));
            }
            catch (Exception error)
            {
                Log.WriteLog(error.Message);
            }
        }

        /// <summary>
        /// 开始
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStart_Click(object sender, EventArgs e)
        {
            delay = txtDelay.Text == "" ? 0 : Convert.ToInt32(txtDelay.Text);
            pbShow.CreateGraphics().Clear(this.BackColor);
            Task.Run(() => DrawSin(new PaintEventArgs(pbShow.CreateGraphics(), Rectangle.Empty)));
            this.btnStart.Enabled = false;//防止多次点击
        }

        /// <summary>
        /// 运行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRun_Click(object sender, EventArgs e)
        {
            delay = txtDelay.Text == "" ? 0 : Convert.ToInt32(txtDelay.Text);
            isPause = false;
            waitHandle.Set();
        }

        /// <summary>
        /// 暂停
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPause_Click(object sender, EventArgs e)
        {
            isPause = true;
        }

        private void TrvStockInfo_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level > 0)
            {
                string[] tagInfo = e.Node.Tag.ToString().Split('/');
                txtCurrentStock.Text = e.Node.Name;
            }
        }
    }
}
