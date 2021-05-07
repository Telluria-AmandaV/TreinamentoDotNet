
namespace AppCadEntTeste
{
    partial class FormModelo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtCPF = new System.Windows.Forms.TextBox();
            this.TxtEndereco = new System.Windows.Forms.TextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.TxtTelefone = new System.Windows.Forms.TextBox();
            this.gbGenero = new System.Windows.Forms.GroupBox();
            this.RbGenero3 = new System.Windows.Forms.RadioButton();
            this.RbGenero2 = new System.Windows.Forms.RadioButton();
            this.RbGenero1 = new System.Windows.Forms.RadioButton();
            this.RbGenero0 = new System.Windows.Forms.RadioButton();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.gbGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(204, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro Simples de Exemplo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(57, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(61, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(61, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(61, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Endereço:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(61, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gênero:";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(163, 164);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(262, 23);
            this.TxtNome.TabIndex = 1;
            // 
            // TxtCPF
            // 
            this.TxtCPF.Location = new System.Drawing.Point(163, 123);
            this.TxtCPF.Name = "TxtCPF";
            this.TxtCPF.Size = new System.Drawing.Size(144, 23);
            this.TxtCPF.TabIndex = 0;
            this.TxtCPF.TextChanged += new System.EventHandler(this.TxtCPF_TextChanged);
            // 
            // TxtEndereco
            // 
            this.TxtEndereco.Location = new System.Drawing.Point(163, 206);
            this.TxtEndereco.Name = "TxtEndereco";
            this.TxtEndereco.Size = new System.Drawing.Size(262, 23);
            this.TxtEndereco.TabIndex = 2;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(163, 91);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(12, 15);
            this.lblCod.TabIndex = 6;
            this.lblCod.Text = "-";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AccessibleName = "";
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(61, 249);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(54, 15);
            this.lblTelefone.TabIndex = 7;
            this.lblTelefone.Text = "Telefone:";
            // 
            // TxtTelefone
            // 
            this.TxtTelefone.Location = new System.Drawing.Point(163, 246);
            this.TxtTelefone.Name = "TxtTelefone";
            this.TxtTelefone.Size = new System.Drawing.Size(144, 23);
            this.TxtTelefone.TabIndex = 8;
            // 
            // gbGenero
            // 
            this.gbGenero.Controls.Add(this.RbGenero3);
            this.gbGenero.Controls.Add(this.RbGenero2);
            this.gbGenero.Controls.Add(this.RbGenero1);
            this.gbGenero.Controls.Add(this.RbGenero0);
            this.gbGenero.Location = new System.Drawing.Point(163, 275);
            this.gbGenero.Name = "gbGenero";
            this.gbGenero.Size = new System.Drawing.Size(417, 44);
            this.gbGenero.TabIndex = 9;
            this.gbGenero.TabStop = false;
            // 
            // RbGenero3
            // 
            this.RbGenero3.AutoSize = true;
            this.RbGenero3.Location = new System.Drawing.Point(305, 14);
            this.RbGenero3.Name = "RbGenero3";
            this.RbGenero3.Size = new System.Drawing.Size(106, 19);
            this.RbGenero3.TabIndex = 3;
            this.RbGenero3.TabStop = true;
            this.RbGenero3.Text = "Não Especificar";
            this.RbGenero3.UseVisualStyleBackColor = true;
            // 
            // RbGenero2
            // 
            this.RbGenero2.AutoSize = true;
            this.RbGenero2.Location = new System.Drawing.Point(200, 14);
            this.RbGenero2.Name = "RbGenero2";
            this.RbGenero2.Size = new System.Drawing.Size(87, 19);
            this.RbGenero2.TabIndex = 2;
            this.RbGenero2.TabStop = true;
            this.RbGenero2.Text = "Não Binário";
            this.RbGenero2.UseVisualStyleBackColor = true;
            // 
            // RbGenero1
            // 
            this.RbGenero1.AutoSize = true;
            this.RbGenero1.Location = new System.Drawing.Point(99, 14);
            this.RbGenero1.Name = "RbGenero1";
            this.RbGenero1.Size = new System.Drawing.Size(80, 19);
            this.RbGenero1.TabIndex = 1;
            this.RbGenero1.TabStop = true;
            this.RbGenero1.Text = "Masculino";
            this.RbGenero1.UseVisualStyleBackColor = true;
            // 
            // RbGenero0
            // 
            this.RbGenero0.AutoSize = true;
            this.RbGenero0.Location = new System.Drawing.Point(6, 14);
            this.RbGenero0.Name = "RbGenero0";
            this.RbGenero0.Size = new System.Drawing.Size(75, 19);
            this.RbGenero0.TabIndex = 0;
            this.RbGenero0.TabStop = true;
            this.RbGenero0.Text = "Feminino";
            this.RbGenero0.UseVisualStyleBackColor = true;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(143, 351);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 10;
            this.BtnSalvar.Text = "&Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(277, 351);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 11;
            this.BtnExcluir.Text = "&Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(416, 351);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(75, 23);
            this.BtnNovo.TabIndex = 12;
            this.BtnNovo.Text = "&Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            // 
            // FormModelo
            // 
            this.AccessibleName = "lblTelefone";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 412);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.gbGenero);
            this.Controls.Add(this.TxtTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.TxtEndereco);
            this.Controls.Add(this.TxtCPF);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormModelo";
            this.Text = "Telefone:";
            this.gbGenero.ResumeLayout(false);
            this.gbGenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtCPF;
        private System.Windows.Forms.TextBox TxtEndereco;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox TxtTelefone;
        private System.Windows.Forms.GroupBox gbGenero;
        private System.Windows.Forms.RadioButton RbGenero3;
        private System.Windows.Forms.RadioButton RbGenero2;
        private System.Windows.Forms.RadioButton RbGenero1;
        private System.Windows.Forms.RadioButton RbGenero0;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnNovo;
    }
}

