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

            gomboszlopa[button1] = 0;
            gomboszlopa[button2] = 1;
            gomboszlopa[button3] = 2;
            gomboszlopa[button4] = 3;
            gomboszlopa[button5] = 4;
            gomboszlopa[button6] = 5;
            gomboszlopa[button7] = 6;

            gombok = new List<Button> { button1, button2, button3, button4, button5, button6, button7 };
            foreach (Button gomb in gombok)
            {
                gomb.Width = 70;
            }

        }

        int kijön = 0;
        List<int> oszlopmagasságok = new List<int> { 0, 0, 0, 0, 0, 0, 0 };
        Dictionary<Button, int> gomboszlopa = new Dictionary<Button,int>();
        List<Button> gombok = new List<Button>();

        int meret = 30;

        const int n = 7;
        const int m = 5;
        int[,] matrix = new int[n, m];

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


            matrix[gomboszlopa[gomb], oszlopmagasságok[gomboszlopa[gomb]]] = 1 + kijön;

            oszlopmagasságok[gomboszlopa[gomb]]++;
            gomb.Text = gomboszlopa[gomb].ToString() + ". gomb: "+ oszlopmagasságok[gomboszlopa[gomb]];

            //meret += 10;


            pictureBox1.Refresh();
            


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


        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;


            for (int i = 0; i < n; i++) // sorok
            {
                for (int j = 0; j < m; j++) // oszlopok
                {
                    if (matrix[i, j]==1)
                    {
                        gr.FillEllipse(new SolidBrush(Color.Red), new Rectangle(new Point(40 + i * 80, 200-(40 + j * 30)), new Size(meret, meret)));
                    }
                    else if (matrix[i, j] == 2)
                    {
                        gr.FillEllipse(new SolidBrush(Color.Yellow), new Rectangle(new Point(40 + i * 80, 200-(40 + j * 30)), new Size(meret, meret)));
                    }
                }
            }


        }
    }
}
