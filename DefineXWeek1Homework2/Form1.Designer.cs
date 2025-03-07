namespace DefineXWeek1Homework2
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
            comboBox1 = new ComboBox();
            button1 = new Button();
            textBox1 = new TextBox();
            lblSonuc = new Label();
            label1 = new Label();
            Amo = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Credit Card", "HepsiPay", "Amazon Pay", "Google Pay" });
            comboBox1.Location = new Point(163, 77);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(125, 190);
            button1.Name = "button1";
            button1.Size = new Size(153, 29);
            button1.TabIndex = 1;
            button1.Text = "Create Payment";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(173, 130);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(163, 257);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(52, 20);
            lblSonuc.TabIndex = 3;
            lblSonuc.Text = "Result:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 80);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 4;
            label1.Text = "Payment Type";
            label1.Click += label1_Click;
            // 
            // Amo
            // 
            Amo.AutoSize = true;
            Amo.Location = new Point(43, 137);
            Amo.Name = "Amo";
            Amo.Size = new Size(62, 20);
            Amo.TabIndex = 5;
            Amo.Text = "Amount";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Amo);
            Controls.Add(label1);
            Controls.Add(lblSonuc);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button button1;
        private TextBox textBox1;
        private Label lblSonuc;
        private Label label1;
        private Label Amo;
    }
}
