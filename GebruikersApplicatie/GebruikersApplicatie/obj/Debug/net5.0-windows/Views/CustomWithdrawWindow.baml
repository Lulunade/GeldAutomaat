   M S B A M L   `   `   `  ����O  KGebruikersApplicatie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:GebruikersApplicatie.ViewsGebruikersApplicatie.Views  5   	   5    /GebruikersApplicatie.Views.CustomWithdrawWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:GebruikersApplicatie.Views     5   	     � Title$  CustomWithdrawWindow��5   	   $	��700��6&   $
��1200��63   .��5	      � -   5         �Name$
 grid��5	      ���#499F68 � RowDefinitions 5
   
   �� 5      $��50 �6   �� 5       � ColumnDefinitions 5   
   �� 5      .+�5   
   � ���#4D805F$��2��5       5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       �� 5!      �� 5"      �� 5#      �� 5$      .+�5'      �� -   5         ��Name$ LabelQuiztime��5'      $��Geld opnemen��6/   
�������$��0��5)      $��Center=�5*      $��Center=�5+      $��Medium"�5,      $��20(�5-      $��2��5.      �� 50      -   5         ��Name$ btnBack��50      $	��←��51      
�������
������ $��0q�54      $��12��55      $��Center=�56      $��Center=�57      $��Medium"�58      $��30(�59      $��2��5:      5=      �� 5?   
   $��1��6   $��Center=�6"   $��Center=�6=    �� Orientation$ Vertical=�6Z   .+�5@      �� -   5        $��
lblWarning��5@   �   $��Center=�6   $��Center=�68   
�������$��40(�6m   $��0,0,0,20q�6{   .��6�   &$Let op: tot maximaal €500 openemen6�   �� 5A      -   5        $��	txbAmount��5A   8   $��Center=�6   $��	20,0,0,30q�6I   $��80��6\   $	��290��6h   ���#4D805F$��0q�6�   $��50(�6�   $
}�True��6�   
�������6�   �� 5B      $��0,0,0,10q�6   $ 
Horizontal=�6+   $��Center=�6D   .+�5C      �� -   5        $ btnSeven��5C      $��7��6+   
�������$��30(�5E      $��Medium"�5F      $��20,0,0,0q�5H      ��5J      �� 5K       �� 
TargetType" ��6    .�5L      ��  �� Property � ��	 �� Value	 �#4D805F6;   �� 5M       �@�Cursor$
	 Hand��67   
 �� Triggers
 5N      P� 5O   "    P� Property �@J�IsMouseOver P� Value$
 True��6A   . �5P   &   ��  � ��	 �#c8c8c86C   5Q   #   5S      ��5V      �� 5W       �� 
TargetType" ��6*   .R�5X      �� $��80��6%   $��80��60    �� CornerRadius$	 360��5Y   )   #��z��5Z   )   ._�5[   "   �� $��Center=�63   $��Center=�5\   7   5]      5^      5`      �� 5a      -   5        $ btnEight��5a      $��8��6+   
�������$��30(�5c      $��Medium"�5d      $��20,0,0,0q�5f      ��5h      �� 5i      " ��6    .�5j      ��  � ��	 �#4D805F6;   �� 5k       �@�Cursor$
	 Hand��67   
 5l      P� 5m   "    �@J�IsMouseOver$
 True��6A   . �5n   &   ��  � ��	 �#c8c8c86C   5o   #   5q      ��5t      �� 5u      " ��6*   .R�5v      �� $��80��6%   $��80��60   $	 360��5w   )   #��z��5x   )   ._�5y   "   �� $��Center=�63   $��Center=�5z   7   5{      5|      5~      �� 5      -   5        $ btnNine��5      $��9��6*   
�������$��30(�5�      $��Medium"�5�      $��20,0,0,0q�5�      ��5�      �� 5�      " ��6    .�5�      ��  � ��	 �#4D805F6;   �� 5�       �@�Cursor$
	 Hand��67   
 5�      P� 5�   "    �@J�IsMouseOver$
 True��6A   . �5�   &   ��  � ��	 �#c8c8c86C   5�   #   5�      ��5�      �� 5�      " ��6*   .R�5�      �� $��80��6%   $��80��60   $	 360��5�   )   #��z��5�   )   ._�5�   "   �� $��Center=�63   $��Center=�5�   7   5�      5�      5�      5�      �� 5�      $��0,0,0,10q�6   $ 
Horizontal=�6+   $��Center=�6D   .+�5�      �� -	   5        $ btnFour��5�      $��4��6*   
�������$��30(�5�      $��Medium"�5�      $��20,0,0,0q�5�      ��5�      �� 5�      " ��6    .�5�      ��  � ��	 �#4D805F6;   �� 5�       �@�Cursor$
	 Hand��67   
 5�      P� 5�   "    �@J�IsMouseOver$
 True��6A   . �5�   &   ��  � ��	 �#c8c8c86C   5�   #   5�      ��5�      �� 5�      " ��6*   .R�5�      �� $��80��6%   $��80��60   $	 360��5�   )   #��z��5�   )   ._�5�   "   �� $��Center=�63   $��Center=�5�   7   5�      5�      5�      �� 5�      -
   5        $ btnFive��5�      $��5��6*   
�������$��30(�5�      $��Medium"�5�      $��20,0,0,0q�5�      ��5�      �� 5�      " ��6    .�5�      ��  � ��	 �#4D805F6;   �� 5�       �@�Cursor$
	 Hand��67   
 5�      P� 5�   "    �@J�IsMouseOver$
 True��6A   . �5�   &   ��  � ��	 �#c8c8c86C   5�   #   5�      ��5�      �� 5�      " ��6*   .R�5�      �� $��80��6%   $��80��60   $	 360��5�   )   #��z��5�   )   ._�5�   "   �� $��Center=�63   $��Center=�5�   7   5�      5�      5�      �� 5�      -   5        $ btnSix��5�      $��6��6)   
�������$��30(�5�      $��Medium"�5�      $��20,0,0,0q�5�      ��5�      �� 5�      " ��6    .�5�      ��  � ��	 �#4D805F6;   �� 5�       �@�Cursor$
	 Hand��67   
 5�      P� 5�   "    �@J�IsMouseOver$
 True��6A   . �5�   &   ��  � ��	 �#c8c8c86C   5�   #   5�      ��5�      �� 5�      " ��6*   .R�5�      �� $��80��6%   $��80��60   $	 360��5�   )   #��z��5�   )   ._�5�   "   �� $��Center=�63   $��Center=�5�   7   5�      5�      5�      5�      �� 5�      $��0,0,0,10q�6   $ 
Horizontal=�6+   $��Center=�6D   .+�5�      �� -   5        $ btnOne��5�      $��1��6)   
�������$��30(�5     $��Medium"�5     $��20,0,0,0q�5     ��5     �� 5     " ��6    .�5     ��  � ��	 �#4D805F6;   �� 5	      �@�Cursor$
	 Hand��67   
 5
     P� 5  "    �@J�IsMouseOver$
 True��6A   . �5  &   ��  � ��	 �#c8c8c86C   5  #   5     ��5     �� 5     " ��6*   .R�5     �� $��80��6%   $��80��60   $	 360��5  )   #��z��5  )   ._�5  "   �� $��Center=�63   $��Center=�5  7   5     5     5     �� 5     -   5        $ btnTwo��5     $��2��6)   
�������$��30(�5      $��Medium"�5!     $��20,0,0,0q�5#     ��5%     �� 5&     " ��6    .�5'     ��  � ��	 �#4D805F6;   �� 5(      �@�Cursor$
	 Hand��67   
 5)     P� 5*  "    �@J�IsMouseOver$
 True��6A   . �5+  &   ��  � ��	 �#c8c8c86C   5,  #   5.     ��51     �� 52     " ��6*   .R�53     �� $��80��6%   $��80��60   $	 360��54  )   #��z��55  )   ._�56  "   �� $��Center=�63   $��Center=�57  7   58     59     5;     �� 5=     -   5        $ btnThree��5=     $��3��6+   
�������$��30(�5?     $��Medium"�5@     $��20,0,0,0q�5B     ��5D     �� 5E     " ��6    .�5F     ��  � ��	 �#4D805F6;   �� 5G      �@�Cursor$
	 Hand��67   
 5H     P� 5I  "    �@J�IsMouseOver$
 True��6A   . �5J  &   ��  � ��	 �#c8c8c86C   5K  #   5M     ��5P     �� 5Q     " ��6*   .R�5R     �� $��80��6%   $��80��60   $	 360��5S  )   #��z��5T  )   ._�5U  "   �� $��Center=�63   $��Center=�5V  7   5W     5X     5Z     5[     �� 5]     $ 
Horizontal=�6   $��Center=�62   .+�5^     �� -   5        $ btnZero��5^     $��0��6*   
�������$��30(�5`     $��Medium"�5a     $��20,0,0,0q�5c     ��5e     �� 5f     " ��6    .�5g     ��  � ��	 �#4D805F6;   �� 5h      �@�Cursor$
	 Hand��67   
 5i     P� 5j  "    �@J�IsMouseOver$
 True��6A   . �5k  &   ��  � ��	 �#c8c8c86C   5l  #   5n     ��5q     �� 5r     " ��6*   .R�5s     �� $��80��6%   $��80��60   $	 360��5t  )   #��z��5u  )   ._�5v  "   �� $��Center=�63   $��Center=�5w  7   5x     5y     5{     �� 5|     -   5        $ btnDel��5|     $��-��6)   
�������$��30(�5~     $��Medium"�5     $��20,0,0,0q�5�     ��5�     �� 5�     " ��6    .�5�     ��  � ��	 �#4D805F6;   �� 5�      �@�Cursor$
	 Hand��67   
 5�     P� 5�  "    �@J�IsMouseOver$
 True��6A   . �5�  &   ��  � ��	 �#c8c8c86C   5�  #   5�     ��5�     �� 5�     " ��6*   .R�5�     �� $��80��6%   $��80��60   $	 360��5�  )   #��z��5�  )   ._�5�  "   �� $��Center=�63   $��Center=�5�  7   5�     5�     5�     �� 5�     -   5        $ btnEnter��5�     $��OK��6+   
�������$��30(�5�     $��Medium"�5�     $��20,0,0,0q�5�     ��5�     �� 5�     " ��6    .�5�     ��  � ��	 �#4D805F6;   �� 5�      �@�Cursor$
	 Hand��67   
 5�     P� 5�  "    �@J�IsMouseOver$
 True��6A   . �5�  &   ��  � ��	 �#c8c8c86C   5�  #   5�     ��5�     �� 5�     " ��6*   .R�5�     �� $��80��6%   $��80��60   $	 360��5�  )   #��z��5�  )   ._�5�  "   �� $��Center=�63   $��Center=�5�  7   5�     5�     5�     5�     5�     5�     5�     