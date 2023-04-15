//
//      GTOS Hosts Editor 
//      Copyright (c) 2023
//      
//      Created by BBitar#3731, Feel free to modify but 
//      don't forget to give credit.
//      github: https://github.com/BBitarX
//

using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTOS_Hosts_Editor
{
    public partial class MainForm : MaterialForm
    {
        
        
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        static readonly string hostsPath = @"C:\Windows\System32\drivers\etc\hosts";
        static readonly string serverIP = "194.62.1.35";
        static readonly string updateUrl = @"https://bbps3.000webhostapp.com/update.txt";
        //static readonly string ipUrl = @"https://bbps3.000webhostapp.com/serverip.txt";
        public MainForm()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                MaterialSkin.Primary.Indigo500,
                MaterialSkin.Primary.Indigo700,
                MaterialSkin.Primary.Indigo100,
                MaterialSkin.Accent.Pink200,
                TextShade.WHITE
                
                );
            try
            {
                string updated = new WebClient().DownloadString(updateUrl);
                if (updated == "AVAILABLE")
                {
                    Generic.showInfo("There's an update available!");
                    System.Diagnostics.Process.Start("https://github.com/BBitarX");
                }
                else if (updated == "UNAVAILABLE")
                {
                    Generic.showInfo("Started Successfully! Software is up-to-date");
                }
                else
                {
                    Generic.showInfo("Failed to fetch update data, invalid response from server.");

                }
                
            }
            catch
            {
                Generic.showInfo("Failed to fetch update data. Connect to the internet?");
            }
            string[] x = File.ReadAllLines(hostsPath);
            string y = $"GTOS is a free-to-play GTPS Server, which you can Join by pressing the 'Join GTOS Server' button\r\n\r\nFor help, please contact staff in either the discord server or the WhatsApp group, or make an issue on github.\r\n\r\nCreated by BBitar#3731";
            txtHosts.Lines = x;
            txtInfo.Text = y;

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtHosts.Lines = File.ReadAllLines(hostsPath);
            Generic.showInfo("Refreshed Successfully!");
        }

        #region oldcode
        /*private void btnJoin_Click(object sender, EventArgs e)
        {
            string[] entriesToAdd = new string[]
            {
        $"\n{serverIP} growtopia1.com",
        $"{serverIP} growtopia2.com",
        $"{serverIP} www.growtopia1.com",
        $"{serverIP} www.growtopia2.com"
            };

            string[] hostsContent = File.ReadAllLines(hostsPath);
            bool allEntriesContained = entriesToAdd.All(entry => hostsContent.Any(host => host.Contains(entry)));
            if (allEntriesContained)
            {
                // Append entries to the end of the file
                File.AppendAllLines(hostsPath, entriesToAdd);
                Generic.showInfo("Done leaving GTOS.");
            }
            else
            {
                // Remove existing entries from the file
                List<string> updatedHostsContent = new List<string>();
                foreach (var host in hostsContent)
                {
                    if (!entriesToAdd.Any(entry => host.Contains(entry)))
                    {
                        updatedHostsContent.Add(host);
                    }
                }
                File.WriteAllLines(hostsPath, updatedHostsContent);
                Generic.showInfo("Done Joining GTOS! Log on GT Now!");
            }
            txtHosts.Lines = File.ReadAllLines(hostsPath);
        }*/
        #endregion

        private void btnJoin_Click(object sender, EventArgs eventArgs)
        {
            string[] entriesToAdd = new string[]
            {
        $"194.62.1.35 growtopia1.com",
        $"194.62.1.35 growtopia2.com",
        $"194.62.1.35 www.growtopia1.com",
        $"194.62.1.35 www.growtopia2.com"
            };

            string[] hostsContent = File.ReadAllLines(hostsPath);
            bool allEntriesContained = entriesToAdd.All(entry => hostsContent.Any(host => host.Contains(entry)));

            if (!allEntriesContained)
            {
                // Remove existing entries from the file
                List<string> updatedHostsContent = new List<string>(hostsContent);
                updatedHostsContent.RemoveAll(entry => entriesToAdd.Any(e => String.Equals(entry, e, StringComparison.OrdinalIgnoreCase)));
                File.WriteAllLines(hostsPath, updatedHostsContent);

                // Append entries to the end of the file
                File.AppendAllLines(hostsPath, entriesToAdd);
                Generic.showInfo("Done Joining GTOS! Log on GT Now!");
            }
            else
            {
                Generic.showInfo("Already joined GTOS!");
            }

            txtHosts.Lines = File.ReadAllLines(hostsPath);
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string[] newHostEntry = txtHosts.Lines;
                File.WriteAllLines(hostsPath, newHostEntry);
                Generic.showInfo("Saved All Entries Successfully");
            }
            catch (Exception ex)
            {
                Generic.showError($"Encountered a problem while attempting to save.\n\nError info: {ex}");
            }
        }

        private void btnGithub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/BBitarX");

        }

        private void btnDiscord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/GTOS");
        }

        private void btnWhatsapp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://chat.whatsapp.com/FJI4NphaKN63Of0u6aoLrY");
        }


    }
}
