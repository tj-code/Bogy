namespace MuxSwt
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
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.btExit = new System.Windows.Forms.Button();
      this.btOpen = new System.Windows.Forms.Button();
      this.btClose = new System.Windows.Forms.Button();
      this.btDo = new System.Windows.Forms.Button();
      this.lbResp = new System.Windows.Forms.Label();
      this.lbStatus = new System.Windows.Forms.Label();
      this.btError = new System.Windows.Forms.Button();
      this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
      ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
      this.SuspendLayout();
      // 
      // btExit
      // 
      this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btExit.Location = new System.Drawing.Point(311, 293);
      this.btExit.Name = "btExit";
      this.btExit.Size = new System.Drawing.Size(59, 23);
      this.btExit.TabIndex = 0;
      this.btExit.Text = "Exit";
      this.btExit.UseVisualStyleBackColor = true;
      this.btExit.Click += new System.EventHandler(this.btExit_Click);
      // 
      // btOpen
      // 
      this.btOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btOpen.Location = new System.Drawing.Point(19, 293);
      this.btOpen.Name = "btOpen";
      this.btOpen.Size = new System.Drawing.Size(59, 23);
      this.btOpen.TabIndex = 1;
      this.btOpen.Text = "Open";
      this.btOpen.UseVisualStyleBackColor = true;
      this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
      // 
      // btClose
      // 
      this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btClose.Location = new System.Drawing.Point(84, 293);
      this.btClose.Name = "btClose";
      this.btClose.Size = new System.Drawing.Size(59, 23);
      this.btClose.TabIndex = 2;
      this.btClose.Text = "Close";
      this.btClose.UseVisualStyleBackColor = true;
      this.btClose.Click += new System.EventHandler(this.btClose_Click);
      // 
      // btDo
      // 
      this.btDo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btDo.Location = new System.Drawing.Point(246, 293);
      this.btDo.Name = "btDo";
      this.btDo.Size = new System.Drawing.Size(59, 23);
      this.btDo.TabIndex = 3;
      this.btDo.Text = "Do";
      this.btDo.UseVisualStyleBackColor = true;
      this.btDo.Click += new System.EventHandler(this.btDo_Click);
      // 
      // lbResp
      // 
      this.lbResp.AutoSize = true;
      this.lbResp.Location = new System.Drawing.Point(16, 13);
      this.lbResp.Name = "lbResp";
      this.lbResp.Size = new System.Drawing.Size(111, 13);
      this.lbResp.TabIndex = 4;
      this.lbResp.Text = "Responses go here ...";
      // 
      // lbStatus
      // 
      this.lbStatus.AutoSize = true;
      this.lbStatus.Location = new System.Drawing.Point(16, 35);
      this.lbStatus.Name = "lbStatus";
      this.lbStatus.Size = new System.Drawing.Size(116, 13);
      this.lbStatus.TabIndex = 5;
      this.lbStatus.Text = "Status info goes here ..";
      // 
      // btError
      // 
      this.btError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btError.Location = new System.Drawing.Point(182, 293);
      this.btError.Name = "btError";
      this.btError.Size = new System.Drawing.Size(58, 23);
      this.btError.TabIndex = 6;
      this.btError.Text = "Error";
      this.btError.UseVisualStyleBackColor = true;
      this.btError.Click += new System.EventHandler(this.btError_Click);
      // 
      // chart
      // 
      this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      chartArea1.Name = "ChartArea1";
      this.chart.ChartAreas.Add(chartArea1);
      legend1.Name = "Legend1";
      this.chart.Legends.Add(legend1);
      this.chart.Location = new System.Drawing.Point(12, 51);
      this.chart.Name = "chart";
      series1.ChartArea = "ChartArea1";
      series1.Legend = "Legend1";
      series1.Name = "Series1";
      this.chart.Series.Add(series1);
      this.chart.Size = new System.Drawing.Size(358, 236);
      this.chart.TabIndex = 7;
      this.chart.Text = "chart";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(382, 328);
      this.Controls.Add(this.chart);
      this.Controls.Add(this.btError);
      this.Controls.Add(this.lbStatus);
      this.Controls.Add(this.lbResp);
      this.Controls.Add(this.btDo);
      this.Controls.Add(this.btClose);
      this.Controls.Add(this.btOpen);
      this.Controls.Add(this.btExit);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btExit;
    private System.Windows.Forms.Button btOpen;
    private System.Windows.Forms.Button btClose;
    private System.Windows.Forms.Button btDo;
    private System.Windows.Forms.Label lbResp;
    private System.Windows.Forms.Label lbStatus;
    private System.Windows.Forms.Button btError;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart;
  }
}

