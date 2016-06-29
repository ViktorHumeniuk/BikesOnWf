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
            this.tbOld = new System.Windows.Forms.TextBox();
            this.lbOld = new System.Windows.Forms.Label();
            this.tbSpeed = new System.Windows.Forms.TextBox();
            this.lbSpeed = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbOld
            // 
            this.tbOld.Location = new System.Drawing.Point(116, 111);
            this.tbOld.Margin = new System.Windows.Forms.Padding(2);
            this.tbOld.Name = "tbOld";
            this.tbOld.Size = new System.Drawing.Size(44, 20);
            this.tbOld.TabIndex = 12;
            // 
            // lbOld
            // 
            this.lbOld.AutoSize = true;
            this.lbOld.Location = new System.Drawing.Point(32, 111);
            this.lbOld.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOld.Name = "lbOld";
            this.lbOld.Size = new System.Drawing.Size(23, 13);
            this.lbOld.TabIndex = 11;
            this.lbOld.Text = "Old";
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(84, 81);
            this.tbSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(76, 20);
            this.tbSpeed.TabIndex = 10;
            // 
            // lbSpeed
            // 
            this.lbSpeed.AutoSize = true;
            this.lbSpeed.Location = new System.Drawing.Point(32, 81);
            this.lbSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSpeed.Name = "lbSpeed";
            this.lbSpeed.Size = new System.Drawing.Size(38, 13);
            this.lbSpeed.TabIndex = 9;
            this.lbSpeed.Text = "Speed";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(84, 51);
            this.tbName.Margin = new System.Windows.Forms.Padding(2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(76, 20);
            this.tbName.TabIndex = 33;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(32, 51);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 32;
            this.lbName.Text = "Name";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(84, 21);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(2);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(76, 20);
            this.tbPrice.TabIndex = 31;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(32, 21);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(31, 13);
            this.lbPrice.TabIndex = 30;
            this.lbPrice.Text = "Price";
            // 
            // UcHardTail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.tbOld);
            this.Controls.Add(this.lbOld);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.lbSpeed);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UcHardTail";
            this.Size = new System.Drawing.Size(252, 151);
            this.Load += new System.EventHandler(this.UcHardTail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbOld;
        private System.Windows.Forms.Label lbOld;
        private System.Windows.Forms.TextBox tbSpeed;
        private System.Windows.Forms.Label lbSpeed;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lbPrice;
    }
}
