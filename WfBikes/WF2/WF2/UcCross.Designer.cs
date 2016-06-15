namespace WF2
{
    partial class UcCross
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
            this.lbDiametr = new System.Windows.Forms.Label();
            this.tbDiametr = new System.Windows.Forms.TextBox();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.lbWeight = new System.Windows.Forms.Label();
            this.lbColor = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbDiametr
            // 
            this.lbDiametr.AutoSize = true;
            this.lbDiametr.Location = new System.Drawing.Point(14, 31);
            this.lbDiametr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDiametr.Name = "lbDiametr";
            this.lbDiametr.Size = new System.Drawing.Size(43, 13);
            this.lbDiametr.TabIndex = 0;
            this.lbDiametr.Text = "Diametr";
            // 
            // tbDiametr
            // 
            this.tbDiametr.Location = new System.Drawing.Point(66, 31);
            this.tbDiametr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbDiametr.Name = "tbDiametr";
            this.tbDiametr.Size = new System.Drawing.Size(76, 20);
            this.tbDiametr.TabIndex = 1;
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(98, 61);
            this.tbWeight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(44, 20);
            this.tbWeight.TabIndex = 3;
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Location = new System.Drawing.Point(14, 61);
            this.lbWeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(41, 13);
            this.lbWeight.TabIndex = 2;
            this.lbWeight.Text = "Weight";
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Location = new System.Drawing.Point(14, 93);
            this.lbColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(31, 13);
            this.lbColor.TabIndex = 4;
            this.lbColor.Text = "Color";
            // 
            // cbColor
            // 
            this.cbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(61, 93);
            this.cbColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(81, 21);
            this.cbColor.TabIndex = 5;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(66, 128);
            this.tbName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(76, 20);
            this.tbName.TabIndex = 7;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(14, 128);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 6;
            this.lbName.Text = "Name";
            // 
            // UcCross
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.lbWeight);
            this.Controls.Add(this.tbDiametr);
            this.Controls.Add(this.lbDiametr);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UcCross";
            this.Size = new System.Drawing.Size(216, 170);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDiametr;
        private System.Windows.Forms.TextBox tbDiametr;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbName;
    }
}
