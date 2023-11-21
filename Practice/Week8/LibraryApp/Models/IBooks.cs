public interface IBooks : IComparable<LibraryItem>
{
    public int Id { get; set; }
    public string Title { get; set; }
    public Authors Author { get; set; }
    public DateTime PublishYear { get; set; }
    public bool IsAvailable { get; set; }

    public void SetAvailability(bool available);
}
