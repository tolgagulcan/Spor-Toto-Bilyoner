using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Specialized;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        StringCollection tumkuponlar = new StringCollection();
        bool a = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void w1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int counter = 0;
            string line;

            

            // Read the file and display it line by line.
            System.IO.StreamReader file =
               new System.IO.StreamReader("test.txt");
            while ((line = file.ReadLine()) != null)
            {
                if (line.Trim()!="")
                {
                    tumkuponlar.Add(line);
                    counter++;
                }
              
            }

         file.Close();
            

          
        }


        public bool testet()
        {

            string dogru = "0-1-1-2-2-1-2-0-0-0-1-1-2-1-2";
            dogru = t1.Text;
            string[] d = dogru.Split('-');

            if (d.Length!=15)
            {
                MessageBox.Show("HATA VAR");
                return false;
            }

           


            int[] sayim = new int[16] {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };


            foreach (var item in tumkuponlar)
            {
                int say = 0;
                string[] a = item.Split('-');

                for (int i = 0; i < 15; i++)
                {
                    if (d[i]==a[i])
                    {
                        say++;
                    }
                }

                sayim[say]++;



            }

            string stra = "";
            for (int i = 0; i < 16; i++)
            {
                stra = stra+i.ToString() + "-" + sayim[i].ToString() + "&";   

            }

            MessageBox.Show(stra);

            return false;

        }

        public bool play() {

            
            

            if (tumkuponlar.Count==0)
            {
                return true;
            }


            for (int i = 0; i < 4; i++)
            {

                
                string kupon = tumkuponlar[0];
                tumkuponlar.RemoveAt(0);

                string[] a = kupon.Split('-');

                for (int b = 0; b < 15; b++)
                {

                    int h = a[b].Length;
                    for (int c = 0; c < h; c++)
                    {
                        string id = idgonder(i + 1, int.Parse((a[b][c]).ToString()),b+1);
                        w1.Document.GetElementById(id).InvokeMember("click");
                    }
                }


                if (tumkuponlar.Count == 0)
                {
                    return true;
                }



            }


            return false;

        }

        public string idgonder(int kolon, int sonuc,int mac) {

            string id="";
            id = "ckid";

            
            // KOLON BELİRLEME
            id = (kolon == 1) ? id + "A" : id;
            id = (kolon == 2) ? id + "B" : id;
            id = (kolon == 3) ? id + "C" : id;
            id = (kolon == 4) ? id + "D" : id;

            //



            //SONUC BELİRLEME
            id = (sonuc == 1) ? id + "Bir" : id;
            id = (sonuc == 0) ? id + "X" : id;
            id = (sonuc == 2) ? id + "Iki" : id;
            //

            //Mac belirleme
            id = id + mac.ToString();

            //
            return id;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            w1.DocumentCompleted += kkk;
            w1.Navigate("https://www.bilyoner.com/spor-toto/bahis-yap");



        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void kkk(object sender, WebBrowserDocumentCompletedEventArgs e)
        {


            //MessageBox.Show(e.Url.ToString());
            //MessageBox.Show("https://www.bilyoner.com/spor-toto/bahis-yap");

            
            if (e.Url.ToString() == "https://www.bilyoner.com/spor-toto/spor-toto-onay")
            {

                string jCode = "onayla(7);";
                w1.Document.InvokeScript("eval", new object[] { jCode });

            }

            if (e.Url.ToString() == "https://www.bilyoner.com/spor-toto/SporTotoPlay")
            {

                if (a) { w1.DocumentCompleted -= kkk; MessageBox.Show("Finished"); }
                w1.Navigate("https://www.bilyoner.com/spor-toto/bahis-yap");

            }

            if (e.Url.ToString() == "https://www.bilyoner.com/spor-toto/bahis-yap")
            {
              
                a = play();

                

                string jCode = "sporTotoOnay();";
                w1.Document.InvokeScript("eval", new object[] { jCode });

            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            testet();
        }
    }
}
