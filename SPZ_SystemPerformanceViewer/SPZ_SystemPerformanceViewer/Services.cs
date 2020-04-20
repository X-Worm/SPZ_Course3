using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPZ_SystemPerformanceViewer
{
    public partial class Services : Form
    {
        private List<ServiceController> ServiceList;
        private ServiceController currentSelectedService;

        public Services()
        {
            InitializeComponent();
            InitServices();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        /// <summary>
        /// Init services list
        /// </summary>
        private void InitServices()
        {
            servicesListBox.MultiSelect = false;
            ServiceList = ServiceController.GetServices().ToList();
            var list = ServiceList.Select(item => new
            {
                ServiceName = item.ServiceName,
                DisplayName = item.DisplayName,
                Status = item.Status,
                StartType = item.StartType,
                ServiceType = item.ServiceType.ToString()
            }).ToList();

            servicesListBox.Columns.Add("ServiceName", 150);
            servicesListBox.Columns.Add("DisplayName", 150);
            servicesListBox.Columns.Add("Status", 75);
            servicesListBox.Columns.Add("StartType", 75);
            servicesListBox.Columns.Add("ServiceType", 175);

            foreach (var service in list)
            {
                var serviceInfo = new string[] { 
                    service.ServiceName, 
                    service.DisplayName, 
                    service.Status.ToString(), 
                    service.StartType.ToString(),
                    service.ServiceType};
                servicesListBox.Items.Add(new ListViewItem(serviceInfo));
            }
        }

        /// <summary>
        /// To track service info when selected item changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void servicesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection breakfast =
                this.servicesListBox.SelectedItems;

            var currentService = new ServiceController();
            foreach (ListViewItem item in breakfast)
            {
                currentSelectedService = ServiceList.Where(service => service.ServiceName == item.Text).FirstOrDefault();
            }
            // define button availability
            // if service is in running status we can only stop or restart it
            if(currentSelectedService.Status == ServiceControllerStatus.Running)
            {
                startServiceButton.Enabled = false;
                SetDisabledButtonColor(startServiceButton);
                stopServiceButton.Enabled = true;
                SetEnableButtonColor(stopServiceButton);
            }
            // if service is stoped we can start it but cannot stop
            else if(currentSelectedService.Status == ServiceControllerStatus.Stopped)
            {
                startServiceButton.Enabled = true;
                SetEnableButtonColor(startServiceButton);
                stopServiceButton.Enabled = false;
                SetDisabledButtonColor(stopServiceButton);
            }

        }

        /// <summary>
        /// Try start stopped service
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startServiceButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(currentSelectedService == null)
                {
                    MessageBox.Show("Service is not selected");
                    return;
                }
                currentSelectedService.Start();
                MessageBox.Show($"Service: {currentSelectedService.DisplayName}, successfully started");
                MessageBox.Show("Current window will be closed to refresh status of service");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Cannot start service: " + ex.Message);
            }
        }

        private void SetDisabledButtonColor(Button button)
        {
            button.BackColor = Color.IndianRed;
        }

        private void SetEnableButtonColor(Button button)
        {
            button.BackColor = Color.LightGray;
        }

        /// <summary>
        /// try stope running service
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stopServiceButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentSelectedService == null)
                {
                    MessageBox.Show("Service is not selected");
                    return;
                }
                currentSelectedService.Stop();
                MessageBox.Show($"Service: {currentSelectedService.DisplayName}, successfully stoped");
                MessageBox.Show("Current window will be closed to refresh status of service");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot stop service: " + ex.Message);
            }
        }

        /// <summary>
        /// Restart service
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void restartServiceButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentSelectedService == null)
                {
                    MessageBox.Show("Service is not selected");
                    return;
                }
                currentSelectedService.Refresh();
                MessageBox.Show($"Service: {currentSelectedService.DisplayName}, successfully refreshed");
                MessageBox.Show("Current window will be closed to refresh status of service");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot refresh service: " + ex.Message);
            }
        }
    }
}
