
namespace Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNew = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonGravar = new System.Windows.Forms.Button();
            this.button2Excluir = new System.Windows.Forms.Button();
            this.buttonPesquisa = new System.Windows.Forms.Button();
            this.buttonListar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxDia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "EMAIL:";
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(30, 134);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 23);
            this.buttonNew.TabIndex = 8;
            this.buttonNew.Text = "NOVO";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(75, 19);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(145, 20);
            this.textBoxEmail.TabIndex = 9;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(75, 45);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(145, 20);
            this.textBoxNome.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "NOME:";
            // 
            // textBoxFone
            // 
            this.textBoxFone.Location = new System.Drawing.Point(75, 71);
            this.textBoxFone.Name = "textBoxFone";
            this.textBoxFone.Size = new System.Drawing.Size(77, 20);
            this.textBoxFone.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "FONE:";
            // 
            // buttonGravar
            // 
            this.buttonGravar.Location = new System.Drawing.Point(111, 134);
            this.buttonGravar.Name = "buttonGravar";
            this.buttonGravar.Size = new System.Drawing.Size(75, 23);
            this.buttonGravar.TabIndex = 14;
            this.buttonGravar.Text = "GRAVAR";
            this.buttonGravar.UseVisualStyleBackColor = true;
            this.buttonGravar.Click += new System.EventHandler(this.buttonGravar_Click);
            // 
            // button2Excluir
            // 
            this.button2Excluir.Location = new System.Drawing.Point(192, 134);
            this.button2Excluir.Name = "button2Excluir";
            this.button2Excluir.Size = new System.Drawing.Size(75, 23);
            this.button2Excluir.TabIndex = 15;
            this.button2Excluir.Text = "EXCLUIR";
            this.button2Excluir.UseVisualStyleBackColor = true;
            this.button2Excluir.Click += new System.EventHandler(this.button2Excluir_Click);
            // 
            // buttonPesquisa
            // 
            this.buttonPesquisa.Location = new System.Drawing.Point(273, 134);
            this.buttonPesquisa.Name = "buttonPesquisa";
            this.buttonPesquisa.Size = new System.Drawing.Size(75, 23);
            this.buttonPesquisa.TabIndex = 16;
            this.buttonPesquisa.Text = "PESQUISA";
            this.buttonPesquisa.UseVisualStyleBackColor = true;
            this.buttonPesquisa.Click += new System.EventHandler(this.buttonPesquisa_Click);
            // 
            // buttonListar
            // 
            this.buttonListar.Location = new System.Drawing.Point(354, 134);
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Size = new System.Drawing.Size(75, 23);
            this.buttonListar.TabIndex = 17;
            this.buttonListar.Text = "LISTAR";
            this.buttonListar.UseVisualStyleBackColor = true;
            this.buttonListar.Click += new System.EventHandler(this.buttonListar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(30, 177);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(399, 121);
            this.listBox1.TabIndex = 18;
            // 
            // textBoxDia
            // 
            this.textBoxDia.Location = new System.Drawing.Point(75, 97);
            this.textBoxDia.Name = "textBoxDia";
            this.textBoxDia.Size = new System.Drawing.Size(27, 20);
            this.textBoxDia.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "DATA:";
            // 
            // textBoxMes
            // 
            this.textBoxMes.Location = new System.Drawing.Point(126, 97);
            this.textBoxMes.Name = "textBoxMes";
            this.textBoxMes.Size = new System.Drawing.Size(30, 20);
            this.textBoxMes.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "/";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(162, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "/";
            // 
            // textBoxAno
            // 
            this.textBoxAno.Location = new System.Drawing.Point(180, 97);
            this.textBoxAno.Name = "textBoxAno";
            this.textBoxAno.Size = new System.Drawing.Size(30, 20);
            this.textBoxAno.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 331);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxAno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxMes);
            this.Controls.Add(this.textBoxDia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonListar);
            this.Controls.Add(this.buttonPesquisa);
            this.Controls.Add(this.button2Excluir);
            this.Controls.Add(this.buttonGravar);
            this.Controls.Add(this.textBoxFone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonGravar;
        private System.Windows.Forms.Button button2Excluir;
        private System.Windows.Forms.Button buttonPesquisa;
        private System.Windows.Forms.Button buttonListar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxDia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAno;
    }
}

