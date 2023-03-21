using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public static int numOfCoins;
        public TextBox[] coins ;
        public static int[] pots;
        public static Form3 instance;
        public Form3()
        {
            InitializeComponent();
            instance = this;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            
            if (numOfCoinsText.Text != null && numOfCoinsText.Text!="")
            {
                int.TryParse(numOfCoinsText.Text, out int numOfCoins);
                if(numOfCoins == null)
                {
                    validlbl.Text = "Not Valid Input";
                    return;
                }
                coins = new TextBox[numOfCoins];
                for(int i = 0; i < numOfCoins; i++)
                {
                    coins[i] = new TextBox();
                    coins[i].Name = "textBox"+(i+1);
                    coins[i].PlaceholderText = "Enter Coin "+ (i + 1);
                    coins[i].Size = new System.Drawing.Size(88, 23);
                    coins[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                    containerOfCoins.Controls.Add(coins[i]);
                }
            }
            else
            {
                validlbl.Text = "You Must Fill The Field Of Coins Number";
                return;
            }
        }

        private void vttbtn_Click(object sender, EventArgs e)
        {
            if(numOfCoinsText.Text != null && numOfCoinsText.Text != "")
            {
                int.TryParse(numOfCoinsText.Text, out int n);
                if (n == null)
                {
                    validlbl.Text = "Not Valid Input For Coins Field ";
                    return;
                }
                else
                {
                    numOfCoins = n;
                    pots = new int[numOfCoins];
                }
                for(int i = 0; i < n; i++)
                {
                    if (coins[i].Text is null|| coins[i].Text == "")
                    {
                        validlbl.Text = $"You Must Fill All The Field Coins! Try Again.";
                        return;
                    }
                    else
                    {
                        int.TryParse(coins[i].Text, out int x);
                            if (x != null)
                            {
                                pots[i] = x;
                            }
                            else
                            {
                                validlbl.Text = "InValid Input";
                                return;
                            }
                    }
                    
                }
                Form1 form = new Form1();
                form.Show();
            }
                
        }

        private void vtgBtn_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void vtfBtn_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
        }
    }
}

