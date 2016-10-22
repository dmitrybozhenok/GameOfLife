namespace DD.Life.WinForms
{
    partial class LifeLauncher
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
            System.Windows.Forms.Label lblXOffset;
            System.Windows.Forms.Label lblYOffset;
            System.Windows.Forms.Label lblTimeout;
            System.Windows.Forms.Label lblXSize;
            System.Windows.Forms.Label lblYSize;
            this.txtBody = new System.Windows.Forms.TextBox();
            this.cmbPatterns = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.tmrReevaluation = new System.Windows.Forms.Timer(this.components);
            this.txtXOffset = new System.Windows.Forms.NumericUpDown();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtTimeout = new System.Windows.Forms.NumericUpDown();
            this.txtHeight = new System.Windows.Forms.NumericUpDown();
            this.txtYOffset = new System.Windows.Forms.NumericUpDown();
            this.txtWidth = new System.Windows.Forms.NumericUpDown();
            lblXOffset = new System.Windows.Forms.Label();
            lblYOffset = new System.Windows.Forms.Label();
            lblTimeout = new System.Windows.Forms.Label();
            lblXSize = new System.Windows.Forms.Label();
            lblYSize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtXOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // lblXOffset
            // 
            lblXOffset.AutoSize = true;
            lblXOffset.Location = new System.Drawing.Point(61, 60);
            lblXOffset.Name = "lblXOffset";
            lblXOffset.Size = new System.Drawing.Size(43, 13);
            lblXOffset.TabIndex = 4;
            lblXOffset.Text = "X offset";
            // 
            // lblYOffset
            // 
            lblYOffset.AutoSize = true;
            lblYOffset.Location = new System.Drawing.Point(61, 86);
            lblYOffset.Name = "lblYOffset";
            lblYOffset.Size = new System.Drawing.Size(43, 13);
            lblYOffset.TabIndex = 4;
            lblYOffset.Text = "Y offset";
            // 
            // lblTimeout
            // 
            lblTimeout.AutoSize = true;
            lblTimeout.Location = new System.Drawing.Point(61, 112);
            lblTimeout.Name = "lblTimeout";
            lblTimeout.Size = new System.Drawing.Size(45, 13);
            lblTimeout.TabIndex = 4;
            lblTimeout.Text = "Timeout";
            // 
            // lblXSize
            // 
            lblXSize.AutoSize = true;
            lblXSize.Location = new System.Drawing.Point(61, 8);
            lblXSize.Name = "lblXSize";
            lblXSize.Size = new System.Drawing.Size(35, 13);
            lblXSize.TabIndex = 4;
            lblXSize.Text = "Width";
            // 
            // lblYSize
            // 
            lblYSize.AutoSize = true;
            lblYSize.Location = new System.Drawing.Point(61, 34);
            lblYSize.Name = "lblYSize";
            lblYSize.Size = new System.Drawing.Size(38, 13);
            lblYSize.TabIndex = 4;
            lblYSize.Text = "Height";
            // 
            // txtBody
            // 
            this.txtBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBody.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBody.Location = new System.Drawing.Point(0, 0);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(420, 258);
            this.txtBody.TabIndex = 0;
            this.txtBody.Text = "Example for design time\r\n*   *\r\n * *\r\n  *";
            // 
            // cmbPatterns
            // 
            this.cmbPatterns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPatterns.FormattingEnabled = true;
            this.cmbPatterns.Location = new System.Drawing.Point(12, 12);
            this.cmbPatterns.Name = "cmbPatterns";
            this.cmbPatterns.Size = new System.Drawing.Size(413, 21);
            this.cmbPatterns.TabIndex = 1;
            this.cmbPatterns.SelectedIndexChanged += new System.EventHandler(this.OnPatternSelectionChanged);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(486, 11);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(23, 21);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "►";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.OnStartClick);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(515, 11);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(20, 21);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "■";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.OnStopClick);
            // 
            // tmrReevaluation
            // 
            this.tmrReevaluation.Interval = 250;
            this.tmrReevaluation.Tick += new System.EventHandler(this.OnReevaluationTick);
            // 
            // txtXOffset
            // 
            this.txtXOffset.Location = new System.Drawing.Point(3, 58);
            this.txtXOffset.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.txtXOffset.Name = "txtXOffset";
            this.txtXOffset.Size = new System.Drawing.Size(52, 20);
            this.txtXOffset.TabIndex = 3;
            this.txtXOffset.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(12, 39);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtBody);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(lblTimeout);
            this.splitContainer1.Panel2.Controls.Add(lblYSize);
            this.splitContainer1.Panel2.Controls.Add(lblYOffset);
            this.splitContainer1.Panel2.Controls.Add(lblXSize);
            this.splitContainer1.Panel2.Controls.Add(lblXOffset);
            this.splitContainer1.Panel2.Controls.Add(this.txtTimeout);
            this.splitContainer1.Panel2.Controls.Add(this.txtHeight);
            this.splitContainer1.Panel2.Controls.Add(this.txtYOffset);
            this.splitContainer1.Panel2.Controls.Add(this.txtWidth);
            this.splitContainer1.Panel2.Controls.Add(this.txtXOffset);
            this.splitContainer1.Size = new System.Drawing.Size(529, 258);
            this.splitContainer1.SplitterDistance = 420;
            this.splitContainer1.TabIndex = 4;
            // 
            // txtTimeout
            // 
            this.txtTimeout.Location = new System.Drawing.Point(3, 110);
            this.txtTimeout.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtTimeout.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtTimeout.Name = "txtTimeout";
            this.txtTimeout.Size = new System.Drawing.Size(52, 20);
            this.txtTimeout.TabIndex = 3;
            this.txtTimeout.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.txtTimeout.ValueChanged += new System.EventHandler(this.OnTimeoutChanged);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(3, 32);
            this.txtHeight.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(52, 20);
            this.txtHeight.TabIndex = 3;
            this.txtHeight.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // txtYOffset
            // 
            this.txtYOffset.Location = new System.Drawing.Point(3, 84);
            this.txtYOffset.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.txtYOffset.Name = "txtYOffset";
            this.txtYOffset.Size = new System.Drawing.Size(52, 20);
            this.txtYOffset.TabIndex = 3;
            this.txtYOffset.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(3, 6);
            this.txtWidth.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(52, 20);
            this.txtWidth.TabIndex = 3;
            this.txtWidth.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // LifeLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 309);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cmbPatterns);
            this.Name = "LifeLauncher";
            this.Text = "The Life";
            ((System.ComponentModel.ISupportInitialize)(this.txtXOffset)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.ComboBox cmbPatterns;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer tmrReevaluation;
        private System.Windows.Forms.NumericUpDown txtXOffset;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.NumericUpDown txtYOffset;
        private System.Windows.Forms.NumericUpDown txtTimeout;
        private System.Windows.Forms.NumericUpDown txtHeight;
        private System.Windows.Forms.NumericUpDown txtWidth;
    }
}

