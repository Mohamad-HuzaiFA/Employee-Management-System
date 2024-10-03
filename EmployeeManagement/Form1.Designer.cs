namespace EmployeeManagement
{
    partial class Main
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
            this.AddEmployee = new System.Windows.Forms.Button();
            this.SearchEmp = new System.Windows.Forms.Button();
            this.ListAllDepts = new System.Windows.Forms.Button();
            this.DeleteById = new System.Windows.Forms.Button();
            this.UpdateEmployee = new System.Windows.Forms.Button();
            this.GetEmployees = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1135, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddEmployee
            // 
            this.AddEmployee.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.AddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployee.Location = new System.Drawing.Point(66, 93);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(166, 45);
            this.AddEmployee.TabIndex = 0;
            this.AddEmployee.Text = "Add Employee";
            this.AddEmployee.UseVisualStyleBackColor = false;
            this.AddEmployee.Click += new System.EventHandler(this.AddEmployee_Click);
            // 
            // SearchEmp
            // 
            this.SearchEmp.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.SearchEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchEmp.Location = new System.Drawing.Point(66, 412);
            this.SearchEmp.Name = "SearchEmp";
            this.SearchEmp.Size = new System.Drawing.Size(533, 45);
            this.SearchEmp.TabIndex = 5;
            this.SearchEmp.Text = "Search for Employee by Name,Department or Position";
            this.SearchEmp.UseVisualStyleBackColor = false;
            this.SearchEmp.Click += new System.EventHandler(this.SearchEmp_Click);
            // 
            // ListAllDepts
            // 
            this.ListAllDepts.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ListAllDepts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListAllDepts.Location = new System.Drawing.Point(66, 346);
            this.ListAllDepts.Name = "ListAllDepts";
            this.ListAllDepts.Size = new System.Drawing.Size(575, 45);
            this.ListAllDepts.TabIndex = 4;
            this.ListAllDepts.Text = "List all Departments with Total Employees and Total Salary";
            this.ListAllDepts.UseVisualStyleBackColor = false;
            this.ListAllDepts.Click += new System.EventHandler(this.ListAllDepts_Click);
            // 
            // DeleteById
            // 
            this.DeleteById.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.DeleteById.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteById.Location = new System.Drawing.Point(66, 283);
            this.DeleteById.Name = "DeleteById";
            this.DeleteById.Size = new System.Drawing.Size(308, 45);
            this.DeleteById.TabIndex = 3;
            this.DeleteById.Text = "Delete an Employee by Id";
            this.DeleteById.UseVisualStyleBackColor = false;
            this.DeleteById.Click += new System.EventHandler(this.DeleteById_Click);
            // 
            // UpdateEmployee
            // 
            this.UpdateEmployee.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.UpdateEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateEmployee.Location = new System.Drawing.Point(66, 218);
            this.UpdateEmployee.Name = "UpdateEmployee";
            this.UpdateEmployee.Size = new System.Drawing.Size(308, 45);
            this.UpdateEmployee.TabIndex = 2;
            this.UpdateEmployee.Text = "Update an Employee Details";
            this.UpdateEmployee.UseVisualStyleBackColor = false;
            this.UpdateEmployee.Click += new System.EventHandler(this.UpdateEmployee_Click);
            // 
            // GetEmployees
            // 
            this.GetEmployees.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.GetEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetEmployees.Location = new System.Drawing.Point(66, 155);
            this.GetEmployees.Name = "GetEmployees";
            this.GetEmployees.Size = new System.Drawing.Size(226, 45);
            this.GetEmployees.TabIndex = 1;
            this.GetEmployees.Text = "Get All Employees";
            this.GetEmployees.UseVisualStyleBackColor = false;
            this.GetEmployees.Click += new System.EventHandler(this.GetEmployees_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(0, 576);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1135, 34);
            this.label2.TabIndex = 6;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 610);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GetEmployees);
            this.Controls.Add(this.UpdateEmployee);
            this.Controls.Add(this.DeleteById);
            this.Controls.Add(this.ListAllDepts);
            this.Controls.Add(this.SearchEmp);
            this.Controls.Add(this.AddEmployee);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddEmployee;
        private System.Windows.Forms.Button SearchEmp;
        private System.Windows.Forms.Button ListAllDepts;
        private System.Windows.Forms.Button DeleteById;
        private System.Windows.Forms.Button UpdateEmployee;
        private System.Windows.Forms.Button GetEmployees;
        private System.Windows.Forms.Label label2;
    }
}

