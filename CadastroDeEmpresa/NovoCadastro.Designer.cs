
namespace CadastroDeEmpresa
{
    partial class frmNovoCadastro
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
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.mskbxCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.btnPesquisarCNPJ = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Location = new System.Drawing.Point(73, 74);
            this.lblCNPJ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(48, 18);
            this.lblCNPJ.TabIndex = 0;
            this.lblCNPJ.Text = "CNPJ";
            // 
            // mskbxCNPJ
            // 
            this.mskbxCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxCNPJ.Location = new System.Drawing.Point(76, 95);
            this.mskbxCNPJ.Mask = "00,000,000/0000-00";
            this.mskbxCNPJ.Name = "mskbxCNPJ";
            this.mskbxCNPJ.Size = new System.Drawing.Size(275, 35);
            this.mskbxCNPJ.TabIndex = 1;
            this.mskbxCNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskbxCNPJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskbxCNPJ_KeyPress);
            // 
            // btnPesquisarCNPJ
            // 
            this.btnPesquisarCNPJ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisarCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarCNPJ.Location = new System.Drawing.Point(74, 212);
            this.btnPesquisarCNPJ.Name = "btnPesquisarCNPJ";
            this.btnPesquisarCNPJ.Size = new System.Drawing.Size(216, 53);
            this.btnPesquisarCNPJ.TabIndex = 2;
            this.btnPesquisarCNPJ.Text = "Pesquisar CNPJ";
            this.btnPesquisarCNPJ.UseVisualStyleBackColor = true;
            this.btnPesquisarCNPJ.Click += new System.EventHandler(this.btnPesquisarCNPJ_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(76, 154);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(24, 25);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = ">";
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(296, 212);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(216, 53);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmNovoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 338);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnPesquisarCNPJ);
            this.Controls.Add(this.mskbxCNPJ);
            this.Controls.Add(this.lblCNPJ);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNovoCadastro";
            this.Text = "Novo Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.MaskedTextBox mskbxCNPJ;
        private System.Windows.Forms.Button btnPesquisarCNPJ;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnAdd;
    }
}