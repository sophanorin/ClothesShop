   M S B A M L   `   `   `  ����G  CFinalProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullo<clr-namespace:FinalProject.Windows.subwindows.windows_Iadmin.FinalProject.Windows.subwindows.windows_Iadmin  5      B    <FinalProject.Windows.subwindows.windows_Iadmin.ViewEmployees   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Nlocal<clr-namespace:FinalProject.Windows.subwindows.windows_Iadmin     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      -   5          �Name$
  this��5       � Title$ ViewEmployees��5	      $
��1000��5
      $	��500��5      $��15(�5       � 
ResizeMode$ NoResize=�5       � WindowStartupLocation$ CenterOwner=�5      .��5      � .+�5   
   �� ��5      �� 5       �� 
StartPoint$	 1,0&�6&   .��5      �  � Color$ 	#7F7F70DB��6#   � 5       � Offset$	 0.5Q�6#   $ 	#7F5414FF��60   � 5      $ 1Q�6#   $ 	#7FFB89E6��6.   5      ._�5      &   System.Windows.Controls.DataGrid  $��0��5      
���   �$
��Auto=�5         AutoGenerateColumns .  ��5      �� *	Employees+ �� ElementName$
 this��	 �� SelectedItem	 5       �� *SelectedItem+$
 this��
 � ContextMenu
 5"      �� 5#      .@�5$      m� -   5        $��Remove��5$   #   63   5%         Columns 5'      0  *System.Windows.Controls.DataGridTextColumn  5(         
Foreground
 �   �,  &System.Windows.Controls.DataGridColumn   Header$	 Sex��6[   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   �� *
EmployeeID+6[     5)      
 �   �$ FistName��6Z    6)   �� *	FirstName+6Z     5*      
 �   �$ LastName��6Y    6)   �� *
LastName+6Y     5+      
 �   �$	 Sex��6T    6)   �� *Sex+6T     5,      
 �   �$ DateOfBirth��6|    6)   �� *DateOfBirth+ �� StringFormat$ {0:dd-mmmm-yyyy}��6|     5-      
 �   �$ Phone��6V    6)   �� *Phone+6V     5.      
 �   �$ Email��6V    6)   �� *Email+6V     5/      
 �   �$ Address��6X    6)   �� *	Address+6X     50      
 �   �$
 Zone��6U    6)   �� *Zone+6U     51      
 �   �$ Position��6Y    6)   �� *
Position+6Y   53      54      55      56      