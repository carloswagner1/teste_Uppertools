
namespace CadastroDeEmpresa
{
    partial class frmExcluirCadastro
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
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblStatusEx = new System.Windows.Forms.Label();
            this.btnPesquisarCNPJEx = new System.Windows.Forms.Button();
            this.mskbxCNPJEx = new System.Windows.Forms.MaskedTextBox();
            this.lblCNPJEx = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(297, 209);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(216, 53);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblStatusEx
            // 
            this.lblStatusEx.AutoSize = true;
            this.lblStatusEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusEx.Location = new System.Drawing.Point(77, 151);
            this.lblStatusEx.Name = "lblStatusEx";
            this.lblStatusEx.Size = new System.Drawing.Size(24, 25);
            this.lblStatusEx.TabIndex = 8;
            this.lblStatusEx.Text = ">";
            // 
            // btnPesquisarCNPJEx
            // 
            this.btnPesquisarCNPJEx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisarCNPJEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarCNPJEx.Location = new System.Drawing.Point(75, 209);
            this.btnPesquisarCNPJEx.Name = "btnPesquisarCNPJEx";
            this.btnPesquisarCNPJEx.Size = new System.Drawing.Size(216, 53);
            this.btnPesquisarCNPJEx.TabIndex = 7;
            this.btnPesquisarCNPJEx.Text = "Pesquisar CNPJ";
            this.btnPesquisarCNPJEx.UseVisualStyleBackColor = true;
            this.btnPesquisarCNPJEx.Click += new System.EventHandler(this.btnPesquisarCNPJEx_Click);
            // 
            // mskbxCNPJEx
            // 
            this.mskbxCNPJEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxCNPJEx.Location = new System.Drawing.Point(77, 92);
            this.mskbxCNPJEx.Mask = "00,000,000/0000-00";
            this.mskbxCNPJEx.Name = "mskbxCNPJEx";
            this.mskbxCNPJEx.Size = new System.Drawing.Size(275, 35);
            this.mskbxCNPJEx.TabIndex = 6;
            this.mskbxCNPJEx.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskbxCNPJEx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskbxCNPJEx_KeyPress);
            // 
            // lblCNPJEx
            // 
            this.lblCNPJEx.AutoSize = true;
            this.lblCNPJEx.Location = new System.Drawing.Point(74, 71);
            this.lblCNPJEx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCNPJEx.Name = "lblCNPJEx";
            this.lblCNPJEx.Size = new System.Drawing.Size(48, 18);
            this.lblCNPJEx.TabIndex = 5;
            this.lblCNPJEx.Text = "CNPJ";
            // 
            // frmExcluirCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 337);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lblStatusEx);
            this.Controls.Add(this.btnPesquisarCNPJEx);
            this.Controls.Add(this.mskbxCNPJEx);
            this.Controls.Add(this.lblCNPJEx);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmExcluirCadastro";
            this.Text = "Excluir Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblStatusEx;
        private System.Windows.Forms.Button btnPesquisarCNPJEx;
        private System.Windows.Forms.MaskedTextBox mskbxCNPJEx;
        private System.Windows.Forms.Label lblCNPJEx;
    }
}