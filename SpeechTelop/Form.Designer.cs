namespace SpeechTelop
{
    partial class Form
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.toLanguageComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.subscriptionKeyTextBox = new System.Windows.Forms.TextBox();
            this.showSubscriptionKeyCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.serviceRegionComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fromLanguageComboBox = new System.Windows.Forms.ComboBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemWatcher = new System.IO.FileSystemWatcher();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.enableTextToSpeechCheckBox = new System.Windows.Forms.CheckBox();
            this.hideAfterSecondsMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.outputFileBrowseButton = new System.Windows.Forms.Button();
            this.addAltKeyCheckBox = new System.Windows.Forms.CheckBox();
            this.outputFileTextBox = new System.Windows.Forms.TextBox();
            this.addCtrlKeyCheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.hotKeyComboBox = new System.Windows.Forms.ComboBox();
            this.addShiftKeyCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.voiceNameLabel = new System.Windows.Forms.Label();
            this.voiceNameComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toLanguageComboBox
            // 
            this.toLanguageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toLanguageComboBox.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.toLanguageComboBox.FormattingEnabled = true;
            this.toLanguageComboBox.Location = new System.Drawing.Point(116, 143);
            this.toLanguageComboBox.Name = "toLanguageComboBox";
            this.toLanguageComboBox.Size = new System.Drawing.Size(121, 23);
            this.toLanguageComboBox.TabIndex = 0;
            this.toLanguageComboBox.SelectedIndexChanged += new System.EventHandler(this.ToLanguageComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(29, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "To-Language:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Subscription-Key:";
            // 
            // subscriptionKeyTextBox
            // 
            this.subscriptionKeyTextBox.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.subscriptionKeyTextBox.Location = new System.Drawing.Point(116, 21);
            this.subscriptionKeyTextBox.Name = "subscriptionKeyTextBox";
            this.subscriptionKeyTextBox.Size = new System.Drawing.Size(225, 23);
            this.subscriptionKeyTextBox.TabIndex = 5;
            this.subscriptionKeyTextBox.UseSystemPasswordChar = true;
            // 
            // showSubscriptionKeyCheckBox
            // 
            this.showSubscriptionKeyCheckBox.AutoSize = true;
            this.showSubscriptionKeyCheckBox.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.showSubscriptionKeyCheckBox.Location = new System.Drawing.Point(116, 50);
            this.showSubscriptionKeyCheckBox.Name = "showSubscriptionKeyCheckBox";
            this.showSubscriptionKeyCheckBox.Size = new System.Drawing.Size(160, 19);
            this.showSubscriptionKeyCheckBox.TabIndex = 6;
            this.showSubscriptionKeyCheckBox.Text = "Show Subscription-Key";
            this.showSubscriptionKeyCheckBox.UseVisualStyleBackColor = true;
            this.showSubscriptionKeyCheckBox.CheckedChanged += new System.EventHandler(this.ShowSubscriptionKeyCheckBox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.voiceNameComboBox);
            this.groupBox1.Controls.Add(this.voiceNameLabel);
            this.groupBox1.Controls.Add(this.enableTextToSpeechCheckBox);
            this.groupBox1.Controls.Add(this.serviceRegionComboBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.fromLanguageComboBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.subscriptionKeyTextBox);
            this.groupBox1.Controls.Add(this.toLanguageComboBox);
            this.groupBox1.Controls.Add(this.showSubscriptionKeyCheckBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 236);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Microsoft Speech Service";
            // 
            // serviceRegionComboBox
            // 
            this.serviceRegionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serviceRegionComboBox.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.serviceRegionComboBox.FormattingEnabled = true;
            this.serviceRegionComboBox.Location = new System.Drawing.Point(116, 75);
            this.serviceRegionComboBox.Name = "serviceRegionComboBox";
            this.serviceRegionComboBox.Size = new System.Drawing.Size(121, 23);
            this.serviceRegionComboBox.TabIndex = 10;
            this.serviceRegionComboBox.SelectedIndexChanged += new System.EventHandler(this.ServiceRegionComboBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(17, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Service-Region:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(12, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "From-Language:";
            // 
            // fromLanguageComboBox
            // 
            this.fromLanguageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fromLanguageComboBox.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.fromLanguageComboBox.FormattingEnabled = true;
            this.fromLanguageComboBox.Items.AddRange(new object[] {
            "Statistical Base Machine Translation",
            "Neural Machine Translation"});
            this.fromLanguageComboBox.Location = new System.Drawing.Point(116, 114);
            this.fromLanguageComboBox.Name = "fromLanguageComboBox";
            this.fromLanguageComboBox.Size = new System.Drawing.Size(121, 23);
            this.fromLanguageComboBox.TabIndex = 7;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "chat_history.txt";
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "SpeechTelop";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.NotifyIcon_DoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(104, 54);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // fileSystemWatcher
            // 
            this.fileSystemWatcher.EnableRaisingEvents = true;
            this.fileSystemWatcher.Filter = "*.txt";
            this.fileSystemWatcher.SynchronizingObject = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.hideAfterSecondsMaskedTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.outputFileBrowseButton);
            this.groupBox2.Controls.Add(this.addAltKeyCheckBox);
            this.groupBox2.Controls.Add(this.outputFileTextBox);
            this.groupBox2.Controls.Add(this.addCtrlKeyCheckBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.hotKeyComboBox);
            this.groupBox2.Controls.Add(this.addShiftKeyCheckBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox2.Location = new System.Drawing.Point(12, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 181);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Push To Talk";
            // 
            // enableTextToSpeechCheckBox
            // 
            this.enableTextToSpeechCheckBox.AutoSize = true;
            this.enableTextToSpeechCheckBox.Checked = true;
            this.enableTextToSpeechCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableTextToSpeechCheckBox.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.enableTextToSpeechCheckBox.Location = new System.Drawing.Point(11, 172);
            this.enableTextToSpeechCheckBox.Name = "enableTextToSpeechCheckBox";
            this.enableTextToSpeechCheckBox.Size = new System.Drawing.Size(159, 19);
            this.enableTextToSpeechCheckBox.TabIndex = 11;
            this.enableTextToSpeechCheckBox.Text = "Enable Text-To-Speech";
            this.enableTextToSpeechCheckBox.UseVisualStyleBackColor = true;
            this.enableTextToSpeechCheckBox.CheckedChanged += new System.EventHandler(this.EnableTextToSpeechCheckBox_CheckedChanged);
            // 
            // hideAfterSecondsMaskedTextBox
            // 
            this.hideAfterSecondsMaskedTextBox.Location = new System.Drawing.Point(136, 147);
            this.hideAfterSecondsMaskedTextBox.Mask = "999";
            this.hideAfterSecondsMaskedTextBox.Name = "hideAfterSecondsMaskedTextBox";
            this.hideAfterSecondsMaskedTextBox.Size = new System.Drawing.Size(40, 23);
            this.hideAfterSecondsMaskedTextBox.TabIndex = 13;
            this.hideAfterSecondsMaskedTextBox.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(5, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Hide-After-Seconds:";
            // 
            // outputFileBrowseButton
            // 
            this.outputFileBrowseButton.Location = new System.Drawing.Point(91, 108);
            this.outputFileBrowseButton.Name = "outputFileBrowseButton";
            this.outputFileBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.outputFileBrowseButton.TabIndex = 7;
            this.outputFileBrowseButton.Text = "Browse";
            this.outputFileBrowseButton.UseVisualStyleBackColor = true;
            this.outputFileBrowseButton.Click += new System.EventHandler(this.OutputFileBrowseButton_Click);
            // 
            // addAltKeyCheckBox
            // 
            this.addAltKeyCheckBox.AutoSize = true;
            this.addAltKeyCheckBox.Location = new System.Drawing.Point(184, 51);
            this.addAltKeyCheckBox.Name = "addAltKeyCheckBox";
            this.addAltKeyCheckBox.Size = new System.Drawing.Size(42, 19);
            this.addAltKeyCheckBox.TabIndex = 11;
            this.addAltKeyCheckBox.Text = "Alt";
            this.addAltKeyCheckBox.UseVisualStyleBackColor = true;
            this.addAltKeyCheckBox.CheckedChanged += new System.EventHandler(this.AddAltKeyCheckBox_CheckedChanged);
            // 
            // outputFileTextBox
            // 
            this.outputFileTextBox.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.outputFileTextBox.Location = new System.Drawing.Point(91, 79);
            this.outputFileTextBox.Name = "outputFileTextBox";
            this.outputFileTextBox.Size = new System.Drawing.Size(250, 23);
            this.outputFileTextBox.TabIndex = 6;
            this.outputFileTextBox.TextChanged += new System.EventHandler(this.OutputFileTextBox_TextChanged);
            // 
            // addCtrlKeyCheckBox
            // 
            this.addCtrlKeyCheckBox.AutoSize = true;
            this.addCtrlKeyCheckBox.Location = new System.Drawing.Point(131, 51);
            this.addCtrlKeyCheckBox.Name = "addCtrlKeyCheckBox";
            this.addCtrlKeyCheckBox.Size = new System.Drawing.Size(47, 19);
            this.addCtrlKeyCheckBox.TabIndex = 10;
            this.addCtrlKeyCheckBox.Text = "Ctrl";
            this.addCtrlKeyCheckBox.UseVisualStyleBackColor = true;
            this.addCtrlKeyCheckBox.CheckedChanged += new System.EventHandler(this.AddCtrlKeyCheckBox_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(8, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Output-File:";
            // 
            // hotKeyComboBox
            // 
            this.hotKeyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hotKeyComboBox.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.hotKeyComboBox.FormattingEnabled = true;
            this.hotKeyComboBox.Location = new System.Drawing.Point(72, 22);
            this.hotKeyComboBox.Name = "hotKeyComboBox";
            this.hotKeyComboBox.Size = new System.Drawing.Size(119, 23);
            this.hotKeyComboBox.TabIndex = 9;
            this.hotKeyComboBox.SelectedIndexChanged += new System.EventHandler(this.HotKeyComboBox_SelectedIndexChanged);
            // 
            // addShiftKeyCheckBox
            // 
            this.addShiftKeyCheckBox.AutoSize = true;
            this.addShiftKeyCheckBox.Location = new System.Drawing.Point(72, 51);
            this.addShiftKeyCheckBox.Name = "addShiftKeyCheckBox";
            this.addShiftKeyCheckBox.Size = new System.Drawing.Size(53, 19);
            this.addShiftKeyCheckBox.TabIndex = 7;
            this.addShiftKeyCheckBox.Text = "Shift";
            this.addShiftKeyCheckBox.UseVisualStyleBackColor = true;
            this.addShiftKeyCheckBox.CheckedChanged += new System.EventHandler(this.AddShiftKeyCheckBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hot-Key:";
            // 
            // voiceNameLabel
            // 
            this.voiceNameLabel.AutoSize = true;
            this.voiceNameLabel.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.voiceNameLabel.Location = new System.Drawing.Point(12, 200);
            this.voiceNameLabel.Name = "voiceNameLabel";
            this.voiceNameLabel.Size = new System.Drawing.Size(77, 15);
            this.voiceNameLabel.TabIndex = 14;
            this.voiceNameLabel.Text = "VoiceName:";
            // 
            // voiceNameComboBox
            // 
            this.voiceNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.voiceNameComboBox.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.voiceNameComboBox.FormattingEnabled = true;
            this.voiceNameComboBox.Items.AddRange(new object[] {
            "ru-RU-Pavel-Apollo (Female)"});
            this.voiceNameComboBox.Location = new System.Drawing.Point(95, 197);
            this.voiceNameComboBox.Name = "voiceNameComboBox";
            this.voiceNameComboBox.Size = new System.Drawing.Size(210, 23);
            this.voiceNameComboBox.TabIndex = 15;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 446);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(100, 100);
            this.MaximizeBox = false;
            this.Name = "Form";
            this.Text = "SpeechTelop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_FormClosed);
            this.Load += new System.EventHandler(this.Form_Load);
            this.ClientSizeChanged += new System.EventHandler(this.Form_ClientSizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox toLanguageComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox subscriptionKeyTextBox;
        private System.Windows.Forms.CheckBox showSubscriptionKeyCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox fromLanguageComboBox;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.IO.FileSystemWatcher fileSystemWatcher;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox addAltKeyCheckBox;
        private System.Windows.Forms.CheckBox addCtrlKeyCheckBox;
        private System.Windows.Forms.ComboBox hotKeyComboBox;
        private System.Windows.Forms.CheckBox addShiftKeyCheckBox;
        private System.Windows.Forms.MaskedTextBox hideAfterSecondsMaskedTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button outputFileBrowseButton;
        private System.Windows.Forms.TextBox outputFileTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox serviceRegionComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox enableTextToSpeechCheckBox;
        private System.Windows.Forms.ComboBox voiceNameComboBox;
        private System.Windows.Forms.Label voiceNameLabel;
    }
}

