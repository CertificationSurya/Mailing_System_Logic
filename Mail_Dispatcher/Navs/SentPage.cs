﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mail_Dispatcher.Navs
{
    public partial class SentPage : Form
    {
        private readonly Dashboard _dashboard;
        public SentPage(Dashboard dashboard)
        {
            InitializeComponent();
            _dashboard = dashboard;
        }
    }
}