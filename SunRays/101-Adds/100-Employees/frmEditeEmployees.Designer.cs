﻿
namespace SunRays._101_Adds._100_Employees
{
    partial class frmEditeEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditeEmployees));
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TxtEmpNote = new System.Windows.Forms.RichTextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtEmpAddress = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.txtEmpMob2 = new DevExpress.XtraEditors.TextEdit();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtEmpEmail = new DevExpress.XtraEditors.TextEdit();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtEmpNataionalId = new DevExpress.XtraEditors.TextEdit();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtEmpName = new DevExpress.XtraEditors.TextEdit();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.txtEmpCode = new DevExpress.XtraEditors.TextEdit();
            this.dtEmpEndJop = new DevExpress.XtraEditors.DateEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtEmpStartJop = new DevExpress.XtraEditors.DateEdit();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.txtEmpMob1 = new DevExpress.XtraEditors.TextEdit();
            this.slkJop = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.slkBranch = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.slkSex = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpMob2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEmpEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEmpNataionalId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEmpName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmpEndJop.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmpEndJop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmpStartJop.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmpStartJop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpMob1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slkJop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slkBranch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slkSex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gridColumn2.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "الكود";
            this.gridColumn2.FieldName = "Customer_Code";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gridColumn3.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "الاسم";
            this.gridColumn3.FieldName = "Branches_Name";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // TxtEmpNote
            // 
            this.TxtEmpNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtEmpNote.Location = new System.Drawing.Point(3, 394);
            this.TxtEmpNote.MaxLength = 100;
            this.TxtEmpNote.Name = "TxtEmpNote";
            this.TxtEmpNote.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtEmpNote.Size = new System.Drawing.Size(294, 34);
            this.TxtEmpNote.TabIndex = 212;
            this.TxtEmpNote.Text = "";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(303, 351);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(93, 40);
            this.materialLabel5.TabIndex = 209;
            this.materialLabel5.Text = "العنوان";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(303, 57);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(93, 38);
            this.materialLabel4.TabIndex = 208;
            this.materialLabel4.Text = "موبيل 2";
            // 
            // TxtEmpAddress
            // 
            this.TxtEmpAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtEmpAddress.Location = new System.Drawing.Point(3, 354);
            this.TxtEmpAddress.MaxLength = 100;
            this.TxtEmpAddress.Name = "TxtEmpAddress";
            this.TxtEmpAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtEmpAddress.Size = new System.Drawing.Size(294, 34);
            this.TxtEmpAddress.TabIndex = 204;
            this.TxtEmpAddress.Text = "";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.81818F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.18182F));
            this.tableLayoutPanel3.Controls.Add(this.btnAdd, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnCancel, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 434);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.76471F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.23529F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(294, 73);
            this.tableLayoutPanel3.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.AllowFocus = false;
            this.btnAdd.Appearance.BackColor = System.Drawing.Color.Blue;
            this.btnAdd.Appearance.Options.UseBackColor = true;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(151, 11);
            this.btnAdd.LookAndFeel.SkinMaskColor = System.Drawing.Color.Blue;
            this.btnAdd.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.Blue;
            this.btnAdd.LookAndFeel.SkinName = "The Bezier";
            this.btnAdd.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 59);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "اضافة";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.AllowFocus = false;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(3, 11);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(142, 59);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "اغلاق";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_2);
            // 
            // txtEmpMob2
            // 
            this.txtEmpMob2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmpMob2.Location = new System.Drawing.Point(3, 60);
            this.txtEmpMob2.Name = "txtEmpMob2";
            this.txtEmpMob2.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtEmpMob2.Properties.Appearance.Options.UseBackColor = true;
            this.txtEmpMob2.Properties.AutoHeight = false;
            this.txtEmpMob2.Properties.Mask.EditMask = "\\d{0,12}";
            this.txtEmpMob2.Properties.Mask.IgnoreMaskBlank = false;
            this.txtEmpMob2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtEmpMob2.Properties.Mask.ShowPlaceHolders = false;
            this.txtEmpMob2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEmpMob2.Size = new System.Drawing.Size(294, 32);
            this.txtEmpMob2.TabIndex = 200;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(303, 95);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(93, 32);
            this.materialLabel1.TabIndex = 207;
            this.materialLabel1.Text = "الاسم ";
            // 
            // TxtEmpEmail
            // 
            this.TxtEmpEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtEmpEmail.Location = new System.Drawing.Point(3, 191);
            this.TxtEmpEmail.Name = "TxtEmpEmail";
            this.TxtEmpEmail.Properties.AutoHeight = false;
            this.TxtEmpEmail.Properties.Mask.EditMask = "(.|\\s){0,50}";
            this.TxtEmpEmail.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.TxtEmpEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtEmpEmail.Size = new System.Drawing.Size(294, 26);
            this.TxtEmpEmail.TabIndex = 202;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(303, 188);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(93, 32);
            this.materialLabel3.TabIndex = 206;
            this.materialLabel3.Text = "الايميل";
            // 
            // TxtEmpNataionalId
            // 
            this.TxtEmpNataionalId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtEmpNataionalId.Location = new System.Drawing.Point(3, 158);
            this.TxtEmpNataionalId.Name = "TxtEmpNataionalId";
            this.TxtEmpNataionalId.Properties.AutoHeight = false;
            this.TxtEmpNataionalId.Properties.Mask.EditMask = "\\d{0,50}";
            this.TxtEmpNataionalId.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.TxtEmpNataionalId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtEmpNataionalId.Size = new System.Drawing.Size(294, 27);
            this.TxtEmpNataionalId.TabIndex = 203;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(303, 155);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(93, 33);
            this.materialLabel2.TabIndex = 205;
            this.materialLabel2.Text = "الرقم القومي";
            // 
            // TxtEmpName
            // 
            this.TxtEmpName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtEmpName.Location = new System.Drawing.Point(3, 98);
            this.TxtEmpName.Name = "TxtEmpName";
            this.TxtEmpName.Properties.AutoHeight = false;
            this.TxtEmpName.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Optimistic;
            this.TxtEmpName.Properties.Mask.EditMask = "(.|\\s){0,50}";
            this.TxtEmpName.Properties.Mask.IgnoreMaskBlank = false;
            this.TxtEmpName.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.TxtEmpName.Properties.Mask.ShowPlaceHolders = false;
            this.TxtEmpName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtEmpName.Size = new System.Drawing.Size(294, 26);
            this.TxtEmpName.TabIndex = 201;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(303, 281);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(93, 37);
            this.materialLabel8.TabIndex = 216;
            this.materialLabel8.Text = "تاريخ التوظيف";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(303, 318);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(93, 33);
            this.materialLabel9.TabIndex = 217;
            this.materialLabel9.Text = "تاريخ الاستقالة";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(303, 391);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(93, 40);
            this.materialLabel6.TabIndex = 213;
            this.materialLabel6.Text = "ملاحظات";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(303, 0);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(93, 28);
            this.materialLabel10.TabIndex = 220;
            this.materialLabel10.Text = "كود الموظف";
            // 
            // txtEmpCode
            // 
            this.txtEmpCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmpCode.EditValue = "";
            this.txtEmpCode.Enabled = false;
            this.txtEmpCode.Location = new System.Drawing.Point(3, 3);
            this.txtEmpCode.Name = "txtEmpCode";
            this.txtEmpCode.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtEmpCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpCode.Properties.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtEmpCode.Properties.Appearance.Options.UseBackColor = true;
            this.txtEmpCode.Properties.Appearance.Options.UseFont = true;
            this.txtEmpCode.Properties.Appearance.Options.UseForeColor = true;
            this.txtEmpCode.Properties.Appearance.Options.UseTextOptions = true;
            this.txtEmpCode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtEmpCode.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtEmpCode.Properties.AutoHeight = false;
            this.txtEmpCode.Properties.Mask.EditMask = "\\d{0,100}";
            this.txtEmpCode.Properties.Mask.IgnoreMaskBlank = false;
            this.txtEmpCode.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtEmpCode.Properties.Mask.ShowPlaceHolders = false;
            this.txtEmpCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEmpCode.Size = new System.Drawing.Size(294, 22);
            this.txtEmpCode.TabIndex = 221;
            // 
            // dtEmpEndJop
            // 
            this.dtEmpEndJop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtEmpEndJop.EditValue = null;
            this.dtEmpEndJop.Location = new System.Drawing.Point(3, 321);
            this.dtEmpEndJop.Name = "dtEmpEndJop";
            this.dtEmpEndJop.Properties.AutoHeight = false;
            this.dtEmpEndJop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEmpEndJop.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEmpEndJop.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent;
            this.dtEmpEndJop.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dtEmpEndJop.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dtEmpEndJop.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtEmpEndJop.Size = new System.Drawing.Size(294, 27);
            this.dtEmpEndJop.TabIndex = 222;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gridColumn4.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.Caption = "الاسم";
            this.gridColumn4.FieldName = "SexTypeName";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            // 
            // dtEmpStartJop
            // 
            this.dtEmpStartJop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtEmpStartJop.EditValue = null;
            this.dtEmpStartJop.Location = new System.Drawing.Point(3, 284);
            this.dtEmpStartJop.Name = "dtEmpStartJop";
            this.dtEmpStartJop.Properties.AutoHeight = false;
            this.dtEmpStartJop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEmpStartJop.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEmpStartJop.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent;
            this.dtEmpStartJop.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dtEmpStartJop.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dtEmpStartJop.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtEmpStartJop.Size = new System.Drawing.Size(294, 31);
            this.dtEmpStartJop.TabIndex = 223;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(303, 28);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(93, 29);
            this.materialLabel11.TabIndex = 224;
            this.materialLabel11.Text = "موبيل 1";
            // 
            // txtEmpMob1
            // 
            this.txtEmpMob1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmpMob1.Location = new System.Drawing.Point(3, 31);
            this.txtEmpMob1.Name = "txtEmpMob1";
            this.txtEmpMob1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtEmpMob1.Properties.Appearance.Options.UseBackColor = true;
            this.txtEmpMob1.Properties.AutoHeight = false;
            this.txtEmpMob1.Properties.Mask.EditMask = "\\d{0,12}";
            this.txtEmpMob1.Properties.Mask.IgnoreMaskBlank = false;
            this.txtEmpMob1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtEmpMob1.Properties.Mask.ShowPlaceHolders = false;
            this.txtEmpMob1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEmpMob1.Size = new System.Drawing.Size(294, 23);
            this.txtEmpMob1.TabIndex = 225;
            // 
            // slkJop
            // 
            this.slkJop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slkJop.EditValue = " ";
            this.slkJop.Location = new System.Drawing.Point(3, 251);
            this.slkJop.Name = "slkJop";
            this.slkJop.Properties.AutoHeight = false;
            this.slkJop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slkJop.Properties.NullText = " ";
            this.slkJop.Properties.PopupView = this.searchLookUpEdit1View;
            this.slkJop.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.slkJop.Size = new System.Drawing.Size(294, 27);
            this.slkJop.TabIndex = 226;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gridColumn1.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "الاسم";
            this.gridColumn1.FieldName = "JobName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(303, 220);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(93, 28);
            this.materialLabel12.TabIndex = 227;
            this.materialLabel12.Text = "الفرع";
            // 
            // slkBranch
            // 
            this.slkBranch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slkBranch.EditValue = " ";
            this.slkBranch.Location = new System.Drawing.Point(3, 223);
            this.slkBranch.Name = "slkBranch";
            this.slkBranch.Properties.AutoHeight = false;
            this.slkBranch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slkBranch.Properties.NullText = " ";
            this.slkBranch.Properties.PopupView = this.gridView1;
            this.slkBranch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.slkBranch.Size = new System.Drawing.Size(294, 22);
            this.slkBranch.TabIndex = 228;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(303, 248);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(93, 33);
            this.materialLabel7.TabIndex = 211;
            this.materialLabel7.Text = "الوظيفة";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(303, 127);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(93, 28);
            this.materialLabel13.TabIndex = 229;
            this.materialLabel13.Text = "الجنس";
            // 
            // slkSex
            // 
            this.slkSex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slkSex.EditValue = " ";
            this.slkSex.Location = new System.Drawing.Point(3, 130);
            this.slkSex.Name = "slkSex";
            this.slkSex.Properties.AutoHeight = false;
            this.slkSex.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slkSex.Properties.NullText = " ";
            this.slkSex.Properties.PopupView = this.gridView2;
            this.slkSex.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.slkSex.Size = new System.Drawing.Size(294, 22);
            this.slkSex.TabIndex = 230;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gridColumn5.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.Caption = "الكود";
            this.gridColumn5.FieldName = "Customer_Code";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.20892F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.79108F));
            this.tableLayoutPanel2.Controls.Add(this.TxtEmpNote, 0, 12);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel5, 1, 11);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel4, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.TxtEmpAddress, 0, 11);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 13);
            this.tableLayoutPanel2.Controls.Add(this.txtEmpMob2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel1, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.TxtEmpEmail, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel3, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.TxtEmpNataionalId, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel2, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.TxtEmpName, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel8, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel9, 1, 10);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel6, 1, 12);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel10, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtEmpCode, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dtEmpEndJop, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.dtEmpStartJop, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel11, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtEmpMob1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.slkJop, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel12, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.slkBranch, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel7, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel13, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.slkSex, 0, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel2.RowCount = 14;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.592839F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.093959F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.393734F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.294086F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.52422F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.406034F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.497591F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.1327F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.1327F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.93214F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(399, 510);
            this.tableLayoutPanel2.TabIndex = 224;
            // 
            // frmEditeEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 510);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel2);
            this.IconOptions.ShowIcon = false;
            this.LookAndFeel.SkinName = "DevExpress Style";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmEditeEmployees";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل بيانات الموظف";
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpMob2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEmpEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEmpNataionalId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEmpName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmpEndJop.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmpEndJop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmpStartJop.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmpStartJop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpMob1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slkJop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slkBranch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slkSex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        public DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        public System.Windows.Forms.RichTextBox TxtEmpNote;
        public MaterialSkin.Controls.MaterialLabel materialLabel5;
        public MaterialSkin.Controls.MaterialLabel materialLabel4;
        public System.Windows.Forms.RichTextBox TxtEmpAddress;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        public DevExpress.XtraEditors.SimpleButton btnAdd;
        public DevExpress.XtraEditors.SimpleButton btnCancel;
        public DevExpress.XtraEditors.TextEdit txtEmpMob2;
        public MaterialSkin.Controls.MaterialLabel materialLabel1;
        public DevExpress.XtraEditors.TextEdit TxtEmpEmail;
        public MaterialSkin.Controls.MaterialLabel materialLabel3;
        public DevExpress.XtraEditors.TextEdit TxtEmpNataionalId;
        public MaterialSkin.Controls.MaterialLabel materialLabel2;
        public DevExpress.XtraEditors.TextEdit TxtEmpName;
        public MaterialSkin.Controls.MaterialLabel materialLabel8;
        public MaterialSkin.Controls.MaterialLabel materialLabel9;
        public MaterialSkin.Controls.MaterialLabel materialLabel6;
        public MaterialSkin.Controls.MaterialLabel materialLabel10;
        public DevExpress.XtraEditors.TextEdit txtEmpCode;
        public DevExpress.XtraEditors.DateEdit dtEmpEndJop;
        public DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        public DevExpress.XtraEditors.DateEdit dtEmpStartJop;
        public MaterialSkin.Controls.MaterialLabel materialLabel11;
        public DevExpress.XtraEditors.TextEdit txtEmpMob1;
        public DevExpress.XtraEditors.SearchLookUpEdit slkJop;
        public DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        public DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        public MaterialSkin.Controls.MaterialLabel materialLabel12;
        public DevExpress.XtraEditors.SearchLookUpEdit slkBranch;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public MaterialSkin.Controls.MaterialLabel materialLabel7;
        public MaterialSkin.Controls.MaterialLabel materialLabel13;
        public DevExpress.XtraEditors.SearchLookUpEdit slkSex;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        public DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}