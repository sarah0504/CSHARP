using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfApplication3.Views;

namespace WpfApplication3.ViewModels
{
    class PdfViewModel
    {
        private Window2 myview;
        public ReplaceCommand pdfcomm { get; set; }

        public PdfViewModel(Window2 window2)
        {
            this.myview = window2;
            pdfcomm = new ReplaceCommand();
            pdfcomm.ReplaceUserControl += printpdf;
        }

        public void printpdf(string obj)
        {
            try
            {
                myview.IsEnabled = false;
                PrintDialog printDialog = new PrintDialog();
                if (printDialog.ShowDialog() == true)
                {
                    printDialog.PrintVisual(myview.print, "Invoice");
                }
                reset();
            }
            finally
            { myview.IsEnabled = true; }
        }
        private void reset()
        {
            myview.lol.SelectedIndex = -1;
            myview.name.Clear();
            myview.tel.Clear();
            myview.lolita.Content = null;
            myview.mail.Clear();
        }
    }
}

 
