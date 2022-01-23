namespace UI
{
    partial class SyncVsAsyncForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.butRun = new System.Windows.Forms.Button();
            this.groupSyncVsAsync = new System.Windows.Forms.GroupBox();
            this.radioAsync = new System.Windows.Forms.RadioButton();
            this.radioSync = new System.Windows.Forms.RadioButton();
            this.numericCountThreads = new System.Windows.Forms.NumericUpDown();
            this.labelTheadPoolSize = new System.Windows.Forms.Label();
            this.labelWebClientInterval = new System.Windows.Forms.Label();
            this.numericClientIntervalMs = new System.Windows.Forms.NumericUpDown();
            this.groupWebServer = new System.Windows.Forms.GroupBox();
            this.labelSynchTimeMs = new System.Windows.Forms.Label();
            this.numericSynchMs = new System.Windows.Forms.NumericUpDown();
            this.labelResponseMs = new System.Windows.Forms.Label();
            this.numericIoMs = new System.Windows.Forms.NumericUpDown();
            this.groupWebClient = new System.Windows.Forms.GroupBox();
            this.numericRequestCount = new System.Windows.Forms.NumericUpDown();
            this.numericResponseCount = new System.Windows.Forms.NumericUpDown();
            this.numericResponseMeanMs = new System.Windows.Forms.NumericUpDown();
            this.labelMeanResponseTime = new System.Windows.Forms.Label();
            this.labelResponses = new System.Windows.Forms.Label();
            this.labelRequests = new System.Windows.Forms.Label();
            this.groupMetrics = new System.Windows.Forms.GroupBox();
            this.groupThreadPool = new System.Windows.Forms.GroupBox();
            this.groupQueuedRequests = new System.Windows.Forms.GroupBox();
            this.groupActiveRequests = new System.Windows.Forms.GroupBox();
            this.labelExpected = new System.Windows.Forms.Label();
            this.numericExpectedMs = new System.Windows.Forms.NumericUpDown();
            this.groupSyncVsAsync.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCountThreads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericClientIntervalMs)).BeginInit();
            this.groupWebServer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSynchMs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericIoMs)).BeginInit();
            this.groupWebClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRequestCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericResponseCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericResponseMeanMs)).BeginInit();
            this.groupMetrics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericExpectedMs)).BeginInit();
            this.SuspendLayout();
            // 
            // butRun
            // 
            this.butRun.Location = new System.Drawing.Point(6, 12);
            this.butRun.Name = "butRun";
            this.butRun.Size = new System.Drawing.Size(75, 23);
            this.butRun.TabIndex = 0;
            this.butRun.Text = "Run";
            this.butRun.UseVisualStyleBackColor = true;
            this.butRun.Click += new System.EventHandler(this.butRun_Click);
            // 
            // groupSyncVsAsync
            // 
            this.groupSyncVsAsync.Controls.Add(this.radioAsync);
            this.groupSyncVsAsync.Controls.Add(this.radioSync);
            this.groupSyncVsAsync.Location = new System.Drawing.Point(6, 15);
            this.groupSyncVsAsync.Name = "groupSyncVsAsync";
            this.groupSyncVsAsync.Size = new System.Drawing.Size(203, 39);
            this.groupSyncVsAsync.TabIndex = 2;
            this.groupSyncVsAsync.TabStop = false;
            this.groupSyncVsAsync.Text = "IO Behavior";
            // 
            // radioAsync
            // 
            this.radioAsync.AutoSize = true;
            this.radioAsync.Location = new System.Drawing.Point(108, 16);
            this.radioAsync.Name = "radioAsync";
            this.radioAsync.Size = new System.Drawing.Size(57, 19);
            this.radioAsync.TabIndex = 1;
            this.radioAsync.Text = "Async";
            this.radioAsync.UseVisualStyleBackColor = true;
            // 
            // radioSync
            // 
            this.radioSync.AutoSize = true;
            this.radioSync.Checked = true;
            this.radioSync.Location = new System.Drawing.Point(8, 16);
            this.radioSync.Name = "radioSync";
            this.radioSync.Size = new System.Drawing.Size(50, 19);
            this.radioSync.TabIndex = 0;
            this.radioSync.TabStop = true;
            this.radioSync.Text = "Sync";
            this.radioSync.UseVisualStyleBackColor = true;
            this.radioSync.CheckedChanged += new System.EventHandler(this.radioSync_CheckedChanged);
            // 
            // numericCountThreads
            // 
            this.numericCountThreads.Location = new System.Drawing.Point(6, 54);
            this.numericCountThreads.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericCountThreads.Name = "numericCountThreads";
            this.numericCountThreads.Size = new System.Drawing.Size(120, 23);
            this.numericCountThreads.TabIndex = 3;
            this.numericCountThreads.ThousandsSeparator = true;
            this.numericCountThreads.ValueChanged += new System.EventHandler(this.numericCountThreads_ValueChanged);
            // 
            // labelTheadPoolSize
            // 
            this.labelTheadPoolSize.AutoSize = true;
            this.labelTheadPoolSize.Location = new System.Drawing.Point(132, 57);
            this.labelTheadPoolSize.Name = "labelTheadPoolSize";
            this.labelTheadPoolSize.Size = new System.Drawing.Size(106, 15);
            this.labelTheadPoolSize.TabIndex = 4;
            this.labelTheadPoolSize.Text = "Thread Pool Count";
            // 
            // labelWebClientInterval
            // 
            this.labelWebClientInterval.AutoSize = true;
            this.labelWebClientInterval.Location = new System.Drawing.Point(134, 19);
            this.labelWebClientInterval.Name = "labelWebClientInterval";
            this.labelWebClientInterval.Size = new System.Drawing.Size(152, 15);
            this.labelWebClientInterval.TabIndex = 6;
            this.labelWebClientInterval.Text = "Send Interval (Milliseconds)";
            // 
            // numericClientIntervalMs
            // 
            this.numericClientIntervalMs.Location = new System.Drawing.Point(8, 16);
            this.numericClientIntervalMs.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericClientIntervalMs.Name = "numericClientIntervalMs";
            this.numericClientIntervalMs.Size = new System.Drawing.Size(120, 23);
            this.numericClientIntervalMs.TabIndex = 5;
            this.numericClientIntervalMs.ThousandsSeparator = true;
            this.numericClientIntervalMs.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // groupWebServer
            // 
            this.groupWebServer.Controls.Add(this.numericExpectedMs);
            this.groupWebServer.Controls.Add(this.labelExpected);
            this.groupWebServer.Controls.Add(this.labelSynchTimeMs);
            this.groupWebServer.Controls.Add(this.numericSynchMs);
            this.groupWebServer.Controls.Add(this.labelResponseMs);
            this.groupWebServer.Controls.Add(this.numericIoMs);
            this.groupWebServer.Controls.Add(this.groupSyncVsAsync);
            this.groupWebServer.Controls.Add(this.labelTheadPoolSize);
            this.groupWebServer.Controls.Add(this.numericCountThreads);
            this.groupWebServer.Location = new System.Drawing.Point(87, 3);
            this.groupWebServer.Name = "groupWebServer";
            this.groupWebServer.Size = new System.Drawing.Size(486, 146);
            this.groupWebServer.TabIndex = 3;
            this.groupWebServer.TabStop = false;
            this.groupWebServer.Text = "WebServer";
            // 
            // labelSynchTimeMs
            // 
            this.labelSynchTimeMs.AutoSize = true;
            this.labelSynchTimeMs.Location = new System.Drawing.Point(132, 85);
            this.labelSynchTimeMs.Name = "labelSynchTimeMs";
            this.labelSynchTimeMs.Size = new System.Drawing.Size(189, 15);
            this.labelSynchTimeMs.TabIndex = 8;
            this.labelSynchTimeMs.Text = "MillisecondsPerRequest (synch x2)";
            // 
            // numericSynchMs
            // 
            this.numericSynchMs.Location = new System.Drawing.Point(6, 82);
            this.numericSynchMs.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericSynchMs.Name = "numericSynchMs";
            this.numericSynchMs.Size = new System.Drawing.Size(120, 23);
            this.numericSynchMs.TabIndex = 7;
            this.numericSynchMs.ThousandsSeparator = true;
            this.numericSynchMs.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericSynchMs.ValueChanged += new System.EventHandler(this.numericSynchMs_ValueChanged);
            // 
            // labelResponseMs
            // 
            this.labelResponseMs.AutoSize = true;
            this.labelResponseMs.Location = new System.Drawing.Point(132, 117);
            this.labelResponseMs.Name = "labelResponseMs";
            this.labelResponseMs.Size = new System.Drawing.Size(216, 15);
            this.labelResponseMs.TabIndex = 6;
            this.labelResponseMs.Text = "MillisecondsPerRequest (IO Operations)";
            // 
            // numericIoMs
            // 
            this.numericIoMs.Location = new System.Drawing.Point(6, 114);
            this.numericIoMs.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericIoMs.Name = "numericIoMs";
            this.numericIoMs.Size = new System.Drawing.Size(120, 23);
            this.numericIoMs.TabIndex = 5;
            this.numericIoMs.ThousandsSeparator = true;
            this.numericIoMs.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericIoMs.ValueChanged += new System.EventHandler(this.numericResponseMs_ValueChanged);
            // 
            // groupWebClient
            // 
            this.groupWebClient.Controls.Add(this.labelWebClientInterval);
            this.groupWebClient.Controls.Add(this.numericClientIntervalMs);
            this.groupWebClient.Location = new System.Drawing.Point(579, 3);
            this.groupWebClient.Name = "groupWebClient";
            this.groupWebClient.Size = new System.Drawing.Size(499, 146);
            this.groupWebClient.TabIndex = 7;
            this.groupWebClient.TabStop = false;
            this.groupWebClient.Text = "WebClient";
            // 
            // numericRequestCount
            // 
            this.numericRequestCount.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericRequestCount.Location = new System.Drawing.Point(373, 22);
            this.numericRequestCount.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericRequestCount.Name = "numericRequestCount";
            this.numericRequestCount.ReadOnly = true;
            this.numericRequestCount.Size = new System.Drawing.Size(120, 23);
            this.numericRequestCount.TabIndex = 8;
            this.numericRequestCount.ThousandsSeparator = true;
            // 
            // numericResponseCount
            // 
            this.numericResponseCount.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericResponseCount.Location = new System.Drawing.Point(373, 49);
            this.numericResponseCount.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericResponseCount.Name = "numericResponseCount";
            this.numericResponseCount.ReadOnly = true;
            this.numericResponseCount.Size = new System.Drawing.Size(120, 23);
            this.numericResponseCount.TabIndex = 7;
            this.numericResponseCount.ThousandsSeparator = true;
            // 
            // numericResponseMeanMs
            // 
            this.numericResponseMeanMs.DecimalPlaces = 4;
            this.numericResponseMeanMs.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericResponseMeanMs.Location = new System.Drawing.Point(373, 76);
            this.numericResponseMeanMs.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericResponseMeanMs.Name = "numericResponseMeanMs";
            this.numericResponseMeanMs.ReadOnly = true;
            this.numericResponseMeanMs.Size = new System.Drawing.Size(120, 23);
            this.numericResponseMeanMs.TabIndex = 6;
            this.numericResponseMeanMs.ThousandsSeparator = true;
            // 
            // labelMeanResponseTime
            // 
            this.labelMeanResponseTime.Location = new System.Drawing.Point(193, 80);
            this.labelMeanResponseTime.Name = "labelMeanResponseTime";
            this.labelMeanResponseTime.Size = new System.Drawing.Size(172, 15);
            this.labelMeanResponseTime.TabIndex = 2;
            this.labelMeanResponseTime.Text = "Mean Response Time (Ms)";
            this.labelMeanResponseTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelResponses
            // 
            this.labelResponses.Location = new System.Drawing.Point(259, 53);
            this.labelResponses.Name = "labelResponses";
            this.labelResponses.Size = new System.Drawing.Size(106, 15);
            this.labelResponses.TabIndex = 1;
            this.labelResponses.Text = "Count Responses";
            this.labelResponses.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelRequests
            // 
            this.labelRequests.Location = new System.Drawing.Point(265, 22);
            this.labelRequests.Name = "labelRequests";
            this.labelRequests.Size = new System.Drawing.Size(100, 23);
            this.labelRequests.TabIndex = 0;
            this.labelRequests.Text = "Count Requests";
            this.labelRequests.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupMetrics
            // 
            this.groupMetrics.Controls.Add(this.numericRequestCount);
            this.groupMetrics.Controls.Add(this.labelRequests);
            this.groupMetrics.Controls.Add(this.numericResponseCount);
            this.groupMetrics.Controls.Add(this.labelResponses);
            this.groupMetrics.Controls.Add(this.numericResponseMeanMs);
            this.groupMetrics.Controls.Add(this.labelMeanResponseTime);
            this.groupMetrics.Location = new System.Drawing.Point(575, 157);
            this.groupMetrics.Name = "groupMetrics";
            this.groupMetrics.Size = new System.Drawing.Size(499, 110);
            this.groupMetrics.TabIndex = 8;
            this.groupMetrics.TabStop = false;
            this.groupMetrics.Text = "Metrics";
            // 
            // groupThreadPool
            // 
            this.groupThreadPool.Location = new System.Drawing.Point(4, 155);
            this.groupThreadPool.Name = "groupThreadPool";
            this.groupThreadPool.Size = new System.Drawing.Size(565, 112);
            this.groupThreadPool.TabIndex = 10;
            this.groupThreadPool.TabStop = false;
            this.groupThreadPool.Text = "Thread Pool";
            this.groupThreadPool.Paint += new System.Windows.Forms.PaintEventHandler(this.groupThreadPool_Paint);
            // 
            // groupQueuedRequests
            // 
            this.groupQueuedRequests.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupQueuedRequests.Location = new System.Drawing.Point(6, 269);
            this.groupQueuedRequests.Name = "groupQueuedRequests";
            this.groupQueuedRequests.Size = new System.Drawing.Size(565, 408);
            this.groupQueuedRequests.TabIndex = 11;
            this.groupQueuedRequests.TabStop = false;
            this.groupQueuedRequests.Text = "Queued Requests";
            this.groupQueuedRequests.Paint += new System.Windows.Forms.PaintEventHandler(this.groupQueuedRequests_Paint);
            // 
            // groupActiveRequests
            // 
            this.groupActiveRequests.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupActiveRequests.Location = new System.Drawing.Point(577, 269);
            this.groupActiveRequests.Name = "groupActiveRequests";
            this.groupActiveRequests.Size = new System.Drawing.Size(501, 408);
            this.groupActiveRequests.TabIndex = 12;
            this.groupActiveRequests.TabStop = false;
            this.groupActiveRequests.Text = "Active Requests";
            this.groupActiveRequests.Paint += new System.Windows.Forms.PaintEventHandler(this.groupActiveRequests_Paint);
            // 
            // labelExpected
            // 
            this.labelExpected.AutoSize = true;
            this.labelExpected.Location = new System.Drawing.Point(353, 19);
            this.labelExpected.Name = "labelExpected";
            this.labelExpected.Size = new System.Drawing.Size(127, 15);
            this.labelExpected.TabIndex = 9;
            this.labelExpected.Text = "Expected Response Ms";
            // 
            // numericExpectedMs
            // 
            this.numericExpectedMs.DecimalPlaces = 4;
            this.numericExpectedMs.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericExpectedMs.Location = new System.Drawing.Point(228, 16);
            this.numericExpectedMs.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericExpectedMs.Name = "numericExpectedMs";
            this.numericExpectedMs.ReadOnly = true;
            this.numericExpectedMs.Size = new System.Drawing.Size(120, 23);
            this.numericExpectedMs.TabIndex = 9;
            this.numericExpectedMs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericExpectedMs.ThousandsSeparator = true;
            this.numericExpectedMs.Value = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            // 
            // SyncVsAsyncForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 689);
            this.Controls.Add(this.groupActiveRequests);
            this.Controls.Add(this.groupQueuedRequests);
            this.Controls.Add(this.groupThreadPool);
            this.Controls.Add(this.groupMetrics);
            this.Controls.Add(this.groupWebClient);
            this.Controls.Add(this.groupWebServer);
            this.Controls.Add(this.butRun);
            this.Name = "SyncVsAsyncForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SyncVsAsyncForm_Load);
            this.groupSyncVsAsync.ResumeLayout(false);
            this.groupSyncVsAsync.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCountThreads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericClientIntervalMs)).EndInit();
            this.groupWebServer.ResumeLayout(false);
            this.groupWebServer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSynchMs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericIoMs)).EndInit();
            this.groupWebClient.ResumeLayout(false);
            this.groupWebClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRequestCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericResponseCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericResponseMeanMs)).EndInit();
            this.groupMetrics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericExpectedMs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button butRun;
        private GroupBox groupSyncVsAsync;
        private RadioButton radioAsync;
        private RadioButton radioSync;
        private NumericUpDown numericCountThreads;
        private Label labelTheadPoolSize;
        private Label labelWebClientInterval;
        private NumericUpDown numericClientIntervalMs;
        private GroupBox groupWebServer;
        private GroupBox groupWebClient;
        private Label labelMeanResponseTime;
        private Label labelResponses;
        private Label labelRequests;
        private Label labelResponseMs;
        private NumericUpDown numericIoMs;
        private NumericUpDown numericRequestCount;
        private NumericUpDown numericResponseCount;
        private NumericUpDown numericResponseMeanMs;
        private GroupBox groupMetrics;
        private GroupBox groupThreadPool;
        private GroupBox groupQueuedRequests;
        private GroupBox groupActiveRequests;
        private Label labelSynchTimeMs;
        private NumericUpDown numericSynchMs;
        private Label labelExpected;
        private NumericUpDown numericExpectedMs;
    }
}