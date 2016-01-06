using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {

            string code;

            code = ICAO.Text;

            using (WebClient client = new WebClient())
            {
                string s = client.DownloadString(url);
                if (s == string.null) {
                    s = ("No hay datos de TAFOR para este aeropuerto :-(");
                }
                MessageBox.Show(s);
            }

            
        }

        private void ICAO_TextChanged(object sender, EventArgs e)
        {
            ICAO.MaxLength = 4;

            

       }

        private void button2_Click(object sender, EventArgs e)
                        
        {
            string code;

            code = ICAO.Text;

            using (WebClient client = new WebClient())

            {
                string s = client.DownloadString(url);
                if (s == string.null)
                {
                    s = ("No hay datos de METAR para este aeropuerto :-(");
                }
                
                MessageBox.Show(s);
            }
        }
    }
}
