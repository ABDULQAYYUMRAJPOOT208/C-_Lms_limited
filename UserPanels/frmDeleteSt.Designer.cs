namespace MidProjectDb.UserPanels
{
    partial class frmDeleteSt
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
            this.label1 = new System.Windows.Forms.Label();
            this.gridViewRegSt = new System.Windows.Forms.DataGridView();
            this.pnlStMenu = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRegSt)).BeginInit();
            this.pnlStMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(478, 34);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(369, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Students To Delete";
            // 
            // gridViewRegSt
            // 
            this.gridViewRegSt.AllowUserToDeleteRows = false;
            this.gridViewRegSt.AllowUserToResizeColumns = false;
            this.gridViewRegSt.AllowUserToResizeRows = false;
            this.gridViewRegSt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewRegSt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gridViewRegSt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewRegSt.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridViewRegSt.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridViewRegSt.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gridViewRegSt.Location = new System.Drawing.Point(3, 118);
            this.gridViewRegSt.Name = "gridViewRegSt";
            this.gridViewRegSt.RowHeadersWidth = 51;
            this.gridViewRegSt.RowTemplate.Height = 24;
            this.gridViewRegSt.Size = new System.Drawing.Size(1346, 615);
            this.gridViewRegSt.TabIndex = 3;
            this.gridViewRegSt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewRegSt_CellContentClick);
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
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.gridViewRegSt);
            this.groupBox1.Controls.Add(this.pnlStMenu);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1352, 953);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Teal;
            this.btnDelete.Location = new System.Drawing.Point(591, 810);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(158, 76);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmDeleteSt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDeleteSt";
            this.Size = new System.Drawing.Size(1352, 953);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRegSt)).EndInit();
            this.pnlStMenu.ResumeLayout(false);
            this.pnlStMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridViewRegSt;
        private System.Windows.Forms.Panel pnlStMenu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
    }
}
