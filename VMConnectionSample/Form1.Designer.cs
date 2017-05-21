namespace VMConnectionSample
{
    partial class Form1
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
            this.labelHostServer = new System.Windows.Forms.Label();
            this.textBoxHostServer = new System.Windows.Forms.TextBox();
            this.labelVmId = new System.Windows.Forms.Label();
            this.textBoxVmId = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxEnableEnhancedSession = new System.Windows.Forms.CheckBox();
            this.labelScreenWidth = new System.Windows.Forms.Label();
            this.numericUpDownScreenWidth = new System.Windows.Forms.NumericUpDown();
            this.labelScreenHeight = new System.Windows.Forms.Label();
            this.numericUpDownScreenHeight = new System.Windows.Forms.NumericUpDown();
            this.checkBoxEnableSmartSizing = new System.Windows.Forms.CheckBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.labelLogMessage = new System.Windows.Forms.Label();
            this.textBoxLogMessage = new System.Windows.Forms.TextBox();
            this.labelPlaceholder = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScreenWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScreenHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHostServer
            // 
            this.labelHostServer.AutoSize = true;
            this.labelHostServer.Location = new System.Drawing.Point(15, 22);
            this.labelHostServer.Name = "labelHostServer";
            this.labelHostServer.Size = new System.Drawing.Size(87, 17);
            this.labelHostServer.TabIndex = 0;
            this.labelHostServer.Text = "Host Server:";
            // 
            // textBoxHostServer
            // 
            this.textBoxHostServer.Location = new System.Drawing.Point(108, 19);
            this.textBoxHostServer.Name = "textBoxHostServer";
            this.textBoxHostServer.Size = new System.Drawing.Size(346, 22);
            this.textBoxHostServer.TabIndex = 1;
            // 
            // labelVmId
            // 
            this.labelVmId.AutoSize = true;
            this.labelVmId.Location = new System.Drawing.Point(15, 53);
            this.labelVmId.Name = "labelVmId";
            this.labelVmId.Size = new System.Drawing.Size(49, 17);
            this.labelVmId.TabIndex = 2;
            this.labelVmId.Text = "VM ID:";
            // 
            // textBoxVmId
            // 
            this.textBoxVmId.Location = new System.Drawing.Point(108, 50);
            this.textBoxVmId.Name = "textBoxVmId";
            this.textBoxVmId.Size = new System.Drawing.Size(346, 22);
            this.textBoxVmId.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownScreenHeight);
            this.groupBox1.Controls.Add(this.labelScreenHeight);
            this.groupBox1.Controls.Add(this.numericUpDownScreenWidth);
            this.groupBox1.Controls.Add(this.labelScreenWidth);
            this.groupBox1.Controls.Add(this.checkBoxEnableEnhancedSession);
            this.groupBox1.Location = new System.Drawing.Point(476, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 75);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // checkBoxEnableEnhancedSession
            // 
            this.checkBoxEnableEnhancedSession.AutoSize = true;
            this.checkBoxEnableEnhancedSession.Location = new System.Drawing.Point(15, -1);
            this.checkBoxEnableEnhancedSession.Name = "checkBoxEnableEnhancedSession";
            this.checkBoxEnableEnhancedSession.Size = new System.Drawing.Size(193, 21);
            this.checkBoxEnableEnhancedSession.TabIndex = 0;
            this.checkBoxEnableEnhancedSession.Text = "Enable enhanced session";
            this.checkBoxEnableEnhancedSession.UseVisualStyleBackColor = true;
            // 
            // labelScreenWidth
            // 
            this.labelScreenWidth.AutoSize = true;
            this.labelScreenWidth.Location = new System.Drawing.Point(12, 38);
            this.labelScreenWidth.Name = "labelScreenWidth";
            this.labelScreenWidth.Size = new System.Drawing.Size(93, 17);
            this.labelScreenWidth.TabIndex = 1;
            this.labelScreenWidth.Text = "Screen width:";
            // 
            // numericUpDownScreenWidth
            // 
            this.numericUpDownScreenWidth.Location = new System.Drawing.Point(111, 36);
            this.numericUpDownScreenWidth.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownScreenWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownScreenWidth.Name = "numericUpDownScreenWidth";
            this.numericUpDownScreenWidth.Size = new System.Drawing.Size(113, 22);
            this.numericUpDownScreenWidth.TabIndex = 2;
            this.numericUpDownScreenWidth.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // labelScreenHeight
            // 
            this.labelScreenHeight.AutoSize = true;
            this.labelScreenHeight.Location = new System.Drawing.Point(251, 38);
            this.labelScreenHeight.Name = "labelScreenHeight";
            this.labelScreenHeight.Size = new System.Drawing.Size(100, 17);
            this.labelScreenHeight.TabIndex = 3;
            this.labelScreenHeight.Text = "Screen height:";
            // 
            // numericUpDownScreenHeight
            // 
            this.numericUpDownScreenHeight.Location = new System.Drawing.Point(357, 36);
            this.numericUpDownScreenHeight.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownScreenHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownScreenHeight.Name = "numericUpDownScreenHeight";
            this.numericUpDownScreenHeight.Size = new System.Drawing.Size(113, 22);
            this.numericUpDownScreenHeight.TabIndex = 4;
            this.numericUpDownScreenHeight.Value = new decimal(new int[] {
            768,
            0,
            0,
            0});
            // 
            // checkBoxEnableSmartSizing
            // 
            this.checkBoxEnableSmartSizing.AutoSize = true;
            this.checkBoxEnableSmartSizing.Location = new System.Drawing.Point(491, 18);
            this.checkBoxEnableSmartSizing.Name = "checkBoxEnableSmartSizing";
            this.checkBoxEnableSmartSizing.Size = new System.Drawing.Size(153, 21);
            this.checkBoxEnableSmartSizing.TabIndex = 5;
            this.checkBoxEnableSmartSizing.Text = "Enable smart sizing";
            this.checkBoxEnableSmartSizing.UseVisualStyleBackColor = true;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(336, 89);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(118, 39);
            this.buttonConnect.TabIndex = 6;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // labelLogMessage
            // 
            this.labelLogMessage.AutoSize = true;
            this.labelLogMessage.Location = new System.Drawing.Point(12, 137);
            this.labelLogMessage.Name = "labelLogMessage";
            this.labelLogMessage.Size = new System.Drawing.Size(104, 17);
            this.labelLogMessage.TabIndex = 7;
            this.labelLogMessage.Text = "Log messages:";
            // 
            // textBoxLogMessage
            // 
            this.textBoxLogMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLogMessage.Location = new System.Drawing.Point(12, 157);
            this.textBoxLogMessage.Multiline = true;
            this.textBoxLogMessage.Name = "textBoxLogMessage";
            this.textBoxLogMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLogMessage.Size = new System.Drawing.Size(999, 129);
            this.textBoxLogMessage.TabIndex = 8;
            // 
            // labelPlaceholder
            // 
            this.labelPlaceholder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPlaceholder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPlaceholder.Location = new System.Drawing.Point(12, 301);
            this.labelPlaceholder.Name = "labelPlaceholder";
            this.labelPlaceholder.Size = new System.Drawing.Size(999, 463);
            this.labelPlaceholder.TabIndex = 9;
            this.labelPlaceholder.Text = "Placeholder";
            this.labelPlaceholder.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 776);
            this.Controls.Add(this.labelPlaceholder);
            this.Controls.Add(this.textBoxLogMessage);
            this.Controls.Add(this.labelLogMessage);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.checkBoxEnableSmartSizing);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxVmId);
            this.Controls.Add(this.labelVmId);
            this.Controls.Add(this.textBoxHostServer);
            this.Controls.Add(this.labelHostServer);
            this.Name = "Form1";
            this.Text = "VM Connection Sample";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScreenWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScreenHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHostServer;
        private System.Windows.Forms.TextBox textBoxHostServer;
        private System.Windows.Forms.Label labelVmId;
        private System.Windows.Forms.TextBox textBoxVmId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxEnableEnhancedSession;
        private System.Windows.Forms.NumericUpDown numericUpDownScreenHeight;
        private System.Windows.Forms.Label labelScreenHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownScreenWidth;
        private System.Windows.Forms.Label labelScreenWidth;
        private System.Windows.Forms.CheckBox checkBoxEnableSmartSizing;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label labelLogMessage;
        private System.Windows.Forms.TextBox textBoxLogMessage;
        private System.Windows.Forms.Label labelPlaceholder;
    }
}

