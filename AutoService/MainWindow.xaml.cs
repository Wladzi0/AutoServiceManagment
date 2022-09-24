using ApiLibrary;
using AutoService.DataBase;
using AutoService.Person;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows;

namespace AutoService
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<UserModel> people = new List<UserModel>();
        public MainWindow()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();
            //UserHelper.InitializeUsers();


        }
        public void LoadVhicleApi_Click(object sender, RoutedEventArgs e)
        {
            ApiProcessor.LoadBasicCarContent(DataField);
        }

        private void DataBaseConnetionButton_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection bdConection = DBConnectionHelper.InitializeDBConnection();

            UploadDataProcces.uploadeAllPeopleFromDB(bdConection, DataField);

        }
    }
}
