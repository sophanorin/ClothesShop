   M S B A M L   `   `   `  ����V  RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullI:clr-namespace:ControlzEx;assembly=MaterialDesignThemes.Wpf
ControlzEx  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      G CFinalProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:FinalProjectFinalProject 5	      .   (FinalProject.Windows.mainwindows.Cashier   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Q
ControlzEx:clr-namespace:ControlzEx;assembly=MaterialDesignThemes.Wpf     5      9System&clr-namespace:System;assembly=mscorlib     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:FinalProject     5	      FmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5
      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006   5      -   5          �Name$
  this��5       � Title$ Cashier��5      $
��1920��5      $
��1080��5      $��Bahnschrift)�5      $
��Bold"�5       � Icon$ /images/Icons/R.png��5       � WindowState$ 	Maximized=�5       � WindowStyle$
 None=�5       � Triggers 5      :� 5   
    :� RoutedEvent$ ButtonBase.Click��6    :� 
SourceName$ ButtonOpenCheckOut��66   .[�5      ��    OpenCheckOut#��[  6   5      :� 5   
   $ ButtonBase.Click��6   $ ButtonCloseCheckOut��66   .[�5      ��   CloseCheckOut#��[ 6   5      .��5       ]� .+�5!   
   ��  K� ZIndex$ 1��6   $	��Top=�6"   	 J� Effect	 5"      3  -System.Windows.Media.Effects.DropShadowEffect  5#      
   
BlurRadius$
 20Q�5$         	Direction$	 -90Q�5%         Opacity$ 1Q�5&         Color$ 	LightGray��5'      ._�5)      �� 
������� �� Orientation$ Vertical=�61   .+�5*      �� $	��Top=�6   .+�5+      � $��0,20,0,0q�6    � ColumnDefinitions 5,      �� 5-      $
��373* �6/   �� 5.      $
��584* �6/   .+�50      �� $��2��51      $��50,0,0,0q�52      $��Center=�53      $ 
Horizontal=�54      .+�55      �� $ Vertical=�6)   .+�56   "   �� -   5         ��Name$ tbsearch��57   %   $	��300��58   %   $��32��59   %   $��Center=�5:   %   $��Center=�5;   %   .   (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush
 �   �
������ $��20(�5@   %   $��Regular"�5A   %    J� RenderTransformOrigin$ 0.203,0.607&�5C   %    �� TextAlignment$ Right=�5D   %   ��5=   %   Z�  �� 
CaretBrush 5?   %   Z� 5D   %   � 5E   "   $	��300��5F   %   $��2��5G   %   $
��Left=�5H   %   
���   �5I   %   5J      �� 5K      -   5         ��Name$ 	Searchbtn��5L   !   $
��10,0q�5M   !   $��0q�5N   !   ��5P   "   �� 5Q   &    �� ImageSource$, &/images/Icons/icons8_search_24px_1.png��61   5S      5T      �� 5U      $��1��5V      $��40��5W      $��Right=�5X      $ 
Horizontal=�5Y      .+�5Z      �� -   5        $��STOCK��5\   !     	topbarbtn#��[ 5]   !   �� 5^      -   5        $��HISTORY��5`   !   #��[ 5a   !   �� 5b      -   5        $ orderstatusbtn��5c   !   $��ORDER STATUS��5e   !   #��[ 5f   !   '   !MaterialDesignThemes.Wpf.PopupBox  5h         ToggleContent$ 
MY ACCOUNT��5i   z   $
��Bold"�5j   n   $��15(�5k   h   
�������$
��20 0q�5m   f   $��Center=�5n   �      PopupContent. 5o   "   �� $	��100��6-   .+�5p   &   �� -   5        $��Center=�5q   )   $��Setting��5u   )   
���   ���5r   )   Z� ��5s   )   Z� 5v   )   �� 5w   &   -   5        $��Center=�5x   )   $��LogOut��5|   )   
���   ���5y   )   Z� ��5z   )   Z� 5}   )   5~   #   5      �� 5�      -	   5        #��[ 5�   :   .��5�   "   �� $.��(/images/Icons/icons8_shutdown_26px_2.png��6(   5�      5�      5�      � 5�      .+�5�      �� .+�5�      � $��
10,25,20,0q�6#   .+�5�   "   �� $	��Top=�6-   $ 
Horizontal=�6E   .+�5�   &   �� -
   5        
 J� Uid$ 0��5�   )   $	��All��5�   )     
menubarbtn#��[ 5�   )   �� 5�   &   -   5        $ 1��5�   )   $	��MEN��5�   )   #��[ 5�   )   �� 5�   &   -   5        $ 2��5�   )   $��WOMEN��5�   )   #��[ 5�   )   �� 5�   &   -   5        $ 3��5�   )   $��SHOES��5�   )   #��[ 5�   )   �� 5�   &   -   5        $ 4��5�   )   $
��BAGS��5�   )   #��[ 5�   )   �� 5�   &   -   5        $ 5��5�   )   $��	ACCESSORY��5�   )   #��[ 5�   )   �� 5�   &   -   5        $ 6��5�   )   $��OTHER��5�   )   #��[ 5�   )   5�   #   5�      � 5�      -   5         �Name$ 
GridCursor��5�   !   $	��150��5�   !   $��5��5�   !   $
��10,0q�5�   !   $
��Left=�5�   !   ���	#FF2196F35�   !   5�      �� 5�      $��1��5�      $��Right=�5�      $��Bottom=�5�      .+�5�      �� -   5        $ ButtonOpenCheckOut��5�   !   $
��20,5q�5�   !   $��	CHECK-OUT��5�   !   #��[ 5�   !   5�      5�      5�      5�      5�      � 5�   
   .+�5�      �� $ -1��5�      
����� �$��Hidden=�5�      .��5�      �� .+�5�      �� $��	20,20,0,0q�6!   .+�5�      �� -   5         ��Name$ ListViewProducts��5�   '   ��6A   �� *	Product+��5�      �� 5�   "   .R�5�   &   �� $	��180��5�   )   $	��270��5�   )   $��5,0,0,5q�5�   )   
�������._�5�   *   �� .+�5�   .   �� $ 1��65   y�6F   �� *IsTag+.+�5�   2   �� $��50��5�   5   $��20��5�   5   $��	-1,16,0,0q�5�   5   
���  ��$ 0.5,0.5&�5�   5   z�5�   6   V� 5�   :   .~�5�   >   �� �� 5�   >   �� 5�   >    �� Angle$	 -50Q�6N   T� 5�   >   5�   ;   ._�5�   6   �� $��Center=�6<   ��6Y   �� *
OffPercent+ �� StringFormat$ {0:P}��5�   3   5�   /   �� 5�   .   $	��170��5�   1   $	��210��5�   1   $��5q�5�   1   	 5�   2     5�   6      ShadowDepth$ 1Q�6G   ��5�   2   �� 5�   6    6A   �� *Image+5�   /   ]� 5�   .   $	��5,0q�68   .+�5�   2   �� .+�5�   6   �� $ 
Horizontal=�6A   .+�5�   :   �� $	��0,3q�5�   =   $��18(�5�   =   ��5�   =   �� *Price+$ {0:C}���� 5�   :   $	��5,3q�5�   =   $��18(�5�   =   
�������$��Strikethrough{�5  =   ��5   =   �� *Price2+$ {0:C}��y�5  =   �� *IsOff+5  7   �� 5  6   $��15(�6@   ��6N   �� *Description+5  3   � 5  2   $��Right=�67   .+�5  6   �� -   5        $��50��5  9   $��40��5	  9   
���  ��$��0q�5  9   
 � Tag 5  9   �� .��5  :   �� $��20��5  =   $��20��5  =   $��Center=�5  =   $)��#/images/Icons/add_shopping_cart.png��5  =   5  7   5  3   5  /   5  +   5  '   5  #   ��5     �� 5  "   .R�5  &   � 5  #   5     5      5!     5"     � 5#     -   5        $ GridCheckOut��5$     $��0��5%     $��Right=�5&     $
 1000��5'     
������.+�5)     ]� $
��10,0q�6   .+�5*     �� $	��Top=�6!   .+�5+     �� -   5        $ ButtonCloseCheckOut��5,     $��50��5-     $��50��5.     $��-10,0q�5/     $
��Left=�50     $	��Top=�51     $��0q�53     ��52     Z� .��55     '   !MaterialDesignThemes.Wpf.PackIcon      Kind$  ArrowForward=�66   56     �� 57     $��0,0,0,20q�58     $��Pattaya)�59     $��35(�5:     
�������$��MyShop��5<     ! �� TextAlignment$! Center=�5=     5>     �� 5@     $��0,0,0,10q�5A     
�������$��Bottom=�5C     .+�5D     �� .+�5E     �� $	��180��5F  !   
���   �$��1q�5H  !   ._�5J  "   �� $��20q�6-   " � DataContext" 69   �� *	SubCost+.+�5K  &   � $	��0,5q�6+   .+�5L  *   �� $��SubTotal��64   $
! Left=�6D   �� 5M  *   $��Right=�64   ��6P   �� *
SubTotal+$ {0:C}��5N  '   � 5O  &   $	��0,5q�6+   .+�5P  *   �� $��Discount��64   $
! Left=�6D   �� 5Q  *   $! Right=�6d   ��64   �� *
Discount+$ {0:P}��6d   5R  '   � 5S  &   $	��0,5q�6+   .+�5T  *   �� $	��Fee��64   $
! Left=�6?   �� 5U  *   $��$0.00��64   $! Right=�6A   5V  '   � 5W  &   $	��0,5q�6+   .+�5X  *   �� $	��Tax��64   $
! Left=�6?   �� 5Y  *   $! Right=�6_   ��64   �� *Tax+$ {0:C}��6_   5Z  '   � 5\  &   $
��0,10q�6+   .+�5]  *   �� $��30(�5^  -   $
��Bold"�5_  -   $��Total��5`  -   $
! Left=�5a  -   �� 5b  *   $��30(�5c  -   $
��Bold"�5d  -   $! Right=�5f  -   ��5e  -   �� *Total+$ {0:C}��5f  -   5g  '   5h  #   5i     � 5j      5k  "   �� 5l  &   �� 5m  &   .+�5o  "   �� -   5        $ calculatebtn��5p  %   $��0��5q  %   $��Calulate��5s  %   �� 5t  "   -   5        $ Cashbtn��5u  %   $��1��5v  %   $
��Cash��5x  %   5y     � 5z      5{  "   �� 5|  &   �� 5}  &   �� 5~  &   �� 5  &   .+�5�  "   �� -   5        $��0��5�  %   $
��Save��5�  %   �� 5�  "   -   5        $��2��5�  %   $��Discount��5�  %   �� 5�  "   -   5        $��1��5�  %   $��Remove��5�  %   �� 5�  "   -   5        $��3��5�  %   $��Clear��5�  %   5�     5�     5�     �� 5�     
�������.+�5�     � $��5q�6    5�     �� 5�  "   $��3* �63   �� 5�  "   $
��1.8* �63   �� 5�  "   $
��1.5* �63   .+�5�     �� $��0��5�  !   $��16(�5�  !   $��
ExtraLight"�5�  !   
�������$��Description��5�  !   �� 5�     $��1��5�  !   $��16(�5�  !   $��
ExtraLight"�5�  !   
�������$��Amount��5�  !   $! Center=�5�  !   �� 5�     $��2��5�  !   $��16(�5�  !   $��
ExtraLight"�5�  !   
�������$��Price��5�  !   $! Center=�5�  !   5�     �� 5�     $��2��5�     $	��5,0q�5�     
�������5�     �� 5�     -   5        # ��Name$# CheckOutList��5�     $	��320��5�     $��0q�5�     $��Disabled=�5�     $��Hidden=�5�     ��5�     �� *Lists+$ �� SelectedIndex$ 5�     �� *SelectedIndex+% �� ElementName$
% this��& � ContextMenu& 5�     �� 5�  "   .@�5�  &   m� $
��Edit��6/   m� 5�  &   -   5        $��Remove��5�  D   m� 5�  &   $��Go to Stock��6/   5�  #   ��5�     �� 5�  "   .R�5�  &   �� $��30��5�  )   $	��0,7q�5�  )   $��0q�5�  )   .��5�  *   � $	��565��6/    5�  .   �� 5�  2   $��3* �6C   �� 5�  2   $
��1.8* �6C   �� 5�  2   $
��1.5* �6C   .+�5�  .   �� $��0��5�  1   $��Center=�5�  1   $��16(�5�  1   $��
ExtraLight"�5�  1   
�������$
��Wrap=�5�  1   ��5�  1   �� *Description+5�  1   �� 5�  .   $��1��5�  1   $��Center=�5�  1   $��16(�5�  1   $��
ExtraLight"�5�  1   
�������$! Center=�5�  1   ��5�  1   �� *Amount+$
 x{0}��5�  1   �� 5�  .   $��2��5�  1   $��Center=�5�  1   $��16(�5�  1   $��
ExtraLight"�5�  1   
�������$! Center=�5�  1   ��5�  1   �� *Price+$ {0:C}��5�  1   5�  +   5�  '   5�  #   5�     5�     5�     5�     5�     5�     5�     