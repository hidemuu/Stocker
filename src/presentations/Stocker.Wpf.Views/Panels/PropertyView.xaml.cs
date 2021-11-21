using System;
using System.Collections.Generic;
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

namespace Stocker.Wpf.Views.Panels
{
    /// <summary>
    /// PropertyView.xaml の相互作用ロジック
    /// </summary>
    public partial class PropertyView : UserControl
    {
        public PropertyView()
        {
            InitializeComponent();

            var stackPanel = new StackPanel();

            var expander = new Expander
            {
                HeaderTemplate = MakeTemplate(true),
                Content = MakeContent(),
            };

            stackPanel.Children.Add(expander);

            var expander2 = new Expander
            {
                HeaderTemplate = MakeTemplate(false),
                Content = MakeContent(),
            };

            stackPanel.Children.Add(expander2);

            this.Content = stackPanel;

        }

        private DataTemplate MakeTemplate(bool isUseTool)
        {
            DataTemplate template = new DataTemplate();

            var gridFactory = new FrameworkElementFactory(typeof(Grid));
            var col1Factory = new FrameworkElementFactory(typeof(ColumnDefinition));
            var col2Factory = new FrameworkElementFactory(typeof(ColumnDefinition));
            col1Factory.SetValue(ColumnDefinition.WidthProperty, new GridLength(1, GridUnitType.Star));
            col2Factory.SetValue(ColumnDefinition.WidthProperty, new GridLength(30, GridUnitType.Pixel));
            gridFactory.AppendChild(col1Factory);
            gridFactory.AppendChild(col2Factory);

            //var checkBoxFactory = new FrameworkElementFactory(typeof(CheckBox));
            //checkBoxFactory.SetValue(Grid.ColumnProperty, 0);
            //checkBoxFactory.SetValue(FrameworkElement.VerticalAlignmentProperty, VerticalAlignment.Center);

            var textBlockFactory = new FrameworkElementFactory(typeof(TextBlock));
            textBlockFactory.SetValue(Grid.ColumnProperty, 0);
            textBlockFactory.SetValue(FrameworkElement.VerticalAlignmentProperty, VerticalAlignment.Center);
            textBlockFactory.SetValue(TextBlock.TextProperty, "Test                    ");

            var toolBarFactory = new FrameworkElementFactory(typeof(ToolBar));
            toolBarFactory.SetValue(Grid.ColumnProperty, 1);
            toolBarFactory.SetValue(FrameworkElement.VerticalAlignmentProperty, VerticalAlignment.Center);
            toolBarFactory.SetValue(ToolBar.ItemsSourceProperty, new List<CheckBox>
            { 
                new CheckBox{ Content = "Test1", IsChecked = true },
                new CheckBox{ Content = "Test2", IsChecked = true },
                new CheckBox{ Content = "Test3", IsChecked = true },
            });

            //gridFactory.AppendChild(checkBoxFactory);
            gridFactory.AppendChild(textBlockFactory);
            if(isUseTool) gridFactory.AppendChild(toolBarFactory);

            template.VisualTree = gridFactory;

            return template;
        }

        private FrameworkElement MakeContent()
        {
            var stackPanel = new StackPanel
            { 

            };
            stackPanel.Children.Add(new TextBlock { Text = "Test1" });
            stackPanel.Children.Add(new TextBlock { Text = "Test2" });
            stackPanel.Children.Add(new TextBlock { Text = "Test3" });

            return stackPanel;
        }

    }
}
