using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPZ_SystemPerformanceViewer
{
    public partial class AddCounter : Form
    {
        private int CurrentPage = 1;
        private int PageSize = 10;
        private int TotalItems = 0;
        private List<Process> ProcessList;

        public AddCounter()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            ProcessList = Process.GetProcesses().OrderBy(item => item.ProcessName).ToList();
            TotalItems = ProcessList.Count;
            TotalProcessCountLabel.Text = TotalItems.ToString();
            InitList(1);
        }

        /// <summary>
        /// Init list of process
        /// </summary>
        /// <param name="pageNumber"></param>
        private void InitList(int pageNumber)
        {
            var localProcessList = ProcessList.Skip((CurrentPage-1)*PageSize).Take(PageSize);
            var nodeList = localProcessList.Select(item => new TreeNode("Id: " + item.Id + ". - " + item.ProcessName)).ToArray();
            countersTree.Nodes.AddRange(nodeList.ToArray());
            countersTree.CheckBoxes = true;
        }

        /// <summary>
        /// Fetch next 10 items from process list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextButton_Click(object sender, EventArgs e)
        {
            CurrentPage++;
            if(CurrentPage*PageSize-PageSize > TotalItems)
            {
                MessageBox.Show("There are no items in next list");
                return;
            }
            countersTree.Nodes.Clear();
            InitList(CurrentPage);
        }

        /// <summary>
        /// Fetch previous 10 items from process list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void previousButton_Click(object sender, EventArgs e)
        {
            if(CurrentPage == 1)
            {
                MessageBox.Show("There are no items in previous list");
                return;
            }
            CurrentPage--;
            countersTree.Nodes.Clear();
            InitList(CurrentPage);
        }

        /// <summary>
        /// Return checked process for next window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addCounterButton_Click(object sender, EventArgs e)
        {
            // get checked items
            var checkedItems = new List<int>();
            foreach(TreeNode node in countersTree.Nodes)
            {
                if (node.Checked)
                {
                    // get process id
                    Regex regex = new Regex("\\w*: (\\d*)");
                    var id = Int32.Parse(regex.Match(node.Text).Groups[1].Value);
                    checkedItems.Add(id);
                }
            }

            SPZ_SystemPerformanceViewer.CommonItems.ProcessList.ProcessListIds = checkedItems;
            this.Close();
        }
    }
}
