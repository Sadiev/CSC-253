namespace WindowsForms
{
    partial class EmployeeForm
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
            this.EmployeeListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // EmployeeListBox
            // 
            this.EmployeeListBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.EmployeeListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeListBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeListBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EmployeeListBox.FormattingEnabled = true;
            this.EmployeeListBox.ItemHeight = 23;
            this.EmployeeListBox.Location = new System.Drawing.Point(0, 0);
            this.EmployeeListBox.Name = "EmployeeListBox";
            this.EmployeeListBox.Size = new System.Drawing.Size(845, 450);
            this.EmployeeListBox.TabIndex = 0;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 450);
            this.Controls.Add(this.EmployeeListBox);
            this.Name = "EmployeeForm";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox EmployeeListBox;
    }
}

