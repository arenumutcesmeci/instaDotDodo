   M S B A M L   `   `   `  ����C  ?InstaDot, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:InstaDotInstaDot  5          InstaDot.DashboardWindow   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5      "localclr-namespace:InstaDot  5      -   5        $��	Dashboard��5	      .��5
      �   � RowDefinitions  5   
   �� 5      $
��50px��6   �� 5      .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��Center=�6.   $��Center=�6I   .+�5      �� $��Anasayfa��6   $��Center=�6'   $��Center=�6B   $��20(�6_   $��	ExtraBold"�6m   ���#5F0A876�   �� 5      -   5        $��
RefreshBtn��5      $
��10,0q�6'   
������ 
������ 
���������5      !  FontAwesome.WPF.FontAwesome  5         Icon$ Refresh=�6%   $��25(�64   5      5      � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      �� 5      .+�5      �� $��5q�6   .+�5      �� -   5        $��ProfilePicture��5      $��100px��6.   $��100px��6?   $��100px��6Q   $��100px��6b   $��Center=�6t   $��Center=�6�   �� 5      $ 
Horizontal=�6   $��Center=�66   $��Center=�6S   .+�5        -   5        $��IsUserPrivate��5   %   $��20(�6:   $
 Lock=�6H   $��Center=�6T   $��Center=�6o   $y�	Collapsed=�6�   �� 5       -   5        $��UsernameTxt��5       $��15(�6/   $��Center=�6=   $��Center=�6X   $
��Bold"�6u   ���#A4508B6�     5!      -   5        $��
IsVerified��5!   %   $ CheckCircle=�67   $��20(�6J   $��Center=�6X   $��Center=�6s   $y�	Collapsed=�6�   5"      �� 5#      -   5        $��FullnameTxt��5#      $��Center=�6+   $��Center=�6F   �� 5$      -   5        $��FollowersTxt��5$      $��Takipçi Sayısı:��6,   $��10q�6F   �� 5%      -	   5        $��FollowingsTxt��5%      $��Takip Sayısı:��6-   $��10q�6E   5&      �� 5'      $��1��6   $��Hidden=�6+   $��Hidden=�6P   .��5(      �� $��1��6   $��5q�6-   .+�5)      �� $��Kullanıcı Adı��6   �� 5*      -
   5        $��UsernameBox��5*      $��25��61   �� 5+      $��	Tam İsim��6   �� 5,      -   5        $��FullnameBox��5,      $��25��61   �� 5-      -   5        $��SaveUserSettingsBtn��5-      $��Kaydet��6Z   $
��0 10q�6k   $	��0 5q�6y   5.      5/      50      51      52      