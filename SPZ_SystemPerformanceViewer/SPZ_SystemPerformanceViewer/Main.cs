using SPZ_SystemPerformanceViewer.CommonItems.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace SPZ_SystemPerformanceViewer
{
    public partial class Main : Form
    {
        private PerformanceCounter CPUCounter;
        private PerformanceCounter RAMCounter;
        private string CurrentCounter = "";
        private int TotalVisibleMemory { get; set; }

        private List<Process> ProcessList = new List<Process>();

        private System.Timers.Timer timer;

        public Main()
        {
            InitializeComponent();
            InitRAMTotalMemory();
            InitCounterList();
            
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            timer = new System.Timers.Timer(500);
            timer.Elapsed += Timer_Elapsed;
            timer.Enabled = true;
        }

        /// <summary>
        /// To initialize CPU and Memory usage counters
        /// </summary>
        private void InitCounterList()
        {
            // set CPU counter
            CPUCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            CurrentCounter = CPUCounter.CounterName;

            // set RAM counter
            RAMCounter = new PerformanceCounter("Memory", "Available MBytes", true);
            var local = RAMCounter.NextValue();

            // init Grapg
            CPUGraph.Minimum = 0; CPUGraph.Maximum = 100;
            MemoryGraph.Minimum = 0; MemoryGraph.Maximum = (int)TotalVisibleMemory;
        }

        /// <summary>
        /// Get total available RAM memory on current PC
        /// </summary>
        private void InitRAMTotalMemory()
        {
            ObjectQuery wql = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(wql);
            ManagementObjectCollection results = searcher.Get();
            foreach (ManagementObject result in results)
            {
                TotalVisibleMemory =  (int)(Convert.ToInt32(result["TotalVisibleMemorySize"])/1024);
            }
            AvailableMemoryLabel.Text = TotalVisibleMemory.ToString();
        }

        /// <summary>
        /// add new process
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addCounterButton_Click(object sender, EventArgs e)
        {
            AddCounter addCountWindow = new AddCounter();
            addCountWindow.ShowDialog(this);

            // get list of processed items
            ProcessList.AddRange(SPZ_SystemPerformanceViewer.CommonItems.ProcessList.ProcessListIds.Select(item => Process.GetProcessById(item)));
            SPZ_SystemPerformanceViewer.CommonItems.ProcessList.ProcessListIds.Clear();

            counterList.DataSource = ProcessList.Select(item => new { Id = item.Id, Name = item.ProcessName }).ToList();
        }

        private void mainGraph_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Update cpu and memory counter value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            CPUGraph.Invoke((MethodInvoker)delegate
            {
                float CPUCounetValue = (float)Math.Round(CPUCounter.NextValue(), 2);
                CPUGraph.Text = CPUCounetValue.ToString() + "%";
                CPUGraph.Value = (int)CPUCounetValue;

                int MemoryTotalValue = TotalVisibleMemory - (int)RAMCounter.NextValue();
                MemoryGraph.Text = MemoryTotalValue.ToString();
                MemoryGraph.Value = MemoryTotalValue;
            });
        }

        /// <summary>
        /// to set process info when it changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void counterList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // init label info
            dynamic processInfo = counterList.SelectedItem;
            InitProcessInfo(processInfo.Id);
        }

        /// <summary>
        /// init process info
        /// </summary>
        /// <param name="processId"></param>
        private void InitProcessInfo(int processId)
        {
            Process currentProcess = Process.GetProcessById(processId);
            ProcessIdLabel.Text = processId.ToString();
            StartTimeLabel.Text = currentProcess.StartTime.ToString();
            FileNameLabel.Text = String.IsNullOrEmpty(currentProcess.StartInfo.FileName) ? "Not available" : currentProcess.StartInfo.FileName;
            ProcessNameLabel.Text = currentProcess.ProcessName;
            PriorityLabel.Text = currentProcess.PriorityClass.ToString();
            MachineNameLabel.Text = String.IsNullOrEmpty(currentProcess.MachineName) || currentProcess.MachineName == "." ? "Not available" : currentProcess.MachineName;
            IsRespondingLabel.Text = currentProcess.Responding.ToString();

        }

        /// <summary>
        /// kill current selected process
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            dynamic selectedItem = counterList.SelectedItem;
            if (selectedItem == null)
            {
                MessageBox.Show("Process not selected");
                return;
            }
            else
            {
                Process process = Process.GetProcessById(selectedItem.Id);
                try
                {
                    process.Kill();
                    MessageBox.Show($"Process: {selectedItem.Id} killed");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("It is not possible to kill process: " + selectedItem.Id + ", Error: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// remove process from list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeCounterButton_Click(object sender, EventArgs e)
        {
            dynamic selectedItem = counterList.SelectedItem;
            if (selectedItem != null)
            {
                ProcessList.RemoveAll(item => item.Id == selectedItem.Id);
            }
            counterList.DataSource = ProcessList.Select(item => new { Id = item.Id, Name = item.ProcessName }).ToList();
        }

        /// <summary>
        /// Show list of services
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Services services = new Services();
            services.ShowDialog(this);
        }
    }
}
