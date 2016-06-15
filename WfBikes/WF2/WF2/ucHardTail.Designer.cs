namespace WF2
{
    partial class UcHardTail
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
            this.tblName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.lbColor = new System.Windows.Forms.Label();
            this.tbOld = new System.Windows.Forms.TextBox();
            this.lbOld = new System.Windows.Forms.Label();
            this.tbSpeed = new System.Windows.Forms.TextBox();
            this.lbSpeed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tblName
            // 
            this.tblName.Location = new System.Drawing.Point(82, 113);
            this.tblName.Margin = new System.Windows.Forms.Padding(2);
            this.tblName.Name = "tblName";
            this.tblName.Size = new System.Drawing.Size(76, 20);
            this.tblName.TabIndex = 16;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(30, 113);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 15;
            this.lbName.Text = "Name";
            // 
            // cbColor
            // 
            this.cbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(77, 78);
            this.cbColor.Margin = new System.Windows.Forms.Padding(2);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(81, 21);
            this.cbColor.TabIndex = 14;
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Location = new System.Drawing.Point(30, 78);
            this.lbColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(31, 13);
            this.lbColor.TabIndex = 13;
            this.lbColor.Text = "Color";
            // 
            // tbOld
            // 
            this.tbOld.Location = new System.Drawing.Point(114, 46);
            this.tbOld.Margin = new System.Windows.Forms.Padding(2);
            this.tbOld.Name = "tbOld";
            this.tbOld.Size = new System.Drawing.Size(44, 20);
            this.tbOld.TabIndex = 12;
            // 
            // lbOld
            // 
            this.lbOld.AutoSize = true;
            this.lbOld.Location = new System.Drawing.Point(30, 46);
            this.lbOld.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOld.Name = "lbOld";
            this.lbOld.Size = new System.Drawing.Size(23, 13);
            this.lbOld.TabIndex = 11;
            this.lbOld.Text = "Old";
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(82, 16);
            this.tbSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(76, 20);
            this.tbSpeed.TabIndex = 10;
            // 
            // lbSpeed
            // 
            this.lbSpeed.AutoSize = true;
            this.lbSpeed.Location = new System.Drawing.Point(30, 16);
            this.lbSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSpeed.Name = "lbSpeed";
            this.lbSpeed.Size = new System.Drawing.Size(38, 13);
            this.lbSpeed.TabIndex = 9;
            this.lbSpeed.Text = "Speed";
            // 
            // UcHardTail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.tbOld);
            this.Controls.Add(this.lbOld);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.lbSpeed);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UcHardTail";
            this.Size = new System.Drawing.Size(252, 151);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tblName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.TextBox tbOld;
        private System.Windows.Forms.Label lbOld;
        private System.Windows.Forms.TextBox tbSpeed;
        private System.Windows.Forms.Label lbSpeed;
    }
}
