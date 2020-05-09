namespace anxiety
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.LabelWatching = new System.Windows.Forms.Label();
            this.TimerWarning = new System.Windows.Forms.Timer(this.components);
            this.TimerMoveEyes = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LabelWatching
            // 
            this.LabelWatching.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelWatching.Location = new System.Drawing.Point(0, 0);
            this.LabelWatching.Name = "LabelWatching";
            this.LabelWatching.Size = new System.Drawing.Size(253, 76);
            this.LabelWatching.TabIndex = 0;
            this.LabelWatching.Text = resources.GetString("LabelWatching.Text");
            this.LabelWatching.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TimerWarning
            // 
            this.TimerWarning.Enabled = true;
            this.TimerWarning.Tick += new System.EventHandler(this.TimerWarning_Tick);
            // 
            // TimerMoveEyes
            // 
            this.TimerMoveEyes.Enabled = true;
            this.TimerMoveEyes.Tick += new System.EventHandler(this.TimerMoveEyes_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(253, 76);
            this.ControlBox = false;
            this.Controls.Add(this.LabelWatching);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.Opacity = 0.03D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelWatching;
        private System.Windows.Forms.Timer TimerWarning;
        private System.Windows.Forms.Timer TimerMoveEyes;
    }
}

