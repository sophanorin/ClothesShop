   M S B A M L   `   `   `  ����G  CFinalProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:FinalProjectFinalProject  5      ,    &FinalProject.Windows.mainwindows.Login   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:FinalProject     5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5        � Title$  Login��5	      $��451.101��5
      $	��600��5       � AllowsTransparency .  � 
ResizeMode$ NoResize=�5       � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5      ��5      Z� .��5      ��  �� CornerRadius$ 10��6   ��5   
   �� 5       �� 
StartPoint$ 0.5,0&�6"    �� EndPoint$ 0.5,1&�65   .��5      �  � Offset$ 0Q�6   	 � Color$	 DeepSkyBlue��6*   � 5      $ 1Q�6   $	 Wheat��6*   5      ._�5   
   � 
 � RowDefinitions
 5      �� 5      $��40 �6    �� 5      .+�5      �� -   5        $��40��5      $��40��6    $��Right=�6,   $��0q�6H   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��6\   ��5      �� 5        �� ImageSource$, &/images/Icons/icons8_delete_48px_1.png��6!   5"      �� 5#      $��1��6   .+�5$      �� $��0 0 0 20q�5%      $��Pattaya)�5&      $��35(�5'      $
��Bold"�5(      
�������$��ClothesShop��5*       �� TextAlignment$ Center=�5+      �� 5,      .+�5-      �� $	��350��5.      $	��400��5/      
�������$ 10��51       J� Effect 52      3  -System.Windows.Media.Effects.DropShadowEffect  53         
BlurRadius$ 10Q�54   !      Opacity$	 0.5Q�55   !      Color$ Black��56   !   ._�58      �� .+�59      �� $
��0,20q�5:   !   $��Cambria)�5;   !   $��25(�5<   !   $
��Bold"�5=   !   
����� �$��Login��5?   !   $ Center=�5@   !   �� 5A      .+�5B   "   �� $
��10,0q�5C   %   $��Username : ��5D   %   $��Arial)�5E   %   $��24(�5F   %    �� Target 5G   %   ��  �� ElementName$ usernamebtn���� 5H   "   -   5         ��Name$ usernamebtn��5I   %   $��50��5K   %   $��
10,0,10,20q�5L   %   $	��5,0q�5M   %   $��Center=�5N   %   .  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush
 ��� �
�������$��0q�5Q   %   $��Arial)�5R   %   $��24(�5S   %   ��5J   %   �� *
Username+ �� UpdateSourceTrigger$ Explicit=�5S   %   �� 5T   "   $
��10,0q�5U   %   $��Password : ��5V   %   $��Arial)�5W   %   $��24(�5X   %    5Y   %   �� $ passwordbtn��G� 5Z   "   -   5         G�Name$ passwordbtn��5[   %   $��50��5]   %   $��
10,0,10,20q�5^   %   $	��5,0q�5_   %   $��Center=�5`   %   
 ��� �
�������$��0q�5c   %   $��Arial)�5d   %   $��24(�5e   %   �� 5f   "   -   5        $	��100��5g   %   $��50��5h   %   $
��0,20q�5i   %   
����� �$��0q�5k   %   $��Login��5m   %   $��Cambria)�5n   %   $��24(�5o   %    �� 	IsDefault . 5p   %   5q      5r      5s      5t      5u      5v      5w      5x      