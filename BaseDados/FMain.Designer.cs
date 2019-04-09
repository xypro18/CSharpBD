namespace BaseDados
{
    partial class FMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.btn_tree = new System.Windows.Forms.Button();
            this.btn_sql = new System.Windows.Forms.Button();
            this.btn_access = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_tree
            // 
            this.btn_tree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tree.Image = global::BaseDados.Properties.Resources.TreeView;
            this.btn_tree.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_tree.Location = new System.Drawing.Point(504, 65);
            this.btn_tree.Name = "btn_tree";
            this.btn_tree.Size = new System.Drawing.Size(159, 173);
            this.btn_tree.TabIndex = 2;
            this.btn_tree.Text = "TreeView";
            this.btn_tree.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_tree.UseVisualStyleBackColor = true;
            this.btn_tree.Click += new System.EventHandler(this.btn_tree_Click);
            // 
            // btn_sql
            // 
            this.btn_sql.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sql.Image = global::BaseDados.Properties.Resources.SQL_1;
            this.btn_sql.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_sql.Location = new System.Drawing.Point(271, 65);
            this.btn_sql.Name = "btn_sql";
            this.btn_sql.Size = new System.Drawing.Size(159, 173);
            this.btn_sql.TabIndex = 1;
            this.btn_sql.Text = "SQL Server";
            this.btn_sql.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_sql.UseVisualStyleBackColor = true;
            this.btn_sql.Click += new System.EventHandler(this.btn_sql_Click);
            // 
            // btn_access
            // 
            this.btn_access.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_access.Image = global::BaseDados.Properties.Resources.ACCESS_1;
            this.btn_access.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_access.Location = new System.Drawing.Point(36, 65);
            this.btn_access.Name = "btn_access";
            this.btn_access.Size = new System.Drawing.Size(159, 173);
            this.btn_access.TabIndex = 0;
            this.btn_access.Text = "ACCESS";
            this.btn_access.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_access.UseVisualStyleBackColor = true;
            this.btn_access.Click += new System.EventHandler(this.btn_access_Click);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 311);
            this.Controls.Add(this.btn_tree);
            this.Controls.Add(this.btn_sql);
            this.Controls.Add(this.btn_access);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demonstração de acesso ao ACCESS e SQL Server";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_access;
        private System.Windows.Forms.Button btn_sql;
        private System.Windows.Forms.Button btn_tree;
    }
}

