using Microsoft.AspNetCore.Mvc;
using MvcIntroApp.Models; // Підключаємо нашу модель

namespace MvcIntroApp.Controllers
{
    public class ProductsController : Controller
    {
        // Статичний список, щоб дані зберігалися між запитами
        private static List<Product> products = new()
        {
            new Product { Id = 1, Name = "Laptop", Price = 35000, Category = "Electronics" },
            new Product { Id = 2, Name = "Phone", Price = 18000, Category = "Electronics" }
        };

        // 1. Головна сторінка зі списком товарів
        public IActionResult Index()
        {
            return View(products); // Передаємо список у View
        }

        // 2. GET: Показати форму створення
        public IActionResult Create()
        {
            return View(new Product());
        }

        // 3. POST: Отримати дані з форми та зберегти
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product product)
        {
            if (!ModelState.IsValid) return View(product); // Якщо є помилки, повертаємо форму

            product.Id = products.Count == 0 ? 1 : products.Max(p => p.Id) + 1;
            products.Add(product);
            return RedirectToAction("Index"); // Після збереження йдемо на список
        }

        // --- РЕДАГУВАННЯ ---

        // 1. GET: Edit (Знайти продукт і показати форму)
        public IActionResult Edit(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null) return NotFound();

            return View(product);
        }

        // 2. POST: Edit (Оновити дані в списку)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Product product)
        {
            if (!ModelState.IsValid) return View(product);

            var existing = products.FirstOrDefault(p => p.Id == product.Id);
            if (existing == null) return NotFound();

            // Оновлюємо поля об'єкта
            existing.Name = product.Name;
            existing.Price = product.Price;
            existing.Category = product.Category;

            return RedirectToAction("Index");
        }

        // --- ВИДАЛЕННЯ ---

        // 3. GET: Delete (Показати сторінку підтвердження)
        public IActionResult Delete(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null) return NotFound();

            return View(product);
        }

        // 4. POST: Delete (Видалити після підтвердження)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection) // Додали collection, щоб сигнатура методу відрізнялася від GET
        {
            var existing = products.FirstOrDefault(p => p.Id == id);
            if (existing != null)
            {
                products.Remove(existing);
            }
            return RedirectToAction("Index");
        }
    }
}