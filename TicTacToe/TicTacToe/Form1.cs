using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {

        string[,] komsulukMatrisi = new string[8, 3] {

            {"Btn1","Btn2","Btn3"},
            {"Btn4","Btn5","Btn6"},
            {"Btn7","Btn8","Btn9"}, 
            {"Btn1","Btn5","Btn9"}, 
            {"Btn1","Btn4","Btn7"}, 
            {"Btn2","Btn5","Btn8"}, 
            {"Btn3","Btn6","Btn9"},
            {"Btn3","Btn5","Btn7"}

        };

        string isaret = "X";
        List<Button> kontrol = new List<Button>();
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonsClick(object sender, EventArgs e)
        {
            Button buton = (Button)sender;

            buton.Text = isaret;


            for (int i = 0; i < komsulukMatrisi.GetLength(0); i++)
            {
                for (int j = 0; j < komsulukMatrisi.GetLength(1); j++)
                {
                    foreach (Button btn in oyunAlaniGbx.Controls)
                    {
                        if(btn.Name == komsulukMatrisi[i, j])
                        {
                            kontrol.Add(btn);
                        }
                    }
                }

                if (kontrol[0].Text != "" && kontrol[1].Text != "" && kontrol[2].Text != "")
                {
                    if(kontrol[0].Text == kontrol[1].Text && kontrol[1].Text == kontrol[2].Text)
                    {
                        OyunBitti(true);
                        break;
                    }
                }

                kontrol.Clear();

            }


            foreach (Button btn in oyunAlaniGbx.Controls)
            {
                if (btn.Text.Length>0)
                {
                    count++;
                }
            }

            if(count == 9)
            {
                OyunBitti(false);
            }

            isaret = (isaret == "X" ? isaret = "O" : isaret = "X");

            count = 0;
        }

        private void OyunBitti(bool value)
        {
            if (value)
            {
                DialogResult result =  MessageBox.Show("Oyun Bitti! Kazanan =>" + isaret+" Yeniden Oynamak İstiyormusunuz?","Oyun Bitti",MessageBoxButtons.YesNo);

                if(result is DialogResult.Yes)
                {
                    Application.Restart();
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Oyun Bitti! Kazanan YOK!!! Yeniden Oynamak İstiyormusunuz?", "Oyun Bitti", MessageBoxButtons.YesNo);

                if (result is DialogResult.Yes)
                {
                    Application.Restart();
                }
                else
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
