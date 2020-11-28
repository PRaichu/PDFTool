using DSkin.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PDFToolPlug
{
    public partial class PDFTool : DSkin.Controls.DSkinUserControl
    {
        DataTable table = new DataTable();
        List<String> filesPath = new List<string>();
        List<String> filesName = new List<string>();

        public PDFTool()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "请选择文件";
            openFile.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFile.Filter = "(*.doc,*.docx,*.xls,*.xlsx,*.ppt,*.pptx,*.pdf)|*.doc;*.docx;*.xls;*.xlsx;*.ppt;*.pptx;*.pdf";
            openFile.Multiselect = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                String[] getFilesPath = openFile.FileNames;
                String[] getFilesName = openFile.SafeFileNames;
                for(int i = 0; i < getFilesPath.Length; i++)
                {
                    if (!filesPath.Contains(getFilesPath[i]))
                    {
                        filesPath.Add(getFilesPath[i]);
                        filesName.Add(getFilesName[i]);
                        table.Rows.Add(getFilesName[i]);
                    }
                }
                tableGridList.DataSource = null;
                tableGridList.DataSource = table;
            }

        }

        private void PDFTool_Load(object sender, EventArgs e)
        {
            this.tableGridList.Columns.Add(new DSkin.Controls.DSkinGridListColumn { Name = "文件名",Width = 400, DataPropertyName = "fileName" });
            this.tableGridList.Columns.Add(new DSkin.Controls.DSkinGridListColumn { Name = "操作", DataPropertyName = "operation", CellTemplate = typeof(tableBtnTemplate) });

            table.Columns.Add("fileName");
        }

        private void PDFTool_Resize(object sender, EventArgs e)
        {
            this.panelBtnBox.AutoScroll = false;
            this.panelSelect1.Width = this.tableGridList.Width = this.panelBtnBox.Width = this.Width - 300;
            this.panelSelect2.Width = this.panelSelect1.Width - 20;
            this.panelSelect1.Location = new Point((this.Width - this.panelSelect1.Width) / 2, 30);
            this.panelSelect2.Location = new Point(10, 10);
            this.tableGridList.Location = new Point((this.Width - this.tableGridList.Width) / 2, 195);
            this.panelBtnBox.Location = new Point((this.Width - this.panelBtnBox.Width) / 2, 510);
            this.btnSelectFile.Location = new Point((this.panelSelect2.Width - this.btnSelectFile.Width) / 2, (this.panelSelect2.Height - this.btnSelectFile.Height) / 2);
            this.labelSelect.Location = new Point((this.panelSelect2.Width - this.labelSelect.Width) / 2, (this.panelSelect2.Height - this.labelSelect.Height) / 2 + 35);

            this.btnAllSelect.Location = new Point((int)(this.panelBtnBox.Width * 0.1), 30);
            this.btnPartSelect.Location = new Point((int)(this.panelBtnBox.Width * 0.1), 55);
            this.labelFrom.Location = new Point((int)(this.panelBtnBox.Width * 0.1) + 100, 56);
            this.numFrom.Location = new Point((int)(this.panelBtnBox.Width * 0.1) + 120, 53);
            this.labelTo.Location = new Point((int)(this.panelBtnBox.Width * 0.1) + 165, 56);
            this.numTo.Location = new Point((int)(this.panelBtnBox.Width * 0.1) + 185, 53);
            this.btnStart.Location = new Point((int)(this.panelBtnBox.Width * 0.7), (this.panelBtnBox.Height - this.btnStart.Height) / 2);
            
        }

        private void panelSelect2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panelSelect2_DragDrop(object sender, DragEventArgs e)
        {
            String[] files = (String[])e.Data.GetData(DataFormats.FileDrop);
            foreach(String s in files)
            {
                if (isAllowFile(s))
                {

                }
                
            }
        }

        /// <summary>
        /// 判断文件是否是允许的类型
        /// </summary>
        /// <param name="filePath">文件路径</param>
        /// <returns>bool值</returns>
        public bool isAllowFile(String filePath)
        {
            /**
             * 文件扩展名
             * 208207 doc xls ppt wps
             * 8075 docx pptx xlsx zip
             * 3780 pdf
             */

            FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);
            string fileclass = "";
            try
            {
                for (int i = 0; i < 2; i++)
                {
                    fileclass += reader.ReadByte().ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return fileclass == "208207" || fileclass == "8075" || fileclass == "3780";
        }
    }

    public class PlugInfo
    {
        public string GetPlugClassName()
        {
            return "PDFTool";
        }
        public string GetPlugGroupName()
        {
            return "工具";
        }
        public string GetPlugName()
        {
            return "PDF工具";
        }
        public string GetPlugNameSpace()
        {
            return "PDFToolPlug";
        }
        public FontAwesomeChars GetPlugIcon()
        {
            return FontAwesomeChars.icon_file_pdf_o;
        }
        public string GetPlugVersion()
        {
            return "1.0.0.0";
        }
    }
}
