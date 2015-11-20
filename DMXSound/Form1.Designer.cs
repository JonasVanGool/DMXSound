namespace DMXSound
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LeftChannelChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.RightChannelChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.FftChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SumFreq1Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SumFreq2Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SumFreq3Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.LeftChannelChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightChannelChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FftChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SumFreq1Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SumFreq2Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SumFreq3Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftChannelChart
            // 
            this.LeftChannelChart.AllowDrop = true;
            this.LeftChannelChart.BackColor = System.Drawing.Color.Transparent;
            this.LeftChannelChart.BorderlineColor = System.Drawing.Color.Transparent;
            this.LeftChannelChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.Maximum = 1023D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Maximum = 32769D;
            chartArea1.AxisY.Minimum = -32769D;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 94F;
            chartArea1.Position.Width = 78.48222F;
            chartArea1.Position.X = 3F;
            chartArea1.Position.Y = 3F;
            this.LeftChannelChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.LeftChannelChart.Legends.Add(legend1);
            this.LeftChannelChart.Location = new System.Drawing.Point(-11, 12);
            this.LeftChannelChart.Name = "LeftChannelChart";
            this.LeftChannelChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "Left Channel";
            this.LeftChannelChart.Series.Add(series1);
            this.LeftChannelChart.Size = new System.Drawing.Size(675, 209);
            this.LeftChannelChart.TabIndex = 0;
            this.LeftChannelChart.Text = "cv";
            // 
            // RightChannelChart
            // 
            this.RightChannelChart.AllowDrop = true;
            this.RightChannelChart.BackColor = System.Drawing.Color.Transparent;
            this.RightChannelChart.BorderlineColor = System.Drawing.Color.Transparent;
            this.RightChannelChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisX.Maximum = 1023D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisY.Maximum = 32769D;
            chartArea2.AxisY.Minimum = -32769D;
            chartArea2.Name = "ChartArea1";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 94F;
            chartArea2.Position.Width = 78.48222F;
            chartArea2.Position.X = 3F;
            chartArea2.Position.Y = 3F;
            this.RightChannelChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.RightChannelChart.Legends.Add(legend2);
            this.RightChannelChart.Location = new System.Drawing.Point(-11, 212);
            this.RightChannelChart.Name = "RightChannelChart";
            this.RightChannelChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.Name = "Right Channel";
            this.RightChannelChart.Series.Add(series2);
            this.RightChannelChart.Size = new System.Drawing.Size(675, 209);
            this.RightChannelChart.TabIndex = 1;
            this.RightChannelChart.Text = "cchart1.Series[\"Series1\"].Points.Remove(chart1.Series[\"Series1\"].Points.First());" +
    "";
            // 
            // FftChart
            // 
            this.FftChart.AllowDrop = true;
            this.FftChart.BackColor = System.Drawing.Color.Transparent;
            this.FftChart.BorderlineColor = System.Drawing.Color.Transparent;
            this.FftChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea3.AxisX.Maximum = 512D;
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisX.ScaleView.SizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.AxisY.IsLogarithmic = true;
            chartArea3.AxisY.Maximum = 1000D;
            chartArea3.AxisY.Minimum = 1D;
            chartArea3.AxisY.MinorGrid.Interval = double.NaN;
            chartArea3.AxisY.MinorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.AxisY.MinorTickMark.Enabled = true;
            chartArea3.Name = "ChartArea1";
            chartArea3.Position.Auto = false;
            chartArea3.Position.Height = 94F;
            chartArea3.Position.Width = 78.48222F;
            chartArea3.Position.X = 3F;
            chartArea3.Position.Y = 3F;
            this.FftChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.FftChart.Legends.Add(legend3);
            this.FftChart.Location = new System.Drawing.Point(12, 408);
            this.FftChart.Name = "FftChart";
            this.FftChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Legend = "Legend1";
            series3.Name = "FFT";
            this.FftChart.Series.Add(series3);
            this.FftChart.Size = new System.Drawing.Size(647, 209);
            this.FftChart.TabIndex = 2;
            this.FftChart.Text = "cchart1.Series[\"Series1\"].Points.Remove(chart1.Series[\"Series1\"].Points.First());" +
    "";
            // 
            // SumFreq1Chart
            // 
            this.SumFreq1Chart.AllowDrop = true;
            this.SumFreq1Chart.BackColor = System.Drawing.Color.Transparent;
            this.SumFreq1Chart.BorderlineColor = System.Drawing.Color.Transparent;
            this.SumFreq1Chart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea4.AxisX.Minimum = 0D;
            chartArea4.AxisY.Minimum = 0D;
            chartArea4.Name = "ChartArea1";
            chartArea4.Position.Auto = false;
            chartArea4.Position.Height = 94F;
            chartArea4.Position.Width = 78.48222F;
            chartArea4.Position.X = 3F;
            chartArea4.Position.Y = 3F;
            this.SumFreq1Chart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.SumFreq1Chart.Legends.Add(legend4);
            this.SumFreq1Chart.Location = new System.Drawing.Point(657, 12);
            this.SumFreq1Chart.Name = "SumFreq1Chart";
            this.SumFreq1Chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Legend = "Legend1";
            series4.Name = "Sum freq 1";
            this.SumFreq1Chart.Series.Add(series4);
            this.SumFreq1Chart.Size = new System.Drawing.Size(640, 209);
            this.SumFreq1Chart.TabIndex = 3;
            this.SumFreq1Chart.Text = "cchart1.Series[\"Series1\"].Points.Remove(chart1.Series[\"Series1\"].Points.First());" +
    "";
            // 
            // SumFreq2Chart
            // 
            this.SumFreq2Chart.AllowDrop = true;
            this.SumFreq2Chart.BackColor = System.Drawing.Color.Transparent;
            this.SumFreq2Chart.BorderlineColor = System.Drawing.Color.Transparent;
            this.SumFreq2Chart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea5.AxisX.Minimum = 0D;
            chartArea5.AxisY.Minimum = 0D;
            chartArea5.Name = "ChartArea1";
            chartArea5.Position.Auto = false;
            chartArea5.Position.Height = 94F;
            chartArea5.Position.Width = 78.48222F;
            chartArea5.Position.X = 3F;
            chartArea5.Position.Y = 3F;
            this.SumFreq2Chart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.SumFreq2Chart.Legends.Add(legend5);
            this.SumFreq2Chart.Location = new System.Drawing.Point(657, 212);
            this.SumFreq2Chart.Name = "SumFreq2Chart";
            this.SumFreq2Chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series5.Legend = "Legend1";
            series5.Name = "Sum freq 2";
            this.SumFreq2Chart.Series.Add(series5);
            this.SumFreq2Chart.Size = new System.Drawing.Size(640, 209);
            this.SumFreq2Chart.TabIndex = 4;
            this.SumFreq2Chart.Text = "cchart1.Series[\"Series1\"].Points.Remove(chart1.Series[\"Series1\"].Points.First());" +
    "";
            // 
            // SumFreq3Chart
            // 
            this.SumFreq3Chart.AllowDrop = true;
            this.SumFreq3Chart.BackColor = System.Drawing.Color.Transparent;
            this.SumFreq3Chart.BorderlineColor = System.Drawing.Color.Transparent;
            this.SumFreq3Chart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea6.AxisX.Minimum = 0D;
            chartArea6.AxisY.Minimum = 0D;
            chartArea6.Name = "ChartArea1";
            chartArea6.Position.Auto = false;
            chartArea6.Position.Height = 94F;
            chartArea6.Position.Width = 78.48222F;
            chartArea6.Position.X = 3F;
            chartArea6.Position.Y = 3F;
            this.SumFreq3Chart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.SumFreq3Chart.Legends.Add(legend6);
            this.SumFreq3Chart.Location = new System.Drawing.Point(657, 408);
            this.SumFreq3Chart.Name = "SumFreq3Chart";
            this.SumFreq3Chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series6.Legend = "Legend1";
            series6.Name = "Sum freq 3";
            this.SumFreq3Chart.Series.Add(series6);
            this.SumFreq3Chart.Size = new System.Drawing.Size(640, 209);
            this.SumFreq3Chart.TabIndex = 5;
            this.SumFreq3Chart.Text = "cchart1.Series[\"Series1\"].Points.Remove(chart1.Series[\"Series1\"].Points.First());" +
    "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 860);
            this.Controls.Add(this.SumFreq3Chart);
            this.Controls.Add(this.SumFreq2Chart);
            this.Controls.Add(this.SumFreq1Chart);
            this.Controls.Add(this.FftChart);
            this.Controls.Add(this.RightChannelChart);
            this.Controls.Add(this.LeftChannelChart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.LeftChannelChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightChannelChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FftChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SumFreq1Chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SumFreq2Chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SumFreq3Chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart LeftChannelChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart RightChannelChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart FftChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart SumFreq1Chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart SumFreq2Chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart SumFreq3Chart;

    }
}

