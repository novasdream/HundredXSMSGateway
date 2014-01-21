namespace HundredXSMSGateway
{
    partial class Form1
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
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtMensagem = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNumeros = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbRecebidas = new System.Windows.Forms.Label();
            this.lbEnviadas = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPortaSrv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btnEnviarMassa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbPortas = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbStatusModem = new System.Windows.Forms.Label();
            this.pGeral = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.pGeral.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(98, 178);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(96, 19);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(121, 20);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.Text = "018996265457";
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(96, 45);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(206, 127);
            this.txtMensagem.TabIndex = 2;
            this.txtMensagem.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mensagem:";
            // 
            // lbNumeros
            // 
            this.lbNumeros.FormattingEnabled = true;
            this.lbNumeros.Location = new System.Drawing.Point(6, 19);
            this.lbNumeros.Name = "lbNumeros";
            this.lbNumeros.Size = new System.Drawing.Size(145, 108);
            this.lbNumeros.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(71, 159);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(59, 23);
            this.btnRemover.TabIndex = 9;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // txtNumeros
            // 
            this.txtNumeros.Location = new System.Drawing.Point(7, 133);
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.Size = new System.Drawing.Size(144, 20);
            this.txtNumeros.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(11, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Iniciar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbRecebidas);
            this.groupBox1.Controls.Add(this.lbEnviadas);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lb);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTempo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPortaSrv);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbStatus);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(3, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 157);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servidor";
            // 
            // lbRecebidas
            // 
            this.lbRecebidas.AutoSize = true;
            this.lbRecebidas.Location = new System.Drawing.Point(73, 88);
            this.lbRecebidas.Name = "lbRecebidas";
            this.lbRecebidas.Size = new System.Drawing.Size(13, 13);
            this.lbRecebidas.TabIndex = 23;
            this.lbRecebidas.Text = "0";
            // 
            // lbEnviadas
            // 
            this.lbEnviadas.AutoSize = true;
            this.lbEnviadas.Location = new System.Drawing.Point(63, 104);
            this.lbEnviadas.Name = "lbEnviadas";
            this.lbEnviadas.Size = new System.Drawing.Size(13, 13);
            this.lbEnviadas.TabIndex = 22;
            this.lbEnviadas.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Enviadas:";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(11, 88);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(61, 13);
            this.lb.TabIndex = 20;
            this.lb.Text = "Recebidas:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "segundos";
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(50, 58);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(41, 20);
            this.txtTempo.TabIndex = 18;
            this.txtTempo.Text = "10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tempo:";
            // 
            // txtPortaSrv
            // 
            this.txtPortaSrv.Location = new System.Drawing.Point(50, 33);
            this.txtPortaSrv.Name = "txtPortaSrv";
            this.txtPortaSrv.Size = new System.Drawing.Size(41, 20);
            this.txtPortaSrv.TabIndex = 16;
            this.txtPortaSrv.Text = "9050";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Porta:";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(48, 18);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(41, 13);
            this.lbStatus.TabIndex = 14;
            this.lbStatus.Text = "Parado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Status:";
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(92, 123);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Parar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnEnviarMassa
            // 
            this.btnEnviarMassa.Enabled = false;
            this.btnEnviarMassa.Location = new System.Drawing.Point(178, 178);
            this.btnEnviarMassa.Name = "btnEnviarMassa";
            this.btnEnviarMassa.Size = new System.Drawing.Size(124, 23);
            this.btnEnviarMassa.TabIndex = 13;
            this.btnEnviarMassa.Text = "Enviar para todos";
            this.btnEnviarMassa.UseVisualStyleBackColor = true;
            this.btnEnviarMassa.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbNumeros);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnRemover);
            this.groupBox2.Controls.Add(this.txtNumeros);
            this.groupBox2.Location = new System.Drawing.Point(336, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(164, 188);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Envio em massa";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEnviar);
            this.groupBox3.Controls.Add(this.btnEnviarMassa);
            this.groupBox3.Controls.Add(this.txtNumero);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.txtMensagem);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(506, 216);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Envio único";
            // 
            // cbPortas
            // 
            this.cbPortas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPortas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPortas.FormattingEnabled = true;
            this.cbPortas.Location = new System.Drawing.Point(11, 19);
            this.cbPortas.Name = "cbPortas";
            this.cbPortas.Size = new System.Drawing.Size(248, 21);
            this.cbPortas.TabIndex = 17;
            this.cbPortas.SelectedIndexChanged += new System.EventHandler(this.cbPortas_SelectedIndexChanged_1);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbStatusModem);
            this.groupBox4.Controls.Add(this.cbPortas);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(517, 48);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Modem";
            // 
            // lbStatusModem
            // 
            this.lbStatusModem.AutoSize = true;
            this.lbStatusModem.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbStatusModem.Location = new System.Drawing.Point(263, 22);
            this.lbStatusModem.Name = "lbStatusModem";
            this.lbStatusModem.Size = new System.Drawing.Size(0, 13);
            this.lbStatusModem.TabIndex = 16;
            // 
            // pGeral
            // 
            this.pGeral.Controls.Add(this.button2);
            this.pGeral.Controls.Add(this.groupBox3);
            this.pGeral.Controls.Add(this.groupBox1);
            this.pGeral.Location = new System.Drawing.Point(12, 75);
            this.pGeral.Name = "pGeral";
            this.pGeral.Size = new System.Drawing.Size(517, 385);
            this.pGeral.TabIndex = 15;
            this.pGeral.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(182, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 515);
            this.Controls.Add(this.pGeral);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.pGeral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.RichTextBox txtMensagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbNumeros;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.TextBox txtNumeros;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPortaSrv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEnviarMassa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbPortas;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel pGeral;
        private System.Windows.Forms.Label lbStatusModem;
        private System.Windows.Forms.Label lbRecebidas;
        private System.Windows.Forms.Label lbEnviadas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Button button2;
    }
}

