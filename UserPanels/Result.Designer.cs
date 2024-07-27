namespace MidProjectDb.UserPanels
{
    partial class Result
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
            this.dashPannel = new System.Windows.Forms.Panel();
            this.gridShowRubric = new System.Windows.Forms.DataGridView();
            this.pnlStMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gridShowAssess = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGoToResult = new System.Windows.Forms.Button();
            this.dashPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridShowRubric)).BeginInit();
            this.pnlStMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridShowAssess)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashPannel
            // 
            this.dashPannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.dashPannel.Controls.Add(this.gridShowRubric);
            this.dashPannel.Controls.Add(this.pnlStMenu);
            this.dashPannel.Controls.Add(this.gridShowAssess);
            this.dashPannel.Controls.Add(this.panel1);
            this.dashPannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashPannel.Location = new System.Drawing.Point(0, 0);
            this.dashPannel.Name = "dashPannel";
            this.dashPannel.Size = new System.Drawing.Size(1352, 953);
            this.dashPannel.TabIndex = 0;
            // 
            // gridShowRubric
            // 
            this.gridShowRubric.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridShowRubric.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gridShowRubric.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridShowRubric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridShowRubric.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gridShowRubric.Location = new System.Drawing.Point(0, 100);
            this.gridShowRubric.Name = "gridShowRubric";
            this.gridShowRubric.RowHeadersWidth = 51;
            this.gridShowRubric.RowTemplate.Height = 24;
            this.gridShowRubric.Size = new System.Drawing.Size(1352, 335);
            this.gridShowRubric.TabIndex = 10;
            // 
            // pnlStMenu
            // 
            this.pnlStMenu.BackColor = System.Drawing.Color.Teal;
            this.pnlStMenu.Controls.Add(this.label1);
            this.pnlStMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlStMenu.Name = "pnlStMenu";
            this.pnlStMenu.Size = new System.Drawing.Size(1352, 100);
            this.pnlStMenu.TabIndex = 6;
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
            this.label1.Size = new System.Drawing.Size(376, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Rubric & Assessment";
            // 
            // gridShowAssess
            // 
            this.gridShowAssess.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridShowAssess.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gridShowAssess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridShowAssess.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridShowAssess.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gridShowAssess.Location = new System.Drawing.Point(0, 435);
            this.gridShowAssess.Name = "gridShowAssess";
            this.gridShowAssess.RowHeadersWidth = 51;
            this.gridShowAssess.RowTemplate.Height = 24;
            this.gridShowAssess.Size = new System.Drawing.Size(1352, 420);
            this.gridShowAssess.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.btnGoToResult);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 855);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1352, 98);
            this.panel1.TabIndex = 7;
            // 
            // btnGoToResult
            // 
            this.btnGoToResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToResult.ForeColor = System.Drawing.Color.Teal;
            this.btnGoToResult.Location = new System.Drawing.Point(570, 14);
            this.btnGoToResult.Name = "btnGoToResult";
            this.btnGoToResult.Size = new System.Drawing.Size(246, 59);
            this.btnGoToResult.TabIndex = 38;
            this.btnGoToResult.Text = "Proceed To Result";
            this.btnGoToResult.UseVisualStyleBackColor = true;
            this.btnGoToResult.Click += new System.EventHandler(this.btnGoToResult_Click_1);
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dashPannel);
            this.Name = "Result";
            this.Size = new System.Drawing.Size(1352, 953);
            this.dashPannel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridShowRubric)).EndInit();
            this.pnlStMenu.ResumeLayout(false);
            this.pnlStMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridShowAssess)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel dashPannel;
        private System.Windows.Forms.DataGridView gridShowRubric;
        private System.Windows.Forms.Panel pnlStMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridShowAssess;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGoToResult;
    }
}
