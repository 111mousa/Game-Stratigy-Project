using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public int result1 = 0;
        public int current1 = 0;
        public int result2 = 0;
        public int current2 = 0;
        public bool flage = false;
        public bool play = false;
        public Button[] coins;
        public static Form2 instance;
        public Form2()
        {
            InitializeComponent();
            instance = this;
        }

        private void container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (flage == false)
            {
                Form1.npg.printSequence(Form3.pots, Form1.moves);
                coins = new Button[Form3.numOfCoins];
                for(int i = 0; i < Form3.numOfCoins; i++)
                {
                    coins[i] = new Button();
                    coins[i].Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    coins[i].Location = new System.Drawing.Point(3, 3);
                    coins[i].Name = "coins"+i;
                    coins[i].Size = new System.Drawing.Size(41, 38);
                    coins[i].Text = ""+(Form3.pots[i]);
                    coins[i].UseVisualStyleBackColor = true;
                    this.container.Controls.Add(coins[i]);
                }
                flage = true;
            }
            else
            {
                int counter = 0;
                if(play == false)
                {
                    if(Program.pl1.Count()>0||Program.pl2.Count()>0)
                    if (coins[counter].Name.Contains("" + Program.pl1.Peek()))
                    {
                        player1Box.Controls.Add(coins[counter]);
                           current1=  int.Parse(player1Result.Text);
                             result1 = current1 + int.Parse(coins[counter].Text);
                            player1Result.Text = ""+result1;
                        container.Controls.Remove(coins[counter++]);
                        Program.pl1.Dequeue();
                        play = true;
                    }
                    else
                    {
                                player1Box.Controls.Add(coins[Form3.numOfCoins-1]);
                                container.Controls.Remove(coins[Form3.numOfCoins-1]);
                             current1 = int.Parse(player1Result.Text);
                            result1 = current1 + int.Parse(coins[Form3.numOfCoins - 1].Text);
                            player1Result.Text = "" + result1;
                            Program.pl1.Dequeue();
                                Form3.numOfCoins--;
                                play = true;
                            }
                }
                else
                {
                    if (Program.pl1.Count() > 0 || Program.pl2.Count() > 0)
                        if (coins[counter].Name.Contains("" + Program.pl2.Peek()))
                    {
                        player2Box.Controls.Add(coins[counter]);
                        container.Controls.Remove(coins[counter++]);
                            current2 = int.Parse(player2Result.Text);
                            result2 = current2 + int.Parse(coins[counter].Text);
                            player2Result.Text = "" + result2;
                            Program.pl2.Dequeue();
                        play = false;
                    }
                    else
                    {
                        player2Box.Controls.Add(coins[Form3.numOfCoins-1]);
                        container.Controls.Remove(coins[Form3.numOfCoins - 1]);
                            current2 = int.Parse(player2Result.Text);
                            result2 = current2 + int.Parse(coins[Form3.numOfCoins - 1].Text);
                            player2Result.Text = "" + result2;
                            Program.pl2.Dequeue();
                        Form3.numOfCoins--;
                        play = false;
                    }
                }
            }
            
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void player2Result_Click(object sender, EventArgs e)
        {

        }
    }
}
