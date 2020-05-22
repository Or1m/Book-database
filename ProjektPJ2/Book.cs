using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektPJ2
{
    class Book
    {
        private int _id;
        private string _title;
        private string _author;
        private int? _numOfPages;
        private bool? _isBestSeller;

        public Book(int id, string title, string author, int? numOfPages, bool? isBestseller)
        {
            _id = id;
            _title = title;
            _author = author;
            _numOfPages = numOfPages;
            _isBestSeller = isBestseller;
        }

        public Book() {}

        public int ID { get => _id; set => _id = value; }
        public string Title { get => _title; set => _title = value; }
        public string Author { get => _author; set => _author = value; }
        public int? NumOfPages { get => _numOfPages; set => _numOfPages = value; }
        public bool? IsBestSeller { get => _isBestSeller; set => _isBestSeller = value; }

        public string[] ToArr()
        {
            return new string[] { _id.ToString(), _title, _author, _numOfPages.ToString(), _isBestSeller.ToString()};
        }
    }
}
