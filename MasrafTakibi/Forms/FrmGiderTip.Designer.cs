namespace MasrafTakibi.Forms
{
    partial class FrmGiderTip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiderTip));
            this.gridControlBase1 = new MasrafTakibiBase.BaseTools.GridControlBase();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.explanation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pasif = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBase1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlBase1
            // 
            this.gridControlBase1.Location = new System.Drawing.Point(12, 106);
            this.gridControlBase1.MainView = this.gridView1;
            this.gridControlBase1.Name = "gridControlBase1";
            this.gridControlBase1.Size = new System.Drawing.Size(1438, 619);
            this.gridControlBase1.TabIndex = 1;
            this.gridControlBase1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControlBase1.Load += new System.EventHandler(this.gridControlBase1_Load);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.code,
            this.explanation,
            this.pasif});
            this.gridView1.GridControl = this.gridControlBase1;
            this.gridView1.Name = "gridView1";
            this.gridView1.NewItemRowText = "Yeni Kayıt Satırı";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // id
            // 
            this.id.Caption = "id";
            this.id.FieldName = "id";
            this.id.MinWidth = 25;
            this.id.Name = "id";
            this.id.Width = 94;
            // 
            // code
            // 
            this.code.Caption = "Kod";
            this.code.FieldName = "code";
            this.code.MinWidth = 25;
            this.code.Name = "code";
            this.code.Visible = true;
            this.code.VisibleIndex = 0;
            this.code.Width = 94;
            // 
            // explanation
            // 
            this.explanation.Caption = "Açıklama";
            this.explanation.FieldName = "explanation";
            this.explanation.MinWidth = 25;
            this.explanation.Name = "explanation";
            this.explanation.Visible = true;
            this.explanation.VisibleIndex = 1;
            this.explanation.Width = 94;
            // 
            // pasif
            // 
            this.pasif.Caption = "Pasif";
            this.pasif.FieldName = "pasif";
            this.pasif.MinWidth = 25;
            this.pasif.Name = "pasif";
            this.pasif.Visible = true;
            this.pasif.VisibleIndex = 2;
            this.pasif.Width = 94;
            // 
            // FrmGiderTip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 736);
            this.Controls.Add(this.gridControlBase1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGiderTip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gider Tipi";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBase1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MasrafTakibiBase.BaseTools.GridControlBase gridControlBase1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn code;
        private DevExpress.XtraGrid.Columns.GridColumn explanation;
        private DevExpress.XtraGrid.Columns.GridColumn pasif;
    }
}