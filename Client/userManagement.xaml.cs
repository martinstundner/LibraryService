﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Client
{
    /// <summary>
    /// Interaktionslogik für userManagement.xaml
    /// </summary>
    public partial class userManagement : Window, ServiceReference1.IAktienInfoCallback
    {
        public DataSet users;
        public userManagement()
        {
            InitializeComponent();
        }

        public void loginUser(int status)
        {
            
        }
        public void UpdateUsers(DataSet ds)
        {
            dataGrid.ItemsSource = users.Tables["LoadUsers"].DefaultView;
            dataGrid.Columns[0].Header = "ID";
            dataGrid.Columns[1].Header = "Benutzername";
            dataGrid.Columns[2].Header = "Vorname";
            dataGrid.Columns[3].Header = "Nachname";
            dataGrid.Columns[4].Visibility = Visibility.Hidden;
            dataGrid.Columns[5].Header = "Registriert seit";
            dataGrid.Columns[6].Header = "Verifiziert";
            dataGrid.Columns[7].Header = "Verizifziert Seit";
            dataGrid.Columns[8].Header = "Stadt";
            dataGrid.Columns[9].Header = "PLZ";
            dataGrid.Columns[10].Header = "Adresse";
            dataGrid.Columns[11].Header = "Klasse";
            dataGrid.Columns[12].Header = "Gesperrt";

        }
        public void BookUpdate(string x, double test, DataSet ds)
        {
            
        }
        public void loadBooks(DataSet ds)
        {
        }
    }
}