Library library = new Library();
Authors author = new Authors();
author.Id = 0;
author.FirstName = "Name";
author.LastName = "SurName";

LibraryItem library1 = new LibraryItem(0, "Title 1", author, DateTime.Now, true);
LibraryItem library2 = new LibraryItem(1, "Title 2", author, DateTime.Now, true);
LibraryItem library3 = new LibraryItem(2, "Title 3", author, DateTime.Now, true);
LibraryItem library4 = new LibraryItem(3, "Title 4", author, DateTime.Now, true);
LibraryItem library5 = new LibraryItem(4, "Title 5", author, DateTime.Now, true);

library.CreateBook(library1);
library.CreateBook(library2);
library.CreateBook(library3);
library.CreateBook(library4);
library.CreateBook(library5);

library.GiveBook(1);
foreach (var item in library.GetAvailableBooks())
{
    System.Console.WriteLine(item.ToString());
}
library.GiveBook(1);
library.TakeBook(1);
foreach (var item in library.GetAvailableBooks())
{
    System.Console.WriteLine(item.ToString());
}