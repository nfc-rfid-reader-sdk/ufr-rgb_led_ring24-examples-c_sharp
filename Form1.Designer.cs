namespace uFR_RGB_LED_Disp
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusReader = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnCardIdEx = new System.Windows.Forms.Button();
            this.tbCardType = new System.Windows.Forms.TextBox();
            this.lbCardType = new System.Windows.Forms.Label();
            this.tbCardId = new System.Windows.Forms.TextBox();
            this.lbCardId = new System.Windows.Forms.Label();
            this.tbDeviceSerialNr = new System.Windows.Forms.TextBox();
            this.lbDeviceSerialNr = new System.Windows.Forms.Label();
            this.tbDeviceType = new System.Windows.Forms.TextBox();
            this.lbDeviceType = new System.Windows.Forms.Label();
            this.btnSetDisplayColor = new System.Windows.Forms.Button();
            this.btnClearDisplay = new System.Windows.Forms.Button();
            this.btnEffect2 = new System.Windows.Forms.Button();
            this.btnEffect1 = new System.Windows.Forms.Button();
            this.btnStopEffect = new System.Windows.Forms.Button();
            this.btnStopSoundEffect = new System.Windows.Forms.Button();
            this.btnSoundEffect2 = new System.Windows.Forms.Button();
            this.btnSoundEffect1 = new System.Windows.Forms.Button();
            this.btnMusic = new System.Windows.Forms.Button();
            this.numLedIntensity = new System.Windows.Forms.NumericUpDown();
            this.lbLedIntensity = new System.Windows.Forms.Label();
            this.btnLedIntensity = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLedIntensity)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.AutoSize = false;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel6,
            this.statusReader});
            this.statusStrip.Location = new System.Drawing.Point(0, 303);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(484, 22);
            this.statusStrip.TabIndex = 23;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.AutoSize = false;
            this.toolStripStatusLabel6.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(52, 17);
            this.toolStripStatusLabel6.Text = "STATUS";
            // 
            // statusReader
            // 
            this.statusReader.AutoSize = false;
            this.statusReader.Name = "statusReader";
            this.statusReader.Size = new System.Drawing.Size(360, 17);
            this.statusReader.Text = "Ok";
            this.statusReader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            this.btnClose.Enabled = false;
            this.btnClose.Location = new System.Drawing.Point(329, 41);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(129, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close Reader";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(329, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(129, 23);
            this.btnOpen.TabIndex = 8;
            this.btnOpen.Text = "Open Reader";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnCardIdEx
            // 
            this.btnCardIdEx.Enabled = false;
            this.btnCardIdEx.Location = new System.Drawing.Point(329, 70);
            this.btnCardIdEx.Name = "btnCardIdEx";
            this.btnCardIdEx.Size = new System.Drawing.Size(129, 23);
            this.btnCardIdEx.TabIndex = 10;
            this.btnCardIdEx.Tag = "";
            this.btnCardIdEx.Text = "Get Card ID";
            this.btnCardIdEx.UseVisualStyleBackColor = true;
            this.btnCardIdEx.Click += new System.EventHandler(this.btnCardIdEx_Click);
            // 
            // tbCardType
            // 
            this.tbCardType.Location = new System.Drawing.Point(104, 64);
            this.tbCardType.Name = "tbCardType";
            this.tbCardType.Size = new System.Drawing.Size(196, 20);
            this.tbCardType.TabIndex = 5;
            this.tbCardType.Tag = "100000000";
            // 
            // lbCardType
            // 
            this.lbCardType.AutoSize = true;
            this.lbCardType.Location = new System.Drawing.Point(14, 67);
            this.lbCardType.MinimumSize = new System.Drawing.Size(84, 13);
            this.lbCardType.Name = "lbCardType";
            this.lbCardType.Size = new System.Drawing.Size(84, 13);
            this.lbCardType.TabIndex = 4;
            this.lbCardType.Tag = "100000000";
            this.lbCardType.Text = "Card Type";
            this.lbCardType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbCardId
            // 
            this.tbCardId.Location = new System.Drawing.Point(104, 90);
            this.tbCardId.Name = "tbCardId";
            this.tbCardId.Size = new System.Drawing.Size(196, 20);
            this.tbCardId.TabIndex = 7;
            this.tbCardId.Tag = "100000000";
            // 
            // lbCardId
            // 
            this.lbCardId.AutoSize = true;
            this.lbCardId.Location = new System.Drawing.Point(14, 93);
            this.lbCardId.MinimumSize = new System.Drawing.Size(84, 13);
            this.lbCardId.Name = "lbCardId";
            this.lbCardId.Size = new System.Drawing.Size(84, 13);
            this.lbCardId.TabIndex = 6;
            this.lbCardId.Tag = "100000000";
            this.lbCardId.Text = "Card ID";
            this.lbCardId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbDeviceSerialNr
            // 
            this.tbDeviceSerialNr.Location = new System.Drawing.Point(104, 38);
            this.tbDeviceSerialNr.Name = "tbDeviceSerialNr";
            this.tbDeviceSerialNr.Size = new System.Drawing.Size(196, 20);
            this.tbDeviceSerialNr.TabIndex = 3;
            // 
            // lbDeviceSerialNr
            // 
            this.lbDeviceSerialNr.AutoSize = true;
            this.lbDeviceSerialNr.Location = new System.Drawing.Point(14, 41);
            this.lbDeviceSerialNr.Name = "lbDeviceSerialNr";
            this.lbDeviceSerialNr.Size = new System.Drawing.Size(84, 13);
            this.lbDeviceSerialNr.TabIndex = 2;
            this.lbDeviceSerialNr.Text = "Device Serial Nr";
            this.lbDeviceSerialNr.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbDeviceType
            // 
            this.tbDeviceType.Location = new System.Drawing.Point(104, 12);
            this.tbDeviceType.Name = "tbDeviceType";
            this.tbDeviceType.Size = new System.Drawing.Size(196, 20);
            this.tbDeviceType.TabIndex = 1;
            // 
            // lbDeviceType
            // 
            this.lbDeviceType.AutoSize = true;
            this.lbDeviceType.Location = new System.Drawing.Point(14, 15);
            this.lbDeviceType.MinimumSize = new System.Drawing.Size(84, 13);
            this.lbDeviceType.Name = "lbDeviceType";
            this.lbDeviceType.Size = new System.Drawing.Size(84, 13);
            this.lbDeviceType.TabIndex = 0;
            this.lbDeviceType.Text = "Device Type";
            this.lbDeviceType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnSetDisplayColor
            // 
            this.btnSetDisplayColor.Enabled = false;
            this.btnSetDisplayColor.Location = new System.Drawing.Point(17, 144);
            this.btnSetDisplayColor.Name = "btnSetDisplayColor";
            this.btnSetDisplayColor.Size = new System.Drawing.Size(129, 23);
            this.btnSetDisplayColor.TabIndex = 11;
            this.btnSetDisplayColor.Tag = "";
            this.btnSetDisplayColor.Text = "Set Display Color";
            this.btnSetDisplayColor.UseVisualStyleBackColor = true;
            this.btnSetDisplayColor.Click += new System.EventHandler(this.btnSetDisplayColor_Click);
            // 
            // btnClearDisplay
            // 
            this.btnClearDisplay.Enabled = false;
            this.btnClearDisplay.Location = new System.Drawing.Point(17, 173);
            this.btnClearDisplay.Name = "btnClearDisplay";
            this.btnClearDisplay.Size = new System.Drawing.Size(129, 23);
            this.btnClearDisplay.TabIndex = 12;
            this.btnClearDisplay.Tag = "";
            this.btnClearDisplay.Text = "Clear Display";
            this.btnClearDisplay.UseVisualStyleBackColor = true;
            this.btnClearDisplay.Click += new System.EventHandler(this.btnClearDisplay_Click);
            // 
            // btnEffect2
            // 
            this.btnEffect2.Enabled = false;
            this.btnEffect2.Location = new System.Drawing.Point(173, 173);
            this.btnEffect2.Name = "btnEffect2";
            this.btnEffect2.Size = new System.Drawing.Size(129, 23);
            this.btnEffect2.TabIndex = 14;
            this.btnEffect2.Tag = "";
            this.btnEffect2.Text = "Display Effect 2";
            this.btnEffect2.UseVisualStyleBackColor = true;
            this.btnEffect2.Click += new System.EventHandler(this.btnEffect2_Click);
            // 
            // btnEffect1
            // 
            this.btnEffect1.Enabled = false;
            this.btnEffect1.Location = new System.Drawing.Point(173, 144);
            this.btnEffect1.Name = "btnEffect1";
            this.btnEffect1.Size = new System.Drawing.Size(129, 23);
            this.btnEffect1.TabIndex = 13;
            this.btnEffect1.Tag = "";
            this.btnEffect1.Text = "Display Effect 1";
            this.btnEffect1.UseVisualStyleBackColor = true;
            this.btnEffect1.Click += new System.EventHandler(this.btnEffect1_Click);
            // 
            // btnStopEffect
            // 
            this.btnStopEffect.Enabled = false;
            this.btnStopEffect.Location = new System.Drawing.Point(329, 144);
            this.btnStopEffect.Name = "btnStopEffect";
            this.btnStopEffect.Size = new System.Drawing.Size(129, 23);
            this.btnStopEffect.TabIndex = 15;
            this.btnStopEffect.Tag = "";
            this.btnStopEffect.Text = "Stop Display Effect";
            this.btnStopEffect.UseVisualStyleBackColor = true;
            this.btnStopEffect.Click += new System.EventHandler(this.btnStopEffect_Click);
            // 
            // btnStopSoundEffect
            // 
            this.btnStopSoundEffect.Enabled = false;
            this.btnStopSoundEffect.Location = new System.Drawing.Point(329, 253);
            this.btnStopSoundEffect.Name = "btnStopSoundEffect";
            this.btnStopSoundEffect.Size = new System.Drawing.Size(129, 23);
            this.btnStopSoundEffect.TabIndex = 22;
            this.btnStopSoundEffect.Tag = "";
            this.btnStopSoundEffect.Text = "Stop Sound Effect";
            this.btnStopSoundEffect.UseVisualStyleBackColor = true;
            this.btnStopSoundEffect.Click += new System.EventHandler(this.btnStopSoundEffect_Click);
            // 
            // btnSoundEffect2
            // 
            this.btnSoundEffect2.Enabled = false;
            this.btnSoundEffect2.Location = new System.Drawing.Point(173, 253);
            this.btnSoundEffect2.Name = "btnSoundEffect2";
            this.btnSoundEffect2.Size = new System.Drawing.Size(129, 23);
            this.btnSoundEffect2.TabIndex = 20;
            this.btnSoundEffect2.Tag = "";
            this.btnSoundEffect2.Text = "Sound Effect 2";
            this.btnSoundEffect2.UseVisualStyleBackColor = true;
            this.btnSoundEffect2.Click += new System.EventHandler(this.btnSoundEffect2_Click);
            // 
            // btnSoundEffect1
            // 
            this.btnSoundEffect1.Enabled = false;
            this.btnSoundEffect1.Location = new System.Drawing.Point(173, 224);
            this.btnSoundEffect1.Name = "btnSoundEffect1";
            this.btnSoundEffect1.Size = new System.Drawing.Size(129, 23);
            this.btnSoundEffect1.TabIndex = 19;
            this.btnSoundEffect1.Tag = "";
            this.btnSoundEffect1.Text = "Sound Effect 1";
            this.btnSoundEffect1.UseVisualStyleBackColor = true;
            this.btnSoundEffect1.Click += new System.EventHandler(this.btnSoundEffect1_Click);
            // 
            // btnMusic
            // 
            this.btnMusic.Enabled = false;
            this.btnMusic.Location = new System.Drawing.Point(329, 224);
            this.btnMusic.Name = "btnMusic";
            this.btnMusic.Size = new System.Drawing.Size(129, 23);
            this.btnMusic.TabIndex = 21;
            this.btnMusic.Tag = "";
            this.btnMusic.Text = "Play Music";
            this.btnMusic.UseVisualStyleBackColor = true;
            this.btnMusic.Click += new System.EventHandler(this.btnMusic_Click);
            // 
            // numLedIntensity
            // 
            this.numLedIntensity.Location = new System.Drawing.Point(93, 224);
            this.numLedIntensity.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numLedIntensity.Name = "numLedIntensity";
            this.numLedIntensity.ReadOnly = true;
            this.numLedIntensity.Size = new System.Drawing.Size(53, 20);
            this.numLedIntensity.TabIndex = 17;
            this.numLedIntensity.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lbLedIntensity
            // 
            this.lbLedIntensity.AutoSize = true;
            this.lbLedIntensity.Location = new System.Drawing.Point(3, 226);
            this.lbLedIntensity.MinimumSize = new System.Drawing.Size(84, 13);
            this.lbLedIntensity.Name = "lbLedIntensity";
            this.lbLedIntensity.Size = new System.Drawing.Size(84, 13);
            this.lbLedIntensity.TabIndex = 16;
            this.lbLedIntensity.Tag = "100000000";
            this.lbLedIntensity.Text = "LED Intensity:";
            this.lbLedIntensity.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnLedIntensity
            // 
            this.btnLedIntensity.Enabled = false;
            this.btnLedIntensity.Location = new System.Drawing.Point(17, 253);
            this.btnLedIntensity.Name = "btnLedIntensity";
            this.btnLedIntensity.Size = new System.Drawing.Size(129, 23);
            this.btnLedIntensity.TabIndex = 18;
            this.btnLedIntensity.Tag = "";
            this.btnLedIntensity.Text = "Set LED Intensity";
            this.btnLedIntensity.UseVisualStyleBackColor = true;
            this.btnLedIntensity.Click += new System.EventHandler(this.btnLedIntensity_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 325);
            this.Controls.Add(this.btnLedIntensity);
            this.Controls.Add(this.lbLedIntensity);
            this.Controls.Add(this.numLedIntensity);
            this.Controls.Add(this.btnMusic);
            this.Controls.Add(this.btnStopSoundEffect);
            this.Controls.Add(this.btnSoundEffect2);
            this.Controls.Add(this.btnSoundEffect1);
            this.Controls.Add(this.btnStopEffect);
            this.Controls.Add(this.btnEffect2);
            this.Controls.Add(this.btnEffect1);
            this.Controls.Add(this.btnClearDisplay);
            this.Controls.Add(this.btnSetDisplayColor);
            this.Controls.Add(this.tbCardType);
            this.Controls.Add(this.lbCardType);
            this.Controls.Add(this.tbCardId);
            this.Controls.Add(this.lbCardId);
            this.Controls.Add(this.tbDeviceSerialNr);
            this.Controls.Add(this.lbDeviceSerialNr);
            this.Controls.Add(this.tbDeviceType);
            this.Controls.Add(this.lbDeviceType);
            this.Controls.Add(this.btnCardIdEx);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.statusStrip);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "uFR RGB LED Display Demo v3.5 (for 24 LEDs)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLedIntensity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel statusReader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnCardIdEx;
        private System.Windows.Forms.TextBox tbCardType;
        private System.Windows.Forms.Label lbCardType;
        private System.Windows.Forms.TextBox tbCardId;
        private System.Windows.Forms.Label lbCardId;
        private System.Windows.Forms.TextBox tbDeviceSerialNr;
        private System.Windows.Forms.Label lbDeviceSerialNr;
        private System.Windows.Forms.TextBox tbDeviceType;
        private System.Windows.Forms.Label lbDeviceType;
        private System.Windows.Forms.Button btnSetDisplayColor;
        private System.Windows.Forms.Button btnClearDisplay;
        private System.Windows.Forms.Button btnEffect2;
        private System.Windows.Forms.Button btnEffect1;
        private System.Windows.Forms.Button btnStopEffect;
        private System.Windows.Forms.Button btnStopSoundEffect;
        private System.Windows.Forms.Button btnSoundEffect2;
        private System.Windows.Forms.Button btnSoundEffect1;
        private System.Windows.Forms.Button btnMusic;
        private System.Windows.Forms.NumericUpDown numLedIntensity;
        private System.Windows.Forms.Label lbLedIntensity;
        private System.Windows.Forms.Button btnLedIntensity;
    }
}

