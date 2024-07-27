namespace MidProjectDb.UserPanels
{
    partial class frmViewRegisteredStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewRegisteredStudent));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOnlyActive = new System.Windows.Forms.Button();
            this.btnAllSt = new System.Windows.Forms.Button();
            this.btnOnlyDelete = new System.Windows.Forms.Button();
            this.gridViewRegSt = new System.Windows.Forms.DataGridView();
            this.pnlStMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.printDocument3 = new System.Drawing.Printing.PrintDocument();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRegSt)).BeginInit();
            this.pnlStMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.gridViewRegSt);
            this.groupBox1.Controls.Add(this.pnlStMenu);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1352, 953);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOnlyActive);
            this.panel1.Controls.Add(this.btnAllSt);
            this.panel1.Controls.Add(this.btnOnlyDelete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 788);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1346, 162);
            this.panel1.TabIndex = 4;
            // 
            // btnOnlyActive
            // 
            this.btnOnlyActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnlyActive.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnlyActive.ForeColor = System.Drawing.Color.Teal;
            this.btnOnlyActive.Location = new System.Drawing.Point(550, 52);
            this.btnOnlyActive.Name = "btnOnlyActive";
            this.btnOnlyActive.Size = new System.Drawing.Size(246, 59);
            this.btnOnlyActive.TabIndex = 41;
            this.btnOnlyActive.Text = "Print Active Only";
            this.btnOnlyActive.UseVisualStyleBackColor = true;
            this.btnOnlyActive.Click += new System.EventHandler(this.btnOnlyActive_Click);
            // 
            // btnAllSt
            // 
            this.btnAllSt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllSt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllSt.ForeColor = System.Drawing.Color.Teal;
            this.btnAllSt.Location = new System.Drawing.Point(998, 53);
            this.btnAllSt.Name = "btnAllSt";
            this.btnAllSt.Size = new System.Drawing.Size(246, 59);
            this.btnAllSt.TabIndex = 40;
            this.btnAllSt.Text = "Print All Students";
            this.btnAllSt.UseVisualStyleBackColor = true;
            this.btnAllSt.Click += new System.EventHandler(this.btnAllSt_Click);
            // 
            // btnOnlyDelete
            // 
            this.btnOnlyDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnlyDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnlyDelete.ForeColor = System.Drawing.Color.Teal;
            this.btnOnlyDelete.Location = new System.Drawing.Point(121, 53);
            this.btnOnlyDelete.Name = "btnOnlyDelete";
            this.btnOnlyDelete.Size = new System.Drawing.Size(246, 59);
            this.btnOnlyDelete.TabIndex = 39;
            this.btnOnlyDelete.Text = "Print Deleted";
            this.btnOnlyDelete.UseVisualStyleBackColor = true;
            this.btnOnlyDelete.Click += new System.EventHandler(this.btnOnlyDelete_Click);
            // 
            // gridViewRegSt
            // 
            this.gridViewRegSt.AllowUserToAddRows = false;
            this.gridViewRegSt.AllowUserToDeleteRows = false;
            this.gridViewRegSt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewRegSt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gridViewRegSt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewRegSt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewRegSt.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridViewRegSt.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gridViewRegSt.Location = new System.Drawing.Point(3, 118);
            this.gridViewRegSt.Name = "gridViewRegSt";
            this.gridViewRegSt.RowHeadersWidth = 51;
            this.gridViewRegSt.RowTemplate.Height = 24;
            this.gridViewRegSt.Size = new System.Drawing.Size(1346, 832);
            this.gridViewRegSt.TabIndex = 3;
            this.gridViewRegSt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewRegSt_CellContentClick);
            // 
            // pnlStMenu
            // 
            this.pnlStMenu.BackColor = System.Drawing.Color.Teal;
            this.pnlStMenu.Controls.Add(this.label1);
            this.pnlStMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStMenu.Location = new System.Drawing.Point(3, 18);
            this.pnlStMenu.Name = "pnlStMenu";
            this.pnlStMenu.Size = new System.Drawing.Size(1346, 100);
            this.pnlStMenu.TabIndex = 2;
            this.pnlStMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlStMenu_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(523, 31);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(291, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registered Students";
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
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // printDocument3
            // 
            this.printDocument3.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument3_PrintPage);
            // 
            // frmViewRegisteredStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "frmViewRegisteredStudent";
            this.Size = new System.Drawing.Size(1352, 953);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRegSt)).EndInit();
            this.pnlStMenu.ResumeLayout(false);
            this.pnlStMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlStMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridViewRegSt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOnlyActive;
        private System.Windows.Forms.Button btnAllSt;
        private System.Windows.Forms.Button btnOnlyDelete;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Drawing.Printing.PrintDocument printDocument3;
    }
}
