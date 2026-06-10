using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Data.Models;
using Services;

namespace UI
{
    public partial class BillingForm : Form
    {
        private readonly ServiceManager _manager;
        public BillingForm(ServiceManager manager)
        {
            InitializeComponent();
            _manager = manager;
        }

        private void BillingForm_Load(object sender, EventArgs e)
        {
            dateTimePickerStart.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateTimePickerEnd.Value = DateTime.Now;

            LoadClients();
            UpdateHistory();
            UpdateStats();

        }

        void UpdateStats()
        {
            listBoxStats.Items.Clear();

            var bills = _manager.BillingRecordService.GetAll();
            var stats = bills
                .GroupBy(b => b.Client.CompanyName)
                .Select(g => new
                {
                    ClientName = g.Key,
                    TotalRevenue = g.Sum(x => x.TotalAmount),
                    InvoicesCount = g.Count()
                })
                .OrderByDescending(x => x.TotalRevenue) 
                .ToList();

            foreach (var item in stats)
            {
                listBoxStats.Items.Add($"{item.ClientName}: ${item.TotalRevenue} ({item.InvoicesCount} invoices)");
            }
        }

        void LoadClients()
        {
            comboBoxClient.Items.Clear();
            comboBoxClient.Items.AddRange(_manager.ClientService.GetAll().ToArray());

            if (comboBoxClient.Items.Count > 0)
                comboBoxClient.SelectedIndex = 0;
        }

        void UpdateHistory()
        {
            var bills = _manager.BillingRecordService.GetAll()
                .OrderByDescending(b => b.BillingDate)
                .Select(b => new
                {
                    ID = b.Id,
                    Client = b.Client.CompanyName,
                    Date = b.BillingDate.ToShortDateString(),
                    Period = $"{b.PeriodStart:d} - {b.PeriodEnd:d}",
                    Amount = $"${b.TotalAmount}",
                    Note = b.Description
                })
                .ToList();

            dataGridViewHistory.DataSource = bills;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (comboBoxClient.SelectedItem == null)
            {
                MessageBox.Show("Будь ласка, оберіть клієнта!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var client = (Client)comboBoxClient.SelectedItem;

                _manager.BillingRecordService.GenerateInvoice(
                    client.Id,
                    dateTimePickerStart.Value,
                    dateTimePickerEnd.Value
                );

                MessageBox.Show("Рахунок успішно сформовано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                UpdateHistory();
                UpdateStats();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не вдалося створити звіт:\n{ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
