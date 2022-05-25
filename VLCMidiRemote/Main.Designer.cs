namespace VLCMidiRemote
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.rtbLogs = new System.Windows.Forms.RichTextBox();
            this.btStartVLC = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.nudMidiChannel = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDebug = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudMidiChannel)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbLogs
            // 
            this.rtbLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLogs.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbLogs.Location = new System.Drawing.Point(15, 104);
            this.rtbLogs.Margin = new System.Windows.Forms.Padding(2);
            this.rtbLogs.Name = "rtbLogs";
            this.rtbLogs.Size = new System.Drawing.Size(383, 66);
            this.rtbLogs.TabIndex = 1;
            this.rtbLogs.Text = "";
            // 
            // btStartVLC
            // 
            this.btStartVLC.BackColor = System.Drawing.Color.Lime;
            this.btStartVLC.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStartVLC.Location = new System.Drawing.Point(179, 20);
            this.btStartVLC.Margin = new System.Windows.Forms.Padding(2);
            this.btStartVLC.Name = "btStartVLC";
            this.btStartVLC.Size = new System.Drawing.Size(84, 41);
            this.btStartVLC.TabIndex = 2;
            this.btStartVLC.Text = "start VLC";
            this.btStartVLC.UseVisualStyleBackColor = false;
            this.btStartVLC.Click += new System.EventHandler(this.btStartVLC_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Red;
            this.btExit.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.Color.White;
            this.btExit.Location = new System.Drawing.Point(293, 21);
            this.btExit.Margin = new System.Windows.Forms.Padding(2);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(84, 40);
            this.btExit.TabIndex = 3;
            this.btExit.Text = "exit";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // nudMidiChannel
            // 
            this.nudMidiChannel.Location = new System.Drawing.Point(118, 22);
            this.nudMidiChannel.Margin = new System.Windows.Forms.Padding(2);
            this.nudMidiChannel.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudMidiChannel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMidiChannel.Name = "nudMidiChannel";
            this.nudMidiChannel.Size = new System.Drawing.Size(47, 20);
            this.nudMidiChannel.TabIndex = 4;
            this.nudMidiChannel.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Midi Channel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Logs";
            // 
            // cbDebug
            // 
            this.cbDebug.AutoSize = true;
            this.cbDebug.Checked = true;
            this.cbDebug.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDebug.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDebug.Location = new System.Drawing.Point(69, 46);
            this.cbDebug.Margin = new System.Windows.Forms.Padding(2);
            this.cbDebug.Name = "cbDebug";
            this.cbDebug.Size = new System.Drawing.Size(75, 26);
            this.cbDebug.TabIndex = 7;
            this.cbDebug.Text = "Debug";
            this.cbDebug.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(409, 197);
            this.Controls.Add(this.cbDebug);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudMidiChannel);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btStartVLC);
            this.Controls.Add(this.rtbLogs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "VLC Playlist Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.nudMidiChannel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbLogs;
        private System.Windows.Forms.Button btStartVLC;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.NumericUpDown nudMidiChannel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbDebug;
    }
}

