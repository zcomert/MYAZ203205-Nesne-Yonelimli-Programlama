using System.Collections;

public class Library : IEnumerable
{
    private List<LibraryItem> libraryItems;

    public Library()
    {
        libraryItems = new List<LibraryItem>();
    }

    public void CreateBook(LibraryItem item)
    {
        item.SetAvailability(true);
        libraryItems.Add(item);
    }

    public void GiveBook(int id)
    {
        // LINQ
        libraryItems.Where(book => book.Id.Equals(id)).First().Borrow();

        // for (int i = 0; i < libraryItems.Count; i++)
        // {
        //     if (libraryItems[i].Id.Equals(id))
        //     {
        //         libraryItems[i].Borrow();
        //     }
        // }
    }

    public void TakeBook(int id)
    {
        libraryItems.Where(book => book.Id.Equals(id)).First().Return();
        // for (int i = 0; i < libraryItems.Count; i++)
        // {
        //     if (libraryItems[i].Id.Equals(id))
        //     {
        //         libraryItems[i].Return();
        //     }
        // }
    }

    public List<LibraryItem> GetAllBooks()
    {
        return libraryItems;
    }
    public List<LibraryItem> GetAvailableBooks()
    {
        return libraryItems.Where(book => book.IsAvailable.Equals(true)).ToList();
    }

    public void DeleteBook(int id)
    {
        var result = libraryItems.Where(book => book.Id.Equals(id)).First();
        libraryItems.Remove(result);
        System.Console.WriteLine(result.ToString());
    }

    public IEnumerator GetEnumerator()
    {
        return libraryItems.GetEnumerator();
    }
}