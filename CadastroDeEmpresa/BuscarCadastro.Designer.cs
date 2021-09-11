
namespace CadastroDeEmpresa
{
    partial class frmBuscarCadastro
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
            this.rdbtnCNPJ = new System.Windows.Forms.RadioButton();
            this.blbBuscar = new System.Windows.Forms.Label();
            this.rdbtnNomeBuscar = new System.Windows.Forms.RadioButton();
            this.txbxNomeBuscar = new System.Windows.Forms.TextBox();
            this.mskbxCNPJBuscar = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblStatusB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdbtnCNPJ
            // 
            this.rdbtnCNPJ.AutoSize = true;
            this.rdbtnCNPJ.Checked = true;
            this.rdbtnCNPJ.Location = new System.Drawing.Point(60, 63);
            this.rdbtnCNPJ.Name = "rdbtnCNPJ";
            this.rdbtnCNPJ.Size = new System.Drawing.Size(66, 22);
            this.rdbtnCNPJ.TabIndex = 0;
            this.rdbtnCNPJ.TabStop = true;
            this.rdbtnCNPJ.Text = "CNPJ";
            this.rdbtnCNPJ.UseVisualStyleBackColor = true;
            // 
            // blbBuscar
            // 
            this.blbBuscar.AutoSize = true;
            this.blbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blbBuscar.Location = new System.Drawing.Point(56, 19);
            this.blbBuscar.Name = "blbBuscar";
            this.blbBuscar.Size = new System.Drawing.Size(264, 20);
            this.blbBuscar.TabIndex = 1;
            this.blbBuscar.Text = "Selecione a opção de pesquisa:";
            // 
            // rdbtnNomeBuscar
            // 
            this.rdbtnNomeBuscar.AutoSize = true;
            this.rdbtnNomeBuscar.Location = new System.Drawing.Point(60, 141);
            this.rdbtnNomeBuscar.Name = "rdbtnNomeBuscar";
            this.rdbtnNomeBuscar.Size = new System.Drawing.Size(115, 22);
            this.rdbtnNomeBuscar.TabIndex = 2;
            this.rdbtnNomeBuscar.Text = "Razão Social";
            this.rdbtnNomeBuscar.UseVisualStyleBackColor = true;
            // 
            // txbxNomeBuscar
            // 
            this.txbxNomeBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxNomeBuscar.Location = new System.Drawing.Point(60, 169);
            this.txbxNomeBuscar.Name = "txbxNomeBuscar";
            this.txbxNomeBuscar.Size = new System.Drawing.Size(463, 29);
            this.txbxNomeBuscar.TabIndex = 3;
            // 
            // mskbxCNPJBuscar
            // 
            this.mskbxCNPJBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxCNPJBuscar.Location = new System.Drawing.Point(60, 91);
            this.mskbxCNPJBuscar.Mask = "00,000,000/0000-00";
            this.mskbxCNPJBuscar.Name = "mskbxCNPJBuscar";
            this.mskbxCNPJBuscar.Size = new System.Drawing.Size(224, 29);
            this.mskbxCNPJBuscar.TabIndex = 4;
            this.mskbxCNPJBuscar.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(184, 254);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(210, 44);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Pesquisar Cadastro";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblStatusB
            // 
            this.lblStatusB.AutoSize = true;
            this.lblStatusB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusB.Location = new System.Drawing.Point(57, 216);
            this.lblStatusB.Name = "lblStatusB";
            this.lblStatusB.Size = new System.Drawing.Size(18, 20);
            this.lblStatusB.TabIndex = 6;
            this.lblStatusB.Text = ">";
            // 
            // frmBuscarCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 362);
            this.Controls.Add(this.lblStatusB);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.mskbxCNPJBuscar);
            this.Controls.Add(this.txbxNomeBuscar);
            this.Controls.Add(this.rdbtnNomeBuscar);
            this.Controls.Add(this.blbBuscar);
            this.Controls.Add(this.rdbtnCNPJ);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBuscarCadastro";
            this.Text = "Buscar Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbtnCNPJ;
        private System.Windows.Forms.Label blbBuscar;
        private System.Windows.Forms.RadioButton rdbtnNomeBuscar;
        private System.Windows.Forms.TextBox txbxNomeBuscar;
        private System.Windows.Forms.MaskedTextBox mskbxCNPJBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblStatusB;
    }
}