using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using demo0312.Models;
using System.Collections.Generic;
using System.Linq;

namespace demo0312;

public partial class GroupZayavka : Window
{

    public List<string> podrazd = Helper.context.Departments.Select(x => x.Dep).ToList();

    public List<string> aims = Helper.context.Purposes.Select(x => x.Purpose1).ToList();
    public GroupZayavka()
    {
        InitializeComponent();
        aimCB.ItemsSource = aims;
        podrCB.ItemsSource = podrazd;
    }

    private void AddFile_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
    }

    private void Ok_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {


    }

    private void vyhod_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {


    }
}