using System.Drawing;
using System.Security.Policy;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public static NPotGold npg;
        public static Pair[,] moves;
        public static Form1 instance;
        public int[] pots;
        public Form1()
        {
            InitializeComponent();
            instance = this;
            pots = Form3.pots;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c = Form3.numOfCoins;
            float size = (float)100 / c;
            TableLayoutPanel tlp = new TableLayoutPanel();
            tlp.BackColor = System.Drawing.Color.DarkGray;
            tlp.ColumnCount = c;
            for (int i = 0; i < c; i++)
            {
                tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, size));
            }
            tlp.ForeColor = System.Drawing.Color.White;
            tlp.Location = new System.Drawing.Point(405, 113);
            tlp.Margin = new System.Windows.Forms.Padding(2);
            tlp.Name = "tlp";
            tlp.RowCount = c;
            for (int i = 0; i < c; i++)
            {
                tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, size));
            }
            tlp.Size = new System.Drawing.Size(100 * c, 50 * c);
            tlp.TabIndex = 3;
            npg = new NPotGold();
            moves = npg.findMoves(pots);
            int s = moves.Length;
            Label[] lbls = new Label[s];
            int counter = -1;
            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    lbls[++counter] = new Label();
                    lbls[counter].Name = $"lbls{counter}";
                    lbls[counter].Size = new System.Drawing.Size(47, 25);
                    lbls[counter].Text = $"{moves[i, j].first},{moves[i, j].second}";
                    lbls[counter].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    tlp.Controls.Add(lbls[counter], j, i);
                }
            }
            this.Controls.Add(tlp);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}