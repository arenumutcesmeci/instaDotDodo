   M S B A M L   `   `   `  ����C  ?InstaDot, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:InstaDotInstaDot  5   	       InstaDot.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	   "localclr-namespace:InstaDot  5   	     � Title$  InstaDot��5	   	   $	��450��6   $	��800��6'   $	��450��63   $	��800��6C   .��5
      � -   5        $
��Main��5
       � ColumnDefinitions 5   
   �� 5      $��200px��6   �� 5      .+�5   
   � $��0��6    � RowDefinitions 5      �� 5      $
��50px��6    $��50 �61   �� 5      �� 5      $
��50px��6    $��50 �61   ��5      �� 5      .��5      �  � Color$ #5F0A87��6#    � Offset$	 0.0Q�63   � 5      $ #A4508B��6#   $	 1.0Q�63   5      .+�5      �� -   5        $��LogoGrid��5      $��0��6)    �� Orientation$ 
Horizontal=�66   $��Center=�6O   $��Center=�6j   .+�5      !  FontAwesome.WPF.FontAwesome     Icon$ 	Instagram=�6!   
�������$��30(�6E   $��Center=�6S   $��Center=�6n   �� 5      $��20(�6   $��InstaDot��6&   
�������$��Center=�6L   $��Center=�6g   $��	ExtraBold"�6�   5      �� 5      -   5        $��MenuGrid��5      $��1��6+   $��Hidden=�68   $��Hidden=�6]   .��5       �� -   5        $��MenuControl��5       $��Center=�60    �� CanVerticallyScroll$
 True��6K   $y�Hidden=�6f   5"      5#      �� 5$      -   5        $��UserControl��5$      $��2��6,   $ 
Horizontal=�69   $��Center=�6R   $��Center=�6m   .+�5%        $ 
UserCircle=�6!   $��Center=�63   $��Center=�6N   $
��25px(�6k   
�������6{   �� 5&      -   5        $��UserNameLabel��5&      $��Lütfen giriş yapınız��6-   $��16(�6L   
�������$��Center=�6m   $��Center=�6�   �� 5'      -   5        $��	LogoutBtn��5'      
������ 
������ 
�������$y�	Collapsed=�6�   $��Center=�6�   $��Center=�6�   ��5(        5)      $ SignOut=�6)   $
��15px(�68   $��Center=�6H   $��Center=�6c   5+      5,      5-      �� 5.   
   -   5        $��MainControl��5.      $��1��6*   $��Hidden=�6:   $��Hidden=�6a   50      51      52      