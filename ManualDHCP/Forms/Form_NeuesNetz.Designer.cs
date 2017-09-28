namespace ManualDHCP
{
    partial class Form_NeuesNetz
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
            this.bt_accept = new System.Windows.Forms.Button();
            this.bt_abort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nmUpDown_anzHosts = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nmUpDown_anzHosts)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_accept
            // 
            this.bt_accept.Location = new System.Drawing.Point(177, 64);
            this.bt_accept.Name = "bt_accept";
            this.bt_accept.Size = new System.Drawing.Size(129, 23);
            this.bt_accept.TabIndex = 0;
            this.bt_accept.Text = "Ok";
            this.bt_accept.UseVisualStyleBackColor = true;
            this.bt_accept.Click += new System.EventHandler(this.bt_accept_Click);
            // 
            // bt_abort
            // 
            this.bt_abort.Location = new System.Drawing.Point(12, 64);
            this.bt_abort.Name = "bt_abort";
            this.bt_abort.Size = new System.Drawing.Size(137, 23);
            this.bt_abort.TabIndex = 1;
            this.bt_abort.Text = "Abbrechen";
            this.bt_abort.UseVisualStyleBackColor = true;
            this.bt_abort.Click += new System.EventHandler(this.bt_abort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP des Datenbankservers";
            // 
            // nmUpDown_anzHosts
            // 
            this.nmUpDown_anzHosts.Location = new System.Drawing.Point(177, 25);
            this.nmUpDown_anzHosts.Maximum = new decimal(new int[] {
            16777212,
            0,
            0,
            0});
            this.nmUpDown_anzHosts.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nmUpDown_anzHosts.Name = "nmUpDown_anzHosts";
            this.nmUpDown_anzHosts.Size = new System.Drawing.Size(129, 20);
            this.nmUpDown_anzHosts.TabIndex = 3;
            this.nmUpDown_anzHosts.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Form_NeuesNetz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 99);
            this.Controls.Add(this.nmUpDown_anzHosts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_abort);
            this.Controls.Add(this.bt_accept);
            this.Name = "Form_NeuesNetz";
            this.Text = "Form_NeuesNetz";
            ((System.ComponentModel.ISupportInitialize)(this.nmUpDown_anzHosts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_accept;
        private System.Windows.Forms.Button bt_abort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmUpDown_anzHosts;
    }
}