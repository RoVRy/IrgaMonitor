using System;
using System.IO;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Reflection;

namespace IrgaMonitor
{
	public partial class MainForm : Form
    {
        public bool ThreadStatus = false;
		public bool Thread1stStart = true;
		public Thread trd;
		public int CRC=0;
      
        public MainForm()
        {
			InitializeComponent();
        }

        public void MainForm_Load(object sender, EventArgs e)
        {
			RefreshInterval.Text = "3";
            TabControl.TabPages.Remove(MonitorTab);
            Version.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
			this.trd = new Thread(new ThreadStart(this.TrendReader));
			this.trd.IsBackground = true;
        }

        private void StartStop_Click(object sender, EventArgs e)
        {
            if (ThreadStatus)
            {
                DialogResult a;
                a = MessageBox.Show("Вы действительно хотите остановить монитор?", "Стоп", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (a == DialogResult.Yes)
                {
                    trd.Suspend();
                    ThreadStatus = !ThreadStatus;
                    InitializeFields();
                    StartStop.Text = "Пуск";
                    this.ControlBox = true;
                    TabControl.TabPages.Insert(0,SettingsTab);
                    SettingsTab.Select();
                }
            }
            else
            {
                StartStop.Text = "Стоп";
                this.ControlBox = false;
                MonitorTab.Select();
                TabControl.TabPages.Remove(SettingsTab);
                ThreadStatus = !ThreadStatus;
                if (Thread1stStart)
                {
                    Thread1stStart = false;
                    trd.Start();
                }
                else trd.Resume();
            }
       }

        private void InitializeFields()
        {
            DateTimeField.Text = "";

            SteamPressure.BackColor = SystemColors.Control;
            SteamPressure.Text = "";

            SteamTemp.BackColor = SystemColors.Control;
            SteamTemp.Text = "";

            SteamCharge.BackColor = SystemColors.Control;
            SteamCharge.Text = "";

            ThermalCap.BackColor = SystemColors.Control;
            ThermalCap.Text = "";

            PressDif.BackColor = SystemColors.Control;
            PressDif.Text = "";

            CRCLight.BackColor = SystemColors.Control;
            CRCLight.Text = "";

            SULight.BackColor = SystemColors.Control;
            SULight.Text = "";

            ErrorLight.BackColor = SystemColors.Control;
            ErrorLight.Text = "";
        }

		private void ExitButton_Click(object sender, EventArgs e)
		{
			this.Close();
			Application.Exit();
		}

		private void GetFilename_Click(object sender, EventArgs e)
		{
			TrendFileDialog.ShowDialog();
		}

		private void TrendFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			GetFilename.Text = TrendFileDialog.FileName;
		}

		private void GetFilename_TextChanged(object sender, EventArgs e)
		{
            if (File.Exists(GetFilename.Text))
            {
                TabControl.TabPages.Insert(1,MonitorTab);
                StartStop.Enabled = true;
            }
		}

		private void TrendReader()
		{
			while(ThreadStatus)
			{
				FileStream fs = new FileStream(GetFilename.Text, FileMode.Open, FileAccess.Read,FileShare.ReadWrite);
				BinaryReader br = new BinaryReader(fs);
				CRC = 0;
				if (fs.Length == 57)
				{
					byte[] IrgaData = new byte[57];
					int i;
					br.Read(IrgaData, 0, 57);
					br.Close(); fs.Close();
					CRCLight.Text = "CRC";
					for (i = 10; i < 55; i++)
					{
						ComputeCRC(IrgaData[i]);
					}
                    CRC &= 0xffff;
					if (CRC != BitConverter.ToUInt16(IrgaData, 55)) CRCLight.BackColor = Color.Tomato;
					else CRCLight.BackColor = Color.LightGreen;
					if (IrgaData[15] % 2 == 1) SULight.Text = "СУ 2";
					else SULight.Text = "";
					if (IrgaData[14] == 'O')
					{
						ErrorLight.Text = "ШР";
						ErrorLight.BackColor = Color.LightGreen;
					}
					if (IrgaData[14] == 'Q')
					{
						ErrorLight.Text = "НУ";
						ErrorLight.BackColor = Color.Tomato;
					}
					if (IrgaData[14] == 'D')
					{
						ErrorLight.BackColor = Color.Tomato;
						int a, b = (int)IrgaData[15];
						a = b & 2;
						a += b & 4;
						if (a == 2) ErrorLight.Text = "НК";
						if (a > 2) ErrorLight.Text = "НИП";
					}
					if (DevNum.Value == IrgaData[8] && MeasureChannel.Value == (1 + IrgaData[13]>>4))
					{
						DateTimeField.Text = DateTime.FromOADate(BitConverter.ToDouble(IrgaData, 0)).ToString("G");
						if (IrgaData[19] == 0xff) SteamPressure.BackColor = Color.Tomato;
						else
						{
							SteamPressure.Text = BitConverter.ToSingle(IrgaData, 16).ToString("F3");
							SteamPressure.BackColor = SystemColors.Control;
						}
						if (IrgaData[23] == 0xff) SteamTemp.BackColor = Color.Tomato;
						else
						{
							SteamTemp.Text = (BitConverter.ToSingle(IrgaData, 20)-273.16).ToString("F1");
							SteamTemp.BackColor = SystemColors.Control;
						}
						if (IrgaData[27] == 0xff) SteamCharge.BackColor = Color.Tomato;
						else
						{
							SteamCharge.Text = BitConverter.ToSingle(IrgaData, 24).ToString("F3");
							SteamCharge.BackColor = SystemColors.Control;
						}
						if (IrgaData[35] == 0xff) ThermalCap.BackColor = Color.Tomato;
						else
						{
							ThermalCap.Text = BitConverter.ToSingle(IrgaData, 32).ToString("F3");
							ThermalCap.BackColor = SystemColors.Control;
						}
						if (IrgaData[39] == 0xff) PressDif.BackColor = Color.Tomato;
						else
						{
							PressDif.Text = BitConverter.ToSingle(IrgaData, 36).ToString("F3");
							PressDif.BackColor = SystemColors.Control;
						}
					}
				}
				else br.Close(); fs.Close();
				Thread.Sleep(1000 * Convert.ToInt16(RefreshInterval.Text));
			}
		}

		private void ComputeCRC(byte p)
		{
			uint data = (uint)p;
			int j, k;
			for (j = 0; j < 8; j++)
			{
				k = (CRC & 0x8000) >> 15;
				k += (CRC & 0x0800) >> 11;
				k += (CRC & 0x0100) >> 8;
				k += (CRC & 0x0040) >> 6;
				if (data % 2 == 1) k++;
				CRC = CRC << 1;
				if (k % 2 == 1) CRC++;
				data = data >> 1;
			}
		}
	}
}