namespace EmployeeManagement
{
    partial class GetEmpForm
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
            this.EmployeesdataGridView = new System.Windows.Forms.DataGridView();
            this.GetEmpBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesdataGridView)).BeginInit();
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
            this.label1.TabIndex = 1;
            this.label1.Text = "Get All Employees";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmployeesdataGridView
            // 
            this.EmployeesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeesdataGridView.Location = new System.Drawing.Point(109, 94);
            this.EmployeesdataGridView.Name = "EmployeesdataGridView";
            this.EmployeesdataGridView.RowHeadersWidth = 51;
            this.EmployeesdataGridView.RowTemplate.Height = 24;
            this.EmployeesdataGridView.Size = new System.Drawing.Size(542, 227);
            this.EmployeesdataGridView.TabIndex = 2;
            // 
            // GetEmpBtn
            // 
            this.GetEmpBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GetEmpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetEmpBtn.Location = new System.Drawing.Point(333, 350);
            this.GetEmpBtn.Name = "GetEmpBtn";
            this.GetEmpBtn.Size = new System.Drawing.Size(153, 31);
            this.GetEmpBtn.TabIndex = 12;
            this.GetEmpBtn.Text = "Get Employees";
            this.GetEmpBtn.UseVisualStyleBackColor = false;
            this.GetEmpBtn.Click += new System.EventHandler(this.GetEmpBtn_Click);
            // 
            // GetEmpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GetEmpBtn);
            this.Controls.Add(this.EmployeesdataGridView);
            this.Controls.Add(this.label1);
            this.Name = "GetEmpForm";
            this.Text = "GetEmpForm";
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView EmployeesdataGridView;
        private System.Windows.Forms.Button GetEmpBtn;
    }
}