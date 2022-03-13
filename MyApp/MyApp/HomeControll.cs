using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Shop
{
    public partial class HomeControll : UserControl
    {
        public HomeControll()
        {
            InitializeComponent();
        }

        private void linkYT_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://www.youtube.com/channel/UC652oRUvX1onwrrZ8ADJRPw",
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://www.instagram.com/nothing_sb0/",
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://mail.google.com/mail/u/1/#inbox?compose=GTvVlcRzCMtPpDVSsbFBVsvJHdrRwhnTnSwJGcnQZXWkhCDgGkQXpZPxcHkZVJtNrspxlwhhjGKMP",
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://github.com/JLW157",
                UseShellExecute = true
            };
            Process.Start(psi);
        
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://www.linkedin.com/in/alex-biletskyi-367064228/",
                UseShellExecute = true
            };
            Process.Start(psi);
        }
    }
}
