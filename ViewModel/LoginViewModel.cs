﻿using MaterialDesignThemes.Wpf;
using Microsoft.Identity.Client.NativeInterop;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPF_Market.Model;
using WPF_Market.Models;
using WPF_Market.View;
namespace WPF_Market.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        private Acccount userAccount = new Acccount();
        public LoginViewModel()
        {
            LoginCommand = new BaseViewModelCommand(ExecuteLoginCommand, CanExecuteLoginCommand);
            CloseCommand = new BaseViewModelCommand(ExecuteCloseCommand);
        }

        private void ExecuteCloseCommand(object obj)
        {
            Application.Current.Shutdown();
        }

        private bool CanExecuteLoginCommand(object obj)
        {
            if (Password is null || UserName is null)
                return false;
            return true;
        }

        private void ExecuteLoginCommand(object obj)
        {
            var ValidAccount = DataProvider.Instance.DB.Accounts.Where(p => p.UserName == UserAccount.UserName 
            && p.Password == SecureStringProcess.ConvertToUnsecureString(UserAccount.Password)).Count();
            if (ValidAccount > 0)
            {
                new Custom_mb("Welcome back, " + UserName, Custom_mb.MessageType.Success, Custom_mb.MessageButtons.Ok).ShowDialog();
                new Main_Board().Show();
                var currentWindow  = obj as Window;
                currentWindow.Close();
            }
            else
            {
                new Custom_mb("Your account does not exist!", Custom_mb.MessageType.Warning, Custom_mb.MessageButtons.Ok).ShowDialog();
            }
        }
        public Acccount UserAccount
        {
            get { return userAccount; }
            set
            {
                userAccount = value;
                OnPropertyChanged(nameof(UserAccount));
            }
        }
        public string UserName
        {
            get { return UserAccount?.UserName; }
            set
            {
                UserAccount.UserName = value;
                OnPropertyChanged(nameof(UserName));
            }
        }
        public SecureString Password
        {
            get { return UserAccount?.Password; }
            set
            {
                UserAccount.Password = value;
                OnPropertyChanged(nameof(Password));
            }
        }
        public ICommand LoginCommand { get; }
        public ICommand CloseCommand { get; }
    }
}
