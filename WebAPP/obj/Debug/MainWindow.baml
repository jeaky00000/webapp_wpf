   M S B A M L   `   `   `  ����E  ADMSkin.WPF, Version=2.5.1.4, Culture=neutral, PublicKeyToken=null;,clr-namespace:DMSkin.WPF;assembly=DMSkin.WPF
DMSkin.WPF  5      A =WebAPP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WebAPP.ViewModelWebAPP.ViewModel 5      1clr-namespace:WebAPP.ControlsWebAPP.Controls 5	      M5clr-namespace:DMSkin.WPF.Controls;assembly=DMSkin.WPFDMSkin.WPF.Controls  5
         WebAPP.MainWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      ?DMSkin,clr-namespace:DMSkin.WPF;assembly=DMSkin.WPF     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      4	viewModelclr-namespace:WebAPP.ViewModel     5      2controlsclr-namespace:WebAPP.Controls     5	      L
dmcontrols5clr-namespace:DMSkin.WPF.Controls;assembly=DMSkin.WPF     5
        � Title$  网易云音乐��5      $
��1022��5      $	��670��5      $
��1062��5      $	��710��5      #   DMSkin.WPF.DMSkinSimpleWindow   DMWindowShadowColor$ #888888��5         DMWindowShadowOpacity$	 0.4Q�5         DMWindowShadowSize$ 20Q�5       � 
ResizeMode$ CanResizeWithGrip=�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Display=�5       � WindowStartupLocation$ CenterScreen=�5       � 	Resources 5         TransparentColor �� Color�� 5   
   %/   &	        �� 5      $ Transparent��67   5      	 � DataContext	 5      *  $WebAPP.ViewModel.MainWindowViewModel  5   
   .��5#      �� ���#dedede
 �� CornerRadius$
 0��6"   ._�5%   
   � $��0,0,0,0q�6   .+�5&      � 
������  � RowDefinitions 5'      �� 5(      $��40 �6$   �� 5)      $��* �6$   �� 5*      $��40 �6$   .+�5,      � .+�5-      �� $��10,0,0,0q�5.      $
��Left=�5/      $��Center=�50      $��14(�51      $
��Bold"�52      $��Login Panel��53      
���   �6,   �� 54      $��1��55      $��Bottom=�56      � 57      $��Right=�6!   $��5q�6=   .+�58      +   %DMSkin.WPF.Controls.DMSystemMinButton   � Cursor$
 Hand��59      (   "DMSkin.WPF.Controls.DMSystemButton   DMSystemButtonForeground$
 #333��5:         DMSystemButtonHoverColor$ Transparent��5;      $   DMSystemButtonHoverForeground$ White��5<         DMSystemButtonSize$ 22Q�5=      +   %DMSkin.WPF.Controls.DMSystemMaxButton  5?      $
 Hand��5@      $
 #333��5A      $ Transparent��5B      $ White��5C      $ 24Q�5D      -   'DMSkin.WPF.Controls.DMSystemCloseButton  5F      $
 Hand��5G      $
 #333��5H      $ Transparent��5I      $ White��5J      $ 24Q�5K      5M      5N      � 5O      $��1��6    � ColumnDefinitions 5Q      �� 5R      $	��200 �6+   �� 5S      $��* �6+   .+�5U      � 
�������.+�5V      (   "DMSkin.WPF.Controls.DMScrollViewer  .��5X   "   �� .+�5Y   &   9� $��推荐��5Z       9� 
IsExpanded .   
NoExpander#��[ 5\      .��5]   *   �� .+�5^   .   &	   WebAPP.Controls.ImageRadioButton	  $��发现音乐��5_   %    	� 	GroupName$
 Menu��5`   %     Icon_FindMusic 	  Image# [ 5a   %    d� 	IsChecked 5b   %   �� *
SelectMenu+ �� Mode$ TwoWay=�  EnumToBooleanConverter �� 	Converter# [  �� ConverterParameter$ 	FindMusic��	  5c   .   $��私人FM��5d   %   $
 Menu��5e   %     Icon_FM# [ 5f   %    	  ImageHeight$ 14Q�5g   %    	  
ImageWidth$ 18Q�5h   %    5i   %   �� *
SelectMenu+$ TwoWay=�# [ $
 Home��	  5j   .   $��视频��5k   %   $
 Menu��5l   %     
Icon_Video# [ 5m   %   $ 12Q�5n   %   $ 18Q�5o   %    5p   %   �� *
SelectMenu+$ TwoWay=�# [ $
 Home��	  5q   .   $��朋友��5r   %   $
 Menu��5s   %     
Icon_Group# [ 5t   %   $ 20Q�5u   %    5v   %   �� *
SelectMenu+$ TwoWay=�# [ $
 Home��5w   +   5x   '   9� 5y   &   $��0,10,0,0q�5z      $��我的音乐��5{       . #��[ 5}      .��5~   *   �� .+�5   .   	  $��本地音乐*��5�   %   $
 Menu��5�   %     
Icon_Music# [ 5�   %   $ 14Q�5�   %    5�   %   �� *
SelectMenu+$ TwoWay=�# [ $ page1��	  5�   .   $��下载管理��5�   %   $
 Menu��5�   %     	Icon_Down# [ 5�   %   $ 16Q�5�   %   $ 16Q�5�   %    5�   %   �� *
SelectMenu+$ TwoWay=�# [ $ page2��	  5�   .   $��我的音乐云盘*��5�   %   $
 Menu��5�   %    	 
Icon_Cloud# [	 5�   %   $ 19Q�5�   %    5�   %   �� *
SelectMenu+$ TwoWay=�# [ $ page1��	  5�   .   $��我的电台��5�   %   $
 Menu��5�   %    
 
Icon_Radio# [
 5�   %    5�   %   �� *
SelectMenu+$ TwoWay=�# [ $ page2��	  5�   .   $��我的收藏��5�   %   $
 Menu��5�   %     	Icon_Love# [ 5�   %   $ 16Q�5�   %   $ 16Q�5�   %    5�   %   �� *
SelectMenu+$ TwoWay=�# [ $ 
Collection��5�   +   5�   '   9� 5�   &   $��0,10,0,0q�5�      $��创建的歌单��5�       . .��5�   *   �� .+�5�   .   	  $��我喜欢的音乐��5�   %   $
 Menu��5�   %     	Icon_Like# [ 5�   %   $ 16Q�5�   %    5�   %   �� *
SelectMenu+$ TwoWay=�# [ $
 Home��5�   +   5�   '   9� 5�   &   $��0,10,0,0q�5�      $��收藏的歌单��5�       .  .��5�   *   �� .+�5�   .   	  $��Dream.Machine 的音乐��5�   %   $
 Menu��5�   %     Icon_MusicList# [ 5�   %   $ 16Q�5�   %    5�   %   �� *
SelectMenu+$ TwoWay=�# [ $
 Home��	  5�   .   $��Dream.Machine 的音乐��5�   %   $
 Menu��5�   %   # [ 5�   %   $ 16Q�5�   %    5�   %   �� *
SelectMenu+$ TwoWay=�# [ $
 Home��	  5�   .   $��Dream.Machine 的音乐��5�   %   $
 Menu��5�   %   # [ 5�   %   $ 16Q�5�   %    5�   %   �� *
SelectMenu+$ TwoWay=�# [ $
 Home��	  5�   .   $��Dream.Machine 的音乐��5�   %   $
 Menu��5�   %   # [ 5�   %   $ 16Q�5�   %    5�   %   �� *
SelectMenu+$ TwoWay=�# [ $
 Home��5�   +   5�   '   5�   #   5�      5�      �� 5�      $��1��6#   ���#E1E1E2 �� ResizeDirection$ Columns=�6B   � 5�      $��1��6   
�������.+�5�       � -   5          �Name$ Frame��5�         � NavigationUIVisibility$ Hidden=�6/   ��6O   �� *CurrentPage+6q   5�      5�      �� 5�      $��2��6     WyyResizeGrip#��[ 6*   $��Bottom=�6Q   $��Right=�5�      $��Right=�5�      $��Bottom=�69   5�      5�      5�      5�      