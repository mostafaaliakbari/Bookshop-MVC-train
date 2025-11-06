
public interface ICategoryService
{
    public List<Category> GetCategories();
    public void Create(string title);
    public void Delete(int id);
    public void Update(Category category);
    public Category GetCategory(int id);

}

