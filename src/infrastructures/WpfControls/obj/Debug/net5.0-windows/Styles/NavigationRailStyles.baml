   M S B A M L   `   `   `  ����\  XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089_ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962ac _MaterialDesignThemes.MahApps, Version=0.1.9.2, Culture=neutral, PublicKeyToken=df2a72020bd7962a  �� MergedDictionaries �� Source !  VerticalTabHeaderTextStyleKey ! MaterialDesignButtonTextBlock �� BasedOn �� 
TargetType �� Property �� Value �� RelativeSource �� AncestorType �� Path ! NavigationRailControlStyleKey	 �� 
TargetType
 � ColumnDefinitions ��Name  BackgroundBrushKey K� IsItemsHost ��Name �� Padding  AccentSelectedColorBrush ��Name  ForegroundBrushKey J� Opacity  BrushRoundConverter �� 	Converter J� RenderTransformOrigin �� ScaleX%   MaterialDesignThemes.Wpf.Ripple    RecognizesAccessKey J� SnapsToDevicePixels    Feedback'   !System.Windows.VisualStateManager   VisualStateGroups%   System.Windows.VisualStateGroup   Name   Transitions%   System.Windows.VisualTransition   GeneratedDuration	   To   GeneratedEasingFunction/  )System.Windows.Media.Animation.CircleEase7  1System.Windows.Media.Animation.EasingFunctionBase   
EasingMode   States    System.Windows.VisualState   Name    
Storyboard! �� 
TargetName" �� TargetProperty	# W� To$ g� Duration% �� Triggers& P� Property' P� Value  PrimaryHueMidBrush�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      :x,http://schemas.microsoft.com/winfx/2006/xaml      5      HmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5        5      �� 5   
   $3 -/WpfControls;component/Styles/BaseStyles.xaml?�6   %Q  &	        7  &	 �     7  7  7  �� 5
      8   " ��5   	   .�5   
   ��  � �� 6'   ��  �� " ��$ 
Foreground��� 5   
    � ��$
 12,0q�6#   5      �� 5      " ��62   .�5   
   ��  � ��$ Stretch=�67   �� 5   
    � ��$ Stretch=�65   �� 5   
    � �� 5      �� 5      "	 ��6"   .R�5      � 
 5      �� 5      $��72 �6/   �� 5      $��* �6/   .+�5      �� $ HeaderPanel��5      #���  5       $
 True��5!      �� 5"      $ ContentSize��5#      $��1��5$      # z��5%      8��  $��1,0,0,0q�5'      ._�5(      �� $ PART_SelectedContentHost��6/   $��SelectedContent��6Q   5)      5*      5+      5-      �� 5.   
    � �� 5/      �� 50      " ��6   .�51      ��  �@�OverridesDefaultStyle$
 True��6>   �� 52       � ��$ 72��6/   �� 53       � ��# �  63   �� 54       � ��
 ���� 63   �� 55       � ��$ Stretch=�6C   �� 56       � ��$ Stretch=�6A   �� 57       � ��$ 	0,12,0,14q�60   �� 58       �@J�Opacity$	 0.7Q�60   �� 59       � �� 5:      �� 5;      "	 ��6.   .R�5<   "   �� #��z��5=   %   #��z��5>   %   #��z��5?   %   #��z��5@   %   #}�z}�5A   %   ._�5B   &   � .+�5C   *   �� $ MouseOverBorder��5D   -   $ 0Q�5G   -   ��5E   -   �� *
Foreground+8  5G   -   �� 5I   *   $ SelectedBorder��5J   -   
������ $ 0Q�5L   -   $ 0.5,0.5&�5M   -   z�5N   .   �� 5O   2   $ 1Q�6A   5Q   +      5R   *   #��z��5S   -   #��z��5T   -   #��z��5U   -   #��z��5V   -   #��z��5W   -   $|�False��5Z   -   $ False��5[   -   # z 5\   -    5X   -   �� *
Foreground+8  .��5]   .   �� $ ContentSite��6?   $��Header��6T   5^   +   5`   '    5a   &     5b   *   $ CommonStates��6;    5c   .     5d   2   $ 0:0:0.3D�6C   $ Normal��6_    5e   6     5f   :   $ EaseOut=�6E   5h   3   . 5j   .     $ Normal��6:     5k   .   $ 	MouseOver��6:   .  5l   2   �� .��5m   6   W� $! MouseOverBorder��5n   9   $" Opacity�5o   9   # 0.15p   9   $$ 0D�5q   9   5r   3   5s   /     5t   .   $ Disabled��6:   5u   +     5v   *   $ SelectionStates��6;    5w   .     5x   2   $ 0:0:0.6D�6C   . 5z   .     $ Selected��6:   .  5{   2   �� .��5|   6   W� $! SelectedBorder��5}   9   $" Opacity�5~   9   # 0.185   9   $$ 0D�5�   9   5�   3   5�   /     5�   .   $ 
Unselected��6:     5�   .   $ SelectedUnfocused��6:   .  5�   2   �� .��5�   6   W� $! SelectedBorder��5�   9   $" Opacity�5�   9   # 0.035�   9   $$ 0D�5�   9   5�   3   5�   /   5�   +   5�   #   % 5�   "   P� 5�   &   & � {�$' False��6C   . �5�   *   ��  �@J�Opacity$	 .50Q�6D   5�   '   P� 5�   &   & �@��
IsSelected$
' True��6D   . �5�   *   �� # �  6G    � ���� 5�   *    �@J�Opacity$ 1Q�6D   5�   '   P� 5�   &   & �@J�IsMouseOver$
' True��6E   . �5�   *   ��  �@J�Opacity$ 1Q�6D   5�   '   5�      5�      5�      5�      5�      5�      