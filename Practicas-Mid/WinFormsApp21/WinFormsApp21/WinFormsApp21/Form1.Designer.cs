namespace WinFormsApp21
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            senderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            receiverDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            subjectDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bodyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mensajeBindingSource = new BindingSource(components);
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mensajeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(141, 31);
            label1.Name = "label1";
            label1.Size = new Size(325, 32);
            label1.TabIndex = 0;
            label1.Text = "Hola, estos son tus mensajes:";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { senderDataGridViewTextBoxColumn, receiverDataGridViewTextBoxColumn, subjectDataGridViewTextBoxColumn, bodyDataGridViewTextBoxColumn });
            dataGridView1.DataSource = mensajeBindingSource;
            dataGridView1.Location = new Point(85, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(541, 287);
            dataGridView1.TabIndex = 1;
            // 
            // senderDataGridViewTextBoxColumn
            // 
            senderDataGridViewTextBoxColumn.DataPropertyName = "sender";
            senderDataGridViewTextBoxColumn.HeaderText = "sender";
            senderDataGridViewTextBoxColumn.Name = "senderDataGridViewTextBoxColumn";
            // 
            // receiverDataGridViewTextBoxColumn
            // 
            receiverDataGridViewTextBoxColumn.DataPropertyName = "receiver";
            receiverDataGridViewTextBoxColumn.HeaderText = "receiver";
            receiverDataGridViewTextBoxColumn.Name = "receiverDataGridViewTextBoxColumn";
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            subjectDataGridViewTextBoxColumn.DataPropertyName = "subject";
            subjectDataGridViewTextBoxColumn.HeaderText = "subject";
            subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            // 
            // bodyDataGridViewTextBoxColumn
            // 
            bodyDataGridViewTextBoxColumn.DataPropertyName = "body";
            bodyDataGridViewTextBoxColumn.HeaderText = "body";
            bodyDataGridViewTextBoxColumn.Name = "bodyDataGridViewTextBoxColumn";
            // 
            // mensajeBindingSource
            // 
            mensajeBindingSource.DataSource = typeof(ClassLibrary1.Mensaje);
            // 
            // button1
            // 
            button1.Location = new Point(681, 157);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Refrescar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(740, 326);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(715, 37);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "Ir Form 2";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 433);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)mensajeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn senderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn receiverDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bodyDataGridViewTextBoxColumn;
        private BindingSource mensajeBindingSource;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
