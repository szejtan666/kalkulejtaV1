
namespace kalkulejtav1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.oknoIPTextBox = new System.Windows.Forms.MaskedTextBox();
            this.naglowekIPlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MaskaTextBox = new System.Windows.Forms.MaskedTextBox();
            this.liczbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.netTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bcTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // oknoIPTextBox
            // 
            this.oknoIPTextBox.Location = new System.Drawing.Point(158, 16);
            this.oknoIPTextBox.Mask = "###\\.###\\.###\\.###";
            this.oknoIPTextBox.Name = "oknoIPTextBox";
            this.oknoIPTextBox.Size = new System.Drawing.Size(91, 20);
            this.oknoIPTextBox.TabIndex = 0;
            this.oknoIPTextBox.Text = "192168000000";
            // 
            // naglowekIPlabel
            // 
            this.naglowekIPlabel.AutoSize = true;
            this.naglowekIPlabel.Location = new System.Drawing.Point(2, 23);
            this.naglowekIPlabel.Name = "naglowekIPlabel";
            this.naglowekIPlabel.Size = new System.Drawing.Size(79, 13);
            this.naglowekIPlabel.TabIndex = 1;
            this.naglowekIPlabel.Text = "Wpisz Adres IP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wpisz maskę";
            // 
            // MaskaTextBox
            // 
            this.MaskaTextBox.Location = new System.Drawing.Point(158, 42);
            this.MaskaTextBox.Mask = "###\\.###\\.###\\.###";
            this.MaskaTextBox.Name = "MaskaTextBox";
            this.MaskaTextBox.Size = new System.Drawing.Size(91, 20);
            this.MaskaTextBox.TabIndex = 2;
            this.MaskaTextBox.Text = "255255255255";
            // 
            // liczbutton
            // 
            this.liczbutton.Location = new System.Drawing.Point(255, 16);
            this.liczbutton.Name = "liczbutton";
            this.liczbutton.Size = new System.Drawing.Size(115, 45);
            this.liczbutton.TabIndex = 4;
            this.liczbutton.Text = "Licz";
            this.liczbutton.UseVisualStyleBackColor = true;
            this.liczbutton.Click += new System.EventHandler(this.kalkulejtaIP);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "adres sieci";
            // 
            // netTextBox1
            // 
            this.netTextBox1.Location = new System.Drawing.Point(158, 68);
            this.netTextBox1.Mask = "###\\.###\\.###\\.###";
            this.netTextBox1.Name = "netTextBox1";
            this.netTextBox1.ReadOnly = true;
            this.netTextBox1.Size = new System.Drawing.Size(91, 20);
            this.netTextBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "adres IP rozgłoszeniowy";
            // 
            // bcTextBox1
            // 
            this.bcTextBox1.Location = new System.Drawing.Point(158, 94);
            this.bcTextBox1.Mask = "###\\.###\\.###\\.###";
            this.bcTextBox1.Name = "bcTextBox1";
            this.bcTextBox1.ReadOnly = true;
            this.bcTextBox1.Size = new System.Drawing.Size(91, 20);
            this.bcTextBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bcTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.netTextBox1);
            this.Controls.Add(this.liczbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaskaTextBox);
            this.Controls.Add(this.naglowekIPlabel);
            this.Controls.Add(this.oknoIPTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox oknoIPTextBox;
        private System.Windows.Forms.Label naglowekIPlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MaskaTextBox;
        private System.Windows.Forms.Button liczbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox netTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox bcTextBox1;
    }
}

