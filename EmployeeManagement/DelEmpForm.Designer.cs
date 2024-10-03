namespace EmployeeManagement
{
    partial class DelEmpForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.DelEmpBtn = new System.Windows.Forms.Button();
            this.idHolder = new System.Windows.Forms.TextBox();
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
            this.label1.Text = "Delete Employee by ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Enter Id of Employee to Delete:";
            // 
            // DelEmpBtn
            // 
            this.DelEmpBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DelEmpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelEmpBtn.Location = new System.Drawing.Point(353, 254);
            this.DelEmpBtn.Name = "DelEmpBtn";
            this.DelEmpBtn.Size = new System.Drawing.Size(201, 39);
            this.DelEmpBtn.TabIndex = 18;
            this.DelEmpBtn.Text = "Enter to Delete";
            this.DelEmpBtn.UseVisualStyleBackColor = false;
            this.DelEmpBtn.Click += new System.EventHandler(this.DelEmpBtn_Click);
            // 
            // idHolder
            // 
            this.idHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idHolder.Location = new System.Drawing.Point(320, 198);
            this.idHolder.Name = "idHolder";
            this.idHolder.Size = new System.Drawing.Size(55, 30);
            this.idHolder.TabIndex = 19;
            // 
            // DelEmpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.idHolder);
            this.Controls.Add(this.DelEmpBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DelEmpForm";
            this.Text = "DelEmpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DelEmpBtn;
        private System.Windows.Forms.TextBox idHolder;
    }
}