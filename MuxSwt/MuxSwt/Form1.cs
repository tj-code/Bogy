using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MuxSwt
{
    public partial class Form1 : Form
    {
        private Comm comm = null;
        private Comm vlt = null;

        private const string m_StatusConnected = "Connnected";
        private const string m_StatusDisConnected = "Disconnected";

        public Form1()
        {
            InitializeComponent();

            comm = new Comm();
            vlt = new Comm();
            this.lbResp.Text = "";
            this.lbStatus.Text = "";
        }



        private void btExit_Click(object sender, EventArgs e)
        {
            btClose_Click(sender, e);
            Application.Exit();
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            if (!comm.viConnected)
            {
                // comm.viOpen("TCPIP0::134.40.63.163::inst0::INSTR");      
                comm.viOpen("GPIB0::5::INSTR");

                string resp;
                comm.viQueryf("*idn?", out resp);
                this.lbResp.Text = resp;
                this.lbStatus.Text = m_StatusConnected;
            }

            if (!vlt.viConnected)
            {
                // comm.viOpen("TCPIP0::134.40.63.163::inst0::INSTR");      
                vlt.viOpen("GPIB0::22::INSTR");

                string resp;
                vlt.viQueryf("*idn?", out resp);
                this.lbResp.Text = resp;

                this.lbStatus.Text = m_StatusConnected;
            }

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            if (comm.viConnected)
            {
                this.lbStatus.Text = m_StatusDisConnected;
                this.lbResp.Text = "";
                comm.viClose();
            }
        }


        private void btDo_Click(object sender, EventArgs e)
        {
            float maxVoltage = 0.8F;
            float step = 0.1F;

            float maxCurrent = 0.05F / maxVoltage;

            float intervalY = 0;

                       var series = new System.Windows.Forms.DataVisualization.Charting.Series("Data 1");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            /*for (int i = 0; i <= 360; i++)
            {
                var rad = Math.PI * i / 180.0;
                series.Points.AddXY(i, Math.Sin(rad));
            }*/
            if (comm.viConnected && vlt.viConnected)
            {
                comm.viPrintf("OUTPut:STATe ON");
                comm.viPrintf("SOURce:CURRent " + maxCurrent);
                for (float i = 0; i <= maxVoltage; i += step)
                {
                    string resp;


                    
                    comm.viPrintf("SOURce:VOLTage " + i);
                    comm.viQueryf("*OPC?", out resp);
                    vlt.viQueryf("MEASure:VOLTage:DC?", out resp);
                    this.lbResp.Text = resp;

                    series.Points.AddXY(i, float.Parse(resp));
                    intervalY = Math.Max(float.Parse(resp), intervalY);
                }
            }
            chart.ChartAreas[0].AxisX.MajorGrid.Interval = 0.2;
            chart.ChartAreas[0].AxisY.Interval = Math.Round(intervalY, 2);
            chart.ChartAreas[0].AxisY.MinorGrid.Enabled = true;
            chart.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
            chart.ChartAreas[0].AxisY.MajorGrid.Interval = Math.Round(intervalY, 2)/2;
            chart.ChartAreas[0].AxisY.MinorGrid.Interval = Math.Round(intervalY, 2)/4;
            chart.ChartAreas[0].AxisX.Minimum = 0;
            chart.ChartAreas[0].AxisY.Minimum = 0;
            chart.ChartAreas[0].AxisY.Maximum = Math.Round(intervalY, 2);
            chart.ChartAreas[0].AxisX.Maximum = maxVoltage;
            chart.ChartAreas[0].AxisX.Interval = Math.Round(step, 1);
            chart.ChartAreas[0].AxisX.MinorGrid.Enabled = true;
            chart.ChartAreas[0].AxisX.MinorGrid.Interval = 15;
            chart.ChartAreas[0].AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chart.ChartAreas[0].AxisX.MajorGrid.Interval = 45;
            chart.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chart.Series.Add(series);
        }

        private void btError_Click(object sender, EventArgs e)
        {
            if (comm.viConnected)
            {
                string errMsg;
                comm.viSystErr(out errMsg);
                this.lbResp.Text = errMsg;
            }
        }
    }
}

