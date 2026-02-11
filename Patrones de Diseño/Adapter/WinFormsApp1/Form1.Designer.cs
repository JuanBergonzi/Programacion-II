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
            btnComprarIndu = new Button();
            dataGridView1 = new DataGridView();
            btnComprarLibre = new Button();
            btnAdapter = new Button();
            btnComprar = new Button();
            C1 = new DataGridViewTextBoxColumn();
            C2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnComprarIndu
            // 
            btnComprarIndu.Location = new Point(646, 21);
            btnComprarIndu.Name = "btnComprarIndu";
            btnComprarIndu.Size = new Size(113, 48);
            btnComprarIndu.TabIndex = 0;
            btnComprarIndu.Text = "Comprar Indumentaria";
            btnComprarIndu.UseVisualStyleBackColor = true;
            btnComprarIndu.Click += btnComprarIndu_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { C1, C2 });
            dataGridView1.Location = new Point(38, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(556, 328);
            dataGridView1.TabIndex = 1;
            // 
            // btnComprarLibre
            // 
            btnComprarLibre.Location = new Point(646, 128);
            btnComprarLibre.Name = "btnComprarLibre";
            btnComprarLibre.Size = new Size(113, 48);
            btnComprarLibre.TabIndex = 2;
            btnComprarLibre.Text = "Comprar Libreria";
            btnComprarLibre.UseVisualStyleBackColor = true;
            btnComprarLibre.Click += btnComprarLibre_Click;
            // 
            // btnAdapter
            // 
            btnAdapter.Location = new Point(161, 390);
            btnAdapter.Name = "btnAdapter";
            btnAdapter.Size = new Size(220, 28);
            btnAdapter.TabIndex = 3;
            btnAdapter.Text = "Adaptar";
            btnAdapter.UseVisualStyleBackColor = true;
            btnAdapter.Click += btnAdapter_Click;
            // 
            // btnComprar
            // 
            btnComprar.Location = new Point(646, 390);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(96, 28);
            btnComprar.TabIndex = 4;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = true;
            btnComprar.Click += button1_Click;
            // 
            // C1
            // 
            C1.HeaderText = "Codigo";
            C1.MinimumWidth = 6;
            C1.Name = "C1";
            C1.Width = 125;
            // 
            // C2
            // 
            C2.HeaderText = "Nombre";
            C2.MinimumWidth = 6;
            C2.Name = "C2";
            C2.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnComprar);
            Controls.Add(btnAdapter);
            Controls.Add(btnComprarLibre);
            Controls.Add(dataGridView1);
            Controls.Add(btnComprarIndu);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnComprarIndu;
        private DataGridView dataGridView1;
        private Button btnComprarLibre;
        private Button btnAdapter;
        private Button btnComprar;
        private DataGridViewTextBoxColumn C1;
        private DataGridViewTextBoxColumn C2;
    }
}
