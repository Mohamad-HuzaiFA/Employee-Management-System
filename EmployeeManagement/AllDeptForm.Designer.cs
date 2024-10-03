namespace EmployeeManagement
{
    partial class AllDeptForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.DepartmentsdataGridView = new System.Windows.Forms.DataGridView();
            this.GetDeptBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentsdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 56);
            this.label1.TabIndex = 2;
            this.label1.Text = "All Departments with Salary and Total Employees";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DepartmentsdataGridView
            // 
            this.DepartmentsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DepartmentsdataGridView.Location = new System.Drawing.Point(107, 84);
            this.DepartmentsdataGridView.Name = "DepartmentsdataGridView";
            this.DepartmentsdataGridView.RowHeadersWidth = 51;
            this.DepartmentsdataGridView.RowTemplate.Height = 24;
            this.DepartmentsdataGridView.Size = new System.Drawing.Size(542, 227);
            this.DepartmentsdataGridView.TabIndex = 3;
            // 
            // GetDeptBtn
            // 
            this.GetDeptBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GetDeptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetDeptBtn.Location = new System.Drawing.Point(454, 340);
            this.GetDeptBtn.Name = "GetDeptBtn";
            this.GetDeptBtn.Size = new System.Drawing.Size(153, 31);
            this.GetDeptBtn.TabIndex = 13;
            this.GetDeptBtn.Text = "Get Departments";
            this.GetDeptBtn.UseVisualStyleBackColor = false;
            this.GetDeptBtn.Click += new System.EventHandler(this.GetDeptBtn_Click);
            // 
            // AllDeptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GetDeptBtn);
            this.Controls.Add(this.DepartmentsdataGridView);
            this.Controls.Add(this.label1);
            this.Name = "AllDeptForm";
            this.Text = "AllDeptForm";
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentsdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DepartmentsdataGridView;
        private System.Windows.Forms.Button GetDeptBtn;
    }
}