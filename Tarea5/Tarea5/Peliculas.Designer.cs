namespace Tarea5
{
    partial class Peliculas
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
            this.dgPeliculas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgPeliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPeliculas
            // 
            this.dgPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPeliculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Pelicula});
            this.dgPeliculas.Location = new System.Drawing.Point(1, 1);
            this.dgPeliculas.Name = "dgPeliculas";
            this.dgPeliculas.Size = new System.Drawing.Size(244, 281);
            this.dgPeliculas.TabIndex = 0;
            this.dgPeliculas.DoubleClick += new System.EventHandler(this.dgPeliculas_DoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id_pelicula";
            this.ID.HeaderText = "ID Pelicula";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Pelicula
            // 
            this.Pelicula.DataPropertyName = "nombre_pelicula";
            this.Pelicula.HeaderText = "Pelicula";
            this.Pelicula.Name = "Pelicula";
            this.Pelicula.ReadOnly = true;
            // 
            // Peliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 284);
            this.Controls.Add(this.dgPeliculas);
            this.Name = "Peliculas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Peliculas";
            this.Load += new System.EventHandler(this.Peliculas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPeliculas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPeliculas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pelicula;
    }
}