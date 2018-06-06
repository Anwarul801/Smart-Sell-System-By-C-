namespace Smart_Sell_System
{
    partial class AddDepartment
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
            this.deparmentText = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(151, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Category:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // deparmentText
            // 
            this.deparmentText.BackColor = System.Drawing.SystemColors.Menu;
            this.deparmentText.Location = new System.Drawing.Point(332, 121);
            this.deparmentText.Multiline = true;
            this.deparmentText.Name = "deparmentText";
            this.deparmentText.Size = new System.Drawing.Size(211, 32);
            this.deparmentText.TabIndex = 1;
            this.deparmentText.TextChanged += new System.EventHandler(this.deparmentText_TextChanged);
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(332, 184);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(96, 45);
            this.Submit.TabIndex = 2;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // AddDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(729, 397);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.deparmentText);
            this.Controls.Add(this.label1);
            this.Name = "AddDepartment";
            this.Text = "AddDepartment:";
            this.Load += new System.EventHandler(this.AddDepartment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox deparmentText;
        private System.Windows.Forms.Button Submit;
    }
}