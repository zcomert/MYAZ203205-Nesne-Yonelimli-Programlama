TodoList todoList = new TodoList(new List<TodoItem>(){
    new TodoItem(){
        Id = 0,
        Title= "Todo 1",
        Description = "Dont forget!",
        DueDate = DateTime.Now
    },
    new ImportantItem(1){
        Id = 1,
        Title= "Important 1",
        Description = "Do this!",
        DueDate = DateTime.Now
    },
    new UrgentItem(true, 2){
        Id = 2,
        Title= "Urgent 1",
        Description = "Do this!",
        DueDate = DateTime.Now
    }
});

foreach (var item in todoList.GetDueItems(DateTime.Now.AddDays(1)))
{
    System.Console.WriteLine(item.ToString());
}