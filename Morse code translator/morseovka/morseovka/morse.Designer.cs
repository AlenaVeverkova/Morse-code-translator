namespace morseovka
{
    partial class Morseovka
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txt_decode = new System.Windows.Forms.TextBox();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.blink = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_blink = new System.Windows.Forms.Button();
            this.timerBlink = new System.Windows.Forms.Timer(this.components);
            this.lbl_alphabet = new System.Windows.Forms.Label();
            this.lbl_morse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_decode
            // 
            this.txt_decode.Location = new System.Drawing.Point(45, 56);
            this.txt_decode.Multiline = true;
            this.txt_decode.Name = "txt_decode";
            this.txt_decode.Size = new System.Drawing.Size(360, 75);
            this.txt_decode.TabIndex = 0;
            this.txt_decode.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_code
            // 
            this.txt_code.Location = new System.Drawing.Point(45, 168);
            this.txt_code.Multiline = true;
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(360, 76);
            this.txt_code.TabIndex = 1;
            this.txt_code.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // blink
            // 
            this.blink.BackColor = System.Drawing.SystemColors.ControlText;
            this.blink.Location = new System.Drawing.Point(421, 56);
            this.blink.Name = "blink";
            this.blink.Size = new System.Drawing.Size(75, 75);
            this.blink.TabIndex = 2;
            // 
            // btn_blink
            // 
            this.btn_blink.Location = new System.Drawing.Point(421, 168);
            this.btn_blink.Name = "btn_blink";
            this.btn_blink.Size = new System.Drawing.Size(72, 31);
            this.btn_blink.TabIndex = 3;
            this.btn_blink.Text = "Blink";
            this.btn_blink.UseVisualStyleBackColor = true;
            this.btn_blink.Click += new System.EventHandler(this.btn_blink_Click);
            // 
            // timerBlink
            // 
            this.timerBlink.Tick += new System.EventHandler(this.timerBlink_Tick);
            // 
            // lbl_alphabet
            // 
            this.lbl_alphabet.AutoSize = true;
            this.lbl_alphabet.Location = new System.Drawing.Point(45, 37);
            this.lbl_alphabet.Name = "lbl_alphabet";
            this.lbl_alphabet.Size = new System.Drawing.Size(49, 13);
            this.lbl_alphabet.TabIndex = 4;
            this.lbl_alphabet.Text = "Alphabet";
            // 
            // lbl_morse
            // 
            this.lbl_morse.AutoSize = true;
            this.lbl_morse.Location = new System.Drawing.Point(45, 152);
            this.lbl_morse.Name = "lbl_morse";
            this.lbl_morse.Size = new System.Drawing.Size(63, 13);
            this.lbl_morse.TabIndex = 5;
            this.lbl_morse.Text = "Morse code";
            // 
            // Morseovka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 282);
            this.Controls.Add(this.lbl_morse);
            this.Controls.Add(this.lbl_alphabet);
            this.Controls.Add(this.btn_blink);
            this.Controls.Add(this.blink);
            this.Controls.Add(this.txt_code);
            this.Controls.Add(this.txt_decode);
            this.Name = "Morseovka";
            this.Text = "Morse code";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_decode;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.FlowLayoutPanel blink;
        private System.Windows.Forms.Button btn_blink;
        private System.Windows.Forms.Timer timerBlink;
        private System.Windows.Forms.Label lbl_alphabet;
        private System.Windows.Forms.Label lbl_morse;
    }
}

