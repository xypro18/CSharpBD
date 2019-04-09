namespace BaseDados
{
    partial class TreeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreeView));
            this.tView = new System.Windows.Forms.TreeView();
            this.tNome = new System.Windows.Forms.TextBox();
            this.bSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tView
            // 
            this.tView.Location = new System.Drawing.Point(12, 12);
            this.tView.Name = "tView";
            this.tView.Size = new System.Drawing.Size(305, 318);
            this.tView.TabIndex = 0;
            this.tView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tView_AfterSelect);
            // 
            // tNome
            // 
            this.tNome.Location = new System.Drawing.Point(343, 12);
            this.tNome.Name = "tNome";
            this.tNome.Size = new System.Drawing.Size(174, 20);
            this.tNome.TabIndex = 1;
            // 
            // bSair
            // 
            this.bSair.Image = global::BaseDados.Properties.Resources.Sair;
            this.bSair.Location = new System.Drawing.Point(447, 260);
            this.bSair.Name = "bSair";
            this.bSair.Size = new System.Drawing.Size(70, 70);
            this.bSair.TabIndex = 7;
            this.bSair.UseVisualStyleBackColor = true;
            this.bSair.Click += new System.EventHandler(this.bSair_Click);
            // 
            // TreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 342);
            this.Controls.Add(this.bSair);
            this.Controls.Add(this.tNome);
            this.Controls.Add(this.tView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TreeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demonstração de uma TreeView - SQL Server";
            this.Load += new System.EventHandler(this.TreeView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tView;
        private System.Windows.Forms.TextBox tNome;
        private System.Windows.Forms.Button bSair;
    }
}