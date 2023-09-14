namespace Crud_Produto
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
            menuStrip1 = new MenuStrip();
            oPÇÕESToolStripMenuItem = new ToolStripMenuItem();
            sAIRToolStripMenuItem = new ToolStripMenuItem();
            addProdutosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { oPÇÕESToolStripMenuItem, sAIRToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // oPÇÕESToolStripMenuItem
            // 
            oPÇÕESToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addProdutosToolStripMenuItem });
            oPÇÕESToolStripMenuItem.Name = "oPÇÕESToolStripMenuItem";
            oPÇÕESToolStripMenuItem.Size = new Size(64, 20);
            oPÇÕESToolStripMenuItem.Text = "OPÇÕES";
            // 
            // sAIRToolStripMenuItem
            // 
            sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
            sAIRToolStripMenuItem.Size = new Size(43, 20);
            sAIRToolStripMenuItem.Text = "SAIR";
            // 
            // addProdutosToolStripMenuItem
            // 
            addProdutosToolStripMenuItem.Name = "addProdutosToolStripMenuItem";
            addProdutosToolStripMenuItem.Size = new Size(180, 22);
            addProdutosToolStripMenuItem.Text = "Add_Produtos";
            addProdutosToolStripMenuItem.Click += addProdutosToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Menu";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem oPÇÕESToolStripMenuItem;
        private ToolStripMenuItem addProdutosToolStripMenuItem;
        private ToolStripMenuItem sAIRToolStripMenuItem;
    }
}