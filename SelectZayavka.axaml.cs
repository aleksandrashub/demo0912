using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media.Imaging;
using System;

namespace demo0312;

public partial class SelectZayavka : Window
{
    public SelectZayavka()
    {
        InitializeComponent();
        group.Source = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "Assets\\grouppovoe.png");
        lich.Source =new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "Assets\\lichn.png"); 
    }

    private void lich_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        Zayavka z = new Zayavka();
        z.Show();
        this.Close();
    }

    private void group_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        GroupZayavka z = new GroupZayavka();
        z.Show();
        this.Close();

    }
}