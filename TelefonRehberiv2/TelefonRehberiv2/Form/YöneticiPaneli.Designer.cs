
namespace TelefonRehberiv2
{
    partial class YöneticiPaneli
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
            this.lbKişiler = new System.Windows.Forms.ListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rbSehirAra = new System.Windows.Forms.RadioButton();
            this.rbİlçeAra = new System.Windows.Forms.RadioButton();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adresEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbKişiler
            // 
            this.lbKişiler.FormattingEnabled = true;
            this.lbKişiler.Location = new System.Drawing.Point(12, 12);
            this.lbKişiler.Name = "lbKişiler";
            this.lbKişiler.Size = new System.Drawing.Size(187, 342);
            this.lbKişiler.TabIndex = 0;
            this.lbKişiler.DoubleClick += new System.EventHandler(this.lbKişiler_DoubleClick);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(205, 90);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(583, 264);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Şehir";
            this.columnHeader1.Width = 115;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "İlçe";
            this.columnHeader2.Width = 165;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Detay";
            this.columnHeader3.Width = 274;
            // 
            // rbSehirAra
            // 
            this.rbSehirAra.AutoSize = true;
            this.rbSehirAra.Location = new System.Drawing.Point(229, 39);
            this.rbSehirAra.Name = "rbSehirAra";
            this.rbSehirAra.Size = new System.Drawing.Size(68, 17);
            this.rbSehirAra.TabIndex = 2;
            this.rbSehirAra.TabStop = true;
            this.rbSehirAra.Text = "Sehir Ara";
            this.rbSehirAra.UseVisualStyleBackColor = true;
            // 
            // rbİlçeAra
            // 
            this.rbİlçeAra.AutoSize = true;
            this.rbİlçeAra.Location = new System.Drawing.Point(344, 39);
            this.rbİlçeAra.Name = "rbİlçeAra";
            this.rbİlçeAra.Size = new System.Drawing.Size(61, 17);
            this.rbİlçeAra.TabIndex = 3;
            this.rbİlçeAra.TabStop = true;
            this.rbİlçeAra.Text = "İlçe Ara";
            this.rbİlçeAra.UseVisualStyleBackColor = true;
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(517, 36);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(168, 20);
            this.txtArama.TabIndex = 4;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adresEkleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 48);
            // 
            // adresEkleToolStripMenuItem
            // 
            this.adresEkleToolStripMenuItem.Name = "adresEkleToolStripMenuItem";
            this.adresEkleToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.adresEkleToolStripMenuItem.Text = "Adres Ekle";
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.silToolStripMenuItem.Text = "Sil";
            // 
            // YöneticiPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 378);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.rbİlçeAra);
            this.Controls.Add(this.rbSehirAra);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lbKişiler);
            this.Name = "YöneticiPaneli";
            this.Text = "YöneticiPaneli";
            this.Load += new System.EventHandler(this.YöneticiPaneli_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbKişiler;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.RadioButton rbSehirAra;
        private System.Windows.Forms.RadioButton rbİlçeAra;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adresEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}