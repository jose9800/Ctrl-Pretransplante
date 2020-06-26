﻿namespace Control_PreTransplante_V2
{
    partial class Lista_P
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tap = new System.Windows.Forms.TabControl();
            this.listapaceintes = new System.Windows.Forms.TabPage();
            this.btnactualizar = new FontAwesome.Sharp.IconButton();
            this.pacientes = new System.Windows.Forms.TabPage();
            this.panellateral = new System.Windows.Forms.Panel();
            this.editar_P = new FontAwesome.Sharp.IconButton();
            this.Estudios = new FontAwesome.Sharp.IconButton();
            this.Lista = new System.Windows.Forms.DataGridView();
            this.tap.SuspendLayout();
            this.listapaceintes.SuspendLayout();
            this.panellateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lista)).BeginInit();
            this.SuspendLayout();
            // 
            // tap
            // 
            this.tap.Controls.Add(this.listapaceintes);
            this.tap.Controls.Add(this.pacientes);
            this.tap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tap.Location = new System.Drawing.Point(0, 0);
            this.tap.Name = "tap";
            this.tap.SelectedIndex = 0;
            this.tap.Size = new System.Drawing.Size(1600, 536);
            this.tap.TabIndex = 0;
            // 
            // listapaceintes
            // 
            this.listapaceintes.Controls.Add(this.Lista);
            this.listapaceintes.Controls.Add(this.panellateral);
            this.listapaceintes.Location = new System.Drawing.Point(4, 25);
            this.listapaceintes.Name = "listapaceintes";
            this.listapaceintes.Padding = new System.Windows.Forms.Padding(3);
            this.listapaceintes.Size = new System.Drawing.Size(1592, 507);
            this.listapaceintes.TabIndex = 0;
            this.listapaceintes.Text = "Lista Pacientes";
            this.listapaceintes.UseVisualStyleBackColor = true;
            // 
            // btnactualizar
            // 
            this.btnactualizar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnactualizar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnactualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizar.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            this.btnactualizar.IconColor = System.Drawing.Color.Black;
            this.btnactualizar.IconSize = 40;
            this.btnactualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnactualizar.Location = new System.Drawing.Point(0, 347);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Rotation = 0D;
            this.btnactualizar.Size = new System.Drawing.Size(230, 154);
            this.btnactualizar.TabIndex = 3;
            this.btnactualizar.Text = " Actualizar\r\nLista";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // pacientes
            // 
            this.pacientes.Location = new System.Drawing.Point(4, 25);
            this.pacientes.Name = "pacientes";
            this.pacientes.Padding = new System.Windows.Forms.Padding(3);
            this.pacientes.Size = new System.Drawing.Size(1592, 507);
            this.pacientes.TabIndex = 1;
            this.pacientes.Text = "Pacientes";
            this.pacientes.UseVisualStyleBackColor = true;
            this.pacientes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pacientes_MouseDoubleClick);
            // 
            // panellateral
            // 
            this.panellateral.Controls.Add(this.Estudios);
            this.panellateral.Controls.Add(this.editar_P);
            this.panellateral.Controls.Add(this.btnactualizar);
            this.panellateral.Dock = System.Windows.Forms.DockStyle.Right;
            this.panellateral.Location = new System.Drawing.Point(1359, 3);
            this.panellateral.Name = "panellateral";
            this.panellateral.Size = new System.Drawing.Size(230, 501);
            this.panellateral.TabIndex = 4;
            // 
            // editar_P
            // 
            this.editar_P.Dock = System.Windows.Forms.DockStyle.Top;
            this.editar_P.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.editar_P.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editar_P.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            this.editar_P.IconColor = System.Drawing.Color.Black;
            this.editar_P.IconSize = 40;
            this.editar_P.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editar_P.Location = new System.Drawing.Point(0, 0);
            this.editar_P.Name = "editar_P";
            this.editar_P.Rotation = 0D;
            this.editar_P.Size = new System.Drawing.Size(230, 160);
            this.editar_P.TabIndex = 6;
            this.editar_P.Text = "Editar\r\nPaciente";
            this.editar_P.UseVisualStyleBackColor = true;
            // 
            // Estudios
            // 
            this.Estudios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Estudios.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Estudios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estudios.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            this.Estudios.IconColor = System.Drawing.Color.Black;
            this.Estudios.IconSize = 40;
            this.Estudios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Estudios.Location = new System.Drawing.Point(0, 160);
            this.Estudios.Name = "Estudios";
            this.Estudios.Rotation = 0D;
            this.Estudios.Size = new System.Drawing.Size(230, 187);
            this.Estudios.TabIndex = 7;
            this.Estudios.Text = "Estudios";
            this.Estudios.UseVisualStyleBackColor = true;
            this.Estudios.Click += new System.EventHandler(this.Estudios_Click);
            // 
            // Lista
            // 
            this.Lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Lista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Lista.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Lista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Lista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Lista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Lista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Lista.ColumnHeadersHeight = 29;
            this.Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Lista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lista.EnableHeadersVisualStyles = false;
            this.Lista.GridColor = System.Drawing.Color.Teal;
            this.Lista.Location = new System.Drawing.Point(3, 3);
            this.Lista.Name = "Lista";
            this.Lista.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Lista.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Lista.RowHeadersVisible = false;
            this.Lista.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.Lista.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Lista.RowTemplate.Height = 24;
            this.Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Lista.Size = new System.Drawing.Size(1356, 501);
            this.Lista.TabIndex = 6;
            // 
            // Lista_P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 536);
            this.Controls.Add(this.tap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lista_P";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Lista_P_Load);
            this.tap.ResumeLayout(false);
            this.listapaceintes.ResumeLayout(false);
            this.panellateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Lista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tap;
        private System.Windows.Forms.TabPage listapaceintes;
        private System.Windows.Forms.TabPage pacientes;
        private FontAwesome.Sharp.IconButton btnactualizar;
        private System.Windows.Forms.Panel panellateral;
        private FontAwesome.Sharp.IconButton Estudios;
        private FontAwesome.Sharp.IconButton editar_P;
        private System.Windows.Forms.DataGridView Lista;
    }
}