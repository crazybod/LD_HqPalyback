using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HqPlayback.Tools;

namespace HqPlayback.Functions
{
    class LoadStockInfo
    {
        public static object[,] excelData;
        static string Path = Environment.CurrentDirectory;
        /// <summary>
        /// 初始化加载交易市场和证券信息
        /// </summary>
        /// <returns></returns>
        public static TreeNode[] LoadSrcData()
        {
            TreeNode parentNode1 = new TreeNode() { Name = "1", Text = "上海证券" };
            TreeNode parentNode2 = new TreeNode() { Name = "2", Text = "深圳证券" };
            TreeNode parentNode3 = new TreeNode() { Name = "3", Text = "沪深证券" };
            TreeNode parentNode4 = new TreeNode() { Name = "4", Text = "港深证券" };



            excelData = GetExcelRangeData($@"{Path}\Data.xlsx");
            int rows = excelData.GetLength(0);
            for (int i = 1; i < rows; i++)
            {
                switch (excelData[i, 2].ToString())
                {
                    case "1":
                        parentNode1.Nodes.Add(new TreeNode() {
                            Text = excelData[i, 1].ToString() , 
                            Name = excelData[i, 1].ToString(),
                            Tag = excelData[i, 4].ToString() + "/" + excelData[i, 5].ToString() + "/" + excelData[i, 6].ToString()
                        });
                        break;
                    case "2":
                        parentNode2.Nodes.Add(new TreeNode()
                        {
                            Text = excelData[i, 1].ToString(),
                            Name = excelData[i, 1].ToString(),
                            Tag = excelData[i, 4].ToString() + "/" + excelData[i, 5].ToString() + "/" + excelData[i, 6].ToString()
                        });
                        break;
                    case "3":
                        parentNode3.Nodes.Add(new TreeNode()
                        {
                            Text = excelData[i, 1].ToString(),
                            Name = excelData[i, 1].ToString(),
                            Tag = excelData[i, 4].ToString() + "/" + excelData[i, 5].ToString() + "/" + excelData[i, 6].ToString()
                        });
                        break;
                    case "4":
                        parentNode4.Nodes.Add(new TreeNode()
                        {
                            Text = excelData[i, 1].ToString(),
                            Name = excelData[i, 1].ToString(),
                            Tag = excelData[i, 4].ToString() + "/" + excelData[i, 5].ToString() + "/" + excelData[i, 6].ToString()
                        });
                        break;
                }
            }

            List<TreeNode> srcData = new List<TreeNode>() { parentNode1, parentNode2,parentNode3, parentNode4 };
            return srcData.ToArray();
        }

        /// <summary>
        /// 读取Excel中某一范围的数据
        /// </summary>
        /// <param name="excelPath">待读取的Excel文件路径</param>
        /// <returns>存放连续读取的数据的二维数组</returns>
        public static object[,] GetExcelRangeData(string excelPath)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook workBook = null;
            object oMissiong = Missing.Value;
            try
            {
                if (excelApp == null)
                {
                    return null;
                }
                excelApp.Visible = false;
                excelApp.UserControl = true;
                workBook = excelApp.Workbooks.Open(excelPath, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong,
                    oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong);
                if (workBook == null)
                {
                    return null;
                }
                Worksheet workSheet = (Worksheet)workBook.Worksheets.Item[1];

                int rows = workSheet.UsedRange.Cells.Rows.Count; //得到行数

                //使用下述语句可以从头读取到最后，按需使用
                return workSheet.Range["A2" + ":" + "F"+ rows.ToString()].Value2;
            }
            catch (Exception e)
            {
                Log.WriteLog(e.Message);
                return null;
            }
            finally
            {
                //COM组件方式调用完记得释放资源
                if (workBook != null)
                {
                    workBook.Close(false, oMissiong, oMissiong);
                    Marshal.ReleaseComObject(workBook);
                    excelApp.Workbooks.Close();
                    excelApp.Quit();
                    Marshal.ReleaseComObject(excelApp);
                }
            }
        }
    }
}
