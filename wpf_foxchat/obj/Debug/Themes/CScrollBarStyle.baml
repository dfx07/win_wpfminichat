   M S B A M L   `   `   `  ����F  Bwpf_foxchat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:wpf_foxchat.Themeswpf_foxchat.Themes  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   ScrollThumbs  �� 
TargetType �� Property �� Value �� 
TargetType �Name ��Name �� CornerRadius �� Triggers P� Property	 P� Value
 �� 
TargetName  
CScrollBar ]�Name J� Opacity ]� Thumb n�Name ]� IncreaseRepeatButton ��Name ]� DecreaseRepeatButton �� Angle  CScrollViewer �� BasedOn � ColumnDefinitions � RowDefinitions �� CanContentScroll ��Name �� VerticalOffset � Value �� ScrollableHeight � Maximum �� ViewportHeight �� ViewportSize* �� #ComputedVerticalScrollBarVisibility �� Orientation  �� HorizontalOffset! �� ScrollableWidth" �� ViewportWidth,# �� %ComputedHorizontalScrollBarVisibility$ :� RoutedEvent% ��Name& �� 
TargetName' �� TargetProperty( W� From	) W� To* g� Duration+ g� AutoReverse, W� EasingFunction4   .System.Windows.Media.Animation.ExponentialEase7  1System.Windows.Media.Animation.EasingFunctionBase-   
EasingMode�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      *local clr-namespace:wpf_foxchat.Themes  5      %�  &	        &	 [    7   &	 �    7��7  7  �� 5      "  n�6!   .�5   
   ��  � �� 5      �� 5      " n�6"   .R�5      � $
 Grid��6   .+�5	      �� $��Stretch=�6$   $��Stretch=�6B   $
��Auto��6^   $
��Auto��6k   
������ 6y   �� 5
      $ ScrollBarRectangle��6!   $ 5��6=   $��Stretch=�6N   $��Stretch=�6l   $
��Auto��6�   $
��Auto��6�   #��z��6�   5       5      P� 5       �@�Tag$	 
Horizontal��61   . �5      �� $
 ScrollBarRectangle��6%    � ��$
 Auto��6V   �� 5      $
 ScrollBarRectangle��6%    � ��$ 7��6W   5      5      5      5      �� 5      "  ��6   .�5   
   ��  � ��$ 	-15,0,0,0q�6#   �� 5   
    �@��IsFlicksEnabled .  63   �� 5   
    � �� �#5053596'   �� 5   
    � ��
 ���� 6'   �� 5   
    � ��$ 8��6"   �� 5   
    � �� 5      �� 5      " ��6"   .R�5      � $ GridRoot��6   $��8��6-   #��z��67   .+�5       ]� $ 
PART_Track��6    $ 1Q�65   ��. |�.   5!      n� 5"   "   $ ScrollBarThumb��6(   #��z��6@   8��  6j    5$      �� 5%   "   $ PageUp��6/   $��ScrollBar.PageDownCommand��6?   $ 0Q�6c   |�.  6o    5'      �� 5(   "   $ PageDown��6/   $��ScrollBar.PageUpCommand��6A   $ 0Q�6c   |�.  6o   5*      5+       5-      P� 5.       �@��Orientation$	 
Horizontal=�69   . �5/      �� $
 GridRoot��6%    �@�LayoutTransform 50   "   �� 51   &   $	 -90Q�66   53      �� 54      $
 
PART_Track��6%    �@�LayoutTransform 55   "   �� 56   &   $	 -90Q�66   58      �� 59       � ��$
 Auto��66   �� 5:       � ��$ 8��67   �� 5;      $
 ScrollBarThumb��6%    �@�Tag$ 
Horizontal��6P   �� 5<      $
 PageDown��6%    � ��$ ScrollBar.PageLeftCommand��6N   �� 5=      $
 PageUp��6%    � ��$  ScrollBar.PageRightCommand��6L   5>      5@      5B      5C      �� 5E      "  ��6"   8   .�5F   
   ��  �@�OverridesDefaultStyle . 62   �� 5G   
    � ��$ 0,0,0,0q�6#   �� 5H   
    � �� 5I      �� 5J      " ��6"   .R�5K      � $ PART_GridCScrollViewer��6   $��Stretch=�6;   $��Stretch=�6Y    5L      �� 5M      $��* �6/   �� 5N      $
��Auto �6/    5P      �� 5Q      $��* �6,   �� 5R      $
��Auto �6,   .+�5U      �� # z��61   $��0��5V   1   $��2��6A   $��0��5W   1   $��2��6>   5X      �� 5Y      $ PART_VerticalScrollBar��6$   $��1��5Z   $   $��0��64   $��0,0,0,0q�5[   $   8�� #��z��5]   $   # z 5^   $   # z 5_   $   # z 5`   $   #y�z 5a   $   5b      �� 5c      $ PART_HorizontalScrollBar��6$   8�� $ 
Horizontal=�5e   $   $��1��5f   $   $��1��5g   $   # z  5h   $   # z! 5i   $   # z" 5j   $   #y�z# 5k   $   5l      5m       5o      :� 5p      $$ ScrollChanged��6'   .[�5q      �� $% AniScrollChanged��6.   .��5r   "   �� .��5s   &   W� $& PART_VerticalScrollBar��67   $' Opacity�5t   7   $	( 1.0X�5u   7   $	) 0.0X�6B   $* 0:0:2.5D�6K   + .  , 5v   *      5w   .   $- EaseIn=�6?   5y   '   5z   #   5{      5|      :� 5}      $$ Loaded��6'   .[�5~      �� .��5   "   �� .��5�   &   W� $& PART_VerticalScrollBar��67   $' Opacity�5�   7   $	( 1.0X�5�   7   $	) 0.0X�6B   $* 0:0:0D�6K   + .  5�   '   5�   #   5�      5�      5�      5�      5�      5�      