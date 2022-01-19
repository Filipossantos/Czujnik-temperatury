
namespace GUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.zapisano = new System.Windows.Forms.Label();
            this.Wyeksportowano = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.dataGridVie = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVie)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Zurich WGL4 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(110, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "Temperatura: \n ... \n °C";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Zurich WGL4 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(125, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 63);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wilgotność: \n ... \n %RH";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 134);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(348, 41);
            this.progressBar1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(403, 197);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(443, 61);
            this.panel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Zurich WGL4 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(141, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gotowy: ...";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Zurich WGL4 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(65, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Odśwież";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(478, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(348, 100);
            this.panel3.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Zurich WGL4 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(65, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(226, 33);
            this.button2.TabIndex = 6;
            this.button2.Text = "   Zapisz pomiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Zurich WGL4 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "0°";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Zurich WGL4 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(342, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "50°";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Zurich WGL4 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(478, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "0%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Zurich WGL4 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(786, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "100%";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Zurich WGL4 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(65, 287);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(226, 33);
            this.button3.TabIndex = 11;
            this.button3.Text = "   Eksport do .csv";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Zurich WGL4 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(65, 326);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(226, 33);
            this.button4.TabIndex = 12;
            this.button4.Text = "O projekcie";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Zurich WGL4 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(65, 365);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(226, 33);
            this.button5.TabIndex = 13;
            this.button5.Text = "Wyjście";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // zapisano
            // 
            this.zapisano.AutoSize = true;
            this.zapisano.Font = new System.Drawing.Font("Zurich WGL4 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.zapisano.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.zapisano.Location = new System.Drawing.Point(297, 256);
            this.zapisano.Name = "zapisano";
            this.zapisano.Size = new System.Drawing.Size(58, 16);
            this.zapisano.TabIndex = 14;
            this.zapisano.Text = "Zapisano";
            this.zapisano.Visible = false;
            // 
            // Wyeksportowano
            // 
            this.Wyeksportowano.AutoSize = true;
            this.Wyeksportowano.Font = new System.Drawing.Font("Zurich WGL4 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Wyeksportowano.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Wyeksportowano.Location = new System.Drawing.Point(297, 295);
            this.Wyeksportowano.Name = "Wyeksportowano";
            this.Wyeksportowano.Size = new System.Drawing.Size(109, 16);
            this.Wyeksportowano.TabIndex = 15;
            this.Wyeksportowano.Text = "Wyeksportowano";
            this.Wyeksportowano.Visible = false;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(478, 134);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(348, 41);
            this.progressBar2.TabIndex = 16;
            // 
            // dataGridVie
            // 
            this.dataGridVie.AllowUserToAddRows = false;
            this.dataGridVie.AllowUserToDeleteRows = false;
            this.dataGridVie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVie.Location = new System.Drawing.Point(403, 264);
            this.dataGridVie.Name = "dataGridVie";
            this.dataGridVie.ReadOnly = true;
            this.dataGridVie.RowTemplate.Height = 25;
            this.dataGridVie.Size = new System.Drawing.Size(443, 175);
            this.dataGridVie.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(852, 450);
            this.Controls.Add(this.dataGridVie);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.Wyeksportowano);
            this.Controls.Add(this.zapisano);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Programowanie aplikacyjne - Projekt";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label zapisano;
        private System.Windows.Forms.Label Wyeksportowano;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.DataGridView dataGridVie;
    }
}

