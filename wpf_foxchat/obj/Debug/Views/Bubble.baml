   M S B A M L   `   `   `  ����F  Bwpf_foxchat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:wpf_foxchat.Viewswpf_foxchat.Views  5          wpf_foxchat.Views.Bubble   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:wpf_foxchat.Views     5      $
��Auto��5      $
��Auto��6   
�������  � 	Resources  5	         Like_React_Source  Haha_React_Source  Love_React_Source  Wow_React_Source  Sad_React_Source " BorderReactionStatisticalStyle �� 
TargetType �� Property �� Value   TextReactionStatisticalStyle   ItemReactionStatisticalStyle �� 
TargetType J� Effect3  -System.Windows.Media.Effects.DropShadowEffect   ShadowDepth   
BlurRadius � ColumnDefinitions  ReactionStatisticalStyle	 �� Orientation��%,  &	        &	 D     &	 �     &	 �     &	     &	 R    &	 &    &	     7  7   7  &	 �    7  7  ��5
   
   0,pack://application:,,,/Assets/react/like.png��6^   ��5   
   0,pack://application:,,,/Assets/react/haha.png��6^   ��5   
   0,pack://application:,,,/Assets/react/love.png��6^   ��5   
   /+pack://application:,,,/Assets/react/wow.png��6]   ��5   
   /+pack://application:,,,/Assets/react/Sad.png��6]   �� 5   
   " ��67   .�5      ��  �@��CornerRadius$ 7��65   �� 5       � ��$ 2,0,0,0q�65   �� 5       �@��Padding$ 2,0,2,0q�65   �� 5       � ��
 ����65   5      �� 5   
   " ��65   .�5      ��  � ��$ Center=�65   �� 5       � ��$ Center=�65   �� 5       � ��$ 9(�65   �� 5       �@��Padding$ 2,0,2,0q�65   �� 5       � ��
 �   �65   5      �� 5!   
   " ��65   .�5"      ��  � �� 5#      �� 5$      " ��6&   .R�5&      �� 8��   5'        5(   "   $ 0Q�63   $ 5Q�6C   6T   ._�5*      �  5+   "   �� 5,   &   69   �� 5-   &   69   .+�50   "   �� $��0��6(   $��10��68   8�� 51   #   �� 52   "   $��1��6,   8�� $��12��54   ,   55   #   56      57      58      5:      5;      �� 5=   
   " ��61   .�5>      ��  � �� 5?      �� 5@      " ��6&   .R�5A      �� $	 
Horizontal=�6%   $��LeftToRight=�5B   %   $��Stretch=�5C   %   $��0,0,10,0q�5D   %   .+�5E      �� 8��  6b   �� 5F      8�� 6b   5G      5H      5J      5K      5L      .��5M      �� $	 
Horizontal=�6   .+�5N   
   � $��40��6   .+�5O      A� $��40��6   ��5P      �� 5Q      
 �� ImageSource$
 /Assets/face_webu.jpg��6!    j� Stretch$ Uniform=�5R   !   5T      5U      � 5V   
    � RowDefinitions 5W      �� 5X      $
��Auto �6    �� 5Y      $��14 �6    .+�5\      � -   5         �Name$ MsgTail��5\      $��0��5]      $��0��6   $��Stretch=�5^      $��Stretch=�5_      .+�5`      F� �����@]� l� ӕkZ l� l� +P l� �y� �l� E�� � ��$�= �*ӹ6 [�X�� ��k�2 z9x�/4 =�Z� �!_"� �FX�;� ��Z�-� T\@]� T\��N2T\މ��މ�y� �މ+P �N2l� @]� l� 	$��Bottom=�5c       J� RenderTransformOrigin$ 0.5,0.5&�5d      $��54.75��5e      $��50��6"   $��58��5f      $��58��6    �� Stretch$ Uniform=�5g      ��5h      �� 5i      " F�6    .�5j      ��  � �� 	 MesseageColorReceive# [	 65   �� 5k       � ��$
 Left=�6D    �� Triggers 5l      �� 5m   "    �� Binding 6.   �� *MessageStatus+ �� Value Sent6P   .a�5n   &   ��  � �� 
 MesseageColorSent# [
 6=   �� 5o   &    � ��$ Right=�6L   �� 5q   &    � z� 5r   *   �� 5s   .    �� ScaleX$ -1Q�6=   5u   '   5v   #   5x      5z      5{      �� 5~      -   5         ��Name$ 
MsgContent��5~      $��0��5      $��0��6    �� CornerRadius$ 30��5�      $��60��5�      $	��200��5�      $	��500��5�      ��5�      �� 5�      " ��6   .�5�      ��  � ��# [	 67    5�      �� 5�       6*   �� *MessageStatus+ Sent6L   .a�5�   "   ��  � ��# [
 6?   5�      5�      ._�5�      ��   CMessageStyle#��[ 6   $.��(This is chat chit tại việt nam đây��5�      5�      5�      � 5�      $��1��6   $��0��6    .+�5�      ]� ��. $��RightToLeft=�5�      $��Stretch=�5�      .+�5�      �� $
��Left=�6    $
��10px(�5�        �� Padding$ 0,0,20,0q�5�       
�������$��7:00px��5�       5�      �� 5�      $��0,0,0,0q�6!   $��Center=�5�      .+�5�      �� $��	0,-10,0,0q�6"   #��[ 65   6i   5�      5�      5�      5�      5�      5�      