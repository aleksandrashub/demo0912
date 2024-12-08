using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using demo0312.Models;
using System.Linq;

namespace demo0312;

public partial class Reg : Window
{
    public Reg()
    {
        InitializeComponent();
    }

    private void Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        User user = new User();
        if (Helper.context.Users.Count() > 0)
        {
            user.IdUser = Helper.context.Users.OrderBy(x => x.IdUser).Last().IdUser + 1;
        }
        else
        {
            user.IdUser = 0;
        }
        user.Mail = mail.Text;
        user.Login = login.Text;
        user.Passwd = passwd.Text;
        Helper.context.Users.Add(user);
        Helper.context.SaveChanges();

        MainWindow mainW = new MainWindow();
        mainW.Show();
        this.Close();

    }

    private void vyhod_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {

        MainWindow main = new MainWindow();
        main.Show();
        this.Close();

    }
}