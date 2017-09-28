namespace ManualDHCP
{
    partial class Form_Anzeige
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
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_abort = new System.Windows.Forms.Button();
            this.bt_refresh = new System.Windows.Forms.Button();
            this.bt_new = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(1150, 549);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(119, 23);
            this.bt_save.TabIndex = 0;
            this.bt_save.Text = "Speichern";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_abort
            // 
            this.bt_abort.Location = new System.Drawing.Point(12, 549);
            this.bt_abort.Name = "bt_abort";
            this.bt_abort.Size = new System.Drawing.Size(119, 23);
            this.bt_abort.TabIndex = 2;
            this.bt_abort.Text = "Schließen";
            this.bt_abort.UseVisualStyleBackColor = true;
            this.bt_abort.Click += new System.EventHandler(this.bt_abort_Click);
            // 
            // bt_refresh
            // 
            this.bt_refresh.Location = new System.Drawing.Point(1150, 508);
            this.bt_refresh.Name = "bt_refresh";
            this.bt_refresh.Size = new System.Drawing.Size(119, 23);
            this.bt_refresh.TabIndex = 2;
            this.bt_refresh.Text = "Aktualisieren";
            this.bt_refresh.UseVisualStyleBackColor = true;
            this.bt_refresh.Click += new System.EventHandler(this.bt_refresh_Click);
            // 
            // bt_new
            // 
            this.bt_new.Location = new System.Drawing.Point(1012, 549);
            this.bt_new.Name = "bt_new";
            this.bt_new.Size = new System.Drawing.Size(119, 23);
            this.bt_new.TabIndex = 3;
            this.bt_new.Text = "Neues Netz eintragen";
            this.bt_new.UseVisualStyleBackColor = true;
            this.bt_new.Click += new System.EventHandler(this.bt_new_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 17);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1257, 472);
            this.listBox1.TabIndex = 4;
            // 
            // Form_Anzeige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 584);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bt_new);
            this.Controls.Add(this.bt_refresh);
            this.Controls.Add(this.bt_abort);
            this.Controls.Add(this.bt_save);
            this.Name = "Form_Anzeige";
            this.Text = "Form_Anzeige";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_abort;
        private System.Windows.Forms.Button bt_refresh;
        private System.Windows.Forms.Button bt_new;
        private System.Windows.Forms.ListBox listBox1;
    }
}