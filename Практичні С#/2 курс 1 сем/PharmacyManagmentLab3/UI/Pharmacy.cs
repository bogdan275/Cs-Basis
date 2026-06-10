using Data.Context;
using Repositories.Extentions;
using Repositories.ForModels;
using Services;

namespace UI
{
    public partial class Pharmacy : Form
    {
        private readonly PharmacyContext _context;


        public Pharmacy()
        {
            InitializeComponent();
            _context = new PharmacyContext();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var repo = new ActiveIngredientRepository(_context);
            var service = new ActiveIngredientService(repo);
            //var form = new ActiveIngredientForm(service);
            //form.ShowDialog();
        }

        private void buttonBatch_Click(object sender, EventArgs e)
        {
            var batchRepo = new BatchRepository(_context);
            var medRepo = new MedicineRepository(_context);
            var orderRepo = new PurchaseOrderRepository(_context);
            var fridgeRepo = new RefrigeratorRepository(_context);
            var service = new Services.BatchService(batchRepo, medRepo, orderRepo, fridgeRepo);
            var form = new BatchForm(service);
            form.ShowDialog();
        }

        private void buttonBrand_Click(object sender, EventArgs e)
        {
            var brandRepo = new BrandRepository(_context);
            var service = new BrandService(brandRepo);
            var form = new BrandForm(service);
            form.ShowDialog();
        }

        private void buttonMedicine_Click(object sender, EventArgs e)
        {
            var medRepo = new MedicineRepository(_context);
            var brandRepo = new BrandRepository(_context);
            var ingRepo = new ActiveIngredientRepository(_context);
            var service = new Services.MedicineService(medRepo, brandRepo, ingRepo);
            var form = new MedicineForm(service);
            form.ShowDialog();
        }

        private void buttonPurchaseOrder_Click(object sender, EventArgs e)
        {
            var orderRepo = new PurchaseOrderRepository(_context);
            var supplierRepo = new SupplierRepository(_context);
            var service = new Services.PurchaseOrderService(orderRepo, supplierRepo);
            var form = new PurchaseOrderForm(service);
            form.ShowDialog();
        }

        private void buttonPurchaseOrderItem_Click(object sender, EventArgs e)
        {
            var itemRepo = new PurchaseOrderItemRepository(_context);
            var orderRepo = new PurchaseOrderRepository(_context);
            var medRepo = new MedicineRepository(_context);

            var service = new Services.PurchaseOrderItemService(itemRepo, orderRepo, medRepo);
            var form = new PurchaseOrderItemForm(service);

            form.ShowDialog();
        }

        private void buttonRecipe_Click(object sender, EventArgs e)
        {
            var recipeRepo = new RecipeRepository(_context);
            var medRepo = new MedicineRepository(_context);

            var service = new Services.RecipeService(recipeRepo, medRepo);
            var form = new RecipeForm(service);

            form.ShowDialog();
        }

        private void buttonRefrigerator_Click(object sender, EventArgs e)
        {
            var repo = new RefrigeratorRepository(_context);
            var service = new Services.RefrigeratorService(repo);
            var form = new RefrigeratorForm(service);

            form.ShowDialog();
        }

        private void buttonLogs_Click(object sender, EventArgs e)
        {
            var logRepo = new RefrigeratorLogRepository(_context);
            var fridgeRepo = new RefrigeratorRepository(_context);

            var service = new Services.RefrigeratorLogService(logRepo, fridgeRepo);
            var form = new RefrigeratorLogForm(service);

            form.ShowDialog();
        }

        private void buttonReturnPolicy_Click(object sender, EventArgs e)
        {
            var policyRepo = new ReturnPolicyRepository(_context);
            var saleRepo = new SaleRepository(_context);

            var service = new Services.ReturnPolicyService(policyRepo, saleRepo);
            var form = new ReturnPolicyForm(service);

            form.ShowDialog();
        }

        private void buttonSale_Click(object sender, EventArgs e)
        {
            var saleRepo = new SaleRepository(_context);
            var medicineRepo = new MedicineRepository(_context);
            var batchRepo = new BatchRepository(_context);

            var service = new Services.SaleService(saleRepo, medicineRepo, batchRepo);
            var form = new SaleForm(service);

            form.ShowDialog();
        }

        private void buttonShelf_Click(object sender, EventArgs e)
        {
            var repo = new ShelfRepository(_context);
            var service = new Services.ShelfService(repo);
            var form = new ShelfForm(service);

            form.ShowDialog();
        }

        private void buttonShelfItem_Click(object sender, EventArgs e)
        {
            var shelfItemRepo = new ShelfItemReposytory(_context);
            var medicineRepo = new MedicineRepository(_context);
            var shelfRepo = new ShelfRepository(_context);

            var service = new Services.ShelfItemService(shelfItemRepo, medicineRepo, shelfRepo);
            var form = new ShelfItemForm(service);

            form.ShowDialog();
        }

        private void buttonSupplier_Click(object sender, EventArgs e)
        {
            var repo = new SupplierRepository(_context);
            var service = new Services.SupplierService(repo);
            var form = new SupplierForm(service);

            form.ShowDialog();
        }
    }
}
