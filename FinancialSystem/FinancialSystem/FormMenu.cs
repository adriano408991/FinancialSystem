using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialSystem
{
    public partial class FormMenu : Form
    {
        private Button btnFechar;
        private Panel panelCabecalho;

        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panelCabecalho.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelCabecalho.Controls.Add(this.btnFechar);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(284, 100);
            this.panelCabecalho.TabIndex = 0;
            this.panelCabecalho.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(0, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "button1";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // FormMenu
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.panelCabecalho);
            this.Name = "FormMenu";
            this.panelCabecalho.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
