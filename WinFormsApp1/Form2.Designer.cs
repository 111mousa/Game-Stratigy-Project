namespace WinFormsApp1
{
    partial class Form2
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
            this.vsButton = new System.Windows.Forms.Button();
            this.player2Result = new System.Windows.Forms.Button();
            this.player1Result = new System.Windows.Forms.Button();
            this.player2Box = new System.Windows.Forms.FlowLayoutPanel();
            this.player1Box = new System.Windows.Forms.FlowLayoutPanel();
            this.container = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.prevBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // vsButton
            // 
            this.vsButton.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.vsButton.Location = new System.Drawing.Point(363, 31);
            this.vsButton.Name = "vsButton";
            this.vsButton.Size = new System.Drawing.Size(75, 60);
            this.vsButton.TabIndex = 16;
            this.vsButton.Text = "VS";
            this.vsButton.UseVisualStyleBackColor = true;
            // 
            // player2Result
            // 
            this.player2Result.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.player2Result.Location = new System.Drawing.Point(455, 31);
            this.player2Result.Name = "player2Result";
            this.player2Result.Size = new System.Drawing.Size(141, 60);
            this.player2Result.TabIndex = 15;
            this.player2Result.Text = "0";
            this.player2Result.UseVisualStyleBackColor = true;
            this.player2Result.Click += new System.EventHandler(this.player2Result_Click);
            // 
            // player1Result
            // 
            this.player1Result.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.player1Result.Location = new System.Drawing.Point(204, 31);
            this.player1Result.Name = "player1Result";
            this.player1Result.Size = new System.Drawing.Size(141, 60);
            this.player1Result.TabIndex = 14;
            this.player1Result.Text = "0";
            this.player1Result.UseVisualStyleBackColor = true;
            // 
            // player2Box
            // 
            this.player2Box.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.player2Box.Location = new System.Drawing.Point(611, 169);
            this.player2Box.Name = "player2Box";
            this.player2Box.Size = new System.Drawing.Size(147, 269);
            this.player2Box.TabIndex = 13;
            // 
            // player1Box
            // 
            this.player1Box.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.player1Box.Location = new System.Drawing.Point(42, 169);
            this.player1Box.Name = "player1Box";
            this.player1Box.Size = new System.Drawing.Size(144, 269);
            this.player1Box.TabIndex = 12;
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.SystemColors.ControlDark;
            this.container.Location = new System.Drawing.Point(258, 169);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(285, 269);
            this.container.TabIndex = 11;
            this.container.Paint += new System.Windows.Forms.PaintEventHandler(this.container_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFormsApp1.Properties.Resources.im2;
            this.pictureBox1.Location = new System.Drawing.Point(56, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 117);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WinFormsApp1.Properties.Resources.im1;
            this.pictureBox2.Location = new System.Drawing.Point(611, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(131, 117);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // prevBtn
            // 
            this.prevBtn.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.prevBtn.Location = new System.Drawing.Point(258, 130);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(75, 36);
            this.prevBtn.TabIndex = 17;
            this.prevBtn.Text = "Prev";
            this.prevBtn.UseVisualStyleBackColor = true;
            // 
            // nextBtn
            // 
            this.nextBtn.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.nextBtn.Location = new System.Drawing.Point(468, 130);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 33);
            this.nextBtn.TabIndex = 18;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.backBtn.Location = new System.Drawing.Point(339, 130);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(123, 36);
            this.backBtn.TabIndex = 19;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.vsButton);
            this.Controls.Add(this.player2Result);
            this.Controls.Add(this.player1Result);
            this.Controls.Add(this.player2Box);
            this.Controls.Add(this.player1Box);
            this.Controls.Add(this.container);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button vsButton;
        private Button player2Result;
        private Button player1Result;
        private FlowLayoutPanel player2Box;
        private FlowLayoutPanel player1Box;
        private FlowLayoutPanel container;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button prevBtn;
        private Button nextBtn;
        private Button backBtn;
    }
}