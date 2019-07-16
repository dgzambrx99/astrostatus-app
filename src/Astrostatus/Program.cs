using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astrostatus
{
    internal static class Program
    {
        internal static string appData => Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        internal static string appDir => Path.Combine(appData, "Astrostatus");

        internal static Models.Settings Settings { get; set; }

        internal static Type ActiveFormType;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Settings = new Models.Settings();
            Settings.Load();

            var ping = new System.Net.NetworkInformation.Ping();
            var result = DialogResult.Retry;
#if !DEBUG
            while (result == DialogResult.Retry)
            {
                try
                {
                    var ip = new Uri(Settings.Endpoint).Host;
                    if (ping.Send(ip).Status == System.Net.NetworkInformation.IPStatus.Success)
                        result = DialogResult.OK;
                    else
                        throw new Exception();
                }
                catch (Exception)
                {
                    result = MessageBox.Show("Unable to connect to server, want to retry?", "Astrostatus - 2019", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk);
                }
            }
#else
            result = DialogResult.OK;
#endif
            if (result == DialogResult.OK)
                Application.Run(new FormMain());
        }
    }

    namespace Models
    {
        internal class Settings : INotifyPropertyChanged
        {
            public Settings()
            {
                endpoint = "http://10.110.40.39/add1.php";
                employeeNameReadOnly = false;
                employeeNameText = string.Empty;
                stationNumberReadOnly = false;
                stationNumberText = string.Empty;
                temperatureReadOnly = false;
                temperatureText = string.Empty;
                topMost = false;
                opacity = 1.0;
            }

            private string endpoint;
            private bool employeeNameReadOnly;
            private string employeeNameText;
            private bool stationNumberReadOnly;
            private string stationNumberText;
            private bool temperatureReadOnly;
            private string temperatureText;
            private bool topMost;
            private double opacity;

            public string Endpoint
            {
                get { return endpoint; }
                set { if (value != this.endpoint) { this.endpoint = value; NotifyPropertyChanged(); } }
            }

            public bool EmployeeNameReadOnly
            {
                get { return employeeNameReadOnly; }
                set { if (value != this.employeeNameReadOnly) { this.employeeNameReadOnly = value; NotifyPropertyChanged(); } }
            }

            public string EmployeeNameText
            {
                get { return employeeNameText; }
                set { if (value != this.employeeNameText) { this.employeeNameText = value; NotifyPropertyChanged(); } }
            }

            public bool StationNumberReadOnly
            {
                get { return stationNumberReadOnly; }
                set { if (value != this.stationNumberReadOnly) { this.stationNumberReadOnly = value; NotifyPropertyChanged(); } }
            }

            public string StationNumberText
            {
                get { return stationNumberText; }
                set { if (value != this.stationNumberText) { this.stationNumberText = value; NotifyPropertyChanged(); } }
            }

            public bool TemperatureReadOnly
            {
                get { return temperatureReadOnly; }
                set { if (value != this.temperatureReadOnly) { this.temperatureReadOnly = value; NotifyPropertyChanged(); } }
            }

            public string TemperatureText
            {
                get { return temperatureText; }
                set { if (value != this.temperatureText) { this.temperatureText = value; NotifyPropertyChanged(); } }
            }

            public bool TopMost
            {
                get { return topMost; }
                set { if (value != this.topMost) { this.topMost = value; NotifyPropertyChanged(); } }
            }

            public double Opacity
            {
                get { return opacity; }
                set { if (value != this.opacity) { this.opacity = value; NotifyPropertyChanged(); } }
            }

            public double OpacityValue { get { return Opacity * 100; } }

            public event PropertyChangedEventHandler PropertyChanged;

            private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }

            public void Save()
            {
                try
                {
                    if (!Directory.Exists(Program.appDir)) Directory.CreateDirectory(Program.appDir);

                    var settingsFile = Path.Combine(Program.appDir, "Settings.ini");

                    var data = new[] {
                        "[Settings]",
                        $"Endpoint={Endpoint}",
                        $"EmployeeNameReadOnly={EmployeeNameReadOnly}",
                        $"EmployeeNameText={EmployeeNameText}",
                        $"StationNumberReadOnly={StationNumberReadOnly}",
                        $"StationNumberText={StationNumberText}",
                        $"TemperatureReadOnly={TemperatureReadOnly}",
                        $"TemperatureText={TemperatureText}",
                        $"TopMost={TopMost}",
                        $"Opacity={Opacity}",
                    };
                    File.WriteAllLines(settingsFile, data);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Astrostatus", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            public void Load()
            {
                try
                {
                    if (!Directory.Exists(Program.appDir)) Directory.CreateDirectory(Program.appDir);

                    var settingsFile = Path.Combine(Program.appDir, "Settings.ini");

                    if (File.Exists(settingsFile))
                    {
                        try
                        {
                            var data = File.ReadAllLines(settingsFile);
                            Endpoint = data[1].Split('=').Last().Trim();
                            EmployeeNameReadOnly = bool.Parse(data[2].Split('=').Last().Trim());
                            EmployeeNameText = data[3].Split('=').Last().Trim();
                            StationNumberReadOnly = bool.Parse(data[4].Split('=').Last().Trim());
                            StationNumberText = data[5].Split('=').Last().Trim();
                            TemperatureReadOnly = bool.Parse(data[6].Split('=').Last().Trim());
                            TemperatureText = data[7].Split('=').Last().Trim();
                            TopMost = bool.Parse(data[8].Split('=').Last().Trim());
                            Opacity = double.Parse(data[9].Split('=').Last().Trim());
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Settings files is corrupted, rebuilding.", "Astrostatus", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            File.Move(settingsFile, Path.Combine(Program.appDir, $"{Path.GetFileNameWithoutExtension(settingsFile)}_{DateTime.Now.ToString("yyyyMMddTHHmmss")}.bak"));
                            Save();
                        }
                    }
                    else
                        Save();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Astrostatus", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
        }
    }
}