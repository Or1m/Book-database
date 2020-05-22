using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProjektPJ2
{
    class ReaderWriter
    {
        private string _fileName;
        private MyList<Book> _myList;

        public ReaderWriter(string fileName, MyList<Book> myList)
        {
            _fileName = fileName;
            _myList = myList;
        }

        public void WriteToXML()
        {
            try
            {
                XmlTextWriter writer = new XmlTextWriter(_fileName, null);
                writer.WriteStartElement("Books");
                foreach (Book book in _myList)
                {
                    if(book != null)
                    {
                        writer.WriteStartElement("Book");
                        writer.WriteElementString("id", book.ID.ToString());
                        writer.WriteElementString("title", book.Title);
                        writer.WriteElementString("author", book.Author);
                        writer.WriteElementString("numOfPages", book.NumOfPages.ToString());
                        writer.WriteElementString("isBestSeller", book.IsBestSeller.ToString());
                        writer.WriteEndElement();
                    }
                }
                writer.WriteEndElement();
                writer.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
        public void ReadFromXML()
        {
            int x = 0;
            bool y = false;
            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(_fileName);
                foreach (XmlNode node in xmlDocument.DocumentElement.ChildNodes)
                {
                    Book book = new Book();
                    foreach (XmlNode innernode in node)
                    {
                        switch (innernode.Name)
                        {
                            case "id":
                                book.ID = int.Parse(innernode.InnerText);
                                break;
                            case "title":
                                book.Title = innernode.InnerText;
                                break;
                            case "author":
                                book.Author = innernode.InnerText;
                                break;
                            case "numOfPages":
                                if (int.TryParse(innernode.InnerText, out x))
                                    book.NumOfPages = x;
                                else
                                    book.NumOfPages = null;
                                break;
                            case "isBestSeller":
                                if (bool.TryParse(innernode.InnerText, out y))
                                    book.IsBestSeller = y;
                                else
                                    book.IsBestSeller = null;
                                break;
                        }
                    }
                    _myList.Add(book);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
