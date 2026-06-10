using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using Data.Models;
using Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace UI
{
    public partial class ClientForm : Form
    {
        private readonly ServiceManager _manager;

        public ClientForm(ServiceManager manager)
        {
            InitializeComponent();
            _manager = manager;
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            UpdateClientList();
            comboBoxTariff.SelectedIndex = 0;
        }

        void UpdateClientList()
        {
            listBoxClients.Items.Clear();
            listBoxClients.Items.AddRange(_manager.ClientService.GetAll().ToArray());
        }

        void LoadComboBoxes()
        {
            comboBoxTariff.Items.Clear();
            var tariffs = _manager.TariffPlanService.GetAll().ToArray();
            comboBoxTariff.Items.AddRange(tariffs);

            if (comboBoxTariff.Items.Count > 0)
            {
                comboBoxTariff.SelectedIndex = 0;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxTariff.SelectedItem == null)
                {
                    MessageBox.Show("Список тарифів порожній! Спочатку створіть Тариф у відповідному меню.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }

                var selectedTariff = (TariffPlan)comboBoxTariff.SelectedItem;

                string companyName = textBoxName.Text;
                string phone = textBoxPhone.Text;
                string email = textBoxEmail.Text;
                int tariffPlanId = selectedTariff.Id;

                _manager.ClientService.Create(companyName, phone, email, tariffPlanId);

                UpdateClientList();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding client: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (listBoxClients.SelectedIndex == -1 || listBoxClients.SelectedItem == null)
            {
                MessageBox.Show("Спочатку оберіть клієнта зі списку зліва!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxTariff.SelectedItem == null)
            {
                MessageBox.Show("Оберіть тарифний план для цього клієнта!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var selectedClient = (Client)listBoxClients.SelectedItem;
                var selectedTariff = (TariffPlan)comboBoxTariff.SelectedItem;

                string companyName = textBoxName.Text;
                string phone = textBoxPhone.Text;
                string email = textBoxEmail.Text;
                int tariffPlanId = selectedTariff.Id;

                _manager.ClientService.Update(selectedClient, companyName, phone, email, tariffPlanId);

                UpdateClientList();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при оновленні: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonDelate_Click(object sender, EventArgs e)
        {
            if (listBoxClients.SelectedIndex != -1)
            {
                var selectedClient = (Client)listBoxClients.SelectedItem;

                var result = MessageBox.Show($"Delete client '{selectedClient.CompanyName}'?",
                    "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        _manager.ClientService.Delete(selectedClient.Id);

                        UpdateClientList();
                        ClearInputs();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting client: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void listBoxClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxClients.SelectedIndex != -1)
            {
                var item = (Client)listBoxClients.SelectedItem;

                // Заповнюємо текстові поля
                textBoxName.Text = item.CompanyName;
                textBoxPhone.Text = item.Phone;
                textBoxEmail.Text = item.Email;

                // === ВАЖЛИВО: Синхронізація тарифу ===
                // Шукаємо в ComboBox тариф, який відповідає клієнту
                foreach (TariffPlan t in comboBoxTariff.Items)
                {
                    if (t.Id == item.TariffPlanId)
                    {
                        comboBoxTariff.SelectedItem = t; // Вибираємо його візуально
                        break;
                    }
                }
            }
        }

        private void ClearInputs()
        {
            textBoxEmail.Clear();
            textBoxName.Clear();
            textBoxPhone.Clear();
        }
    }
}