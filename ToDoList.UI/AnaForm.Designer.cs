
namespace ToDoList.UI
{
    partial class AnaForm
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
            this.txtNot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lstNotlar = new System.Windows.Forms.ListBox();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblZaman = new System.Windows.Forms.Label();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.btnArama = new System.Windows.Forms.Button();
            this.cbYildiz = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNot
            // 
            this.txtNot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNot.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNot.Location = new System.Drawing.Point(41, 84);
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(702, 46);
            this.txtNot.TabIndex = 0;
            this.txtNot.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNot_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Not almak istediğin ?";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(323, 27);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(147, 39);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lstNotlar
            // 
            this.lstNotlar.FormattingEnabled = true;
            this.lstNotlar.ItemHeight = 25;
            this.lstNotlar.Location = new System.Drawing.Point(41, 144);
            this.lstNotlar.Name = "lstNotlar";
            this.lstNotlar.Size = new System.Drawing.Size(702, 229);
            this.lstNotlar.TabIndex = 3;
            this.lstNotlar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstNotlar_KeyDown);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDuzenle.Location = new System.Drawing.Point(41, 391);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(116, 42);
            this.btnDuzenle.TabIndex = 4;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSil.Location = new System.Drawing.Point(172, 391);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(116, 43);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblZaman
            // 
            this.lblZaman.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblZaman.Location = new System.Drawing.Point(664, 9);
            this.lblZaman.Name = "lblZaman";
            this.lblZaman.Size = new System.Drawing.Size(88, 38);
            this.lblZaman.TabIndex = 6;
            this.lblZaman.Text = "0";
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(507, 47);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(190, 31);
            this.txtArama.TabIndex = 7;
            // 
            // btnArama
            // 
            this.btnArama.BackgroundImage = global::ToDoList.UI.Properties.Resources.Magnifier_87133;
            this.btnArama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnArama.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnArama.Location = new System.Drawing.Point(703, 38);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(40, 40);
            this.btnArama.TabIndex = 8;
            this.btnArama.UseVisualStyleBackColor = true;
            // 
            // cbYildiz
            // 
            this.cbYildiz.AutoSize = true;
            this.cbYildiz.Location = new System.Drawing.Point(582, 379);
            this.cbYildiz.Name = "cbYildiz";
            this.cbYildiz.Size = new System.Drawing.Size(161, 29);
            this.cbYildiz.TabIndex = 9;
            this.cbYildiz.Text = "★ Yıldızlı Notlar";
            this.cbYildiz.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 43);
            this.button1.TabIndex = 10;
            this.button1.Text = "★";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 464);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbYildiz);
            this.Controls.Add(this.btnArama);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.lblZaman);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.lstNotlar);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNot);
            this.Name = "AnaForm";
            this.Text = "Notlarım";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnaForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lstNotlar;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblZaman;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Button btnArama;
        private System.Windows.Forms.CheckBox cbYildiz;
        private System.Windows.Forms.Button button1;
    }
}