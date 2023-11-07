using System.Diagnostics;

public class TodoList
{
    private List<TodoItem> items;

    public TodoList()
    {
        items = new List<TodoItem>();
    }

    public TodoList(List<TodoItem> list) : this()
    {
        foreach (var item in list)
        {
            AddItem(item);
        }
    }

    public void AddItem(TodoItem todoItem)
    {
        items.Add(todoItem);
    }

    public void RemoveItem(int id)
    {
        var item = items.Where(item => item.Id.Equals(id)).SingleOrDefault();
        if (item != null)
        {
            items.Remove(item);
        }
    }

    public void MarkComplete(int id)
    {
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i].Id.Equals(id))
            {
                items[i].IsComplete = true;
            }
        }
    }

    public List<TodoItem> GetDueItems(DateTime date){
        return items.Where(item => item.DueDate < date).ToList();
    }

    public List<TodoItem> GetItems(){
        return items;
    }

    public TodoItem GetOneItem(int id){
        return items.Where(item=>item.Id==id).SingleOrDefault();
    }

    public void DisplayTask()
    {
        foreach (var item in items)
        {
            System.Console.WriteLine(item.ToString());
        }
    }
}