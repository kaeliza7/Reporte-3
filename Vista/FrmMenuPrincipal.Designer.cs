namespace Vista
{
    partial class FrmMenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_rep = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btn_Inv = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btn_rv = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_rep = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_emp = new System.Windows.Forms.Button();
            this.btn_comp = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_pro = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ven = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.bnt_min = new System.Windows.Forms.Button();
            this.btn_max = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btn_res = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblCargo = new System.Windows.Forms.Label();
            this.pnl_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_rep.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_menu
            // 
            this.pnl_menu.BackColor = System.Drawing.Color.Red;
            this.pnl_menu.Controls.Add(this.pictureBox1);
            this.pnl_menu.Controls.Add(this.pnl_rep);
            this.pnl_menu.Controls.Add(this.panel7);
            this.pnl_menu.Controls.Add(this.btn_rep);
            this.pnl_menu.Controls.Add(this.panel6);
            this.pnl_menu.Controls.Add(this.panel5);
            this.pnl_menu.Controls.Add(this.btn_emp);
            this.pnl_menu.Controls.Add(this.btn_comp);
            this.pnl_menu.Controls.Add(this.panel4);
            this.pnl_menu.Controls.Add(this.btn_pro);
            this.pnl_menu.Controls.Add(this.panel2);
            this.pnl_menu.Controls.Add(this.btn_ven);
            this.pnl_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(294, 661);
            this.pnl_menu.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(58, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 123);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pnl_rep
            // 
            this.pnl_rep.Controls.Add(this.panel11);
            this.pnl_rep.Controls.Add(this.btn_Inv);
            this.pnl_rep.Controls.Add(this.panel10);
            this.pnl_rep.Controls.Add(this.button2);
            this.pnl_rep.Controls.Add(this.panel9);
            this.pnl_rep.Controls.Add(this.btn_rv);
            this.pnl_rep.Location = new System.Drawing.Point(48, 449);
            this.pnl_rep.Name = "pnl_rep";
            this.pnl_rep.Size = new System.Drawing.Size(246, 248);
            this.pnl_rep.TabIndex = 8;
            this.pnl_rep.Visible = false;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.Location = new System.Drawing.Point(1, 49);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(5, 40);
            this.panel11.TabIndex = 13;
            // 
            // btn_Inv
            // 
            this.btn_Inv.BackColor = System.Drawing.Color.Red;
            this.btn_Inv.FlatAppearance.BorderSize = 0;
            this.btn_Inv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_Inv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Inv.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inv.ForeColor = System.Drawing.Color.White;
            this.btn_Inv.Image = ((System.Drawing.Image)(resources.GetObject("btn_Inv.Image")));
            this.btn_Inv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Inv.Location = new System.Drawing.Point(0, 49);
            this.btn_Inv.Name = "btn_Inv";
            this.btn_Inv.Size = new System.Drawing.Size(246, 40);
            this.btn_Inv.TabIndex = 12;
            this.btn_Inv.Text = "Inventario";
            this.btn_Inv.UseVisualStyleBackColor = false;
            this.btn_Inv.Click += new System.EventHandler(this.btn_Inv_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Location = new System.Drawing.Point(1, 95);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(5, 40);
            this.panel10.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(246, 40);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(1, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(5, 40);
            this.panel9.TabIndex = 9;
            // 
            // btn_rv
            // 
            this.btn_rv.BackColor = System.Drawing.Color.Red;
            this.btn_rv.FlatAppearance.BorderSize = 0;
            this.btn_rv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_rv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rv.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rv.ForeColor = System.Drawing.Color.White;
            this.btn_rv.Image = ((System.Drawing.Image)(resources.GetObject("btn_rv.Image")));
            this.btn_rv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_rv.Location = new System.Drawing.Point(0, 3);
            this.btn_rv.Name = "btn_rv";
            this.btn_rv.Size = new System.Drawing.Size(246, 40);
            this.btn_rv.TabIndex = 8;
            this.btn_rv.Text = "Ventas";
            this.btn_rv.UseVisualStyleBackColor = false;
            this.btn_rv.Click += new System.EventHandler(this.btn_rv_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(0, 398);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 45);
            this.panel7.TabIndex = 7;
            // 
            // btn_rep
            // 
            this.btn_rep.FlatAppearance.BorderSize = 0;
            this.btn_rep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_rep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rep.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rep.ForeColor = System.Drawing.Color.White;
            this.btn_rep.Image = ((System.Drawing.Image)(resources.GetObject("btn_rep.Image")));
            this.btn_rep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_rep.Location = new System.Drawing.Point(0, 398);
            this.btn_rep.Name = "btn_rep";
            this.btn_rep.Size = new System.Drawing.Size(294, 45);
            this.btn_rep.TabIndex = 6;
            this.btn_rep.Text = "Reportes";
            this.btn_rep.UseVisualStyleBackColor = true;
            this.btn_rep.Click += new System.EventHandler(this.btn_rep_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(0, 347);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 45);
            this.panel6.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(0, 245);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 45);
            this.panel5.TabIndex = 5;
            // 
            // btn_emp
            // 
            this.btn_emp.FlatAppearance.BorderSize = 0;
            this.btn_emp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_emp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_emp.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_emp.ForeColor = System.Drawing.Color.White;
            this.btn_emp.Image = ((System.Drawing.Image)(resources.GetObject("btn_emp.Image")));
            this.btn_emp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_emp.Location = new System.Drawing.Point(0, 347);
            this.btn_emp.Name = "btn_emp";
            this.btn_emp.Size = new System.Drawing.Size(294, 45);
            this.btn_emp.TabIndex = 3;
            this.btn_emp.Text = "Empleados";
            this.btn_emp.UseVisualStyleBackColor = true;
            this.btn_emp.Click += new System.EventHandler(this.btn_emp_Click);
            // 
            // btn_comp
            // 
            this.btn_comp.FlatAppearance.BorderSize = 0;
            this.btn_comp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_comp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_comp.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comp.ForeColor = System.Drawing.Color.White;
            this.btn_comp.Image = ((System.Drawing.Image)(resources.GetObject("btn_comp.Image")));
            this.btn_comp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_comp.Location = new System.Drawing.Point(0, 245);
            this.btn_comp.Name = "btn_comp";
            this.btn_comp.Size = new System.Drawing.Size(294, 45);
            this.btn_comp.TabIndex = 4;
            this.btn_comp.Text = "Compras";
            this.btn_comp.UseVisualStyleBackColor = true;
            this.btn_comp.Click += new System.EventHandler(this.btn_comp_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(0, 296);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 45);
            this.panel4.TabIndex = 3;
            // 
            // btn_pro
            // 
            this.btn_pro.FlatAppearance.BorderSize = 0;
            this.btn_pro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_pro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pro.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pro.ForeColor = System.Drawing.Color.White;
            this.btn_pro.Image = ((System.Drawing.Image)(resources.GetObject("btn_pro.Image")));
            this.btn_pro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pro.Location = new System.Drawing.Point(0, 296);
            this.btn_pro.Name = "btn_pro";
            this.btn_pro.Size = new System.Drawing.Size(294, 45);
            this.btn_pro.TabIndex = 2;
            this.btn_pro.Text = "Productos";
            this.btn_pro.UseVisualStyleBackColor = true;
            this.btn_pro.Click += new System.EventHandler(this.btn_pro_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 194);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 45);
            this.panel2.TabIndex = 1;
            // 
            // btn_ven
            // 
            this.btn_ven.FlatAppearance.BorderSize = 0;
            this.btn_ven.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_ven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ven.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ven.ForeColor = System.Drawing.Color.White;
            this.btn_ven.Image = ((System.Drawing.Image)(resources.GetObject("btn_ven.Image")));
            this.btn_ven.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ven.Location = new System.Drawing.Point(0, 194);
            this.btn_ven.Name = "btn_ven";
            this.btn_ven.Size = new System.Drawing.Size(294, 45);
            this.btn_ven.TabIndex = 0;
            this.btn_ven.Text = "Venta";
            this.btn_ven.UseVisualStyleBackColor = true;
            this.btn_ven.Click += new System.EventHandler(this.btn_ven_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblCargo);
            this.panel3.Controls.Add(this.btn_cerrar);
            this.panel3.Controls.Add(this.lblUsuario);
            this.panel3.Controls.Add(this.bnt_min);
            this.panel3.Controls.Add(this.btn_max);
            this.panel3.Controls.Add(this.btn_res);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(294, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(890, 57);
            this.panel3.TabIndex = 20;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.BackgroundImage")));
            this.btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Location = new System.Drawing.Point(831, 3);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(34, 34);
            this.btn_cerrar.TabIndex = 12;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // bnt_min
            // 
            this.bnt_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnt_min.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnt_min.BackgroundImage")));
            this.bnt_min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnt_min.FlatAppearance.BorderSize = 0;
            this.bnt_min.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(66)))), ((int)(((byte)(216)))));
            this.bnt_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_min.Location = new System.Drawing.Point(751, 3);
            this.bnt_min.Name = "bnt_min";
            this.bnt_min.Size = new System.Drawing.Size(34, 34);
            this.bnt_min.TabIndex = 13;
            this.bnt_min.UseVisualStyleBackColor = true;
            this.bnt_min.Click += new System.EventHandler(this.bnt_min_Click);
            // 
            // btn_max
            // 
            this.btn_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_max.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_max.BackgroundImage")));
            this.btn_max.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_max.FlatAppearance.BorderSize = 0;
            this.btn_max.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(66)))), ((int)(((byte)(216)))));
            this.btn_max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_max.Location = new System.Drawing.Point(791, 3);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(34, 34);
            this.btn_max.TabIndex = 14;
            this.btn_max.UseVisualStyleBackColor = true;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.BackColor = System.Drawing.Color.White;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(457, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(185, 44);
            this.lblUsuario.TabIndex = 7;
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // btn_res
            // 
            this.btn_res.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_res.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_res.BackgroundImage")));
            this.btn_res.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_res.FlatAppearance.BorderSize = 0;
            this.btn_res.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(66)))), ((int)(((byte)(216)))));
            this.btn_res.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_res.Location = new System.Drawing.Point(791, 3);
            this.btn_res.Name = "btn_res";
            this.btn_res.Size = new System.Drawing.Size(34, 34);
            this.btn_res.TabIndex = 15;
            this.btn_res.UseVisualStyleBackColor = true;
            this.btn_res.Visible = false;
            this.btn_res.Click += new System.EventHandler(this.btn_res_Click);
            // 
            // lblCargo
            // 
            this.lblCargo.BackColor = System.Drawing.Color.White;
            this.lblCargo.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(136, 9);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(220, 44);
            this.lblCargo.TabIndex = 16;
            this.lblCargo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnl_menu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenuPrincipal";
            this.Activated += new System.EventHandler(this.FrmMenuPrincipal_Activated);
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.pnl_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_rep.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnl_rep;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btn_Inv;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btn_rv;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btn_rep;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_emp;
        private System.Windows.Forms.Button btn_comp;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_pro;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_ven;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button bnt_min;
        private System.Windows.Forms.Button btn_max;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btn_res;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblCargo;
    }
}