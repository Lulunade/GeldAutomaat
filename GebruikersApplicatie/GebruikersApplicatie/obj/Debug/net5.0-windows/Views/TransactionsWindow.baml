   M S B A M L   `   `   `  ����O  KGebruikersApplicatie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:GebruikersApplicatieGebruikersApplicatie  5   	   -    'GebruikersApplicatie.TransactionsWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:GebruikersApplicatie     5   	     � Title$  TransactionsWindow��5   	   $	��700��6$   $
��1200��61   .��5	      � -   5         �Name$
 grid��5	      ���#499F68 � RowDefinitions 5
   
   �� 5      $��50 �6   �� 5       � ColumnDefinitions 5   
   �� 5      .+�5   
   � ���#4D805F$��2��5       5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       �� 5!      �� 5"      �� 5#      �� 5$      .+�5'      �� $��Transacties��6   
�������$��0��5)      $��Center=�5*      $��Center=�5+      $��Medium"�5,      $��20(�5-      $��2��5.      �� 50      -   5         ��Name$ btnBack��50      $	��←��51      
�������
������ $��0q�54      $��13��55      $��Center=�56      $��Center=�57      $��Medium"�58      $��30(�59      $��2��5:      5<      �� 5=   
   $��1��6   $��Center=�6"   $��Center=�6=   .+�5>      &   System.Windows.Controls.DataGrid  -   5        $��dgClient��5>      $	��200��6'   $	��560��64      AutoGenerateColumns$ False��5?         
IsReadOnly$
 true��5@         CanUserSortColumns$ False��5B      ��5A      ��  �� Path$ LoadDataBinding�	   Columns	 5C      0  *System.Windows.Controls.DataGridTextColumn  5D      
   FontSize$
 40Q�6)   ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 67   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6B   �� $ deposit�  5E      $
 40Q�6)   $	 100 67    6C   �� $ amount�  5F      $
 40Q�6)   $	 400 67    6C   �� $
 date�5H      5J      5K      5L      