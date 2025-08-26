namespace WinFormsApp12
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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            btn3 = new Button();
            label1 = new Label();
            tbmp = new TextBox();
            btn4 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(88, 128);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(148, 27);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(11, 178);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(90, 27);
            button1.TabIndex = 1;
            button1.Text = "Pagar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(233, 178);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(90, 27);
            button2.TabIndex = 2;
            button2.Text = "Devolver";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(95, 231);
            btn3.Name = "btn3";
            btn3.Size = new Size(156, 29);
            btn3.TabIndex = 3;
            btn3.Text = "Consultar Saldo";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(401, 78);
            label1.Name = "label1";
            label1.Size = new Size(170, 20);
            label1.TabIndex = 4;
            label1.Text = "Nuevo Metodo de Pago:";
            label1.Click += label1_Click;
            // 
            // tbmp
            // 
            tbmp.Location = new Point(401, 128);
            tbmp.Name = "tbmp";
            tbmp.Size = new Size(125, 27);
            tbmp.TabIndex = 5;
            // 
            // btn4
            // 
            btn4.Location = new Point(401, 176);
            btn4.Name = "btn4";
            btn4.Size = new Size(156, 29);
            btn4.TabIndex = 6;
            btn4.Text = "Agregar Mp";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(btn4);
            Controls.Add(tbmp);
            Controls.Add(label1);
            Controls.Add(btn3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button btn3;
        private Label label1;
        private TextBox tbmp;
        private Button btn4;
    }
}
