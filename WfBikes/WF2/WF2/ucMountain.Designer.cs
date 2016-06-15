namespace WF2
{
    partial class UcMountain
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.lbColor = new System.Windows.Forms.Label();
            this.tbMadeIn = new System.Windows.Forms.TextBox();
            this.lbMadeIn = new System.Windows.Forms.Label();
            this.tbMaterial = new System.Windows.Forms.TextBox();
            this.lbMaterial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(80, 113);
            this.tbName.Margin = new System.Windows.Forms.Padding(2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(76, 20);
            this.tbName.TabIndex = 24;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(28, 113);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 23;
            this.lbName.Text = "Name";
            // 
            // cbColor
            // 
            this.cbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(75, 78);
            this.cbColor.Margin = new System.Windows.Forms.Padding(2);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(81, 21);
            this.cbColor.TabIndex = 22;
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Location = new System.Drawing.Point(28, 78);
            this.lbColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(31, 13);
            this.lbColor.TabIndex = 21;
            this.lbColor.Text = "Color";
            // 
            // tbMadeIn
            // 
            this.tbMadeIn.Location = new System.Drawing.Point(112, 46);
            this.tbMadeIn.Margin = new System.Windows.Forms.Padding(2);
            this.tbMadeIn.Name = "tbMadeIn";
            this.tbMadeIn.Size = new System.Drawing.Size(44, 20);
            this.tbMadeIn.TabIndex = 20;
            // 
            // lbMadeIn
            // 
            this.lbMadeIn.AutoSize = true;
            this.lbMadeIn.Location = new System.Drawing.Point(28, 46);
            this.lbMadeIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMadeIn.Name = "lbMadeIn";
            this.lbMadeIn.Size = new System.Drawing.Size(43, 13);
            this.lbMadeIn.TabIndex = 19;
            this.lbMadeIn.Text = "MadeIn";
            // 
            // tbMaterial
            // 
            this.tbMaterial.Location = new System.Drawing.Point(80, 16);
            this.tbMaterial.Margin = new System.Windows.Forms.Padding(2);
            this.tbMaterial.Name = "tbMaterial";
            this.tbMaterial.Size = new System.Drawing.Size(76, 20);
            this.tbMaterial.TabIndex = 18;
            // 
            // lbMaterial
            // 
            this.lbMaterial.AutoSize = true;
            this.lbMaterial.Location = new System.Drawing.Point(28, 16);
            this.lbMaterial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaterial.Name = "lbMaterial";
            this.lbMaterial.Size = new System.Drawing.Size(44, 13);
            this.lbMaterial.TabIndex = 17;
            this.lbMaterial.Text = "Material";
            // 
            // UcMountain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.tbMadeIn);
            this.Controls.Add(this.lbMadeIn);
            this.Controls.Add(this.tbMaterial);
            this.Controls.Add(this.lbMaterial);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UcMountain";
            this.Size = new System.Drawing.Size(216, 148);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.TextBox tbMadeIn;
        private System.Windows.Forms.Label lbMadeIn;
        private System.Windows.Forms.TextBox tbMaterial;
        private System.Windows.Forms.Label lbMaterial;
    }
}
