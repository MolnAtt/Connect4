using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Click += button1_Click;
            button3.Click += button1_Click;
            button4.Click += button1_Click;
            button5.Click += button1_Click;
            button6.Click += button1_Click;
            button7.Click += button1_Click;
        }

        int kijön = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (kijön == 0)
            {
                label2.Text = "sárga";
            }
            else
            {
                label2.Text = "piros";
            }
            kijön = 1-kijön;

            Button gomb = sender as Button;

            gomb.Text = "lenyomódtam";

            /*Ide az kéne, hogy ha valaki lenyomja a gombot, akkor 
             a MEGNYOMOTT GOMB (gomb) alá terem egy golyó, elindul egy metronóm, 
            a metronóm úsztatja lefele a golyót, és ha eléri a helyét, akkor megáll.
             */


            /*
             * 1. részfeladat: ha megnyomsz egy gombot, induljon el egy kör, egy fix helyen
             * 2. részfeladat, ha megnyomsz egy gombot, induljon el egy kör, egy fix helyen, de aztán álljon meg valahol.
             * 3. részfeladat, ha megnyomsz egy gombot, induljon el egy kör, egy fix helyen, de aztán álljon meg valahol. De ha még egyszer megnyomod, akkor hamarabb álljon meg. legalább 6-szor működjön!
             * 4. részfeladat, ha megnyomsz egy gombot, induljon el egy kör a megnyomott gomb alatt, de aztán álljon meg valahol. De ha még egyszer megnyomod, akkor hamarabb álljon meg. legalább 6-szor működjön!
             * 5. részfeladat, ha megnyomsz egy gombot, induljon el egy kör a megnyomott gomb alatt, de aztán álljon meg valahol. De ha még egyszer megnyomod, akkor csak akkor álljon meg hamarabb, ha már van alatta valamit.
             * 
             */

        }
    }
}
