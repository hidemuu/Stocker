   M S B A M L   `   `   `  ����L  HStocker.Wpf.Views, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Stocker.Wpf.Views.DialogsStocker.Wpf.Views.Dialogs  5      +    %Stocker.Wpf.Views.Dialogs.AlertDialog   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:Stocker.Wpf.Views.Dialogs     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      T PPrism.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59$prismhttp://prismlibrary.com/  5      $	��350��5	      $	��120��5
      !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  True5      #  Prism.Services.Dialogs.Dialog   WindowStyle 5      �� 5   
    �� 
TargetType" �6   .�5      ��  �� Property �@ WindowStartupLocation �� Value$ CenterScreen=�6C   �� 5       �@�ShowInTaskbar$ False��6.   �� 5       �@�SizeToContent$ WidthAndHeight=�6.   �� 5       �@�WindowStyle$
 None=�6,   �� 5       �@�
ResizeMode$ NoResize=�6+   5      .��5      � $��5q�6    � RowDefinitions 5   
   �� 5      �� 5      $
��Auto �6   .+�5   
   � $��0,0,0,10q�6    � ColumnDefinitions 5      �� 5      $��70 �6#   �� 5      .+�5       �� $��40��5!       �� BitmapScalingMode$ HighQuality=�5"      $M��Gpack://application:,,,/Mov.WpfDesigns;Component/Assets/Photos/alter.png��5#       � UseLayoutRounding$
 True��5$      �� 5%      $��0��5&      $��1��5'      $
��Left=�5(      $��Center=�5)      $��	Open Sans)�5*      $��15(�5+      $
��Wrap=�5-      ��5,      �� *Message.Value+5-      5.      � 5/   
   $��1��6    50      �� 51      �� 52      .+�54      �� $��1��55      $��64��56      $��28��57      $��5q�58      $��Right=�59      ���#5cb85c$
��true��5<      $	��Yes��5=      $��12(�5>      
���������5;      �� *RequestCloseCommand+5?      �� 5@      $��1��5A      $��1��5B      $��64��5C      $��28��5D      $��5q�5E      $
��Left=�5F      ���#d9534f$��false��5I      $��No��5J      $��12(�5K      
���������5H      �� *RequestCloseCommand+5L      5M      5N      5O      