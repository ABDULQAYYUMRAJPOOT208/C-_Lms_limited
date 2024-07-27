namespace MidProjectDb.UserPanels
{
    partial class frmAssessComp
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
            this.btnAddComp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTMarks = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCompName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridShowAssess = new System.Windows.Forms.DataGridView();
            this.gridShowRubric = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlStMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridShowAssess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridShowRubric)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlStMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddComp
            // 
            this.btnAddComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddComp.ForeColor = System.Drawing.Color.Teal;
            this.btnAddComp.Location = new System.Drawing.Point(130, 412);
            this.btnAddComp.Name = "btnAddComp";
            this.btnAddComp.Size = new System.Drawing.Size(246, 59);
            this.btnAddComp.TabIndex = 38;
            this.btnAddComp.Text = "Add Component";
            this.btnAddComp.UseVisualStyleBackColor = true;
            this.btnAddComp.Click += new System.EventHandler(this.btnAddComp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(43, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Enter Total Marks :";
            // 
            // txtTMarks
            // 
            this.txtTMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTMarks.Location = new System.Drawing.Point(268, 278);
            this.txtTMarks.Name = "txtTMarks";
            this.txtTMarks.Size = new System.Drawing.Size(218, 26);
            this.txtTMarks.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(43, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Enter Component Name :";
            // 
            // txtCompName
            // 
            this.txtCompName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCompName.Location = new System.Drawing.Point(268, 230);
            this.txtCompName.Name = "txtCompName";
            this.txtCompName.Size = new System.Drawing.Size(218, 26);
            this.txtCompName.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.pnlStMenu);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1352, 953);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridShowAssess);
            this.panel2.Controls.Add(this.gridShowRubric);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(510, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(839, 832);
            this.panel2.TabIndex = 5;
            // 
            // gridShowAssess
            // 
            this.gridShowAssess.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridShowAssess.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gridShowAssess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridShowAssess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridShowAssess.Location = new System.Drawing.Point(0, 371);
            this.gridShowAssess.Name = "gridShowAssess";
            this.gridShowAssess.RowHeadersWidth = 51;
            this.gridShowAssess.RowTemplate.Height = 24;
            this.gridShowAssess.Size = new System.Drawing.Size(839, 461);
            this.gridShowAssess.TabIndex = 5;
            // 
            // gridShowRubric
            // 
            this.gridShowRubric.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridShowRubric.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gridShowRubric.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridShowRubric.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridShowRubric.Location = new System.Drawing.Point(0, 0);
            this.gridShowRubric.Name = "gridShowRubric";
            this.gridShowRubric.RowHeadersWidth = 51;
            this.gridShowRubric.RowTemplate.Height = 24;
            this.gridShowRubric.Size = new System.Drawing.Size(839, 371);
            this.gridShowRubric.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddComp);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTMarks);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCompName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 832);
            this.panel1.TabIndex = 4;
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(498, 34);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(354, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Component Details";
            // 
            // frmAssessComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAssessComp";
            this.Size = new System.Drawing.Size(1352, 953);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridShowAssess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridShowRubric)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlStMenu.ResumeLayout(false);
            this.pnlStMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddComp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTMarks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCompName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlStMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gridShowAssess;
        private System.Windows.Forms.DataGridView gridShowRubric;
    }
}
