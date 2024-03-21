namespace EmpleadoVista
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 49);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(113, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(108, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(113, 70);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(108, 23);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 78);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Apellido";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(398, 41);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(108, 23);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(317, 49);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 4;
            label3.Text = "Puesto";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(398, 70);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(108, 23);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(317, 78);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 6;
            label4.Text = "Salario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 130);
            label5.Name = "label5";
            label5.Size = new Size(126, 15);
            label5.TabIndex = 8;
            label5.Text = "Fecha de Contratación";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(209, 122);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(233, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 261);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(474, 177);
            dataGridView1.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(113, 200);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Insertar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(222, 200);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 12;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(327, 200);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 13;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}