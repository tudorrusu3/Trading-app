﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW
{
    public partial class Form3 : Form
    {
        public Form3(DataSet ds)
        {
            InitializeComponent();
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
