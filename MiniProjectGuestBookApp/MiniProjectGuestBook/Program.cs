

using MiniProjectGuestBook;


List<string> allNames = GuestBook.NameOfParty();
List<int> totalNumOfGuest = GuestBook.SizeOfParty();
GuestBook.IsPartyOver(allNames, totalNumOfGuest);
GuestBook.ShowGuestBook(allNames, totalNumOfGuest);