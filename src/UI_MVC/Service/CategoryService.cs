

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepo repo;
    public CategoryService()
    {
        repo = new CategoryRepo();
    }
    public void Create(string title)
    {
       repo.Create(title);
    }

    public void Delete(int id)
    {
       repo.Delete(id);
    }

    public List<Category> GetCategories()
    {
        return repo.GetCategories();
    }

    public Category GetCategory(int id)
    {
        return repo.GetById(id);
    }

    public void Update(Category category)
    {
        repo.Update(category);
    }
}

