using Avalonia.Animation;
using Avalonia.Controls;
using Avalonia.Media.Transformation;
using Avalonia.Media;
using Avalonia.Styling;
using System;

namespace AvaloniaApplicationIraVerstkaSite
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new Style(x => x.OfType<StackPanel>().Child().OfType<Button>());
        }
    }
}