﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace cafe_management.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public ICommand StaffCommand { get; set; }
        public ICommand MenuCommand { get; set; }

        private StaffWindow staffWindow;
        private MenuWindow menuWindow;
        public MainViewModel()
        {

            StaffCommand = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                if (staffWindow == null)
                {
                    staffWindow = new StaffWindow();
                }
                menuWindow?.Hide();
                staffWindow.ShowDialog();
            });

            MenuCommand = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                menuWindow = new MenuWindow();
                staffWindow.Hide();
                menuWindow.ShowDialog();
            });
        }
    }
}
