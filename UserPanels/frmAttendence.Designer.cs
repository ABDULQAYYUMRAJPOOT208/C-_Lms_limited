namespace MidProjectDb.UserPanels
{
    partial class frmAttendence
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMarkAnother = new System.Windows.Forms.Button();
            this.dtpicker = new System.Windows.Forms.DateTimePicker();
            this.btnDate = new System.Windows.Forms.Button();
            this.gridViewRegSt = new System.Windows.Forms.DataGridView();
            this.pnlStMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
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
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(1014, 774);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMarkAnother);
            this.panel1.Controls.Add(this.dtpicker);
            this.panel1.Controls.Add(this.btnDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(2, 96);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 676);
            this.panel1.TabIndex = 4;
            // 
            // btnMarkAnother
            // 
            this.btnMarkAnother.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkAnother.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarkAnother.ForeColor = System.Drawing.Color.Teal;
            this.btnMarkAnother.Location = new System.Drawing.Point(97, 141);
            this.btnMarkAnother.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMarkAnother.Name = "btnMarkAnother";
            this.btnMarkAnother.Size = new System.Drawing.Size(184, 48);
            this.btnMarkAnother.TabIndex = 40;
            this.btnMarkAnother.Text = "Mark AnOther";
            this.btnMarkAnother.UseVisualStyleBackColor = true;
            this.btnMarkAnother.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpicker
            // 
            this.dtpicker.CalendarMonthBackground = System.Drawing.Color.Teal;
            this.dtpicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpicker.Location = new System.Drawing.Point(0, 0);
            this.dtpicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpicker.Name = "dtpicker";
            this.dtpicker.Size = new System.Drawing.Size(380, 32);
            this.dtpicker.TabIndex = 39;
            // 
            // btnDate
            // 
            this.btnDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDate.ForeColor = System.Drawing.Color.Teal;
            this.btnDate.Location = new System.Drawing.Point(97, 88);
            this.btnDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(184, 48);
            this.btnDate.TabIndex = 38;
            this.btnDate.Text = "Select Date";
            this.btnDate.UseVisualStyleBackColor = true;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // gridViewRegSt
            // 
            this.gridViewRegSt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewRegSt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gridViewRegSt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewRegSt.Dock = System.Windows.Forms.DockStyle.Right;
            this.gridViewRegSt.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gridViewRegSt.Location = new System.Drawing.Point(387, 96);
            this.gridViewRegSt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridViewRegSt.Name = "gridViewRegSt";
            this.gridViewRegSt.RowHeadersWidth = 51;
            this.gridViewRegSt.RowTemplate.Height = 24;
            this.gridViewRegSt.Size = new System.Drawing.Size(625, 676);
            this.gridViewRegSt.TabIndex = 3;
            this.gridViewRegSt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pnlStMenu
            // 
            this.pnlStMenu.BackColor = System.Drawing.Color.Teal;
            this.pnlStMenu.Controls.Add(this.label1);
            this.pnlStMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStMenu.Location = new System.Drawing.Point(2, 15);
            this.pnlStMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlStMenu.Name = "pnlStMenu";
            this.pnlStMenu.Size = new System.Drawing.Size(1010, 81);
            this.pnlStMenu.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(358, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(368, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Date and Mark Attendence";
            // 
            // frmAttendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAttendence";
            this.Size = new System.Drawing.Size(1014, 774);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRegSt)).EndInit();
            this.pnlStMenu.ResumeLayout(false);
            this.pnlStMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpicker;
        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.DataGridView gridViewRegSt;
        private System.Windows.Forms.Panel pnlStMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMarkAnother;
    }
}
