﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseDados
{
    public partial class FAccess : Form
    {
        OleDbConnection Con = new OleDbConnection();
        int XBotao;

        public FAccess()
        {
            InitializeComponent();
        }

        private void FAccess_Load(object sender, EventArgs e)
        {

        }
    }
}
