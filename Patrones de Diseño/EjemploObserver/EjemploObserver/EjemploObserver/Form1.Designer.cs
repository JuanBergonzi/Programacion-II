namespace EjemploObserver
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
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(203, 52);
            button1.Name = "button1";
            button1.Size = new Size(159, 59);
            button1.TabIndex = 0;
            button1.Text = "Crear 3 Prod";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(728, 288);
            button2.Name = "button2";
            button2.Size = new Size(140, 65);
            button2.TabIndex = 1;
            button2.Text = "Cambiar Dolar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(728, 230);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(169, 31);
            textBox1.TabIndex = 2;
            // 
            // button3
            // 
            button3.Location = new Point(203, 189);
            button3.Name = "button3";
            button3.Size = new Size(159, 51);
            button3.TabIndex = 3;
            button3.Text = "Ver Productos";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(452, 405);
            button4.Name = "button4";
            button4.Size = new Size(272, 76);
            button4.TabIndex = 4;
            button4.Text = "Crear Observer";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 591);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Button button3;
        private Button button4;
    }
}
