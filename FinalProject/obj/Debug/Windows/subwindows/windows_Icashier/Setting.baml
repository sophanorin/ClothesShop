   M S B A M L   `   `   `  ����G  CFinalProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulls>clr-namespace:FinalProject.Windows.subwindows.windows_Icashier0FinalProject.Windows.subwindows.windows_Icashier  5      E'clr-namespace:FinalProject.UserControlsFinalProject.UserControls  5      >    8FinalProject.Windows.subwindows.windows_Icashier.Setting   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Plocal>clr-namespace:FinalProject.Windows.subwindows.windows_Icashier     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmetarialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      :UserControls'clr-namespace:FinalProject.UserControls  5      -   5          �Name$
  this��5       � Title$ Setting��5
       � Icon$% /images/icons/settings_96px.png��5      $	��700��5      $	��500��5      $��14(�5       � 
ResizeMode$ NoResize=�5       � WindowStartupLocation$ CenterOwner=�5      .��5      ]� .+�5   
   �� $��10��6   $	��Top=�6    K� ZIndex$ 4��62    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Opacity$	 0.2Q�6#      Color$
 Gray��61   ��5      �� 5      	 �� 
StartPoint$		 0,0&�6&   
 �� EndPoint$
 0.5,1&�67   .��5      �  � Offset$	 0.7Q�6#    � Color$ 	#FFA88BEB��60   � 5      $ 1Q�6#   $ 	#FF5DE6DE��6.   5      5      � 5   
   $
��Left=�6   $ 5��6%   .+�5       �� $��0q�6   ��5!      �� 5"      $	 0.5,0&�6*   $
 0.5,1&�6=   .��5#      � $ 0Q�6'   $ 	#FFA88BEB��62   � 5$      $ 1Q�6'   $ 	#FF5DE6DE��62   5%      ._�5'      � $	��200��6    � RowDefinitions 5(      �� 5)      $��* �6(   �� 5*      $��3* �6(   .+�5,      '  !MaterialDesignThemes.Wpf.PackIcon  $��0��5-      $��50��5.      $��50��5/      $��Center=�50      $��Center=�51      
�������   Kind$ Settings=�54      ��52      Z� 54      �� 55      $��1��6!   .+�56      �� $��Disabled=�6'   $
��Auto=�6P   .��57      �� .+�58   "   �� -   5         ��Name$ Informationbtn��59   %   $
��0,10q�5:   %   $��0q�5<   %   
���������5;   %   Z� .��5@   &   � $	��200��6+   $��-20,0q�67    � ColumnDefinitions 5A   *   �� 5B   .   $��* �6?   �� 5C   .   $
��2.3* �6?   .+�5E   *     $��0��5F   -   $��25��5G   -   $��25��5H   -   $
��20,0q�5I   -   $
��Left=�5J   -   $
 User=�5K   -   �� 5L   *   $��1��5M   -   $
��10,0q�5N   -   $��Center=�5O   -   $��Information��5P   -    �� TextAlignment$
 Left=�5Q   -   5R   '   5S   #   �� 5T   "   -   5        $ Passwordbtn��5U   %   $
��0,10q�5V   %   $��0q�5X   %   
���������5W   %   Z� .��5\   &   � $	��200��6+   $��-20,0q�67    5]   *   �� 5^   .   $��* �6?   �� 5_   .   $
��2.3* �6?   .+�5a   *     $��0��5b   -   $��25��5c   -   $��25��5d   -   $
��20,0q�5e   -   $
��Left=�5f   -   $ FormTextboxPassword=�5g   -   �� 5h   *   $��1��5i   -   $
��10,0q�5j   -   $��Center=�5k   -   $��	Passwords��5l   -   $
 Left=�5m   -   5n   '   5o   #   �� 5p   "   -   5        $ Bankaccountbtn��5q   %   $
��0,10q�5r   %   $��0q�5t   %   
���������5s   %   Z� .��5x   &   � $	��200��6+   $��-20,0q�67    5y   *   �� 5z   .   $��* �6?   �� 5{   .   $
��2.3* �6?   .+�5}   *     $��0��5~   -   $��25��5   -   $��25��5�   -   $
��20,0q�5�   -   $
��Left=�5�   -   $
 Bank=�5�   -   �� 5�   *   $��1��5�   -   $
��10,0q�5�   -   $��Center=�5�   -   $��BankAccount��5�   -   $
 Left=�5�   -   5�   '   5�   #   �� 5�   "   -   5        $
��0,10q�5�   )   $��0q�5�   %   
���������5�   %   Z� .��5�   &   � $	��200��6+   $��-20,0q�67    5�   *   �� 5�   .   $��* �6?   �� 5�   .   $
��2.3* �6?   .+�5�   *     $��0��5�   -   $��25��5�   -   $��25��5�   -   $
��20,0q�5�   -   $
��Left=�5�   -   $ Refresh=�5�   -   �� 5�   *   $��1��5�   -   $
��10,0q�5�   -   $��Center=�5�   -   $��Refresh��5�   -   $
 Left=�5�   -   5�   '   5�   #   5�      5�      5�      5�      5�      5�      �� 5�   
   -   5         ��Name$ 
BlockPanel��5�      $��0��5�      $��2��5�      $��0��5�      $��2��5�      $ -1��5�      ���#9795EF.+�5�      +   %FinalProject.UserControls.Information  -   5          Name$ InformationPanel��5�   a   $	��462��6{   $y�	Collapsed=�6�   $ 2��6�      EmployeeInformation 6'   �� *
Employee+ �� ElementName$
 this��6�   (   "FinalProject.UserControls.Password  5�      -   5          Name$ PasswordPanel��5�   P   $	��450��6g   $y�	Collapsed=�6t   $ 2��6�      Login 6$   �� *
Password+$
 this��6�   +   %FinalProject.UserControls.BankAccount  5�      -	   5          Name$ BankAccountPanel��5�   U   $	��462��6o   $y�	Collapsed=�6|   $ 2��6�      Bank 6'   �� *BankAccount+$
 this��6�   5�      5�      5�      