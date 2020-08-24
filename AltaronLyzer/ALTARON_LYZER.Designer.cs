namespace AltaronLyzer
{
    partial class ALTARON_LYZER
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
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBoxPelnaMana = new System.Windows.Forms.CheckBox();
            this.checkBoxOtrzymanieObrazen = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_HP = new System.Windows.Forms.Label();
            this.label_MP = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.checkBoxHpWarning = new System.Windows.Forms.CheckBox();
            this.textBoxHpWarning = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(8, 181);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(271, 144);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(8, 10);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(190, 56);
            this.listBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Skan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(204, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Wybierz ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBoxPelnaMana
            // 
            this.checkBoxPelnaMana.AutoSize = true;
            this.checkBoxPelnaMana.Location = new System.Drawing.Point(8, 91);
            this.checkBoxPelnaMana.Name = "checkBoxPelnaMana";
            this.checkBoxPelnaMana.Size = new System.Drawing.Size(85, 17);
            this.checkBoxPelnaMana.TabIndex = 4;
            this.checkBoxPelnaMana.Text = "Pełna Mana";
            this.checkBoxPelnaMana.UseVisualStyleBackColor = true;
            this.checkBoxPelnaMana.CheckedChanged += new System.EventHandler(this.checkBoxPelnaMana_CheckedChanged);
            // 
            // checkBoxOtrzymanieObrazen
            // 
            this.checkBoxOtrzymanieObrazen.AutoSize = true;
            this.checkBoxOtrzymanieObrazen.Location = new System.Drawing.Point(8, 68);
            this.checkBoxOtrzymanieObrazen.Name = "checkBoxOtrzymanieObrazen";
            this.checkBoxOtrzymanieObrazen.Size = new System.Drawing.Size(121, 17);
            this.checkBoxOtrzymanieObrazen.TabIndex = 5;
            this.checkBoxOtrzymanieObrazen.Text = "Otrzymanie Obrażeń";
            this.checkBoxOtrzymanieObrazen.UseVisualStyleBackColor = true;
            this.checkBoxOtrzymanieObrazen.CheckedChanged += new System.EventHandler(this.checkBoxOtrzymanieObrazen_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // label_HP
            // 
            this.label_HP.AutoSize = true;
            this.label_HP.Location = new System.Drawing.Point(135, 72);
            this.label_HP.Name = "label_HP";
            this.label_HP.Size = new System.Drawing.Size(42, 13);
            this.label_HP.TabIndex = 8;
            this.label_HP.Text = "labeHP";
            // 
            // label_MP
            // 
            this.label_MP.AutoSize = true;
            this.label_MP.Location = new System.Drawing.Point(135, 91);
            this.label_MP.Name = "label_MP";
            this.label_MP.Size = new System.Drawing.Size(35, 13);
            this.label_MP.TabIndex = 10;
            this.label_MP.Text = "label5";
            // 
            // timer2
            // 
            this.timer2.Interval = 3200;
            // 
            // checkBoxHpWarning
            // 
            this.checkBoxHpWarning.AutoSize = true;
            this.checkBoxHpWarning.Location = new System.Drawing.Point(8, 114);
            this.checkBoxHpWarning.Name = "checkBoxHpWarning";
            this.checkBoxHpWarning.Size = new System.Drawing.Size(80, 17);
            this.checkBoxHpWarning.TabIndex = 11;
            this.checkBoxHpWarning.Text = "HpWarning";
            this.checkBoxHpWarning.UseVisualStyleBackColor = true;
            this.checkBoxHpWarning.CheckedChanged += new System.EventHandler(this.checkBoxHpWarning_CheckedChanged);
            // 
            // textBoxHpWarning
            // 
            this.textBoxHpWarning.Location = new System.Drawing.Point(94, 114);
            this.textBoxHpWarning.Name = "textBoxHpWarning";
            this.textBoxHpWarning.Size = new System.Drawing.Size(100, 20);
            this.textBoxHpWarning.TabIndex = 12;
            this.textBoxHpWarning.Text = "50";
            this.textBoxHpWarning.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHpWarning_KeyPress_1);
            // 
            // ALTARON_LYZER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 368);
            this.Controls.Add(this.textBoxHpWarning);
            this.Controls.Add(this.checkBoxHpWarning);
            this.Controls.Add(this.label_MP);
            this.Controls.Add(this.label_HP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxOtrzymanieObrazen);
            this.Controls.Add(this.checkBoxPelnaMana);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "ALTARON_LYZER";
            this.Text = "ALTARON_LYZER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBoxPelnaMana;
        private System.Windows.Forms.CheckBox checkBoxOtrzymanieObrazen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_HP;
        private System.Windows.Forms.Label label_MP;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.CheckBox checkBoxHpWarning;
        private System.Windows.Forms.TextBox textBoxHpWarning;
    }
}

