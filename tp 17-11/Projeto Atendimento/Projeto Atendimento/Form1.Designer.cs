
namespace Projeto_Atendimento
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
            this.buttonGerarSenha = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxSenhas = new System.Windows.Forms.ListBox();
            this.labelQtdGuiches = new System.Windows.Forms.Label();
            this.listBoxAtendimentos = new System.Windows.Forms.ListBox();
            this.textBoxGuiche = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonChamar = new System.Windows.Forms.Button();
            this.buttonAddGuiche = new System.Windows.Forms.Button();
            this.buttonListarSenhas = new System.Windows.Forms.Button();
            this.buttonListarAtdm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGerarSenha
            // 
            this.buttonGerarSenha.Location = new System.Drawing.Point(50, 12);
            this.buttonGerarSenha.Name = "buttonGerarSenha";
            this.buttonGerarSenha.Size = new System.Drawing.Size(75, 23);
            this.buttonGerarSenha.TabIndex = 0;
            this.buttonGerarSenha.Text = "Gerar Senha";
            this.buttonGerarSenha.UseVisualStyleBackColor = true;
            this.buttonGerarSenha.Click += new System.EventHandler(this.buttonGerarSenha_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Qtde guiches";
            // 
            // listBoxSenhas
            // 
            this.listBoxSenhas.FormattingEnabled = true;
            this.listBoxSenhas.Location = new System.Drawing.Point(12, 43);
            this.listBoxSenhas.Name = "listBoxSenhas";
            this.listBoxSenhas.Size = new System.Drawing.Size(145, 134);
            this.listBoxSenhas.TabIndex = 2;
            // 
            // labelQtdGuiches
            // 
            this.labelQtdGuiches.AutoSize = true;
            this.labelQtdGuiches.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQtdGuiches.Location = new System.Drawing.Point(200, 89);
            this.labelQtdGuiches.Name = "labelQtdGuiches";
            this.labelQtdGuiches.Size = new System.Drawing.Size(20, 24);
            this.labelQtdGuiches.TabIndex = 3;
            this.labelQtdGuiches.Text = "0";
            // 
            // listBoxAtendimentos
            // 
            this.listBoxAtendimentos.FormattingEnabled = true;
            this.listBoxAtendimentos.Location = new System.Drawing.Point(262, 43);
            this.listBoxAtendimentos.Name = "listBoxAtendimentos";
            this.listBoxAtendimentos.Size = new System.Drawing.Size(254, 134);
            this.listBoxAtendimentos.TabIndex = 4;
            // 
            // textBoxGuiche
            // 
            this.textBoxGuiche.Location = new System.Drawing.Point(357, 14);
            this.textBoxGuiche.Name = "textBoxGuiche";
            this.textBoxGuiche.Size = new System.Drawing.Size(50, 20);
            this.textBoxGuiche.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Guiche:";
            // 
            // buttonChamar
            // 
            this.buttonChamar.Location = new System.Drawing.Point(429, 12);
            this.buttonChamar.Name = "buttonChamar";
            this.buttonChamar.Size = new System.Drawing.Size(75, 23);
            this.buttonChamar.TabIndex = 7;
            this.buttonChamar.Text = "Chamar";
            this.buttonChamar.UseVisualStyleBackColor = true;
            this.buttonChamar.Click += new System.EventHandler(this.buttonChamar_Click);
            // 
            // buttonAddGuiche
            // 
            this.buttonAddGuiche.Location = new System.Drawing.Point(171, 127);
            this.buttonAddGuiche.Name = "buttonAddGuiche";
            this.buttonAddGuiche.Size = new System.Drawing.Size(75, 23);
            this.buttonAddGuiche.TabIndex = 8;
            this.buttonAddGuiche.Text = "Adicionar";
            this.buttonAddGuiche.UseVisualStyleBackColor = true;
            this.buttonAddGuiche.Click += new System.EventHandler(this.buttonAddGuiche_Click);
            // 
            // buttonListarSenhas
            // 
            this.buttonListarSenhas.Location = new System.Drawing.Point(29, 183);
            this.buttonListarSenhas.Name = "buttonListarSenhas";
            this.buttonListarSenhas.Size = new System.Drawing.Size(110, 23);
            this.buttonListarSenhas.TabIndex = 9;
            this.buttonListarSenhas.Text = "Listar Senhas";
            this.buttonListarSenhas.UseVisualStyleBackColor = true;
            this.buttonListarSenhas.Click += new System.EventHandler(this.buttonListarSenhas_Click);
            // 
            // buttonListarAtdm
            // 
            this.buttonListarAtdm.Location = new System.Drawing.Point(297, 183);
            this.buttonListarAtdm.Name = "buttonListarAtdm";
            this.buttonListarAtdm.Size = new System.Drawing.Size(194, 23);
            this.buttonListarAtdm.TabIndex = 10;
            this.buttonListarAtdm.Text = "Listar Atendimentos";
            this.buttonListarAtdm.UseVisualStyleBackColor = true;
            this.buttonListarAtdm.Click += new System.EventHandler(this.buttonListarAtdm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 234);
            this.Controls.Add(this.buttonListarAtdm);
            this.Controls.Add(this.buttonListarSenhas);
            this.Controls.Add(this.buttonAddGuiche);
            this.Controls.Add(this.buttonChamar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxGuiche);
            this.Controls.Add(this.listBoxAtendimentos);
            this.Controls.Add(this.labelQtdGuiches);
            this.Controls.Add(this.listBoxSenhas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGerarSenha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGerarSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxSenhas;
        private System.Windows.Forms.Label labelQtdGuiches;
        private System.Windows.Forms.ListBox listBoxAtendimentos;
        private System.Windows.Forms.TextBox textBoxGuiche;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonChamar;
        private System.Windows.Forms.Button buttonAddGuiche;
        private System.Windows.Forms.Button buttonListarSenhas;
        private System.Windows.Forms.Button buttonListarAtdm;
    }
}

