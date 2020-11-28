
namespace PDFToolPlug
{
    partial class tableBtnTemplate
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

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.duiButton1 = new DSkin.DirectUI.DuiButton();
            // 
            // duiButton1
            // 
            this.duiButton1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.duiButton1.HoverColor = System.Drawing.Color.Empty;
            this.duiButton1.Location = new System.Drawing.Point(0, 0);
            this.duiButton1.Name = "duiButton1";
            this.duiButton1.PressColor = System.Drawing.Color.Empty;
            this.duiButton1.Size = new System.Drawing.Size(80, 25);
            this.duiButton1.Text = "删除";
            this.duiButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableBtnTemplate
            // 
            this.Controls.Add(this.duiButton1);
            this.Size = new System.Drawing.Size(87, 30);

        }

        #endregion

        private DSkin.DirectUI.DuiButton duiButton1;
    }
}
