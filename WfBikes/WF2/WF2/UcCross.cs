﻿using System;
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
        public UcCross()
        {
            InitializeComponent();
        }

        public Cross GetCross()
        {
            return new Cross()
            {
                Name = tbName.Text;
                Size = tbSize.Text.GetInt();
            };
        }

        private void UcCross_Load(object sender, EventArgs e)
        {

        }
    }

    private void UcCross_Load(object sender, EventArgs e)
        {

        }
    }
}
