﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WashablesSystem
{
    public partial class notifItem : UserControl
    {
        public notifItem()
        {
            InitializeComponent();
        }
        public void setNotif(string notif)
        {
            activityText.Text = notif;
        }
    }
}