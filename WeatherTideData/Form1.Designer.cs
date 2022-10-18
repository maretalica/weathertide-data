namespace WeatherTideStormglass
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TideChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.WeatherChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TideChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(566, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stormglass API";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(22, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Location, Location";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TideChart
            // 
            chartArea1.Name = "ChartArea1";
            this.TideChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.TideChart.Legends.Add(legend1);
            this.TideChart.Location = new System.Drawing.Point(23, 226);
            this.TideChart.Name = "TideChart";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.SystemColors.Highlight;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Height";
            series1.YValuesPerPoint = 4;
            this.TideChart.Series.Add(series1);
            this.TideChart.Size = new System.Drawing.Size(900, 300);
            this.TideChart.TabIndex = 2;
            this.TideChart.Text = "TideChart";
            this.TideChart.Click += new System.EventHandler(this.TideChart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(22, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Location, Location";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat Medium", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(23, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Location, Location";
            // 
            // WeatherChart
            // 
            chartArea2.Name = "ChartArea1";
            this.WeatherChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.WeatherChart.Legends.Add(legend2);
            this.WeatherChart.Location = new System.Drawing.Point(23, 621);
            this.WeatherChart.Name = "WeatherChart";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.SystemColors.Highlight;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "Temp";
            series2.YValuesPerPoint = 4;
            this.WeatherChart.Series.Add(series2);
            this.WeatherChart.Size = new System.Drawing.Size(900, 300);
            this.WeatherChart.TabIndex = 5;
            this.WeatherChart.Text = "chart1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat Medium", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label5.Location = new System.Drawing.Point(23, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Location, Location";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat Medium", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label6.Location = new System.Drawing.Point(872, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tide";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat Medium", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label7.Location = new System.Drawing.Point(832, 594);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Weather";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 933);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.WeatherChart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TideChart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TideChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart TideChart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart WeatherChart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

