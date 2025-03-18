namespace NESNE.ÖDEV.GONCAA
{
    partial class Form1
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
            DOKTORLAR = new ListBox();
            HASTALAR = new ListBox();
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // DOKTORLAR
            // 
            DOKTORLAR.FormattingEnabled = true;
            DOKTORLAR.Location = new Point(140, 49);
            DOKTORLAR.Name = "DOKTORLAR";
            DOKTORLAR.Size = new Size(150, 104);
            DOKTORLAR.TabIndex = 0;
            DOKTORLAR.SelectedIndexChanged += DOKTORLAR_SelectedIndexChanged;
            // 
            // HASTALAR
            // 
            HASTALAR.FormattingEnabled = true;
            HASTALAR.Location = new Point(140, 218);
            HASTALAR.Name = "HASTALAR";
            HASTALAR.Size = new Size(150, 104);
            HASTALAR.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(523, 200);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "hasta ekle";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(506, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(523, 293);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "doktor ekle";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(HASTALAR);
            Controls.Add(DOKTORLAR);
            Name = "Form1";
            Text = "hasta kayıt sisitemi";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox DOKTORLAR;
        private ListBox HASTALAR;
        private Button button1;
        private TextBox textBox1;
        private Button button2;
    }
}
