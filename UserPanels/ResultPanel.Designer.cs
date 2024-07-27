namespace MidProjectDb.UserPanels
{
    partial class ResultPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblMarks = new System.Windows.Forms.Label();
            this.btnCalculateResult = new System.Windows.Forms.Button();
            this.gridShowSt = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridShowAssessComp = new System.Windows.Forms.DataGridView();
            this.gridShowRubricLvl = new System.Windows.Forms.DataGridView();
            this.pnlStMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridShowSt)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridShowAssessComp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridShowRubricLvl)).BeginInit();
            this.pnlStMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.gridShowSt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 832);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblMarks);
            this.panel3.Controls.Add(this.btnCalculateResult);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(507, 371);
            this.panel3.TabIndex = 6;
            // 
            // lblMarks
            // 
            this.lblMarks.AutoSize = true;
            this.lblMarks.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarks.ForeColor = System.Drawing.Color.DarkGray;
            this.lblMarks.Location = new System.Drawing.Point(103, 91);
            this.lblMarks.Name = "lblMarks";
            this.lblMarks.Size = new System.Drawing.Size(305, 45);
            this.lblMarks.TabIndex = 29;
            this.lblMarks.Text = "Obtained Marks: 0";
            // 
            // btnCalculateResult
            // 
            this.btnCalculateResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculateResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateResult.ForeColor = System.Drawing.Color.Teal;
            this.btnCalculateResult.Location = new System.Drawing.Point(122, 260);
            this.btnCalculateResult.Name = "btnCalculateResult";
            this.btnCalculateResult.Size = new System.Drawing.Size(246, 59);
            this.btnCalculateResult.TabIndex = 38;
            this.btnCalculateResult.Text = "Calculate Result";
            this.btnCalculateResult.UseVisualStyleBackColor = true;
            this.btnCalculateResult.Click += new System.EventHandler(this.btnCalculateResult_Click);
            // 
            // gridShowSt
            // 
            this.gridShowSt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridShowSt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gridShowSt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridShowSt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridShowSt.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridShowSt.Location = new System.Drawing.Point(0, 371);
            this.gridShowSt.Name = "gridShowSt";
            this.gridShowSt.RowHeadersWidth = 51;
            this.gridShowSt.RowTemplate.Height = 24;
            this.gridShowSt.Size = new System.Drawing.Size(507, 461);
            this.gridShowSt.TabIndex = 39;
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
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridShowAssessComp);
            this.panel2.Controls.Add(this.gridShowRubricLvl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(510, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(839, 832);
            this.panel2.TabIndex = 5;
            // 
            // gridShowAssessComp
            // 
            this.gridShowAssessComp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridShowAssessComp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gridShowAssessComp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridShowAssessComp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridShowAssessComp.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridShowAssessComp.Location = new System.Drawing.Point(0, 371);
            this.gridShowAssessComp.Name = "gridShowAssessComp";
            this.gridShowAssessComp.RowHeadersWidth = 51;
            this.gridShowAssessComp.RowTemplate.Height = 24;
            this.gridShowAssessComp.Size = new System.Drawing.Size(839, 461);
            this.gridShowAssessComp.TabIndex = 5;
            // 
            // gridShowRubricLvl
            // 
            this.gridShowRubricLvl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridShowRubricLvl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gridShowRubricLvl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridShowRubricLvl.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridShowRubricLvl.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridShowRubricLvl.Location = new System.Drawing.Point(0, 0);
            this.gridShowRubricLvl.Name = "gridShowRubricLvl";
            this.gridShowRubricLvl.RowHeadersWidth = 51;
            this.gridShowRubricLvl.RowTemplate.Height = 24;
            this.gridShowRubricLvl.Size = new System.Drawing.Size(839, 371);
            this.gridShowRubricLvl.TabIndex = 4;
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
            this.label1.Size = new System.Drawing.Size(394, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select And Calculate Result";
            // 
            // ResultPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.Controls.Add(this.groupBox1);
            this.Name = "ResultPanel";
            this.Size = new System.Drawing.Size(1352, 953);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridShowSt)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridShowAssessComp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridShowRubricLvl)).EndInit();
            this.pnlStMenu.ResumeLayout(false);
            this.pnlStMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCalculateResult;
        private System.Windows.Forms.Label lblMarks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gridShowAssessComp;
        private System.Windows.Forms.DataGridView gridShowRubricLvl;
        private System.Windows.Forms.Panel pnlStMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView gridShowSt;
    }
}
