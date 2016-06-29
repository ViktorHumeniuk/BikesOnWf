using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF2
{
    public partial class UcCross : UserControl
    {
        private readonly int Id;

        public UcCross(int bikeId)
        {
            InitializeComponent();
            Id = bikeId;
        }

        public UcCross(Cross bike)
        {
            InitializeComponent();
            tbName.Text = bike.Name;
            tbPrice.Text = bike.Price.ToString();
            tbDiametr.Text = bike.Diametr.ToString();
            tbWeight.Text = bike.Weight.ToString();
            this.Enabled = false;
        }

        public bool ValidateControls()
        {
            if (tbName.Text.Trim() == String.Empty)
            {
                return false;
            }
            if ((float)Convert.ToDouble(tbPrice) <= 0)
            {
                return false;
            }
            if ((float)Convert.ToDouble(tbDiametr) <= 0)
            {
                return false;
            }
            if ((float)Convert.ToDouble(tbWeight) <= 0)
            {
                return false;
            }
            return true;
        }

        public Cross GetCross()
        {
            return new Cross(Id)
            {
                Name = tbName.Text,
                Price = (float)Convert.ToDouble(tbPrice),
                Diametr = (float)Convert.ToDouble(tbDiametr),
                Weight = (float)Convert.ToDouble(tbWeight)
            };
        }

        private void gbMain_Enter(object sender, EventArgs e)
        {

        }

        private void UcCross_Load(object sender, EventArgs e)
        {

        }

       

        private void UcCross_Load_1(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.tbDiametr = new System.Windows.Forms.TextBox();
            this.lbWeight = new System.Windows.Forms.Label();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.lbDiametr = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbDiametr
            // 
            this.tbDiametr.Location = new System.Drawing.Point(100, 93);
            this.tbDiametr.Margin = new System.Windows.Forms.Padding(2);
            this.tbDiametr.Name = "tbDiametr";
            this.tbDiametr.Size = new System.Drawing.Size(76, 20);
            this.tbDiametr.TabIndex = 33;
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Location = new System.Drawing.Point(48, 132);
            this.lbWeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(41, 13);
            this.lbWeight.TabIndex = 32;
            this.lbWeight.Text = "Weight";
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(100, 125);
            this.tbWeight.Margin = new System.Windows.Forms.Padding(2);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(76, 20);
            this.tbWeight.TabIndex = 31;
            // 
            // lbDiametr
            // 
            this.lbDiametr.AutoSize = true;
            this.lbDiametr.Location = new System.Drawing.Point(48, 96);
            this.lbDiametr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDiametr.Name = "lbDiametr";
            this.lbDiametr.Size = new System.Drawing.Size(43, 13);
            this.lbDiametr.TabIndex = 30;
            this.lbDiametr.Text = "Diametr";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(100, 58);
            this.tbName.Margin = new System.Windows.Forms.Padding(2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(76, 20);
            this.tbName.TabIndex = 29;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(48, 58);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 28;
            this.lbName.Text = "Name";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(100, 28);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(2);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(76, 20);
            this.tbPrice.TabIndex = 27;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(48, 28);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(31, 13);
            this.lbPrice.TabIndex = 26;
            this.lbPrice.Text = "Price";
            // 
            // UcCross
            // 
            this.Controls.Add(this.tbDiametr);
            this.Controls.Add(this.lbWeight);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.lbDiametr);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.lbPrice);
            this.Name = "UcCross";
            this.Size = new System.Drawing.Size(216, 173);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private TextBox tbDiametr;
        private Label lbWeight;
        private TextBox tbWeight;
        private Label lbDiametr;
        private TextBox tbName;
        private Label lbName;
        private TextBox tbPrice;
        private Label lbPrice;
    }
}