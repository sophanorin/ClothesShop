   M S B A M L   `   `   `  ����G  CFinalProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulls>clr-namespace:FinalProject.Windows.subwindows.windows_Icashier0FinalProject.Windows.subwindows.windows_Icashier  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089M4clr-namespace:System.Globalization;assembly=mscorlibSystem.Globalization 5      @    :FinalProject.Windows.subwindows.windows_Icashier.Calculate   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Plocal>clr-namespace:FinalProject.Windows.subwindows.windows_Icashier     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      TSystemGlobalization4clr-namespace:System.Globalization;assembly=mscorlib     5        � Title$  	Calculate��5	      $	��380��5
      $	��320��5      ���#12cad6$��18(�5       � 
ResizeMode$ NoResize=�5      $��DemiBold"�5       � WindowStartupLocation$ CenterOwner=�5      .��5      �� .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��10q�6.   .+�5      �� $��Total : ��6   $	��100��6'   �� 5      -   5         ��Name$ Total��5      $	��200��6%   $	��1.2q�61   
���   � J� IsHitTestVisible .   �� TextAlignment$ Right=�6�   $	��5 0q�6  
���������6t   �� *Total+" �� DefaultThreadCurrentCulture �� ConverterCulture# Z 	 �� StringFormat$	 {0:C}��6  5      �� 5   
   $ 
Horizontal=�6   $��10q�6.   .+�5      �� $��
Recieve : ��6   $	��100��6)   �� 5      -   5        $ 	tbRecieve��5      $	��200��6)   $	��1.2q�65   
���   �$	��5 0q�6_   
�������$ Right=�6�   ��6�   �� *	Recieve+
 �� UpdateSourceTrigger$
 PropertyChanged=�5      �� 5   
   $ 
Horizontal=�6   $��10q�6.   .+�5      �� $��	Refund : ��6   $	��100��6(   �� 5      $	��200��6   $	��1.2q�6"   
���   �$	��5 0q�6L   
�������$ Right=�6m    .  ��6�   �� *Refund+$	 {0:C}��$
 PropertyChanged=�6�   5      � 5    
   $	��125��6   .+�5!      �� $ 
Horizontal=�6   $	��Top=�62   $��10q�6J   .+�5"      	� -   5        $	��USD��5"      $
��10 0q�6,    	� 	GroupName$ currency��6:    d� 	IsChecked$
 TrueY�6O   
 � Tag$ en-Us��6`   6l   	� 5#      -   5        $
��Rial��5#      $
��10 0q�6-   $ currency��6;   $ km-KH��6P   6\   	� 5$      -   5        $��Renminbi��5$      $
��10 0q�61   $ currency��6?   $ zh-CN��6T   6`   	� 5%      -   5        $
��Baht��5%      $
��10 0q�6-   $ currency��6;   $ th-TH��6P   6\   5&      �� 5'      $��Bottom=�6   $ 
Horizontal=�64   $��Right=�6M   $��10q�6i   .+�5(      �� -   5        $��	Calculate��5(      $
��10 0q�6-   $	��100��6;   6G   �� 5)      -   5        $��OK��5)      $	��100��6&   62   5*      5+      5,      5-      