namespace NET.M._0011.Exercise1
{
    public class Book
    {
        public string BookName { get; set; }
        public string ISBN { get; set; }
        public string AthurName { get; set; }
        public string Publisher { get; set; }
        public Book() { }
        public Book(string bookName, string iSBN, string athurName, string publisher)
        {
            this.BookName = bookName;
            this.ISBN = iSBN;
            this.AthurName = athurName;
            this.Publisher = publisher;
        }

        public string ShowInformationBook()
        {
            Console.WriteLine("---Book Information---");
            return "BookName: " + BookName + "\n" + "ISBN: " + ISBN + "\n" + "AthurName: " + AthurName + "\n" + "Publisher: " + Publisher;
        }
    }
}
