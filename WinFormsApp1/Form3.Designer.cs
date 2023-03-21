namespace WinFormsApp1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numOfCoinslbl = new System.Windows.Forms.Label();
            this.numOfCoinsText = new System.Windows.Forms.TextBox();
            this.containerOfCoins = new System.Windows.Forms.FlowLayoutPanel();
            this.nextBtn = new System.Windows.Forms.Button();
            this.vtfBtn = new System.Windows.Forms.Button();
            this.vtgBtn = new System.Windows.Forms.Button();
            this.vttbtn = new System.Windows.Forms.Button();
            this.validlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numOfCoinslbl
            // 
            this.numOfCoinslbl.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.numOfCoinslbl.Location = new System.Drawing.Point(12, 23);
            this.numOfCoinslbl.Name = "numOfCoinslbl";
            this.numOfCoinslbl.Size = new System.Drawing.Size(177, 23);
            this.numOfCoinslbl.TabIndex = 0;
            this.numOfCoinslbl.Text = "Enter Number Of Coins : ";
            // 
            // numOfCoinsText
            // 
            this.numOfCoinsText.Location = new System.Drawing.Point(224, 22);
            this.numOfCoinsText.Name = "numOfCoinsText";
            this.numOfCoinsText.Size = new System.Drawing.Size(125, 23);
            this.numOfCoinsText.TabIndex = 1;
            // 
            // containerOfCoins
            // 
            this.containerOfCoins.AutoScroll = true;
            this.containerOfCoins.BackColor = System.Drawing.Color.Silver;
            this.containerOfCoins.Location = new System.Drawing.Point(47, 64);
            this.containerOfCoins.Name = "containerOfCoins";
            this.containerOfCoins.Size = new System.Drawing.Size(758, 146);
            this.containerOfCoins.TabIndex = 2;
            // 
            // nextBtn
            // 
            this.nextBtn.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.nextBtn.Location = new System.Drawing.Point(634, 22);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 29);
            this.nextBtn.TabIndex = 3;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // vtfBtn
            // 
            this.vtfBtn.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.vtfBtn.Location = new System.Drawing.Point(188, 374);
            this.vtfBtn.Name = "vtfBtn";
            this.vtfBtn.Size = new System.Drawing.Size(474, 47);
            this.vtfBtn.TabIndex = 4;
            this.vtfBtn.Text = "View The Formula";
            this.vtfBtn.UseVisualStyleBackColor = true;
            this.vtfBtn.Click += new System.EventHandler(this.vtfBtn_Click);
            // 
            // vtgBtn
            // 
            this.vtgBtn.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.vtgBtn.Location = new System.Drawing.Point(188, 321);
            this.vtgBtn.Name = "vtgBtn";
            this.vtgBtn.Size = new System.Drawing.Size(474, 47);
            this.vtgBtn.TabIndex = 7;
            this.vtgBtn.Text = "View The Game";
            this.vtgBtn.UseVisualStyleBackColor = true;
            this.vtgBtn.Click += new System.EventHandler(this.vtgBtn_Click);
            // 
            // vttbtn
            // 
            this.vttbtn.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.vttbtn.Location = new System.Drawing.Point(188, 268);
            this.vttbtn.Name = "vttbtn";
            this.vttbtn.Size = new System.Drawing.Size(474, 47);
            this.vttbtn.TabIndex = 8;
            this.vttbtn.Text = "View The Table";
            this.vttbtn.UseVisualStyleBackColor = true;
            this.vttbtn.Click += new System.EventHandler(this.vttbtn_Click);
            // 
            // validlbl
            // 
            this.validlbl.Font = new System.Drawing.Font("Segoe UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.validlbl.ForeColor = System.Drawing.Color.Red;
            this.validlbl.Location = new System.Drawing.Point(224, 228);
            this.validlbl.Name = "validlbl";
            this.validlbl.Size = new System.Drawing.Size(368, 25);
            this.validlbl.TabIndex = 9;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 450);
            this.Controls.Add(this.validlbl);
            this.Controls.Add(this.vttbtn);
            this.Controls.Add(this.vtgBtn);
            this.Controls.Add(this.vtfBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.containerOfCoins);
            this.Controls.Add(this.numOfCoinsText);
            this.Controls.Add(this.numOfCoinslbl);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label numOfCoinslbl;
        private TextBox numOfCoinsText;
        private FlowLayoutPanel containerOfCoins;
        private Button nextBtn;
        private Button vtfBtn;
        private Button vtgBtn;
        private Button vttbtn;
        private Label validlbl;
    }
}