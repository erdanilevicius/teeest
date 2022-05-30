namespace teeest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.testas = new System.Windows.Forms.TextBox();
            this.TeamID = new System.Windows.Forms.Label();
            this.Komanda = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pasirinkimas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Teams = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Serv = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.veiksm = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // testas
            // 
            this.testas.Location = new System.Drawing.Point(518, 12);
            this.testas.Multiline = true;
            this.testas.Name = "testas";
            this.testas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.testas.Size = new System.Drawing.Size(426, 606);
            this.testas.TabIndex = 1;
            // 
            // TeamID
            // 
            this.TeamID.AutoSize = true;
            this.TeamID.Location = new System.Drawing.Point(22, 435);
            this.TeamID.Name = "TeamID";
            this.TeamID.Size = new System.Drawing.Size(54, 15);
            this.TeamID.TabIndex = 3;
            this.TeamID.Text = "Team Id: ";
            // 
            // Komanda
            // 
            this.Komanda.AutoSize = true;
            this.Komanda.Location = new System.Drawing.Point(22, 450);
            this.Komanda.Name = "Komanda";
            this.Komanda.Size = new System.Drawing.Size(76, 15);
            this.Komanda.TabIndex = 4;
            this.Komanda.Text = "Team Name: ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Select Team";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pasirinkimas
            // 
            this.pasirinkimas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pasirinkimas.FormattingEnabled = true;
            this.pasirinkimas.Location = new System.Drawing.Point(174, 351);
            this.pasirinkimas.Name = "pasirinkimas";
            this.pasirinkimas.Size = new System.Drawing.Size(121, 23);
            this.pasirinkimas.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Projects";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(174, 380);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Select Project";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Teams
            // 
            this.Teams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Teams.FormattingEnabled = true;
            this.Teams.Location = new System.Drawing.Point(22, 351);
            this.Teams.Name = "Teams";
            this.Teams.Size = new System.Drawing.Size(121, 23);
            this.Teams.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Teams";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Selected:";
            // 
            // Serv
            // 
            this.Serv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Serv.FormattingEnabled = true;
            this.Serv.Location = new System.Drawing.Point(347, 351);
            this.Serv.Name = "Serv";
            this.Serv.Size = new System.Drawing.Size(121, 23);
            this.Serv.TabIndex = 12;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(347, 380);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Select Server";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Servers";
            // 
            // veiksm
            // 
            this.veiksm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.veiksm.FormattingEnabled = true;
            this.veiksm.Location = new System.Drawing.Point(174, 473);
            this.veiksm.Name = "veiksm";
            this.veiksm.Size = new System.Drawing.Size(121, 23);
            this.veiksm.TabIndex = 16;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(174, 502);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "Perform action";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 455);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Select Action";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(22, 134);
            this.email.Name = "email";
            this.email.PlaceholderText = "Email";
            this.email.Size = new System.Drawing.Size(174, 23);
            this.email.TabIndex = 19;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(294, 134);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.PlaceholderText = "Password";
            this.pass.Size = new System.Drawing.Size(174, 23);
            this.pass.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(294, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 630);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.veiksm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Serv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Teams);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pasirinkimas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Komanda);
            this.Controls.Add(this.TeamID);
            this.Controls.Add(this.testas);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox testas;
        private Label TeamID;
        private Label Komanda;
        private Button button2;
        private ComboBox pasirinkimas;
        private Label label1;
        private Button button3;
        private ComboBox Teams;
        private Label label2;
        private Label label3;
        private ComboBox Serv;
        private Button button4;
        private Label label4;
        private ComboBox veiksm;
        private Button button5;
        private Label label5;
        private TextBox email;
        private TextBox pass;
        private Label label6;
        private Label label7;
    }
}