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
        private static int fftLength = 1024; // NAudio fft wants powers of two!
        private long counter = 0;

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
                    chart1.Series["Series1"].Points.AddY(sampleL);
                    chart2.Series["Series1"].Points.AddY(sampleR);
                    if (counter > 1023)
                    {
                        chart1.Series["Series1"].Points.Remove(chart1.Series["Series1"].Points.First());
                        chart2.Series["Series1"].Points.Remove(chart2.Series["Series1"].Points.First());
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
            chart3.Series["Series1"].Points.Clear();
            for (var i = 0; i < e.Result.Length/2; i++)
            {
               chart3.Series["Series1"].Points.AddY(Math.Sqrt(e.Result[i].X * e.Result[i].X + e.Result[i].Y * e.Result[i].Y));
            }
        }
    }
}
