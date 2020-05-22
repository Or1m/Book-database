using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektPJ2
{
    public partial class mainForm : Form
    {
        bool _title = false;
        bool _author = false;
        bool _edit = false;

        MyList<Book> _myList;
        ReaderWriter _readerWriter;

        public mainForm()
        {
            InitializeComponent();
            Load += new EventHandler(MainForm_Load);
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            _myList = new MyList<Book>();
            _readerWriter = new ReaderWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"test.xml"), _myList);

            _readerWriter.ReadFromXML();
            
            foreach (Book item in _myList)
            {
                if (item != null)
                    mainList.Items.Add(new ListViewItem(item.ToArr()));
            }
        }

        private void ButtAddBook_Click(object sender, EventArgs e)
        {
            panelAdd.Visible = !panelAdd.Visible;
            _edit = false;

            if (panelAdd.Visible)
                buttAddBook.Text = "Hide";
            else
            {
                buttAddBook.Text = "Add book";
                ClearPanel();
            }

            if (!_edit)
                buttonAdd.Text = "Add";
        }

        private void RefreshList()
        {
            mainList.Items.Clear();
            foreach (Book item in _myList)
            {
                if (item != null)
                    mainList.Items.Add(new ListViewItem(item.ToArr()));
            }
        }

        private void TitleBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (!(String.IsNullOrEmpty(titleBox.Text) || String.IsNullOrWhiteSpace(titleBox.Text)))
            {
                _title = true;
            }
            else
            {
                _title = false;
            }

            buttonAdd.Enabled = _title && _author;
        }

        private void AuthorBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (!(String.IsNullOrEmpty(authorBox.Text) || String.IsNullOrWhiteSpace(authorBox.Text)))
            {
                _author = true;
            }
            else
            {
                _author = false;
            }

            buttonAdd.Enabled = _title && _author;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if(buttonAdd.Text == "Add")
            {
                Book book = new Book(maxId() + 1, titleBox.Text, authorBox.Text, getNumOfPages(), getValFromCombo());
                _myList.Add(book);
            }
            else
            {
                int idx = findIdx();
                Book book = new Book(_myList.Get(idx).ID, titleBox.Text, authorBox.Text, getNumOfPages(), getValFromCombo());
                _myList.Add(book, idx);
            }

            RefreshList();
            ClearPanel();
        }

        private void ClearPanel()
        {
            titleBox.Text = String.Empty;
            authorBox.Text = String.Empty;
            numBox.Text = String.Empty;
            bestBox.Text = String.Empty;

            buttonAdd.Enabled = _author = _title = false;
        }

        private bool? getValFromCombo()
        {
            bool? temp;
            switch (bestBox.SelectedIndex)
            {
                case 0:
                    temp = true;
                    break;
                case 1:
                    temp = false;
                    break;
                default:
                    temp = null;
                    break;
            }

            return temp;
        }

        private int? getNumOfPages()
        {
            int x = 0;
            bool test = Int32.TryParse(numBox.Text, out x);
            if (test)
                return x;
            return null;
        }

        private int maxId()
        {
            int tmp = 0;
            foreach (Book item in _myList)
            {
                if (item != null && item.ID > tmp)
                    tmp = item.ID;
            }

            return tmp;
        }

        private void ButtRemove_Click(object sender, EventArgs e)
        {
            _myList.Remove(findIdx());
            RefreshList();
        }

        private int findIdx()
        {
            int id = Int32.Parse(mainList.SelectedItems[0].SubItems[0].Text);

            int idx = 0;
            foreach (Book item in _myList)
            {
                if (item != null && item.ID == id)
                    break;
                idx++;
            }

            return idx;
        }

        private void MainList_MouseMove(object sender, MouseEventArgs e)
        {
            if (mainList.SelectedItems.Count == 1)
            {
                buttRemove.Enabled = true;
                buttEdit.Enabled = true;
            }
            else
            {
                buttRemove.Enabled = false;
                buttEdit.Enabled = false;
            }
        }

        private void ButtEdit_Click(object sender, EventArgs e)
        {
            panelAdd.Visible = !panelAdd.Visible;
            _edit = true;

            if (panelAdd.Visible)
            {
                buttEdit.Text = "Hide";
                buttonAdd.Text = "Edit";
            }
            else
            {
                buttEdit.Text = "Edit book";
                ClearPanel();
            }

            if (_edit)
                buttonAdd.Text = "Edit";

            if(mainList.SelectedItems.Count == 1)
            {
                titleBox.Text = mainList.SelectedItems[0].SubItems[1].Text;
                authorBox.Text = mainList.SelectedItems[0].SubItems[2].Text;
                numBox.Text = mainList.SelectedItems[0].SubItems[3].Text;

                buttonAdd.Enabled = true;
            }
        }

        private void ButtSave_Click(object sender, EventArgs e)
        {
            _readerWriter.WriteToXML();
        }
    }
}