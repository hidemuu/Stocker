   M S B A M L   `   `   `  ����J  FMov.WpfControls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null`Aclr-namespace:Mov.WpfControls.Converters;assembly=Mov.WpfControlsMov.WpfControls.Converters  5      L HStocker.Wpf.Views, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Stocker.Wpf.Views.LoginStocker.Wpf.Views.Login 5      +   %Stocker.Wpf.Views.Login.CreateAccount   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a;	behaviors+http://schemas.microsoft.com/xaml/behaviors  5      R
convertersAclr-namespace:Mov.WpfControls.Converters;assembly=Mov.WpfControls  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      1local%clr-namespace:Stocker.Wpf.Views.Login  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5	      T PPrism.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59$prismhttp://prismlibrary.com/  5
      $	��600��5      $	��400��5      !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  True5       � 	Resources 5      2   ,Mov.WpfControls.Converters.PasswordConverter   PasswordConverter��%   &	          5   
   6'   5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      $
��1.5* �6   �� 5      $��0 �6   .+�5   
   �  5      �� 5      �� 5      .+�5      �� $��30��5      $��30��5      $��10q�5       $
��Left=�5!      $Z��Tpack://application:,,,/CovidReader.ViewControls.Wpf;Component/Assets/Fonts/#iconfont)�5"      $��30(�5#      $
��Bold"�5$      $	����5%      *  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5&      +  %Microsoft.Xaml.Behaviors.EventTrigger  5'         	EventName$ MouseLeftButtonDown��6-   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5(      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 68   �� *GoBackCommand+5)      ��5+      �� 5,       �� 
TargetType" ��6    �� Triggers 5-      P� 5.      	 P� Property	 �@J�IsMouseOver
 P� Value$

 True��6=   . �5/   "   ��  �� Property � �� �� Value �#F9F9F96?   50      52      54      �� 55      $��1��56      $��	20,0,20,0q�57      $��Center=�58      $��25(�59      $
��Bold"�5:      ���#3F487F$��Create a personal account��5<      5=      � 5?   
   $��1��6    5@      �� 5A      �� 5B      �� 5C      .+�5E      �  5F      �� 5G      $
��auto �6$   �� 5H      .+�5J      �� $��	20,0,20,0q�5K      ���#B6B9BC$��LoginId��5M      �� 5N      $��1��5O      $��50��5P      $��	20,5,20,5q�5Q      ���#F9F9F9$��2q�5S       �� CornerRadius$ 15��5T      ._�5U      �� $��Center=�5V      
������ $��0q�5X      ��5Y      �� *RegisteredLoginId.Value+5Z      5[      � 5\      $��1��6    5]      �� 5^      $
��auto �6$   �� 5_      .+�5a      �� $��	20,0,20,0q�5b      ���#B6B9BC$��Password��5d      �� 5e      $��1��5f      $��50��5g      $��	20,5,20,5q�5h      ���#F9F9F9
���   �$��0q�5k      $ 15��5l      ._�5m      G� -   5         G�Name$ Password��5n      $��Center=�5o      
������ $��0q�5q      5r      5s      � 5t      $��2��6    5u      �� 5v      $
��auto �6$   �� 5w      .+�5y      �� $��	20,0,20,0q�5z      ���#B6B9BC$��Confirm Password��5|      �� 5}      $��1��5~      $��50��5      $��	20,5,20,5q�5�      ���#F9F9F9
���   �$��0q�5�      $ 15��5�      ._�5�      G� -   5        $ ConfirmPassword��5�      $��Center=�5�      
������ $��0q�5�      5�      5�      5�      � 5�   
   $��2��6   $��0,20,0,0q�6   .+�5�      �� $��50��5�      $��	20,0,20,0q�5�      $	��Top=�5�      
���   �$��Verity��5�      $��15(�5�      ���#DAD9FF��5�      �� *VerityCommand+��5�      `� 5�       `� 	Converter# [  6#   .1�5�      ��  �� ElementName$ Password��6"   �� 5�      $ ConfirmPassword��6"   5�      5�      � 5�      $
��0,15q�6   $��Bottom=�6!    � ColumnDefinitions 5�      �� 5�      �� 5�      .+�5�      �� $��Right=�5�      $��Center=�5�      ���#DFE2E3$��already registerted?��5�      �� 5�      $��1��5�      $��5,0,0,0q�5�      $
��Left=�5�      $��Center=�5�      $
��Bold"�5�      ���#4F5156$��Login��5�       5�        5�      $ MouseLeftButtonDown��61   . 5�         6<   �� *LoginMainContentCommand+5�      ��5�      �� 5�      " ��6     5�      P� 5�   "   	 �@J�IsMouseOver$

 True��6A   . �5�   &   ��  � �� �#F9F9F96C   5�   #   5�      5�      5�      5�      5�      5�      