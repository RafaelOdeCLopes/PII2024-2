﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PII2024_2
{
    public partial class Frm_Menu : Form
    {
        bool sidebarExpand;
        public Frm_Menu()
        {
            InitializeComponent();
        }

       
        private void Frm_Menu_Load(object sender, EventArgs e)
        {

        }

        private void sidebarTimer_Trick(object sender, EventArgs e)
        {

            //set min e max size

            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();

                }
            }
            
        }

        private void MenuButtom_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_Menu_Click(object sender, EventArgs e)
        {

        }
    }
}
