   M S B A M L   `   `   `  ����M  IStocker.Wpf.Models, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullgFclr-namespace:Stocker.Wpf.Models.Constants;assembly=Stocker.Wpf.ModelsStocker.Wpf.Models.Constants  5      J FMov.WpfControls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null`Aclr-namespace:Mov.WpfControls.Converters;assembly=Mov.WpfControlsMov.WpfControls.Converters 5      L HStocker.Wpf.Views, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Stocker.Wpf.Views.LoginStocker.Wpf.Views.Login 5	      )   #Stocker.Wpf.Views.Login.LoginDialog   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a;	behaviors+http://schemas.microsoft.com/xaml/behaviors  5      V	constantsFclr-namespace:Stocker.Wpf.Models.Constants;assembly=Stocker.Wpf.Models  5      R
convertersAclr-namespace:Mov.WpfControls.Converters;assembly=Mov.WpfControls  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      1local%clr-namespace:Stocker.Wpf.Views.Login  5	      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5
      T	 PPrism.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59$prismhttp://prismlibrary.com/ 	 5      $	��400��5      $	��600��5      ! 	 Prism.Mvvm.ViewModelLocator    AutoWireViewModel  True5       � 	Resources 5       �� MergedDictionaries �� Source;  5Mov.WpfControls.Converters.BoolToVisibillityConverter   boolToVisibillityConverter�� 5   
    5      �� 5      $6 0/Mov.WpfDesigns;component/Styles/BaseStyles.xaml?�6%   �� 5      $; 5/Mov.WpfDesigns;component/Styles/ComponentStyles.xaml?�6%   %   &	          5      64   5      *  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5      +  %Microsoft.Xaml.Behaviors.EventTrigger  5   
      	EventName$ Loaded��6!   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 6,   �� *LoadedCommand+5      # 	 Prism.Services.Dialogs.Dialog   WindowStyle 5      �� 5   
   	 �� 
TargetType"	 �6   .�5       �� 
 �� Property
 �@ WindowStartupLocation �� Value$ CenterScreen=�6C   �� 5!      
 �@�ShowInTaskbar$ False��6.   �� 5"      
 �@�SizeToContent$ WidthAndHeight=�6.   �� 5#      
 �@�WindowStyle$
 None=�6,   5$      .��5&      �  � RowDefinitions 5'   
   �� 5(      $��* �6   �� 5)      $
��auto �6   .+�5+   
   �� $��0��5,      $��5q�5-      .   (Stocker.Wpf.Models.Constants.RegionNames   MAIN!	 	 Prism.Regions.RegionManager 	  
RegionName# Z 5/       	  RegionManager 5.      �� *RegionManager+5/      � 50   
   $��1��6    51      �� 52      $��* �6    �� 53      $
��auto �6    .+�55      �� $��0��56      $��50��57      $��	20,0,20,0q�58      $	��Top=�59      
���   �$��15(�5>      ���#DAD9FF  LoginButton#��[ 5@      ��5;      �� *ApplyCommand+��5<      ��  �� ElementName$ password����5=      �� *ApplyContent.Value+5@      � 5A      $��1��6   $
��0,15q�6!   $��Bottom=�6/    � ColumnDefinitions 5B      �� 5C      �� 5D      .+�5F      �� $��Right=�5G      $��Center=�5H      ���#DFE2E3��5J      �� *ChangeContentGuide.Value+�� 5K      $��1��5L      $��5,0,0,0q�5M      $
��Left=�5N      $��Center=�5O      $
��Bold"�5P      ���#4F5156��5R      �� *ChangeContent.Value+ 5S        5T      $ MouseLeftButtonDown��61   . 5U         6<   �� *ChangeContentCommand+5V      ��5X      �� 5Y      "	 ��6     �� Triggers 5Z      P� 5[   "    P� Property �@J�IsMouseOver P� Value$
 True��6A   . �5\   &   �� 
 � �� �#F9F9F96C   5]   #   5_      5a      5b      5c      5d      5e      