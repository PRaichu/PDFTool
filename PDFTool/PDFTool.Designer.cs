
namespace PDFToolPlug
{
    partial class PDFTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDFTool));
            this.panelSelect2 = new DSkin.Controls.DSkinPanel();
            this.labelSelect = new DSkin.Controls.DSkinLabel();
            this.btnSelectFile = new DSkin.Controls.DSkinButton();
            this.panelSelect1 = new DSkin.Controls.DSkinPanel();
            this.panelBtnBox = new DSkin.Controls.DSkinNewPanel();
            this.numTo = new DSkin.Controls.DSkinNumericUpDown();
            this.numFrom = new DSkin.Controls.DSkinNumericUpDown();
            this.btnStart = new DSkin.Controls.DSkinButton();
            this.labelTo = new DSkin.Controls.DSkinLabel();
            this.labelFrom = new DSkin.Controls.DSkinLabel();
            this.btnPartSelect = new DSkin.Controls.DSkinRadioButton();
            this.btnAllSelect = new DSkin.Controls.DSkinRadioButton();
            this.tableGridList = new DSkin.Controls.DSkinGridList();
            this.panelSelect2.SuspendLayout();
            this.panelSelect1.SuspendLayout();
            this.panelBtnBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableGridList)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSelect2
            // 
            this.panelSelect2.AllowDrop = true;
            this.panelSelect2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelSelect2.Controls.Add(this.labelSelect);
            this.panelSelect2.Controls.Add(this.btnSelectFile);
            this.panelSelect2.DuiBackgroundRender.BorderType = DSkin.DirectUI.BorderTypes.Dash;
            this.panelSelect2.DuiBackgroundRender.Radius = 30;
            this.panelSelect2.Location = new System.Drawing.Point(10, 10);
            this.panelSelect2.MaximumSize = new System.Drawing.Size(980, 130);
            this.panelSelect2.MinimumSize = new System.Drawing.Size(480, 130);
            this.panelSelect2.Name = "panelSelect2";
            this.panelSelect2.RightBottom = ((System.Drawing.Image)(resources.GetObject("panelSelect2.RightBottom")));
            this.panelSelect2.Size = new System.Drawing.Size(860, 130);
            this.panelSelect2.TabIndex = 0;
            this.panelSelect2.Text = "dSkinPanel1";
            this.panelSelect2.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelSelect2_DragDrop);
            this.panelSelect2.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelSelect2_DragEnter);
            // 
            // labelSelect
            // 
            this.labelSelect.ForeColor = System.Drawing.Color.Black;
            this.labelSelect.Location = new System.Drawing.Point(355, 86);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(103, 16);
            this.labelSelect.TabIndex = 1;
            this.labelSelect.Text = "或拖拽文件至此处";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.ButtonBorderWidth = 0;
            this.btnSelectFile.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSelectFile.Font = new System.Drawing.Font("黑体", 13F);
            this.btnSelectFile.HoverColor = System.Drawing.Color.Empty;
            this.btnSelectFile.HoverImage = null;
            this.btnSelectFile.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectFile.Image")));
            this.btnSelectFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectFile.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnSelectFile.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSelectFile.Location = new System.Drawing.Point(330, 40);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.NormalImage = null;
            this.btnSelectFile.PressColor = System.Drawing.Color.Empty;
            this.btnSelectFile.PressedImage = null;
            this.btnSelectFile.Radius = 10;
            this.btnSelectFile.ShowButtonBorder = true;
            this.btnSelectFile.Size = new System.Drawing.Size(150, 40);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "    选择文件";
            this.btnSelectFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSelectFile.TextInnerPadding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnSelectFile.TextPadding = 0;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // panelSelect1
            // 
            this.panelSelect1.BackColor = System.Drawing.Color.White;
            this.panelSelect1.Controls.Add(this.panelSelect2);
            this.panelSelect1.DuiBackgroundRender.Radius = 30;
            this.panelSelect1.DuiBackgroundRender.RenderBorders = true;
            this.panelSelect1.Location = new System.Drawing.Point(76, 3);
            this.panelSelect1.MaximumSize = new System.Drawing.Size(1000, 150);
            this.panelSelect1.MinimumSize = new System.Drawing.Size(500, 150);
            this.panelSelect1.Name = "panelSelect1";
            this.panelSelect1.RightBottom = ((System.Drawing.Image)(resources.GetObject("panelSelect1.RightBottom")));
            this.panelSelect1.Size = new System.Drawing.Size(880, 150);
            this.panelSelect1.TabIndex = 1;
            this.panelSelect1.Text = "dSkinPanel2";
            // 
            // panelBtnBox
            // 
            this.panelBtnBox.BackColor = System.Drawing.Color.White;
            this.panelBtnBox.Controls.Add(this.numTo);
            this.panelBtnBox.Controls.Add(this.numFrom);
            this.panelBtnBox.Controls.Add(this.btnStart);
            this.panelBtnBox.Controls.Add(this.labelTo);
            this.panelBtnBox.Controls.Add(this.labelFrom);
            this.panelBtnBox.Controls.Add(this.btnPartSelect);
            this.panelBtnBox.Controls.Add(this.btnAllSelect);
            this.panelBtnBox.DuiBackgroundRender.Radius = 30;
            this.panelBtnBox.DuiBackgroundRender.RenderBorders = true;
            this.panelBtnBox.Location = new System.Drawing.Point(76, 481);
            this.panelBtnBox.MaximumSize = new System.Drawing.Size(1000, 100);
            this.panelBtnBox.MinimumSize = new System.Drawing.Size(500, 100);
            this.panelBtnBox.Name = "panelBtnBox";
            this.panelBtnBox.Size = new System.Drawing.Size(880, 100);
            this.panelBtnBox.TabIndex = 3;
            this.panelBtnBox.Text = "dSkinNewPanel2";
            // 
            // numTo
            // 
            this.numTo.ArrowColor = System.Drawing.Color.DimGray;
            this.numTo.BitmapCache = false;
            this.numTo.Borders.AllColor = System.Drawing.Color.Silver;
            this.numTo.Borders.BottomColor = System.Drawing.Color.Silver;
            this.numTo.Borders.LeftColor = System.Drawing.Color.Silver;
            this.numTo.Borders.RightColor = System.Drawing.Color.Silver;
            this.numTo.Borders.TopColor = System.Drawing.Color.Silver;
            this.numTo.ButtonBaseColor = System.Drawing.Color.Transparent;
            this.numTo.ButtonBorderColor = System.Drawing.Color.LightGray;
            this.numTo.Location = new System.Drawing.Point(287, 45);
            this.numTo.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTo.Name = "numTo";
            this.numTo.RightBottom = ((System.Drawing.Image)(resources.GetObject("numTo.RightBottom")));
            this.numTo.Size = new System.Drawing.Size(41, 20);
            this.numTo.TabIndex = 11;
            // 
            // numFrom
            // 
            this.numFrom.ArrowColor = System.Drawing.Color.DimGray;
            this.numFrom.BitmapCache = false;
            this.numFrom.Borders.AllColor = System.Drawing.Color.Silver;
            this.numFrom.Borders.BottomColor = System.Drawing.Color.Silver;
            this.numFrom.Borders.LeftColor = System.Drawing.Color.Silver;
            this.numFrom.Borders.RightColor = System.Drawing.Color.Silver;
            this.numFrom.Borders.TopColor = System.Drawing.Color.Silver;
            this.numFrom.ButtonBaseColor = System.Drawing.Color.Transparent;
            this.numFrom.ButtonBorderColor = System.Drawing.Color.LightGray;
            this.numFrom.Location = new System.Drawing.Point(217, 45);
            this.numFrom.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numFrom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFrom.Name = "numFrom";
            this.numFrom.RightBottom = ((System.Drawing.Image)(resources.GetObject("numFrom.RightBottom")));
            this.numFrom.Size = new System.Drawing.Size(41, 20);
            this.numFrom.TabIndex = 10;
            // 
            // btnStart
            // 
            this.btnStart.ButtonBorderWidth = 1;
            this.btnStart.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnStart.HoverColor = System.Drawing.Color.Empty;
            this.btnStart.HoverImage = null;
            this.btnStart.Location = new System.Drawing.Point(683, 39);
            this.btnStart.Name = "btnStart";
            this.btnStart.NormalImage = null;
            this.btnStart.PressColor = System.Drawing.Color.Empty;
            this.btnStart.PressedImage = null;
            this.btnStart.Radius = 10;
            this.btnStart.ShowButtonBorder = true;
            this.btnStart.Size = new System.Drawing.Size(100, 28);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "开始转换";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStart.TextPadding = 0;
            // 
            // labelTo
            // 
            this.labelTo.Location = new System.Drawing.Point(264, 49);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(17, 16);
            this.labelTo.TabIndex = 8;
            this.labelTo.Text = "到";
            // 
            // labelFrom
            // 
            this.labelFrom.Location = new System.Drawing.Point(194, 49);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(17, 16);
            this.labelFrom.TabIndex = 7;
            this.labelFrom.Text = "从";
            // 
            // btnPartSelect
            // 
            this.btnPartSelect.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPartSelect.Checked = false;
            this.btnPartSelect.CheckFlagColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(151)))), ((int)(((byte)(2)))));
            this.btnPartSelect.CheckFlagColorDisabled = System.Drawing.Color.Gray;
            this.btnPartSelect.CheckRectBackColorDisabled = System.Drawing.Color.Silver;
            this.btnPartSelect.CheckRectBackColorHighLight = System.Drawing.Color.Transparent;
            this.btnPartSelect.CheckRectBackColorNormal = System.Drawing.Color.Transparent;
            this.btnPartSelect.CheckRectBackColorPressed = System.Drawing.Color.Transparent;
            this.btnPartSelect.CheckRectColor = System.Drawing.Color.DodgerBlue;
            this.btnPartSelect.CheckRectColorDisabled = System.Drawing.Color.Gray;
            this.btnPartSelect.CheckRectWidth = 14;
            this.btnPartSelect.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.btnPartSelect.InnerPaddingWidth = 2;
            this.btnPartSelect.InnerRectInflate = 4;
            this.btnPartSelect.Location = new System.Drawing.Point(89, 45);
            this.btnPartSelect.Name = "btnPartSelect";
            this.btnPartSelect.Size = new System.Drawing.Size(87, 19);
            this.btnPartSelect.SpaceBetweenCheckMarkAndText = 3;
            this.btnPartSelect.TabIndex = 4;
            this.btnPartSelect.Text = "指定页转换";
            this.btnPartSelect.TextColorDisabled = System.Drawing.Color.Gray;
            this.btnPartSelect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // btnAllSelect
            // 
            this.btnAllSelect.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllSelect.Checked = false;
            this.btnAllSelect.CheckFlagColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(151)))), ((int)(((byte)(2)))));
            this.btnAllSelect.CheckFlagColorDisabled = System.Drawing.Color.Gray;
            this.btnAllSelect.CheckRectBackColorDisabled = System.Drawing.Color.Silver;
            this.btnAllSelect.CheckRectBackColorHighLight = System.Drawing.Color.Transparent;
            this.btnAllSelect.CheckRectBackColorNormal = System.Drawing.Color.Transparent;
            this.btnAllSelect.CheckRectBackColorPressed = System.Drawing.Color.Transparent;
            this.btnAllSelect.CheckRectColor = System.Drawing.Color.DodgerBlue;
            this.btnAllSelect.CheckRectColorDisabled = System.Drawing.Color.Gray;
            this.btnAllSelect.CheckRectWidth = 14;
            this.btnAllSelect.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.btnAllSelect.InnerPaddingWidth = 2;
            this.btnAllSelect.InnerRectInflate = 4;
            this.btnAllSelect.Location = new System.Drawing.Point(89, 20);
            this.btnAllSelect.Name = "btnAllSelect";
            this.btnAllSelect.Size = new System.Drawing.Size(75, 19);
            this.btnAllSelect.SpaceBetweenCheckMarkAndText = 3;
            this.btnAllSelect.TabIndex = 3;
            this.btnAllSelect.Text = "全部转换";
            this.btnAllSelect.TextColorDisabled = System.Drawing.Color.Gray;
            this.btnAllSelect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // tableGridList
            // 
            // 
            // 
            // 
            this.tableGridList.BackPageButton.AdaptImage = true;
            this.tableGridList.BackPageButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.tableGridList.BackPageButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.tableGridList.BackPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableGridList.BackPageButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableGridList.BackPageButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.tableGridList.BackPageButton.Location = new System.Drawing.Point(724, 4);
            this.tableGridList.BackPageButton.Name = "BtnBackPage";
            this.tableGridList.BackPageButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.tableGridList.BackPageButton.Radius = 0;
            this.tableGridList.BackPageButton.Size = new System.Drawing.Size(50, 24);
            this.tableGridList.BackPageButton.Text = "上一页";
            this.tableGridList.BackPageButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tableGridList.BackPageButton.TextRenderMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.tableGridList.Borders.AllColor = System.Drawing.Color.Silver;
            this.tableGridList.Borders.BottomColor = System.Drawing.Color.Silver;
            this.tableGridList.Borders.LeftColor = System.Drawing.Color.Silver;
            this.tableGridList.Borders.RightColor = System.Drawing.Color.Silver;
            this.tableGridList.Borders.TopColor = System.Drawing.Color.Silver;
            this.tableGridList.ColumnHeight = 30;
            this.tableGridList.DoubleItemsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.tableGridList.EnabledOrder = false;
            this.tableGridList.EnablePage = false;
            // 
            // 
            // 
            this.tableGridList.FirstPageButton.AdaptImage = true;
            this.tableGridList.FirstPageButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.tableGridList.FirstPageButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.tableGridList.FirstPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableGridList.FirstPageButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableGridList.FirstPageButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.tableGridList.FirstPageButton.Location = new System.Drawing.Point(676, 4);
            this.tableGridList.FirstPageButton.Name = "BtnFistPage";
            this.tableGridList.FirstPageButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.tableGridList.FirstPageButton.Radius = 0;
            this.tableGridList.FirstPageButton.Size = new System.Drawing.Size(44, 24);
            this.tableGridList.FirstPageButton.Text = "首页";
            this.tableGridList.FirstPageButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tableGridList.FirstPageButton.TextRenderMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // 
            // 
            this.tableGridList.GoPageButton.AdaptImage = true;
            this.tableGridList.GoPageButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.tableGridList.GoPageButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tableGridList.GoPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableGridList.GoPageButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableGridList.GoPageButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.tableGridList.GoPageButton.Location = new System.Drawing.Point(290, 4);
            this.tableGridList.GoPageButton.Name = "BtnGoPage";
            this.tableGridList.GoPageButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.tableGridList.GoPageButton.Radius = 0;
            this.tableGridList.GoPageButton.Size = new System.Drawing.Size(44, 24);
            this.tableGridList.GoPageButton.Text = "跳转";
            this.tableGridList.GoPageButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tableGridList.GoPageButton.TextRenderMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.tableGridList.GridLineColor = System.Drawing.Color.Silver;
            this.tableGridList.HeaderFont = new System.Drawing.Font("微软雅黑", 9F);
            this.tableGridList.HoverItemsBackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.tableGridList.HScrollBar.AutoSize = false;
            this.tableGridList.HScrollBar.Fillet = true;
            this.tableGridList.HScrollBar.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableGridList.HScrollBar.Location = new System.Drawing.Point(0, 56);
            this.tableGridList.HScrollBar.Name = "";
            this.tableGridList.HScrollBar.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.tableGridList.HScrollBar.ScrollBarPartitionWidth = new System.Windows.Forms.Padding(5);
            this.tableGridList.HScrollBar.Size = new System.Drawing.Size(880, 12);
            this.tableGridList.HScrollBar.Visible = false;
            // 
            // 
            // 
            this.tableGridList.LastPageButton.AdaptImage = true;
            this.tableGridList.LastPageButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.tableGridList.LastPageButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.tableGridList.LastPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableGridList.LastPageButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableGridList.LastPageButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.tableGridList.LastPageButton.Location = new System.Drawing.Point(832, 4);
            this.tableGridList.LastPageButton.Name = "BtnLastPage";
            this.tableGridList.LastPageButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.tableGridList.LastPageButton.Radius = 0;
            this.tableGridList.LastPageButton.Size = new System.Drawing.Size(44, 24);
            this.tableGridList.LastPageButton.Text = "末页";
            this.tableGridList.LastPageButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tableGridList.LastPageButton.TextRenderMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.tableGridList.Location = new System.Drawing.Point(76, 170);
            this.tableGridList.MaximumSize = new System.Drawing.Size(1000, 300);
            this.tableGridList.MinimumSize = new System.Drawing.Size(500, 300);
            this.tableGridList.Name = "tableGridList";
            // 
            // 
            // 
            this.tableGridList.NextPageButton.AdaptImage = true;
            this.tableGridList.NextPageButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.tableGridList.NextPageButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.tableGridList.NextPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableGridList.NextPageButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableGridList.NextPageButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.tableGridList.NextPageButton.Location = new System.Drawing.Point(778, 4);
            this.tableGridList.NextPageButton.Name = "BtnNextPage";
            this.tableGridList.NextPageButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.tableGridList.NextPageButton.Radius = 0;
            this.tableGridList.NextPageButton.Size = new System.Drawing.Size(50, 24);
            this.tableGridList.NextPageButton.Text = "下一页";
            this.tableGridList.NextPageButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tableGridList.NextPageButton.TextRenderMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.tableGridList.SelectedItem = null;
            this.tableGridList.SelectedItemsBackColor = System.Drawing.Color.Transparent;
            this.tableGridList.Size = new System.Drawing.Size(880, 300);
            this.tableGridList.TabIndex = 3;
            this.tableGridList.Text = "dSkinGridList1";
            // 
            // 
            // 
            this.tableGridList.VScrollBar.AutoSize = false;
            this.tableGridList.VScrollBar.BitmapCache = true;
            this.tableGridList.VScrollBar.Fillet = true;
            this.tableGridList.VScrollBar.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableGridList.VScrollBar.LargeChange = 1000;
            this.tableGridList.VScrollBar.Location = new System.Drawing.Point(867, 1);
            this.tableGridList.VScrollBar.Margin = new System.Windows.Forms.Padding(1);
            this.tableGridList.VScrollBar.Maximum = 10000;
            this.tableGridList.VScrollBar.Name = "";
            this.tableGridList.VScrollBar.ScrollBarPartitionWidth = new System.Windows.Forms.Padding(5);
            this.tableGridList.VScrollBar.Size = new System.Drawing.Size(12, 267);
            this.tableGridList.VScrollBar.SmallChange = 500;
            this.tableGridList.VScrollBar.Visible = false;
            // 
            // PDFTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.panelBtnBox);
            this.Controls.Add(this.panelSelect1);
            this.Controls.Add(this.tableGridList);
            this.DuiBackgroundRender.BorderWidth = 0;
            this.Name = "PDFTool";
            this.Size = new System.Drawing.Size(1087, 643);
            this.Load += new System.EventHandler(this.PDFTool_Load);
            this.Resize += new System.EventHandler(this.PDFTool_Resize);
            this.panelSelect2.ResumeLayout(false);
            this.panelSelect2.PerformLayout();
            this.panelSelect1.ResumeLayout(false);
            this.panelBtnBox.ResumeLayout(false);
            this.panelBtnBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableGridList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DSkin.Controls.DSkinPanel panelSelect2;
        private DSkin.Controls.DSkinButton btnSelectFile;
        private DSkin.Controls.DSkinPanel panelSelect1;
        private DSkin.Controls.DSkinNewPanel panelBtnBox;
        private DSkin.Controls.DSkinRadioButton btnPartSelect;
        private DSkin.Controls.DSkinRadioButton btnAllSelect;
        private DSkin.Controls.DSkinLabel labelSelect;
        private DSkin.Controls.DSkinButton btnStart;
        private DSkin.Controls.DSkinLabel labelTo;
        private DSkin.Controls.DSkinLabel labelFrom;
        private DSkin.Controls.DSkinGridList tableGridList;
        private DSkin.Controls.DSkinNumericUpDown numTo;
        private DSkin.Controls.DSkinNumericUpDown numFrom;
    }
}
