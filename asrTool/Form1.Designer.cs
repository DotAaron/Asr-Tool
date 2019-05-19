namespace asrTool
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tcpfrontThird = new System.Windows.Forms.Label();
            this.tcpfrontTwo = new System.Windows.Forms.Label();
            this.tcpfrontOne = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.asrstatus = new System.Windows.Forms.Label();
            this.asrport = new System.Windows.Forms.TextBox();
            this.asrip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.asrshareTwo = new System.Windows.Forms.Label();
            this.asrshareOne = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.clientTwo = new System.Windows.Forms.Label();
            this.clientOne = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(666, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Asr Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tcpfrontThird);
            this.groupBox1.Controls.Add(this.tcpfrontTwo);
            this.groupBox1.Controls.Add(this.tcpfrontOne);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 122);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FrontTcp check";
            // 
            // tcpfrontThird
            // 
            this.tcpfrontThird.Location = new System.Drawing.Point(7, 66);
            this.tcpfrontThird.Name = "tcpfrontThird";
            this.tcpfrontThird.Size = new System.Drawing.Size(214, 13);
            this.tcpfrontThird.TabIndex = 6;
            this.tcpfrontThird.Text = "AsrShare";
            // 
            // tcpfrontTwo
            // 
            this.tcpfrontTwo.Location = new System.Drawing.Point(7, 44);
            this.tcpfrontTwo.Name = "tcpfrontTwo";
            this.tcpfrontTwo.Size = new System.Drawing.Size(214, 13);
            this.tcpfrontTwo.TabIndex = 5;
            this.tcpfrontTwo.Text = "Plugin injection";
            // 
            // tcpfrontOne
            // 
            this.tcpfrontOne.Location = new System.Drawing.Point(7, 20);
            this.tcpfrontOne.Name = "tcpfrontOne";
            this.tcpfrontOne.Size = new System.Drawing.Size(214, 13);
            this.tcpfrontOne.TabIndex = 4;
            this.tcpfrontOne.Text = "Basic";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(158, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Run check";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // asrstatus
            // 
            this.asrstatus.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.asrstatus.Location = new System.Drawing.Point(666, 402);
            this.asrstatus.Name = "asrstatus";
            this.asrstatus.Size = new System.Drawing.Size(122, 13);
            this.asrstatus.TabIndex = 2;
            this.asrstatus.Text = "Unknown";
            this.asrstatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // asrport
            // 
            this.asrport.Location = new System.Drawing.Point(625, 416);
            this.asrport.Name = "asrport";
            this.asrport.Size = new System.Drawing.Size(37, 20);
            this.asrport.TabIndex = 3;
            this.asrport.Text = "100";
            this.asrport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // asrip
            // 
            this.asrip.Location = new System.Drawing.Point(539, 416);
            this.asrip.Name = "asrip";
            this.asrip.Size = new System.Drawing.Size(80, 20);
            this.asrip.TabIndex = 4;
            this.asrip.Text = "127.0.0.1";
            this.asrip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(616, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = ":";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.asrshareTwo);
            this.groupBox2.Controls.Add(this.asrshareOne);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(247, 349);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 89);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AsrShare emulator";
            // 
            // asrshareTwo
            // 
            this.asrshareTwo.Location = new System.Drawing.Point(7, 44);
            this.asrshareTwo.Name = "asrshareTwo";
            this.asrshareTwo.Size = new System.Drawing.Size(214, 13);
            this.asrshareTwo.TabIndex = 5;
            this.asrshareTwo.Text = "Asrshare: Not connected";
            // 
            // asrshareOne
            // 
            this.asrshareOne.Location = new System.Drawing.Point(7, 20);
            this.asrshareOne.Name = "asrshareOne";
            this.asrshareOne.Size = new System.Drawing.Size(214, 13);
            this.asrshareOne.TabIndex = 4;
            this.asrshareOne.Text = "Not emulating";
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(150, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Run emulator";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Location = new System.Drawing.Point(553, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(235, 181);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Server config";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Silver;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(7, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(222, 126);
            this.textBox1.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(150, 152);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Get config";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.clientTwo);
            this.groupBox4.Controls.Add(this.clientOne);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Location = new System.Drawing.Point(6, 349);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(235, 89);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Client emulator";
            // 
            // clientTwo
            // 
            this.clientTwo.Location = new System.Drawing.Point(7, 44);
            this.clientTwo.Name = "clientTwo";
            this.clientTwo.Size = new System.Drawing.Size(214, 13);
            this.clientTwo.TabIndex = 5;
            this.clientTwo.Text = "Client: Not connected";
            // 
            // clientOne
            // 
            this.clientOne.Location = new System.Drawing.Point(7, 20);
            this.clientOne.Name = "clientOne";
            this.clientOne.Size = new System.Drawing.Size(214, 13);
            this.clientOne.TabIndex = 4;
            this.clientOne.Text = "Not emulating";
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Location = new System.Drawing.Point(150, 60);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(79, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "Run emulator";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Controls.Add(this.button6);
            this.groupBox5.Location = new System.Drawing.Point(312, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(235, 181);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Server ids";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Silver;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(7, 20);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(222, 126);
            this.textBox2.TabIndex = 3;
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Location = new System.Drawing.Point(150, 152);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(79, 23);
            this.button6.TabIndex = 2;
            this.button6.Text = "Get ids";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox3);
            this.groupBox6.Controls.Add(this.button7);
            this.groupBox6.Location = new System.Drawing.Point(12, 140);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(235, 145);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Plugin injection";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Silver;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(7, 19);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(222, 91);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "printl Plugin injection test ; color 6";
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Location = new System.Drawing.Point(150, 116);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(79, 23);
            this.button7.TabIndex = 2;
            this.button7.Text = "Inject";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button8);
            this.groupBox7.Location = new System.Drawing.Point(703, 199);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(85, 106);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Crash";
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.button8.Location = new System.Drawing.Point(7, 17);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(72, 80);
            this.button8.TabIndex = 0;
            this.button8.Text = "Kill Server";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.asrip);
            this.Controls.Add(this.asrport);
            this.Controls.Add(this.asrstatus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asr Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label tcpfrontThird;
        private System.Windows.Forms.Label tcpfrontTwo;
        private System.Windows.Forms.Label tcpfrontOne;
        private System.Windows.Forms.Label asrstatus;
        private System.Windows.Forms.TextBox asrport;
        private System.Windows.Forms.TextBox asrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label asrshareTwo;
        private System.Windows.Forms.Label asrshareOne;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label clientTwo;
        private System.Windows.Forms.Label clientOne;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button8;
    }
}

