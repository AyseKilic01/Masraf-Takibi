﻿namespace MasrafTakibi.Forms
{
    partial class FrmFirmaTanim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFirmaTanim));
            this.gridControlBase1 = new MasrafTakibiBase.BaseTools.GridControlBase();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.kod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.aciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pasif = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBase1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlBase1
            // 
            this.gridControlBase1.Location = new System.Drawing.Point(12, 105);
            this.gridControlBase1.MainView = this.gridView1;
            this.gridControlBase1.Name = "gridControlBase1";
            this.gridControlBase1.Size = new System.Drawing.Size(1438, 619);
            this.gridControlBase1.TabIndex = 0;
            this.gridControlBase1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.kod,
            this.aciklama,
            this.pasif});
            this.gridView1.GridControl = this.gridControlBase1;
            this.gridView1.Name = "gridView1";
            this.gridView1.NewItemRowText = "Yeni Kayıt Satırı";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // id
            // 
            this.id.Caption = "id";
            this.id.MinWidth = 25;
            this.id.Name = "id";
            this.id.Width = 94;
            // 
            // kod
            // 
            this.kod.Caption = "Kod";
            this.kod.MinWidth = 25;
            this.kod.Name = "kod";
            this.kod.Visible = true;
            this.kod.VisibleIndex = 0;
            this.kod.Width = 94;
            // 
            // aciklama
            // 
            this.aciklama.Caption = "Açıklama";
            this.aciklama.MinWidth = 25;
            this.aciklama.Name = "aciklama";
            this.aciklama.Visible = true;
            this.aciklama.VisibleIndex = 1;
            this.aciklama.Width = 94;
            // 
            // pasif
            // 
            this.pasif.Caption = "Pasif";
            this.pasif.MinWidth = 25;
            this.pasif.Name = "pasif";
            this.pasif.Visible = true;
            this.pasif.VisibleIndex = 2;
            this.pasif.Width = 94;
            // 
            // FrmFirmaTanim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 736);
            this.Controls.Add(this.gridControlBase1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFirmaTanim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Firma Kartı Tanımı";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBase1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MasrafTakibiBase.BaseTools.GridControlBase gridControlBase1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn kod;
        private DevExpress.XtraGrid.Columns.GridColumn aciklama;
        private DevExpress.XtraGrid.Columns.GridColumn pasif;
        private DevExpress.XtraGrid.Columns.GridColumn id;
    }
}