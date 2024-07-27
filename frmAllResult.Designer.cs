namespace MidProjectDb
{
    partial class frmAllResult
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAllResult));
            this.label1 = new System.Windows.Forms.Label();
            this.pnlStMenu = new System.Windows.Forms.Panel();
            this.gridShowRubricLvl = new System.Windows.Forms.DataGridView();
            this.btnPrintResult = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pnlStMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridShowRubricLvl)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(501, 34);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(394, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select And Calculate Result";
            // 
            // pnlStMenu
            // 
            this.pnlStMenu.BackColor = System.Drawing.Color.Teal;
            this.pnlStMenu.Controls.Add(this.label1);
            this.pnlStMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlStMenu.Name = "pnlStMenu";
            this.pnlStMenu.Size = new System.Drawing.Size(1352, 100);
            this.pnlStMenu.TabIndex = 5;
            // 
            // gridShowRubricLvl
            // 
            this.gridShowRubricLvl.AllowUserToAddRows = false;
            this.gridShowRubricLvl.AllowUserToDeleteRows = false;
            this.gridShowRubricLvl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridShowRubricLvl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gridShowRubricLvl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridShowRubricLvl.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridShowRubricLvl.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridShowRubricLvl.Location = new System.Drawing.Point(0, 100);
            this.gridShowRubricLvl.Name = "gridShowRubricLvl";
            this.gridShowRubricLvl.RowHeadersWidth = 51;
            this.gridShowRubricLvl.RowTemplate.Height = 24;
            this.gridShowRubricLvl.Size = new System.Drawing.Size(1352, 724);
            this.gridShowRubricLvl.TabIndex = 7;
            // 
            // btnPrintResult
            // 
            this.btnPrintResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrintResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintResult.ForeColor = System.Drawing.Color.Teal;
            this.btnPrintResult.Location = new System.Drawing.Point(598, 856);
            this.btnPrintResult.Name = "btnPrintResult";
            this.btnPrintResult.Size = new System.Drawing.Size(246, 59);
            this.btnPrintResult.TabIndex = 39;
            this.btnPrintResult.Text = "Print Result";
            this.btnPrintResult.UseVisualStyleBackColor = true;
            this.btnPrintResult.Click += new System.EventHandler(this.btnPrintResult_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // frmAllResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.btnPrintResult);
            this.Controls.Add(this.gridShowRubricLvl);
            this.Controls.Add(this.pnlStMenu);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "frmAllResult";
            this.Size = new System.Drawing.Size(1352, 953);
            this.pnlStMenu.ResumeLayout(false);
            this.pnlStMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridShowRubricLvl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlStMenu;
        private System.Windows.Forms.DataGridView gridShowRubricLvl;
        private System.Windows.Forms.Button btnPrintResult;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
