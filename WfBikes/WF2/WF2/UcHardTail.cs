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
    public partial class UcHardTail : UserControl
    {
        private readonly int Id;

        public UcHardTail(int bikeId)
        {
            InitializeComponent();
            Id = bikeId;
        }

        public UcHardTail(Cross bike)
        {
            InitializeComponent();
            tbName.Text = bike.Name;
            tbPrice.Text = bike.Price.ToString();
            tbSpeed.Text = bike.;
            tbOld.Text = bike.Weight.ToString();
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

        public HardTail GetHardTail()
        {
            return new HardTail(Id)
            {
                Name = tbName.Text,
                Price = (float)Convert.ToDouble(tbPrice),
                Diametr = (float)Convert.ToDouble(tbDiametr),
                Weight = (float)Convert.ToDouble(tbWeight)
            };
        }

    }
}
