using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WorkerClock
{
    using _faLog = Fa.Common.Log;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region [ Main RTN ]

        string _Time1 = string.Empty;
        string _Time2 = string.Empty;
        bool _bCheck = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            _log = new _faLog(this, 30);
            _faLog.LogMsg += new _faLog.LogEventHandler(_faLog_LogMsg);
            _faLog.AddLog(string.Format("{0}", "Program Start"));
            init();
            this.Location = new System.Drawing.Point(70, 10);
            menuToolStripMenuItem.Text = string.Format("{0:yyyy-MM-dd}", System.DateTime.Now); 
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _faLog.AddLog(string.Format("{0}", "Form1_FormClosing"));

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            _faLog.AddLog(string.Format("{0}", "Form1_FormClosed"));

        }
        private void init()
        {
            timer1.Start();

            // 환경설정파일 위치 
            //_path_ini = Application.StartupPath + @"\ini";
            _path_ini = Application.StartupPath;
            ConfigOpenini();
            GetWeekOfYear();
        }

        private string Time25()
        {
            string Time25 = string.Empty;

            if (Convert.ToInt16(DateTime.Now.TimeOfDay.Hours) < 6)
            {
                Time25 = string.Format("{0:00}:{1:mm}", 24 + Convert.ToInt16(DateTime.Now.TimeOfDay.Hours), DateTime.Now);
            }
            else
            {
                Time25 = string.Format("{0:HH:mm}", DateTime.Now);
            }
            return Time25;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
#if false
            if (_Time1 != string.Format("{0:HH:mm}", System.DateTime.Now))
            {
                _Time1 = string.Format("{0:HH:mm}", System.DateTime.Now);
            }
            else
            {
                if (_bCheck)
                {
                    _Time1 = string.Format("{0:HH mm}", System.DateTime.Now);
                    _bCheck = false;
                }
                else
                {
                    _Time1 = string.Format("{0:HH:mm}", System.DateTime.Now);
                    _bCheck = true;
                }
            }

#endif
            if (_Time1 != Time25())
            {
                _Time1 = Time25();
            }
            else
            {
                if (_bCheck)
                {
                    _Time1 = Time25();
                    _bCheck = false;
                }
                else
                {
                    _Time1 = Time25();
                    _bCheck = true;
                }
            }
            if (stopwatch.IsRunning)
            {
                //_Time2 = string.Format("{0:HH:mm}", stopwatch.Elapsed.);
                _Time2 = string.Format("{0:00}:{1:00}:{2:00}", stopwatch.Elapsed.Hours, stopwatch.Elapsed.Minutes, stopwatch.Elapsed.Seconds);

                if (_trkcfg.AlaramTypeHMS == "H")
                {
                    if (stopwatch.Elapsed.TotalHours >= _trkcfg.AlarmTimeHour)
                    {
                        timerBeep.Start();
                    }
                }
                else if (_trkcfg.AlaramTypeHMS == "M")
                {
                    //if (stopwatch.Elapsed.Minutes * _trkcfg.AlarmTimeMinites >= _trkcfg.AlarmTimeMinites)
                    //if (stopwatch.Elapsed.Minutes >= _trkcfg.AlarmTimeMinites)
                    if (stopwatch.Elapsed.TotalMinutes >= _trkcfg.AlarmTimeMinites)
                        {
                            timerBeep.Start();
                    }
                }
                else // (_trkcfg.AlaramTypeHMS == "S")
                {
                    //if (stopwatch.Elapsed.Seconds >= _trkcfg.AlarmTimeSecond)
                    if (stopwatch.Elapsed.TotalSeconds >= _trkcfg.AlarmTimeSecond)
                        {
                            timerBeep.Start();
                    }
                }
            }
            lbTime1.Text = _Time1;
            lbTime2.Text = _Time2;
        }

        static Calendar cal = new GregorianCalendar();
        void GetWeekOfYear()
        {
            DateTime date = DateTime.Now;
            DayOfWeek firstDay = DayOfWeek.Sunday;
            CalendarWeekRule rule;

            rule = CalendarWeekRule.FirstFullWeek;

            lbWeekDay.Text = string.Format(" {0}", cal.GetWeekOfYear(date, rule, firstDay));

        }

        System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();

        bool _bStart = false;
        private void btnStart_Click(object sender, EventArgs e)
        {
            _faLog.AddLog(string.Format("{0}", "btnStart_Click"));
            if (_bStart)
            {
                stopwatch.Stop();
                _bStart = false;
                btnStart.Text = "Start";
            }
            else
            {
                stopwatch.Start();
                btnStart.Text = "Stop";
                _bStart = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _faLog.AddLog(string.Format("{0}", "btnReset_Click"));
            if (_bStart)
            {
                stopwatch.Restart();
                btnStart.Text = "Stop";
                _bStart = true;
            }
            else
            {
                stopwatch.Reset();
                _bStart = false;
                btnStart.Text = "Start";

                _Time2 = string.Format("{0:00}:{1:00}:{2:00}", stopwatch.Elapsed.Hours, stopwatch.Elapsed.Minutes, stopwatch.Elapsed.Seconds);
                timerBeep.Stop();

            }
        }


        #endregion


        #region Log message

        Fa.Common.Log _log;

        void _faLog_LogMsg(object sender, Fa.Common.LogEventArgs e)
        {
            try
            {
                this.BeginInvoke((ThreadStart)delegate ()
                {
#if false
                    if (listInspMsg.Items.Count > 500) listInspMsg.Items.RemoveAt(0);
					listInspMsg.Items.Add(e._logMsg);
					listInspMsg.SelectedIndex = listInspMsg.Items.Count - 1;

#endif
                });

            }
            catch {; }
        }

        protected void Add_InspMsg(string format, params object[] args)
        {
            //AddLog(_log.AddLog(msgString, args));
            _faLog.AddLog(format, args);
        }

        #endregion


        #region [ Beep ]

        private void Beep1() 
        {
            Beep(512, 300);
            Beep(640, 300);
            Beep(768, 300);
        }

        // 도 = 256Hz
        // 레 = 도 * 9/8 = 288Hz
        // 미 = 레 * 10/9 = 320Hz
        // 파 = 미 * 16/15 = 341.3Hz
        // 솔 = 파 * 9/8 = 384Hz
        // 라 = 솔 * 10/9 = 426.6Hz
        // 시 = 라 * 9/8 = 480Hz
        // 도 = 시 * 16/15 = 512Hz (= 처음 도의 2배)
        // 2배 = 높은음, 1/2배 = 낮은음

        [DllImport("KERNEL32.DLL")]
        extern public static void Beep(int freq, int dur);

        private void timerBeep_Tick(object sender, EventArgs e)
        {
            timerBeep.Stop();
            Beep1();
            timerBeep.Start();
        }

		#endregion


		#region [ CONFIG ] 

		string _path_ini;
		TRKConfig _trkcfg;

		void ConfigOpenini()
		{
			using (XmlIO io = new XmlIO())
			{
				_trkcfg = io.ReadTRKConfig(_path_ini);
			}
			int isSet = 0;
			ConfigSetData(isSet);
		}
		void ConfigSaveini()
		{
			int isSet = 1;
			ConfigSetData(isSet);
			using (XmlIO io = new XmlIO())
			{
				io.SaveTRKConfig(_path_ini, _trkcfg);
			}
		}

		void ConfigSetData(int iSet)
		{
#if false
			if (iSet == 0)
			{
				//numSensorPort.Value = _trkcfg.SensorPort;
			}
			else
			{
				//_trkcfg.SensorPort = numSensorPort.ValueToInt32;
			}
#endif
		}

		#endregion


		#region [ToolStripMenu]

		private void exclamationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SystemSounds.Asterisk.Play();
            //SystemSounds.Beep.Play();
            //SystemSounds.Exclamation.Play();
            SystemSounds.Hand.Play();
            //SystemSounds.Question.Play();
        }

        private void beepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            //SystemSounds.Asterisk.Play();
            //SystemSounds.Question.Play();

        }

        private void doremiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Beep1();
        }




        #endregion

        private void configSaveiniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ConfigSaveini();
        }

        private void eXiTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            this.Close();
        }

        private void toolStripMenuItemMinites10_Click(object sender, EventArgs e)
        {
            _trkcfg.AlaramTypeHMS = "M";
            _trkcfg.AlarmTimeMinites = 10;
            ConfigSaveini();
            ConfigOpenini();
        }

        private void toolStripMenuItemMinites05_Click(object sender, EventArgs e)
        {
            _trkcfg.AlaramTypeHMS = "M";
            _trkcfg.AlarmTimeMinites = 5;
            ConfigSaveini();
            ConfigOpenini();
        }

        private void toolStripMenuItemMin5010_Click(object sender, EventArgs e)
        {
            _trkcfg.AlaramTypeHMS = "M";
            _trkcfg.AlarmTimeMinites = 50;
            ConfigSaveini();
            ConfigOpenini();
        }

        private void seconds570ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _trkcfg.AlaramTypeHMS = "S";
            _trkcfg.AlarmTimeMinites = 570;
            ConfigSaveini();
            ConfigOpenini();
        }

        private void second350ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _trkcfg.AlaramTypeHMS = "S";
            _trkcfg.AlarmTimeMinites = 350;
            ConfigSaveini();
            ConfigOpenini();
        }

        //

        //

    }
}
