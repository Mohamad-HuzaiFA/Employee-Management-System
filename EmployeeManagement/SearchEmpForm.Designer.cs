namespace EmployeeManagement
{
    partial class SearchEmpForm
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
            this.SearchEmployeesdataGridView = new System.Windows.Forms.DataGridView();
            this.GetEmpBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textQuery = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SearchEmployeesdataGridView)).BeginInit();
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
            this.label1.Text = "Search Employees using Name,Department and Position";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchEmployeesdataGridView
            // 
            this.SearchEmployeesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchEmployeesdataGridView.Location = new System.Drawing.Point(104, 144);
            this.SearchEmployeesdataGridView.Name = "SearchEmployeesdataGridView";
            this.SearchEmployeesdataGridView.RowHeadersWidth = 51;
            this.SearchEmployeesdataGridView.RowTemplate.Height = 24;
            this.SearchEmployeesdataGridView.Size = new System.Drawing.Size(542, 227);
            this.SearchEmployeesdataGridView.TabIndex = 3;
            // 
            // GetEmpBtn
            // 
            this.GetEmpBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GetEmpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetEmpBtn.Location = new System.Drawing.Point(606, 389);
            this.GetEmpBtn.Name = "GetEmpBtn";
            this.GetEmpBtn.Size = new System.Drawing.Size(153, 31);
            this.GetEmpBtn.TabIndex = 13;
            this.GetEmpBtn.Text = "Get Employees";
            this.GetEmpBtn.UseVisualStyleBackColor = false;
            this.GetEmpBtn.Click += new System.EventHandler(this.GetEmpBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Enter Query:";
            // 
            // textQuery
            // 
            this.textQuery.Location = new System.Drawing.Point(131, 81);
            this.textQuery.Name = "textQuery";
            this.textQuery.Size = new System.Drawing.Size(154, 22);
            this.textQuery.TabIndex = 0;
            // 
            // SearchEmpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textQuery);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GetEmpBtn);
            this.Controls.Add(this.SearchEmployeesdataGridView);
            this.Controls.Add(this.label1);
            this.Name = "SearchEmpForm";
            this.Text = "SearchEmpForm";
            ((System.ComponentModel.ISupportInitialize)(this.SearchEmployeesdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView SearchEmployeesdataGridView;
        private System.Windows.Forms.Button GetEmpBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textQuery;
    }
}