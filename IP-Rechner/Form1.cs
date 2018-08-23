using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP_Rechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class global
        {
            public static int[] ipint = { 0, 0, 0, 0 };
            public static byte[] imsk = { 0, 0, 0, 0 };
            public static int[] ntzid = { 0, 0, 0, 0 };
            public static int counter = 0;
            public static int counter2 = 0;
        };

        public static byte BitStringToInt(string bits)
        {
            var reversedBits = bits.Reverse().ToArray();
            byte num = 0;
            for (var power = 0; power < reversedBits.Count(); power++)
            {
                var currentBit = reversedBits[power];
                if (currentBit == '1')
                {
                    var currentNum = (byte)Math.Pow(2, power);
                    num += currentNum;
                }
            }

            return num;
        }

        public void Clear()
        {
            ipb.Text = "";
            mskb.Text = "";
            nab.Text = "";
            nad.Text = "";
            bad.Text = "";
            bab.Text = "";
            global.counter = 0;
            global.counter2 = 0;
            for (int i = 0; i < 4; i++)
            {
                global.ipint[i] = 0;
                global.imsk[i] = 0;
                global.ntzid[i] = 0;
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            Clear();
            try
            {               
                string ipvar = ip.Text;
                string[] ipstring = ipvar.Split('.');
                string msktext = msk.Text;
                int mskcount = Int32.Parse(msktext);
                string mskstring = "";
                for (int i = 0; i < mskcount; i++)
                {
                    mskstring += "1";
                    global.counter++;
                    if ((global.counter >= 8) && (global.counter2 < 3))
                    {
                        global.counter = 0;
                        global.counter2++;
                        mskstring += ".";
                    }
                }
                for (int i = mskcount; i < mskcount + 32 - mskcount; i++)
                {
                    mskstring += "0";
                    global.counter++;
                    if ((global.counter >= 8) && (global.counter2 < 3))
                    {
                        global.counter = 0;
                        global.counter2++;
                        mskstring += ".";
                    }
                }
                mskstring.Insert(8, ".");
                mskstring.Insert(16, ".");
                mskstring.Insert(24, ".");
                mskb.Text = mskstring;
                string[] mskstr = mskstring.Split('.');
                for (int i = 0; i < 4; i++)
                {
                    global.ipint[i] = Int32.Parse(ipstring[i]);
                    global.imsk[i] = BitStringToInt(mskstr[i]);
                    ipb.Text += Convert.ToString(global.ipint[i], 2).PadLeft(8, '0');
                    global.ntzid[i] = global.ipint[i] & global.imsk[i];
                    nad.Text += global.ntzid[i].ToString() + ".";
                    nab.Text += Convert.ToString(global.ntzid[i], 2).PadLeft(8, '0');
                    mskstr[i] = mskstr[i].Replace("1", "2");
                    mskstr[i] = mskstr[i].Replace("0", "1");
                    mskstr[i] = mskstr[i].Replace("2", "0");
                    bab.Text += Convert.ToString(global.ipint[i] | BitStringToInt(mskstr[i]), 2).PadLeft(8, '0');
                    bad.Text += (global.ipint[i] | BitStringToInt(mskstr[i])).ToString();
                    if (i < 3)
                    {
                        bab.Text += ".";
                        bad.Text += ".";
                        nab.Text += ".";
                        ipb.Text += ".";
                    }

                }
            }
            catch
            {
                MessageBox.Show("Please insert valid data");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clr_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
