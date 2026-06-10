using Services;

namespace UI
{
    public partial class Form1 : Form
    {
        private readonly ServiceManager _manager;
        public Form1()
        {
            InitializeComponent();

            _manager = new ServiceManager();
            UpdateDashboard();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UpdateDashboard()
        {
            var clientsCount = _manager.ClientService.GetAll().Count();
            var productsCount = _manager.ProductService.GetAll().Count();
            var tariffsCount = _manager.TariffPlanService.GetAll().Count();

            labelClientsStat.Text = $"Active Clients: {clientsCount}";
            labelProductsStat.Text = $"Registered Products: {productsCount}";
            labelTariffsStat.Text = $"Tariff Plans: {tariffsCount}";

            var stockItems = _manager.InventoryItemService.GetAll().ToList();

            var totalItemsCount = stockItems.Sum(x => x.Quantity);
            var occupiedBins = stockItems.Select(x => x.StorageBinId).Distinct().Count();
            var totalBins = _manager.StorageBinService.GetAll().Count();

            labelTotalStock.Text = $"Total Items stored: {totalItemsCount}";
            labelOccupancy.Text = $"Bins Occupied: {occupiedBins} / {totalBins}";

            var lastMove = _manager.StockMovementService.GetAll().FirstOrDefault();

            if (lastMove != null)
            {
                var prodName = lastMove.Product?.Name ?? "Unknown Product";
                labelLastActivity.Text = $"Last: {lastMove.Type} - {prodName} ({lastMove.Quantity} pcs) at {lastMove.MovementDate:g}";
            }
            else
            {
                labelLastActivity.Text = "No activity yet.";
            }

            var bills = _manager.BillingRecordService.GetAll().ToList();
            var totalRevenue = bills.Sum(x => x.TotalAmount);
            var billsCount = bills.Count();

            labelRevenue.Text = $"Total Revenue: ${totalRevenue}";
            labelInvoices.Text = $"Invoices Generated: {billsCount}";
        }

        private void buttonClients_Click(object sender, EventArgs e)
        {
            var dirForm = new ClientForm(_manager);
            dirForm.ShowDialog();
            UpdateDashboard();
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            var productForm = new ProductForm(_manager);
            productForm.ShowDialog();
            UpdateDashboard();
        }

        private void buttonTariffs_Click(object sender, EventArgs e)
        {
            var tariffForm = new TariffForm(_manager);
            tariffForm.ShowDialog();
            UpdateDashboard();
        }

        //----------------------------------------------------------------

        private void buttonWarehouses_Click(object sender, EventArgs e)
        {
            var warForm = new WarehouseForm(_manager);
            warForm.ShowDialog();
            UpdateDashboard();

        }

        private void buttonZones_Click(object sender, EventArgs e)
        {
            var zoneForm = new ZoneForm(_manager);
            zoneForm.ShowDialog();
            UpdateDashboard();

        }

        private void buttonBins_Click(object sender, EventArgs e)
        {
            var binForm = new BinForm(_manager);
            binForm.ShowDialog();
            UpdateDashboard();

        }
        // ---------------------------------------------------------------------

        private void buttonBilling_Click(object sender, EventArgs e)
        {
            var billForm = new BillingForm(_manager);
            billForm.ShowDialog();
            UpdateDashboard();
        }

        private void buttonInfrastructure_Click(object sender, EventArgs e)
        {
            var stockMoveForm = new StockMoveForm(_manager);
            stockMoveForm.ShowDialog();
            UpdateDashboard();
        }


    }
}
