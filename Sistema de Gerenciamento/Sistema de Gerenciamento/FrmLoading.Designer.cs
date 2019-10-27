namespace Sistema_de_Gerenciamento
{
    partial class FrmLoading
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
            this.panFundo = new System.Windows.Forms.Panel();
            this.pbLoading = new System.Windows.Forms.ProgressBar();
            this.picFundo = new System.Windows.Forms.PictureBox();
            this.timLoad = new System.Windows.Forms.Timer(this.components);
            this.panFundo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFundo)).BeginInit();
            this.SuspendLayout();
            // 
            // panFundo
            // 
            this.panFundo.Controls.Add(this.pbLoading);
            this.panFundo.Controls.Add(this.picFundo);
            this.panFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panFundo.Location = new System.Drawing.Point(0, 0);
            this.panFundo.Name = "panFundo";
            this.panFundo.Size = new System.Drawing.Size(443, 268);
            this.panFundo.TabIndex = 0;
            // 
            // pbLoading
            // 
            this.pbLoading.Location = new System.Drawing.Point(76, 197);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(292, 23);
            this.pbLoading.TabIndex = 1;
            // 
            // picFundo
            // 
            this.picFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picFundo.Image = global::Sistema_de_Gerenciamento.Properties.Resources.orcamento_logistica;
            this.picFundo.Location = new System.Drawing.Point(0, 0);
            this.picFundo.Name = "picFundo";
            this.picFundo.Size = new System.Drawing.Size(443, 268);
            this.picFundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFundo.TabIndex = 0;
            this.picFundo.TabStop = false;
            // 
            // timLoad
            // 
            this.timLoad.Enabled = true;
            this.timLoad.Tick += new System.EventHandler(this.timLoad_Tick);
            // 
            // FrmLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 268);
            this.Controls.Add(this.panFundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLoading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.panFundo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFundo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panFundo;
        private System.Windows.Forms.PictureBox picFundo;
        private System.Windows.Forms.ProgressBar pbLoading;
        private System.Windows.Forms.Timer timLoad;
    }
}

