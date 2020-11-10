namespace Jardineria
{
    partial class Pruebas
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.btnCodigoCliente = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BuscarPedido = new System.Windows.Forms.Button();
            this.txtCodigoPedido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnListarProductos = new System.Windows.Forms.Button();
            this.txtListarProductos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ListarPedidos = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Prueba";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ListarPedidos ->";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo Cliente:";
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Location = new System.Drawing.Point(184, 91);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoCliente.TabIndex = 3;
            // 
            // btnCodigoCliente
            // 
            this.btnCodigoCliente.Location = new System.Drawing.Point(310, 89);
            this.btnCodigoCliente.Name = "btnCodigoCliente";
            this.btnCodigoCliente.Size = new System.Drawing.Size(75, 23);
            this.btnCodigoCliente.TabIndex = 4;
            this.btnCodigoCliente.Text = "Mostrar";
            this.btnCodigoCliente.UseVisualStyleBackColor = true;
            this.btnCodigoCliente.Click += new System.EventHandler(this.btnCodigoCliente_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(15, 230);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(578, 186);
            this.listBox1.TabIndex = 5;
            // 
            // BuscarPedido
            // 
            this.BuscarPedido.Location = new System.Drawing.Point(310, 131);
            this.BuscarPedido.Name = "BuscarPedido";
            this.BuscarPedido.Size = new System.Drawing.Size(75, 23);
            this.BuscarPedido.TabIndex = 9;
            this.BuscarPedido.Text = "Mostrar";
            this.BuscarPedido.UseVisualStyleBackColor = true;
            this.BuscarPedido.Click += new System.EventHandler(this.BuscarPedido_Click);
            // 
            // txtCodigoPedido
            // 
            this.txtCodigoPedido.Location = new System.Drawing.Point(184, 130);
            this.txtCodigoPedido.Name = "txtCodigoPedido";
            this.txtCodigoPedido.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoPedido.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Codigo Pedido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "ListarPedido ->";
            // 
            // btnListarProductos
            // 
            this.btnListarProductos.Location = new System.Drawing.Point(310, 176);
            this.btnListarProductos.Name = "btnListarProductos";
            this.btnListarProductos.Size = new System.Drawing.Size(75, 23);
            this.btnListarProductos.TabIndex = 13;
            this.btnListarProductos.Text = "Mostrar";
            this.btnListarProductos.UseVisualStyleBackColor = true;
            this.btnListarProductos.Click += new System.EventHandler(this.btnListarProductos_Click);
            // 
            // txtListarProductos
            // 
            this.txtListarProductos.Location = new System.Drawing.Point(184, 175);
            this.txtListarProductos.Name = "txtListarProductos";
            this.txtListarProductos.Size = new System.Drawing.Size(100, 20);
            this.txtListarProductos.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Codigo Pedido:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "ListarProductos ->";
            // 
            // ListarPedidos
            // 
            this.ListarPedidos.Location = new System.Drawing.Point(477, 49);
            this.ListarPedidos.Name = "ListarPedidos";
            this.ListarPedidos.Size = new System.Drawing.Size(164, 39);
            this.ListarPedidos.TabIndex = 17;
            this.ListarPedidos.Text = "Mostrar todos los Pedidos";
            this.ListarPedidos.UseVisualStyleBackColor = true;
            this.ListarPedidos.Click += new System.EventHandler(this.ListarPedidos_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(647, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = " ->";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(672, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(548, 367);
            this.dataGridView1.TabIndex = 18;
            // 
            // Pruebas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 518);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ListarPedidos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnListarProductos);
            this.Controls.Add(this.txtListarProductos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BuscarPedido);
            this.Controls.Add(this.txtCodigoPedido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnCodigoCliente);
            this.Controls.Add(this.txtCodigoCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Pruebas";
            this.Text = "Pruebas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.Button btnCodigoCliente;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BuscarPedido;
        private System.Windows.Forms.TextBox txtCodigoPedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnListarProductos;
        private System.Windows.Forms.TextBox txtListarProductos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ListarPedidos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}