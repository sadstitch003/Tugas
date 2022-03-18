using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnProses_Click(object sender, EventArgs e)
        {
            if (TxtboxInput.Text.ToUpper().IndexOf("ISI:") == 0)
            {
                LblOutput.Text = TxtboxInput.Text.Remove(0, 4); 
            }
            else if (TxtboxInput.Text.ToUpper().IndexOf("WARNA:") == 0)
            {
                if (TxtboxInput.Text.ToUpper().IndexOf("MERAH") == 6)
                {
                    LblOutput.ForeColor = Color.Red;
                }
                else if (TxtboxInput.Text.Remove(0, 6) == "HIJAU")
                {
                    LblOutput.ForeColor = Color.Green;
                }
                else if (TxtboxInput.Text.Remove(0, 6) == "BIRU")
                {
                    LblOutput.ForeColor = Color.Blue;
                }
                else if (TxtboxInput.Text.Remove(0, 6) == "DEFAULT")
                {
                    LblOutput.ForeColor = Color.Black;
                }
                else
                {
                    LblOutput.Text = "Syntax tidak terdaftar !";
                }
            }
            else if (TxtboxInput.Text.ToUpper() == "SHOWN")
            {
                TxtboxInput.Visible = true;
            }
            else if (TxtboxInput.Text.ToUpper() == "HIDE")
            {
                LblOutput.Visible = false;
            }
            else if (TxtboxInput.Text.ToUpper() == "BESARKAN")
            {
                LblOutput.Font = new System.Drawing.Font(LblOutput.Font.FontFamily, LblOutput.Font.Size + 1F, LblOutput.Font.Style);
            } 
            else if (TxtboxInput.Text.ToUpper() == "KECILKAN") 
            {
                if (LblOutput.Font.Size > 7) LblOutput.Font = new System.Drawing.Font(LblOutput.Font.FontFamily, LblOutput.Font.Size - 1F, LblOutput.Font.Style);
            }
            else if (TxtboxInput.Text.ToUpper() == "RESET")
            {
                LblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                LblOutput.Text = "[RESET]";
            } 
            else
            {
                LblOutput.Text = "Syntax tidak terdaftar !";
            }

            TxtboxInput.Text = "";
        }
    }
}
