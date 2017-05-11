namespace BUS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.tabMenu = new DevExpress.XtraTab.XtraTabControl();
            this.tabTiepNhanDaiLy = new DevExpress.XtraTab.XtraTabPage();
            this.tabLapPhieuXuatHang = new DevExpress.XtraTab.XtraTabPage();
            this.tabTimKiemDaiLy = new DevExpress.XtraTab.XtraTabPage();
            this.tabLapPhieuThuTien = new DevExpress.XtraTab.XtraTabPage();
            this.tabLapBaoCao = new DevExpress.XtraTab.XtraTabPage();
            this.tabSuaDoiQuyDinh = new DevExpress.XtraTab.XtraTabPage();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnMinimize = new DevExpress.XtraEditors.SimpleButton();
            this.pnlAction = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.img = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tabMenu)).BeginInit();
            this.tabMenu.SuspendLayout();
            this.pnlAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Springtime";
            // 
            // tabMenu
            // 
            this.tabMenu.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.tabMenu.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal;
            this.tabMenu.Location = new System.Drawing.Point(43, 96);
            this.tabMenu.MultiLine = DevExpress.Utils.DefaultBoolean.True;
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedTabPage = this.tabTiepNhanDaiLy;
            this.tabMenu.Size = new System.Drawing.Size(787, 431);
            this.tabMenu.TabIndex = 0;
            this.tabMenu.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabTiepNhanDaiLy,
            this.tabLapPhieuXuatHang,
            this.tabTimKiemDaiLy,
            this.tabLapPhieuThuTien,
            this.tabLapBaoCao,
            this.tabSuaDoiQuyDinh});
            // 
            // tabTiepNhanDaiLy
            // 
            this.tabTiepNhanDaiLy.AutoScroll = true;
            this.tabTiepNhanDaiLy.Image = ((System.Drawing.Image)(resources.GetObject("tabTiepNhanDaiLy.Image")));
            this.tabTiepNhanDaiLy.Name = "tabTiepNhanDaiLy";
            this.tabTiepNhanDaiLy.Size = new System.Drawing.Size(619, 400);
            this.tabTiepNhanDaiLy.Text = "Tiếp Nhận Đại Lý";
            // 
            // tabLapPhieuXuatHang
            // 
            this.tabLapPhieuXuatHang.Image = ((System.Drawing.Image)(resources.GetObject("tabLapPhieuXuatHang.Image")));
            this.tabLapPhieuXuatHang.Name = "tabLapPhieuXuatHang";
            this.tabLapPhieuXuatHang.Size = new System.Drawing.Size(619, 426);
            this.tabLapPhieuXuatHang.Text = "Lập Phiếu Xuất Hàng";
            // 
            // tabTimKiemDaiLy
            // 
            this.tabTimKiemDaiLy.Image = ((System.Drawing.Image)(resources.GetObject("tabTimKiemDaiLy.Image")));
            this.tabTimKiemDaiLy.Name = "tabTimKiemDaiLy";
            this.tabTimKiemDaiLy.Size = new System.Drawing.Size(619, 426);
            this.tabTimKiemDaiLy.Text = "Tìm Kiếm Đại Lý";
            // 
            // tabLapPhieuThuTien
            // 
            this.tabLapPhieuThuTien.Image = ((System.Drawing.Image)(resources.GetObject("tabLapPhieuThuTien.Image")));
            this.tabLapPhieuThuTien.Name = "tabLapPhieuThuTien";
            this.tabLapPhieuThuTien.Size = new System.Drawing.Size(619, 400);
            this.tabLapPhieuThuTien.Text = "Lập Phiếu Thu Tiền";
            // 
            // tabLapBaoCao
            // 
            this.tabLapBaoCao.Image = ((System.Drawing.Image)(resources.GetObject("tabLapBaoCao.Image")));
            this.tabLapBaoCao.Name = "tabLapBaoCao";
            this.tabLapBaoCao.Size = new System.Drawing.Size(619, 400);
            this.tabLapBaoCao.Text = "Báo Cáo Tháng";
            // 
            // tabSuaDoiQuyDinh
            // 
            this.tabSuaDoiQuyDinh.Image = ((System.Drawing.Image)(resources.GetObject("tabSuaDoiQuyDinh.Image")));
            this.tabSuaDoiQuyDinh.Name = "tabSuaDoiQuyDinh";
            this.tabSuaDoiQuyDinh.Size = new System.Drawing.Size(619, 426);
            this.tabSuaDoiQuyDinh.Text = "Sửa Đổi Quy Định";
            // 
            // btnExit
            // 
            this.btnExit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(66, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(37, 46);
            this.btnExit.TabIndex = 0;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(13, 6);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(38, 46);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pnlAction
            // 
            this.pnlAction.Controls.Add(this.btnMinimize);
            this.pnlAction.Controls.Add(this.btnExit);
            this.pnlAction.Location = new System.Drawing.Point(710, 35);
            this.pnlAction.Name = "pnlAction";
            this.pnlAction.Size = new System.Drawing.Size(120, 55);
            this.pnlAction.TabIndex = 2;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Image = ((System.Drawing.Image)(resources.GetObject("lblHeader.Image")));
            this.lblHeader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHeader.Location = new System.Drawing.Point(54, 41);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(307, 40);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "     Quản Lý Đại Lý";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // img
            // 
            this.img.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img.ImageStream")));
            this.img.TransparentColor = System.Drawing.Color.Transparent;
            this.img.Images.SetKeyName(0, "BaoCao.png");
            this.img.Images.SetKeyName(1, "DaiLy.png");
            this.img.Images.SetKeyName(2, "Thu.png");
            this.img.Images.SetKeyName(3, "Xuat.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 548);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pnlAction);
            this.Controls.Add(this.tabMenu);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.tabMenu)).EndInit();
            this.tabMenu.ResumeLayout(false);
            this.pnlAction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraTab.XtraTabControl tabMenu;
        private DevExpress.XtraTab.XtraTabPage tabTiepNhanDaiLy;
        private DevExpress.XtraTab.XtraTabPage tabLapPhieuXuatHang;
        private DevExpress.XtraTab.XtraTabPage tabTimKiemDaiLy;
        private DevExpress.XtraTab.XtraTabPage tabLapPhieuThuTien;
        private DevExpress.XtraTab.XtraTabPage tabLapBaoCao;
        private DevExpress.XtraTab.XtraTabPage tabSuaDoiQuyDinh;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnMinimize;
        private System.Windows.Forms.Panel pnlAction;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ImageList img;

    }
}

