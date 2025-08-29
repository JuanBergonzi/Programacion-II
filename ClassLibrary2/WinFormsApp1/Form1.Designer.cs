namespace WinFormsApp1
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
            btn_Agregar = new Button();
            tbNombre = new TextBox();
            tbDni = new TextBox();
            Nombre = new Label();
            label1 = new Label();
            label2 = new Label();
            tbTitulo = new TextBox();
            btnPeli = new Button();
            Lista = new ListView();
            SuspendLayout();
            // 
            // btn_Agregar
            // 
            btn_Agregar.Location = new Point(580, 340);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(166, 29);
            btn_Agregar.TabIndex = 0;
            btn_Agregar.Text = "Crear Persona";
            btn_Agregar.UseVisualStyleBackColor = true;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(612, 248);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(125, 27);
            tbNombre.TabIndex = 1;
            // 
            // tbDni
            // 
            tbDni.Location = new Point(612, 161);
            tbDni.Name = "tbDni";
            tbDni.Size = new Size(125, 27);
            tbDni.TabIndex = 2;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(516, 255);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(64, 20);
            Nombre.TabIndex = 3;
            Nombre.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(516, 164);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 4;
            label1.Text = "Dni";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 259);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 5;
            label2.Text = "Titulo";
            // 
            // tbTitulo
            // 
            tbTitulo.Location = new Point(162, 252);
            tbTitulo.Name = "tbTitulo";
            tbTitulo.Size = new Size(125, 27);
            tbTitulo.TabIndex = 6;
            // 
            // btnPeli
            // 
            btnPeli.Location = new Point(175, 340);
            btnPeli.Name = "btnPeli";
            btnPeli.Size = new Size(94, 29);
            btnPeli.TabIndex = 7;
            btnPeli.Text = "Crear PELI";
            btnPeli.UseVisualStyleBackColor = true;
            btnPeli.Click += btnPeli_Click;
            // 
            // Lista
            // 
            Lista.Location = new Point(12, 12);
            Lista.Name = "Lista";
            Lista.Size = new Size(506, 197);
            Lista.TabIndex = 8;
            Lista.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Lista);
            Controls.Add(btnPeli);
            Controls.Add(tbTitulo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Nombre);
            Controls.Add(tbDni);
            Controls.Add(tbNombre);
            Controls.Add(btn_Agregar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Agregar;
        private TextBox tbNombre;
        private TextBox tbDni;
        private Label Nombre;
        private Label label1;
        private Label label2;
        private TextBox tbTitulo;
        private Button btnPeli;
        private ListView Lista;
    }
}
