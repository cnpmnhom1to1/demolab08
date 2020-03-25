using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace football_field_management
{
    public partial class MainF : Form
    {
        public MainF()
        {
            InitializeComponent();
        }

        private void MainF_Load(object sender, EventArgs e)
        {

        }

        private void MainF_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void manageFieldsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageFieldsForm manageField = new ManageFieldsForm();
            manageField.ShowDialog();
        }

        private void othersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Others manageOthers = new Others();
            manageOthers.ShowDialog();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.ShowDialog();
        }

        private void menuStrip1_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void manageReserveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageBookingForm manageBooking = new ManageBookingForm();
            manageBooking.ShowDialog();
        }

        private void manageClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageClientsForm manageClient = new ManageClientsForm();
            manageClient.ShowDialog();
        }

        private void manageEmployeeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ManageEmployeeForm manageEmployee = new ManageEmployeeForm();
            manageEmployee.ShowDialog();
        }

        private void generateBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BillForm bill = new BillForm();
            bill.ShowDialog();
        }
    }
}
