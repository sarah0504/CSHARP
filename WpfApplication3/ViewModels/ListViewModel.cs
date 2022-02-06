using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication3.Views;

namespace WpfApplication3.ViewModels
{
    class ListViewModel
    {
        public Window1 myview;
        public ReplaceCommand addListCommand { get; set; }
        public ReplaceCommand mapBISWinCommand { get; set; }
        public  ListViewModel(Window1 view)
            {
            myview = view;
            addListCommand = new ReplaceCommand();
            mapBISWinCommand = new ReplaceCommand();
            mapBISWinCommand.ReplaceUserControl += mapwindow;
            addListCommand.ReplaceUserControl += addList;
           }
        private void addList(string obj)
        {
            //la liste des clients selectionnes on la mets dans la liste que ya dans adddisviewmodel 
            myview.addDisViewModel.clientlistrecupered = myview.listSelectedClients;

            this.myview.Close();
        }
        private void mapwindow(string obj)
        {
            myview.page.Content = new MapsUserControlxaml();
        }

    }
}
