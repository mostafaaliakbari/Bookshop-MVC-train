

using Microsoft.EntityFrameworkCore;
using UI_MVC.Inferastructure;

public class CategoryRepo : ICategoryRepo
{
    private readonly ApplicationDbContext context;

    public CategoryRepo()
    {
        context = new ApplicationDbContext();
    }
    public List<Category> GetCategories()
    {
        return context.Categories.ToList();
    }
    public void Create(string title)
    {
        context.Categories.Add(new Category { Name = title });
        context.SaveChanges();
    }
    public void Delete(int id)
    {
        context.Categories.Where(x => x.Id == id).ExecuteDelete();
    }

    public void Update(Category category)
    {
        context.Update(category);
        context.SaveChanges();
    }

    public Category GetById(int id)
    {
        return context.Categories.Find(id);
    }
}

