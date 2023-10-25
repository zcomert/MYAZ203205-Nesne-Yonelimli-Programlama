class TodoItem
{
    // Property
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }
    public bool IsComplete { get; set; }

    // Constructor
    public TodoItem()
    {
        IsComplete = false;
    }

    public TodoItem(int Id, string Title, string Description, DateTime DueDate)
    {
        this.Id = Id;
        this.Title = Title;
        this.Description = Description;
        this.DueDate = DueDate;
    }

    // Methods
    public override string ToString()
    {
        return $"{Id} {Title} {Description} {DueDate} {IsComplete}";
    }
}