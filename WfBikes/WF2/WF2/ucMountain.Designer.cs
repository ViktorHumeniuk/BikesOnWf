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
            this.tbMadeIn = new System.Windows.Forms.TextBox();
            this.lbMadeIn = new System.Windows.Forms.Label();
            this.tbMaterial = new System.Windows.Forms.TextBox();
            this.lbMaterial = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbMadeIn
            // 
            this.tbMadeIn.Location = new System.Drawing.Point(116, 107);
            this.tbMadeIn.Margin = new System.Windows.Forms.Padding(2);
            this.tbMadeIn.Name = "tbMadeIn";
            this.tbMadeIn.Size = new System.Drawing.Size(44, 20);
            this.tbMadeIn.TabIndex = 20;
            // 
            // lbMadeIn
            // 
            this.lbMadeIn.AutoSize = true;
            this.lbMadeIn.Location = new System.Drawing.Point(32, 107);
            this.lbMadeIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMadeIn.Name = "lbMadeIn";
            this.lbMadeIn.Size = new System.Drawing.Size(43, 13);
            this.lbMadeIn.TabIndex = 19;
            this.lbMadeIn.Text = "MadeIn";
            // 
            // tbMaterial
            // 
            this.tbMaterial.Location = new System.Drawing.Point(84, 77);
            this.tbMaterial.Margin = new System.Windows.Forms.Padding(2);
            this.tbMaterial.Name = "tbMaterial";
            this.tbMaterial.Size = new System.Drawing.Size(76, 20);
            this.tbMaterial.TabIndex = 18;
            // 
            // lbMaterial
            // 
            this.lbMaterial.AutoSize = true;
            this.lbMaterial.Location = new System.Drawing.Point(32, 77);
            this.lbMaterial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaterial.Name = "lbMaterial";
            this.lbMaterial.Size = new System.Drawing.Size(44, 13);
            this.lbMaterial.TabIndex = 17;
            this.lbMaterial.Text = "Material";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(84, 42);
            this.tbName.Margin = new System.Windows.Forms.Padding(2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(76, 20);
            this.tbName.TabIndex = 33;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(32, 42);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 32;
            this.lbName.Text = "Name";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(84, 12);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(2);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(76, 20);
            this.tbPrice.TabIndex = 31;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(32, 12);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(31, 13);
            this.lbPrice.TabIndex = 30;
            this.lbPrice.Text = "Price";
            // 
            // UcMountain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.tbMadeIn);
            this.Controls.Add(this.lbMadeIn);
            this.Controls.Add(this.tbMaterial);
            this.Controls.Add(this.lbMaterial);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UcMountain";
            this.Size = new System.Drawing.Size(216, 148);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbMadeIn;
        private System.Windows.Forms.Label lbMadeIn;
        private System.Windows.Forms.TextBox tbMaterial;
        private System.Windows.Forms.Label lbMaterial;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lbPrice;
    }
}
