using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using Microsoft.Office.Interop.Excel;
using System.Drawing.Printing;

namespace KiemtraExcel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog
            {
                ShowNewFolderButton = true
            };
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                filepath.Text = folderDlg.SelectedPath;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SucessList.Items.Clear();
            ErrorList.Items.Clear();
            if (filepath.Text==string.Empty)
            {
                label5.Text = "Vui lòng nhập đầy đủ thông tin";
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa Excel không? Xin hãy nhớ dùng bản copy để tránh ảnh hưởng bản gốc.");
            if (result == DialogResult.OK)
            {
                Check(filepath.Text);
            }
        }

        public void Check(string filepath)
        {
            List<string> fileList = FileList(filepath);
            // Suy nghĩ xem có cần try catch không//
            Excel.Application oXL = new Excel.Application
            {
                Visible = false
            };
            Excel.Workbooks books = oXL.Workbooks;
            foreach (var item in fileList)
            {
                Excel._Workbook oWB = books.Open(item);
                Excel.Sheets xlWorkSheets = oWB.Sheets;
                // Duyệt qua từng sheet
                    Excel._Worksheet oSheet = xlWorkSheets[1];
                label5.Text = $"Đang thực hiện: {item},{oSheet.Name}";
                label5.ForeColor = Color.Red;
                int changing = 0;
                for (int j = 3; j < 10; j++)
                {
                    if (oSheet.Cells[j, 1].Value != null)
                    {
                        if (oSheet.Cells[j, 1].Value.ToString().StartsWith("Người gửi yêu cầu"))
                        {
                            oSheet.Cells[j, 1].Value = "Người gửi yêu cầu : Trưởng phòng kiểm nghiệm";
                            changing += 1;
                            break;
                        }
                    }
                }
                int flag = 2;
                // Biến để kiểm tra xem có phải nhóm sản phẩm hay không
                bool isSPGroup = false;
                for (int j = 15; j < 25 && flag !=0; j++)
                {
                    for (int i = 15; i < 25; i++)
                    {
                        if (oSheet.Cells[j, i].Value != null)
                        {
                            if (oSheet.Cells[j, i].Value.ToString()== "P.Trưởng phòng kiểm nghiệm")
                            {
                                oSheet.Cells[j, i].Value = "Trưởng phòng kiểm nghiệm";
                                changing += 1;
                                flag -= 1;
                                break;
                            }
                        }   
                    }
                    for (int i = 15; i < 25; i++)
                    {
                        if (oSheet.Cells[j, i].Value != null)
                        {
                            if (oSheet.Cells[j, i].Value.ToString().StartsWith("Tô"))
                            {
                                oSheet.Cells[j, i].Value = "Nguyễn Thanh Tùng";
                                if (oSheet.Cells[j, 1].Value.ToString().StartsWith("Nguyễn Thị Thúy Ái"))
                                {
                                    oSheet.Cells[j, 1].Value = "Lê Phượng Liên";
                                    isSPGroup = true;
                                    changing -= 1;
                                }
                                changing += 1;
                                flag -= 1;
                                break;
                            }
                        }
                    }
                }
                if (isSPGroup)
                {
                    for (int j = 3; j < 10; j++)
                    {
                        if (oSheet.Cells[j, 1].Value != null)
                        {
                            if (oSheet.Cells[j, 1].Value.ToString().StartsWith("Người nhận yêu cầu"))
                            {
                                oSheet.Cells[j, 1].Value = "Người nhận yêu cầu : Tổ sản phẩm";
                                changing += 1;
                                break;
                            }
                        }
                    }
                }


                if (changing == 3)
                {
                    SucessList.Items.Add($"{item},{oSheet.Name}");
                }
                else
                {
                    ErrorList.Items.Add($"{item},{oSheet.Name}");
                }
                
                oWB.Close(true);        
            }
        }

        public List<string> FileList(string filepath)
        {
            string[] kq = Directory.GetFiles(filepath, "*.xlsx");
            var kqlist = kq.ToList();
            int t = filepath.Length;
            kqlist.RemoveAll(s => s[t + 1] == '~');
            return kqlist;
        }


        private void ErrorList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (filepath.Text == string.Empty)
            {
                label5.Text = "Vui lòng nhập đầy đủ thông tin";
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn in Excel trong thư mục hay không");
            if (result == DialogResult.OK)
            {
                List<string> fileList = FileList(filepath.Text);
                Excel.Application oXL = new Excel.Application
                {
                    Visible = false
                };
                Excel.Workbooks books = oXL.Workbooks;
                var printers = System.Drawing.Printing.PrinterSettings.InstalledPrinters;
                string printername = SucessList.GetItemText(SucessList.SelectedItem);
                int printerIndex = 0;
                foreach (string s in printers)
                {
                    if (s.Equals(printername))
                    {
                        break;
                    }
                    printerIndex++;
                }
                foreach (var item in fileList)
                {
                    Excel._Workbook oWB = books.Open(item);
                    Excel.Sheets xlWorkSheets = oWB.Sheets;
                    // Duyệt qua từng sheet
                    Excel._Worksheet oSheet = xlWorkSheets[1];
                    label5.Text = $"Đang thực hiện: {item},{oSheet.Name}";
                    label5.ForeColor = Color.Red;
                    oSheet.PrintOut(Type.Missing, Type.Missing, Type.Missing, Type.Missing, printers[printerIndex], Type.Missing, Type.Missing, Type.Missing);
                    ErrorList.Items.Add($"{item},{oSheet.Name}");
                    oWB.Close(true);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var printers = System.Drawing.Printing.PrinterSettings.InstalledPrinters;
            foreach (String s in printers)
                SucessList.Items.Add($"{s}");
        }
    }
}
