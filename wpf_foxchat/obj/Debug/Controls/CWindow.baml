   M S B A M L   `   `   `  ����F  Bwpf_foxchat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:wpf_foxchat.Controlswpf_foxchat.Controls  5   	   "    wpf_foxchat.Controls.CWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:wpf_foxchat.Controls     5   	     � WindowStyle$
  None=�5   	    � AllowsTransparency . 
������    	TextColor#��[  5   	    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ 	CanResize=�5   	   $	��100��5   	   $	��300��6    � SizeToContent$ WidthAndHeight=�5   	   z�5      T� 5   
    T� X$ 0Q�6    T� Y$ 0Q�6#   ��5      �� 5   
    �� 
TargetType" �6    �� Triggers 5      P� 5      	 P� Property	 � y�
 P� Value$
 Visible=�60    N� EnterActions 5      �� 5      .��5      �� .��5#   "   W�  �� TargetProperty$, &RenderTransform.(TranslateTransform.Y)�62    W� From$ 20X�5$   2    g� Duration$ 0:0:0.7D�6<    g� 
SpeedRatio$ 1Q�6O    W� EasingFunction 5%   &   0  *System.Windows.Media.Animation.ElasticEase  5&   *   7  1System.Windows.Media.Animation.EasingFunctionBase   
EasingMode$ EaseOut=�66   5(   #   5)      5*      5,      5.       � Triggers 50      :� 51   
    :� RoutedEvent$ Loaded��6   .[�52      �� .��53      �� $ Opacity�6   .��54      W� $ 0X�6&   	 W� To$ 1X�6/   $ 
00:00:00.2D�66   55      56      5A       � 	Resources 5C        TitleBarDialogColor��%)   &	       ��5D   
   #E6E6E6��6?   5E      .��5F      � 
������ $��10q�5G       J� Effect 5I   
   3  -System.Windows.Media.Effects.DropShadowEffect  5J         ShadowDepth$ 0Q�6       
BlurRadius$ 10Q�61    � RowDefinitions 5L   
   �� 5M      $��26 �6   6*   �� 5N      $��* �6   6)   �� 5O      $��5 �6   6)   .+�5R   
   �� -   5         ��Name$ 	Title_Bar��5R      $��0��5T      $��0��6   ���#C3C1C3$��0,0,0,1q�5W       �� CornerRadius$ 5,5,0,0��5X      y�5S      �� *VisibleTitleBar+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=���5Y      �� 5Z       �� 
StartPoint$ 0.5,0&�6&    �� EndPoint$ 0.5,1&�69   ��5\      �   � Offset$  0Q�6'   ! � Color$! #FEFEFE��64   � 5]      $  1Q�6'   $! #CBCBCB��64   5_      ._�5a      � .+�5b      ]� ��. $��RightToLeft=�5c      .+�5e      �� " �� Orientation$" 
Horizontal=�6!   $��RightToLeft=�5f   !   .+�5g      "   wpf_foxchat.Controls.CButton  "   wpf_foxchat.Controls.CButton#   Click$# BTN_Close_Click��5j   (   
������   CButtonStyleVM#��[ 5h   (   $��26��5k   (   $
��🗙��5l   (   $   BorderRadius$$ 5,0,0,0��5m   (   % � DataContext% 5i   (   �� *	BTN_Close+5n        5o      
������ #��[ 5p   (   $��26��5r   (   $
��🗖��5s   (   $$ 0��5t   (   % 5q   (   �� *BTN_Maximize+5u        5v      
������ #��[ 5w   (   $��26��5y   (   $
��🗕��5z   (   $$ 0��5{   (   % 5x   (   �� *BTN_Minimize+5|      5}      �� 5�      $" 
Horizontal=�6!   $��LeftToRight=�5�   !   .+�5�      �� $��26��6    $��0,1,0,0q�5�       $��Uniform=�5�         Erro_Alert_Source#��[ 5�       y�5�       �� *VisibleImageTitleBar+$ TwoWay=�$ PropertyChanged=�5�      �� 5�      $��Center=�6$   & �� TextAlignment$& Right=�5�   $   $��12(�5�   $   ' �� Padding$' 10,0,0,0q�5�   $   ��5�   $   �� *Title+5�      5�      5�      5�      5�      ]� 5�   
   -   5        ( ]�Name$( Content_Control��5�      $��1��5�      $��0��6!   
������ 5�      �� 5�   
   -   5        $ 
Footer_Bar��5�      $��2��5�      $��0��6   $ 0,0,5,5��5�      #��[ 5�      y�5�      �� *VisibleTitleBar+$ TwoWay=�$ PropertyChanged=�5�      5�      5�      