using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace DMXSound
{
    public partial class Form1 : Form
    {
        private static int fftLength = 128; // NAudio fft wants powers of two!
        private static string channel1 = "Left Channel";
        private static string channel2 = "Right Channel";
        private static string fft = "FFT";
        private static string sumFreq1series = "Sum freq 1";
        private static string sumFreq2series = "Sum freq 2";
        private static string sumFreq3series = "Sum freq 3";
        private long counter = 0;
        private long counter2 = 0;

        // There might be a sample aggregator in NAudio somewhere but I made a variation for my needs
        private SampleAggregator sampleAggregator = new SampleAggregator(fftLength);
        NAudio.Wave.WaveIn sourceStream = null;
        NAudio.Wave.DirectSoundOut waveOut = null;

        public Form1()
        {
            InitializeComponent();
            

            sampleAggregator.FftCalculated += new EventHandler<FftEventArgs>(FftCalculated);
            sampleAggregator.PerformFFT = true;

            sourceStream = new NAudio.Wave.WaveIn();
            sourceStream.DeviceNumber = 0;
            sourceStream.WaveFormat = new NAudio.Wave.WaveFormat(44100, NAudio.Wave.WaveIn.GetCapabilities(0).Channels);
            sourceStream.DataAvailable += OnDataAvailable;

            //NAudio.Wave.WaveInProvider waveIn = new NAudio.Wave.WaveInProvider(sourceStream);

            //waveOut = new NAudio.Wave.DirectSoundOut();
           // waveOut.Init(waveIn);

            sourceStream.StartRecording();
           // waveOut.Play();

        }

        void OnDataAvailable(object sender, WaveInEventArgs e)
        {
            int numberOfChannels = 2;
            int numberOfbytes = 2;
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new EventHandler<WaveInEventArgs>(OnDataAvailable), sender, e);
            }
            else
            {
                byte[] buffer = e.Buffer;
                int bytesRecorded = e.BytesRecorded;
                int bufferIncrement = sourceStream.WaveFormat.BlockAlign;

                for (int i = 0; i < e.Buffer.Length/4; i = i + 4)
                {

                    float sampleL = Convert.ToSingle(buffer[i] + (buffer[i + 1]<<8));
                    float sampleR = Convert.ToSingle(buffer[i+2] + (buffer[i + 3]<<8));

                    if (sampleL > 32767)
                        sampleL = sampleL - 65536;
                    if (sampleR > 32767)
                        sampleR = sampleR - 65536;

                    sampleAggregator.Add(sampleL);
                    LeftChannelChart.Series[channel1].Points.AddY(sampleL);
                    RightChannelChart.Series[channel2].Points.AddY(sampleR);
                    if (counter > 1023)
                    {
                        LeftChannelChart.Series[channel1].Points.Remove(LeftChannelChart.Series[channel1].Points.First());
                        RightChannelChart.Series[channel2].Points.Remove(RightChannelChart.Series[channel2].Points.First());
                    }
                    else
                    {
                        counter++;
                    }
                }
            }
        }

        void FftCalculated(object sender, FftEventArgs e)
        {
            double sumFreq1 = 0;
            double sumFreq2 = 0;
            double sumFreq3 = 0;
            double temp = 0;
            FftChart.Series[fft].Points.Clear();
            for (var i = 0; i < e.Result.Length/2; i++)
            {
                temp = Math.Sqrt(e.Result[i].X * e.Result[i].X + e.Result[i].Y * e.Result[i].Y);
                if (i < 3)
                {
                    sumFreq1 = sumFreq1 + temp;
                }else if(i<10){
                    sumFreq2 = sumFreq2 + temp;
                }
                else
                {
                    sumFreq3 = sumFreq3 + temp;
                }

                FftChart.Series[fft].Points.AddY(temp);
            }
            if (counter2 > 100)
            {
                SumFreq1Chart.Series[sumFreq1series].Points.Remove(SumFreq1Chart.Series[sumFreq1series].Points.First());
                SumFreq2Chart.Series[sumFreq2series].Points.Remove(SumFreq2Chart.Series[sumFreq2series].Points.First());
                SumFreq3Chart.Series[sumFreq3series].Points.Remove(SumFreq3Chart.Series[sumFreq3series].Points.First());
            }
            else
            {
                counter2++;
            }
            SumFreq1Chart.Series[sumFreq1series].Points.AddY(sumFreq1);
            SumFreq2Chart.Series[sumFreq2series].Points.AddY(sumFreq2);
            SumFreq3Chart.Series[sumFreq3series].Points.AddY(sumFreq3);
        }
    }
}
