using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RootDesign
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<string> CourseName = new List<string>();
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.db))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "select CourseName from Course";
                
                SqlDataReader reader1;
                reader1 = cmd.ExecuteReader();
                while (reader1.Read())
                {
                    CourseName.Add(reader1.GetString(0));
                }
                reader1.Close();
                con.Close();
            }
            Course.ItemsSource = CourseName;
        }

        private void Course_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var CurrentItem = Course.SelectedItem;
            BatchInsertion(CurrentItem.ToString());
        }

        private void StackPanel_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Do You Want to Add New Batch ?");
            var CurrentItem = Course.SelectedItem;
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.db))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "insert into BatchDetails(CourseName,NoOfStudents)values('"+CurrentItem+"',0)";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            BatchInsertion(CurrentItem.ToString());
            MessageBox.Show("Batch Added Successfully");
          
        }

        public void BatchInsertion(string SelectedItem)
        {
            var check = SelectedItem;
            List<string> BatchId = new List<string>();
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.db))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "select top(1) BatchId,NoOfStudents from BatchDetails where CourseName = '" + check + "' order by BatchId desc";

                SqlDataReader reader1;
                reader1 = cmd.ExecuteReader();
                while (reader1.Read())
                {
                    BatchId.Add("Batch " + Convert.ToString(reader1.GetInt32(0)) + ": NoOfStudents " + Convert.ToString(reader1.GetInt32(1)));
                }
                reader1.Close();
                con.Close();
            }
            Batch.ItemsSource = BatchId;
            Batch.SelectedIndex = 0;
        }

        private void StudentName_SelectionChanged(object sender, RoutedEventArgs e)
        {
            UserName.Text.Insert(0, StudentName.Text);
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            List<string> UserNameFromDB = new List<string>();
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.db))
            {
                SqlCommand Commend = new SqlCommand();
                Commend.Connection = con;
                con.Open();
                Commend.CommandText = "select top(1) UserName from StudentDetails where Name = '" + StudentName.Text + "'order by UserName desc ";
                SqlDataReader reader1;
                reader1 = Commend.ExecuteReader();
                string lastUsername= "";
                while(reader1.Read())
                {
                    lastUsername = reader1.GetString(0);
                }
                reader1.Close();
                string _currentUserName = StudentName.Text + "@Root";
                char check = lastUsername[lastUsername.Length - 6];
                if(char.IsDigit(check))
                {
                    check++;
                    _currentUserName = StudentName.Text + check + "@Root";
                }
                else
                {
                    _currentUserName = StudentName.Text + "1" + "@Root";
                }
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                string[] B = Batch.SelectedItem.ToString().Split(':');
                cmd.CommandText = "insert into StudentDetails values('"+UserName.Text+"','"+B[0]+"','"+Course.SelectedItem.ToString()+"','"+_currentUserName+"','"+Password.Text+"')";
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
