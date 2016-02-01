namespace Commercial.Presentation
{
    partial class FDetailsCde
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDetailsCde));
            this.lvart = new System.Windows.Forms.ListView();
            this.HT = new System.Windows.Forms.Label();
            this.TTC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvart
            // 
            this.lvart.Location = new System.Drawing.Point(16, 14);
            this.lvart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvart.Name = "lvart";
            this.lvart.Size = new System.Drawing.Size(688, 317);
            this.lvart.TabIndex = 5;
            this.lvart.UseCompatibleStateImageBehavior = false;
            // 
            // HT
            // 
            this.HT.AutoSize = true;
            this.HT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HT.Location = new System.Drawing.Point(26, 346);
            this.HT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HT.Name = "HT";
            this.HT.Size = new System.Drawing.Size(119, 20);
            this.HT.TabIndex = 6;
            this.HT.Text = "Montant HT :";
            // 
            // TTC
            // 
            this.TTC.AutoSize = true;
            this.TTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTC.Location = new System.Drawing.Point(386, 346);
            this.TTC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TTC.Name = "TTC";
            this.TTC.Size = new System.Drawing.Size(129, 20);
            this.TTC.TabIndex = 7;
            this.TTC.Text = "Montant TTC :";
            // 
            // FDetailsCde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 375);
            this.Controls.Add(this.TTC);
            this.Controls.Add(this.HT);
            this.Controls.Add(this.lvart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(739, 431);
            this.MinimumSize = new System.Drawing.Size(739, 401);
            this.Name = "FDetailsCde";
            this.Text = "Détails de la commande";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvart;
        private System.Windows.Forms.Label HT;
        private System.Windows.Forms.Label TTC;
    }
}