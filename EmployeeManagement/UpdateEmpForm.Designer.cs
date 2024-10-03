namespace EmployeeManagement
{
    partial class UpdateEmpForm
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
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deptidtext = new System.Windows.Forms.TextBox();
            this.salarytext = new System.Windows.Forms.TextBox();
            this.positiontext = new System.Windows.Forms.TextBox();
            this.empidtext = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(848, 56);
            this.label1.TabIndex = 2;
            this.label1.Text = "Update Employee Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(34, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 32);
            this.label10.TabIndex = 11;
            this.label10.Text = "Position:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 32);
            this.label9.TabIndex = 12;
            this.label9.Text = "Salary:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 32);
            this.label8.TabIndex = 13;
            this.label8.Text = "DepartmentID:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 32);
            this.label2.TabIndex = 14;
            this.label2.Text = "EmployeeID:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deptidtext
            // 
            this.deptidtext.Location = new System.Drawing.Point(192, 261);
            this.deptidtext.Name = "deptidtext";
            this.deptidtext.Size = new System.Drawing.Size(204, 22);
            this.deptidtext.TabIndex = 15;
            // 
            // salarytext
            // 
            this.salarytext.Location = new System.Drawing.Point(192, 214);
            this.salarytext.Name = "salarytext";
            this.salarytext.Size = new System.Drawing.Size(204, 22);
            this.salarytext.TabIndex = 16;
            // 
            // positiontext
            // 
            this.positiontext.Location = new System.Drawing.Point(192, 173);
            this.positiontext.Name = "positiontext";
            this.positiontext.Size = new System.Drawing.Size(204, 22);
            this.positiontext.TabIndex = 17;
            // 
            // empidtext
            // 
            this.empidtext.Location = new System.Drawing.Point(192, 125);
            this.empidtext.Name = "empidtext";
            this.empidtext.Size = new System.Drawing.Size(204, 22);
            this.empidtext.TabIndex = 18;
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(192, 319);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(99, 31);
            this.submitBtn.TabIndex = 19;
            this.submitBtn.Text = "Update";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // UpdateEmpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 485);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.empidtext);
            this.Controls.Add(this.positiontext);
            this.Controls.Add(this.salarytext);
            this.Controls.Add(this.deptidtext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Name = "UpdateEmpForm";
            this.Text = "UpdateEmpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox deptidtext;
        private System.Windows.Forms.TextBox salarytext;
        private System.Windows.Forms.TextBox positiontext;
        private System.Windows.Forms.TextBox empidtext;
        private System.Windows.Forms.Button submitBtn;
    }
}