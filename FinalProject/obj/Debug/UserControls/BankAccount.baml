   M S B A M L   `   `   `  ����G  CFinalProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:FinalProject.UserControlsFinalProject.UserControls  5      +    %FinalProject.UserControls.BankAccount   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:FinalProject.UserControls     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmeterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      $��DemiBold"�5      .��5      � ���#9795EF.+�5   
   � -   5          �Name$  bankaccPanel��5      $	��Top=�6%   $	��300��6=    J� IsHitTestVisible .  .+�5      �� $��Center=�6    � DataContext 64   �� *Bank+.+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��10,10q�6   $ 
Horizontal=�6,   .+�5      �� $��80��6   $��
First Name��6'   �� 5      $
��10 0q�6   $��:��6*   �� 5      -   5         ��Name$ fname��5      $	��100��5      $	��3,0q�5      ��5      �� *	FirstName+5      5      �� 5      $��10,10q�6   $ 
Horizontal=�6,   .+�5      �� $��80��6   $��	Last Name��6'   �� 5      $
��10 0q�6   $��:��6*   �� 5      -   5        $ lname��5       $	��100��5"      $	��3,0q�5#      ��5!      �� *
LastName+5$      5%      5&      �� 5'      $��10,10q�6   $ 
Horizontal=�6(   .+�5(      �� $��80��6   $��BankName��6#   �� 5)      $
��10 0q�6   $��:��6&   �� 5*      -   5        $��1q�5+      $	��100��5-      $	��3,0q�5.      ��5,      �� *
BankName+5/      50      �� 51      $��10,10q�6   $ 
Horizontal=�6(   .+�52      �� $��80��6   $��
Account ID��6#   �� 53      $
��10 0q�6   $��:��6&   �� 54      -   5        $	��150��56      $	��3,0q�57      $��1q�58      ��55      �� *	AccountID+59      5:      �� 5;      $��10,10q�6   $ 
Horizontal=�6(   .+�5<      �� $��80��6   $��Credit Card��6#   �� 5=      $
��10 0q�6   $��:��6&   �� 5>      -   5         � 
InputScope$ CurrencyAmount��5@      $	��200��5A      $	��3,0q�5B      $��1q�5C      ��5?      �� *
CreditCard+5D      5E      5F      5G      � 5H   
   $��Bottom=�6   $	��300��6*   $
��0 10q�67   .+�5I      �� -   5         ��Name$ savebtn��5I      $��Bottom=�6&   $��Right=�6A   $��10q�6]   $	��100��6i   $
��Save��6u   $y�	Collapsed=�6�   �� 5J      -   5        $ editbtn��5J      $��Bottom=�6&   $��Right=�6A   $��10q�6]   $	��100��6i   $
��Edit��6u   6�   5K      5L      5M      