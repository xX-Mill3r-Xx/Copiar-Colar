
namespace Ctrl_C_Ctrl_V
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Box1 = new System.Windows.Forms.TextBox();
            this.txt_Box2 = new System.Windows.Forms.TextBox();
            this.btn_Copiar = new System.Windows.Forms.Button();
            this.btn_Colar = new System.Windows.Forms.Button();
            this.lbl_FeedBack = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Box1
            // 
            this.txt_Box1.BackColor = System.Drawing.Color.White;
            this.txt_Box1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Box1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Box1.Location = new System.Drawing.Point(12, 12);
            this.txt_Box1.Multiline = true;
            this.txt_Box1.Name = "txt_Box1";
            this.txt_Box1.Size = new System.Drawing.Size(277, 289);
            this.txt_Box1.TabIndex = 0;
            // 
            // txt_Box2
            // 
            this.txt_Box2.BackColor = System.Drawing.Color.White;
            this.txt_Box2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Box2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Box2.Location = new System.Drawing.Point(337, 12);
            this.txt_Box2.Multiline = true;
            this.txt_Box2.Name = "txt_Box2";
            this.txt_Box2.Size = new System.Drawing.Size(277, 289);
            this.txt_Box2.TabIndex = 1;
            // 
            // btn_Copiar
            // 
            this.btn_Copiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Copiar.FlatAppearance.BorderSize = 2;
            this.btn_Copiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Copiar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Copiar.Location = new System.Drawing.Point(13, 308);
            this.btn_Copiar.Name = "btn_Copiar";
            this.btn_Copiar.Size = new System.Drawing.Size(276, 72);
            this.btn_Copiar.TabIndex = 2;
            this.btn_Copiar.Text = "Copiar";
            this.btn_Copiar.UseVisualStyleBackColor = true;
            this.btn_Copiar.Click += new System.EventHandler(this.btn_Copiar_Click);
            // 
            // btn_Colar
            // 
            this.btn_Colar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Colar.FlatAppearance.BorderSize = 2;
            this.btn_Colar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Colar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Colar.Location = new System.Drawing.Point(338, 308);
            this.btn_Colar.Name = "btn_Colar";
            this.btn_Colar.Size = new System.Drawing.Size(276, 72);
            this.btn_Colar.TabIndex = 3;
            this.btn_Colar.Text = "Colar";
            this.btn_Colar.UseVisualStyleBackColor = true;
            this.btn_Colar.Click += new System.EventHandler(this.btn_Colar_Click);
            // 
            // lbl_FeedBack
            // 
            this.lbl_FeedBack.AutoSize = true;
            this.lbl_FeedBack.ForeColor = System.Drawing.Color.Black;
            this.lbl_FeedBack.Location = new System.Drawing.Point(12, 393);
            this.lbl_FeedBack.Name = "lbl_FeedBack";
            this.lbl_FeedBack.Size = new System.Drawing.Size(48, 17);
            this.lbl_FeedBack.TabIndex = 4;
            this.lbl_FeedBack.Text = "Feed:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(626, 429);
            this.Controls.Add(this.lbl_FeedBack);
            this.Controls.Add(this.btn_Colar);
            this.Controls.Add(this.btn_Copiar);
            this.Controls.Add(this.txt_Box2);
            this.Controls.Add(this.txt_Box1);
            this.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Copiar & Colar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Box1;
        private System.Windows.Forms.TextBox txt_Box2;
        private System.Windows.Forms.Button btn_Copiar;
        private System.Windows.Forms.Button btn_Colar;
        private System.Windows.Forms.Label lbl_FeedBack;
    }
}

