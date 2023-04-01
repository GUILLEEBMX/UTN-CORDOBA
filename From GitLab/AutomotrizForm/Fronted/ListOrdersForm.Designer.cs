namespace AutomotrizForm.Fronted
{
    partial class ListOrdersForm
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
            this.Clientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlazoEntregaPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEntregaPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiposSolicitudes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sucursales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiposEntregas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPedidod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlazoEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtNumberOrder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Clientes
            // 
            this.Clientes.HeaderText = "Nº Pedido";
            this.Clientes.Name = "Clientes";
            // 
            // PlazoEntregaPedido
            // 
            this.PlazoEntregaPedido.HeaderText = "Proveedores";
            this.PlazoEntregaPedido.Name = "PlazoEntregaPedido";
            // 
            // FechaEntregaPedido
            // 
            this.FechaEntregaPedido.HeaderText = "Sucursales";
            this.FechaEntregaPedido.Name = "FechaEntregaPedido";
            // 
            // HoraPedido
            // 
            this.HoraPedido.HeaderText = "Tipos Entregas";
            this.HoraPedido.Name = "HoraPedido";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Tipos Solicitudes";
            this.Fecha.Name = "Fecha";
            // 
            // Empleados
            // 
            this.Empleados.HeaderText = "Empleados";
            this.Empleados.Name = "Empleados";
            // 
            // TiposSolicitudes
            // 
            this.TiposSolicitudes.HeaderText = "Fecha Pedido";
            this.TiposSolicitudes.Name = "TiposSolicitudes";
            // 
            // Sucursales
            // 
            this.Sucursales.HeaderText = "Hora Pedido";
            this.Sucursales.Name = "Sucursales";
            // 
            // Proveedores
            // 
            this.Proveedores.HeaderText = "Fecha Entrega";
            this.Proveedores.Name = "Proveedores";
            // 
            // NroPedido
            // 
            this.NroPedido.HeaderText = "Nº Pedido";
            this.NroPedido.Name = "NroPedido";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Proveedores";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Sucursales";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // TiposEntregas
            // 
            this.TiposEntregas.HeaderText = "Tipos Entregas";
            this.TiposEntregas.Name = "TiposEntregas";
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.FechaPedidod,
            this.dataGridViewTextBoxColumn9,
            this.FechaEntrega,
            this.PlazoEntrega,
            this.dataGridViewTextBoxColumn10});
            this.dgvOrders.Location = new System.Drawing.Point(18, 166);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowTemplate.Height = 25;
            this.dgvOrders.Size = new System.Drawing.Size(1106, 272);
            this.dgvOrders.TabIndex = 0;
            this.dgvOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellContentClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Nº Pedido";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Proveedores";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Sucursales";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Tipos Entregas";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Tipos Solicitudes";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Empleados";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // FechaPedidod
            // 
            this.FechaPedidod.HeaderText = "Fecha Pedido";
            this.FechaPedidod.Name = "FechaPedidod";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Hora Pedido";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // FechaEntrega
            // 
            this.FechaEntrega.HeaderText = "Fecha Entrega";
            this.FechaEntrega.Name = "FechaEntrega";
            // 
            // PlazoEntrega
            // 
            this.PlazoEntrega.HeaderText = "Plazo Entrega";
            this.PlazoEntrega.Name = "PlazoEntrega";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Clientes";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(6, 71);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtNumberOrder
            // 
            this.txtNumberOrder.Location = new System.Drawing.Point(6, 44);
            this.txtNumberOrder.Name = "txtNumberOrder";
            this.txtNumberOrder.Size = new System.Drawing.Size(100, 23);
            this.txtNumberOrder.TabIndex = 3;
            this.txtNumberOrder.TextChanged += new System.EventHandler(this.txtNumberOrder_TextChanged);
            this.txtNumberOrder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumberOrder_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nº Pedido :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtNumberOrder);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 113);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Pedido:";
            // 
            // ListOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvOrders);
            this.Name = "ListOrdersForm";
            this.Text = "ListOrdersForm";
            this.Load += new System.EventHandler(this.ListOrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridViewTextBoxColumn Clientes;
        private DataGridViewTextBoxColumn PlazoEntregaPedido;
        private DataGridViewTextBoxColumn FechaEntregaPedido;
        private DataGridViewTextBoxColumn HoraPedido;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Empleados;
        private DataGridViewTextBoxColumn TiposSolicitudes;
        private DataGridViewTextBoxColumn Sucursales;
        private DataGridViewTextBoxColumn Proveedores;
        private DataGridViewTextBoxColumn NroPedido;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn TiposEntregas;
        private DataGridView dgvOrders;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn FechaPedidod;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn FechaEntrega;
        private DataGridViewTextBoxColumn PlazoEntrega;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private Button btnSearch;
        private TextBox txtNumberOrder;
        private Label label1;
        private GroupBox groupBox1;
    }
}