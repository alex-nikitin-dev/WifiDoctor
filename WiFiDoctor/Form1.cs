using System;
using System.Diagnostics;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using WiFiDoctor.Properties;

namespace WiFiDoctor
{
    public partial class Form1 : Form
    {
        bool IsVisibilityChangeAllowed { get; set; }
        protected override void SetVisibleCore(bool value)
        {
            if (IsVisibilityChangeAllowed)
            {
                base.SetVisibleCore(value);
            }
        }
        private readonly Timer _timer = new Timer();
        public Form1()
        {
            InitializeComponent();


            _firstStart = true;
            _timer.Interval = 1000*60*4;
            _timer.Tick += _timer_Tick;
            _timer.Start();

          //  Do();
        }

        private bool _firstStart;
        private void ShowEx()
        {
            IsVisibilityChangeAllowed = true;
            Show();
        }
        void _timer_Tick(object sender, EventArgs e)
        {

            _timer.Stop();

            Log("");
            Log("--------------------------------------");
            Log("Таймер сработал и остановлен");

            if (_firstStart)
            {
                _firstStart = false;
                _timer.Interval = Stt.Interval1;
            }

           Do();


            Log("Таймер проверки вновь запущен");
            Log("");
            Log("--------------------------------------");
            _timer.Start();
        }

        private int _pingCount;
        private bool _lastResult;
        private int _reconnectCount;
        private int _continuouslyReconnectCount;
        void Do()
        {
            Log("Начало проверки...");

            _pingCount++;

            if (!VerifyWifiByProvider())
            {

                if(_continuouslyReconnectCount > 3)
                {
                    var oldInterval = _timer.Interval;
                    _timer.Interval = (int)Math.Round(1.3 * _timer.Interval);
                    Log(string.Format("Интервал был увеличен от {0} до {1}", oldInterval, _timer.Interval));
                }

                _continuouslyReconnectCount++;

                var oldJod = Stt.JurnalingOnlyDisconnect;

                if (oldJod) Stt.JurnalingOnlyDisconnect = false;

                Reconnect();

                if (oldJod) Stt.JurnalingOnlyDisconnect = true;
            }
            else
            {
                _continuouslyReconnectCount = 0;
                _timer.Interval = Stt.Interval1;
            }

            ShowInfo();

            Log("Проверка окончена");
        }

        void Reconnect()
        {
            _reconnectCount++;

            WlanDisConnect();
            WlanConnect();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        void Log(string text)
        {
            if (!Stt.Jurnaling) return;
            if (Stt.JurnalingOnlyDisconnect) return;

            LogBase(text);
        }

        void LogDisconnect(string text)
        {
            if (!Stt.Jurnaling) return;
            
            LogBase(text);
           
        }

        void LogBase(string text)
        {
            textBox1.AppendText(string.Format("{2} {0}{1}",
               text,
               Environment.NewLine,
               DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss")));
        }

        private void LoadSettings()
        {
            txtAddress1.Text = Stt.Address1;
            numInterval.Value = Stt.Interval1;
            chkJurnaling.Checked = Stt.Jurnaling;
            chkJurnalingDisconnectOnly.Checked = Stt.JurnalingOnlyDisconnect;
            txtConnectName.Text = Stt.NetName;
        }

        private void SaveSettings()
        {
            Stt.Address1 = txtAddress1.Text;
            Stt.Interval1 = (int) numInterval.Value;
            Stt.Jurnaling = chkJurnaling.Checked;
            Stt.JurnalingOnlyDisconnect = chkJurnalingDisconnectOnly.Checked;
            Stt.NetName = txtConnectName.Text;

            Stt.Save();
        }


        void ApplySettings()
        {
            SaveSettings();

            _timer.Interval = Stt.Interval1;
        }

        static Settings Stt
        {
            get { return Settings.Default; }
        }

        void ShowInfo()
        {
            lblInfoAddress.Text = Stt.Address1;
            lblInfoCount.Text = _pingCount.ToString(CultureInfo.InvariantCulture);
            lblInfoInterval.Text = _timer.Interval.ToString(CultureInfo.InvariantCulture);
            lblInfoLastResult.Text = (_lastResult) ? "Доступен" : "НЕ доступен";
            lblInfoReconnectCount.Text = _reconnectCount.ToString(CultureInfo.InvariantCulture);
            lblContinuosReconnetCont.Text = _continuouslyReconnectCount.ToString(CultureInfo.InvariantCulture);
        }
        Ping ping = new Ping();
        bool VerifyWifiByProvider()
        {
            Log(String.Format("Пингуем {0} ...", Stt.Address1));

            try
            {
                var res = ping.Send(Stt.Address1);
                if (res != null && res.Status == IPStatus.Success)
                {
                    Log(String.Format("... {0} доступен", Stt.Address1));
                   
                    _lastResult = true;
                    return true;
                }
            }
            catch (Exception exception)
            {
                Log(exception.Message);
                
            }


            LogDisconnect(String.Format("... {0} НЕ доступен", Stt.Address1));
            _lastResult = false;
            return false;
           
        }


        private void button1_Click(object sender, EventArgs e)
        {
            WlanConnect();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WlanDisConnect();
        }

        void WlanConnect()
        {
            Log("Попытка соединения с вайфай...");


            Netsh(string.Format("wlan connect {0}", Stt.NetName));
        }
        void WlanDisConnect()
        {
            Log("Попытка разрыва...");
            Netsh("wlan disconnect");
        }
        void Netsh(string cmd)
        {
            var ps = new ProcessStartInfo("netsh", cmd)
            {
                WindowStyle = ProcessWindowStyle.Hidden
            };


            Log(string.Format("Создаем процесс Netsh команда: {0} ... ", cmd));
            var p = Process.Start(ps);


            Log("Ждем выхода из процесса Netsh...");
            if (p != null) p.WaitForExit(30000);

            Log("Процесс Netsh завершен"); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = VerifyWifiByProvider().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _timer.Enabled = !_timer.Enabled;

            Log("");
            Log("Состояние таймера: " + _timer.Enabled);
            Log("");
        }

        private bool _exit;
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_exit == false && e.CloseReason != CloseReason.WindowsShutDown)
            {
                e.Cancel = true;
                Hide();
            }
        }
        void Exit()
        {
            _exit = true;
            try
            {
                _timer.Stop();
            }
// ReSharper disable once EmptyGeneralCatchClause
            catch (Exception){
            }
           
            Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowEx();
        }

        private void btnApplySettings_Click(object sender, EventArgs e)
        {
            ApplySettings();
        }

        private void btnAutoRun_Click(object sender, EventArgs e)
        {
            Program.SetAutoRun();
        }

        private void btnDelAutoRun_Click(object sender, EventArgs e)
        {
            Program.TryResetAutoRun();
        }

    }
}
