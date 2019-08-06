using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HqPlayback.Functions;

namespace HqPlayback
{
    public partial class frmHqPlayback : Form
    {
        public frmHqPlayback()
        {
            InitializeComponent();
        }

        private void FrmHqPlayback_Load(object sender, EventArgs e)
        {
            trvStockInfo.Nodes.AddRange(LoadStockInfo.LoadSrcData());
        }


        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string info = txtStockNo.Text;
            string exchNo = info.Substring(0, 1);//交易市场编号
            string stockNo = info.Substring(1, info.Length - 1);//证券代码
            //查找一级父节点
            TreeNode patentNode = trvStockInfo.Nodes.Find(exchNo, false).First();
            //查找一级父节点下的子节点
            TreeNode selectNode = patentNode.Nodes.Find(stockNo, false).First();
            trvStockInfo.Focus();//必须要先令TreeView控件获得焦点
            trvStockInfo.SelectedNode = selectNode;
        }

        private void PbShow_Paint(object sender, PaintEventArgs e)
        {
            int Zoom = 15;  //放大倍数
            Point center = new Point(0, pbShow.Height/2); //原点

            float x1 = (float)(0 * Math.PI * Zoom / 180 + center.X);
            float y1 = (float)(Math.Sin(0 * Math.PI / 180) * 12 * Zoom + center.Y);

            e.Graphics.DrawLine(Pens.Black, 0, center.Y, pbShow.Width, center.Y);  //x坐标轴
            e.Graphics.DrawLine(Pens.Black, center.X, 0, center.X, pbShow.Height);  //y坐标轴

            for (double i = 0.005; i < 360 * 4; i+=0.005)   //角
            {
                float x2 = (float)(i * Math.PI * Zoom / 180 + center.X);
                float y2 = (float)Math.Sin(i * Math.PI / 180) * (-1) * 12 * Zoom + center.Y;


                e.Graphics.DrawLine(Pens.Red, x1, y1, x2, y2);

                x1 = x2;
                y1 = y2;

            }
        }
    }
}
