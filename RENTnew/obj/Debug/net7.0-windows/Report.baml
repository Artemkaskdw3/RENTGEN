   M S B A M L   `   `   `  ����B  >RENTnew, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:RENTnewRENTnew  5   	       RENTnew.Report   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:RENTnew     5   	   ] YXceed.Wpf.Toolkit.NET5, Version=4.6.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  6-     � Title$  Report��5   	   $	��300��6   $	��600��6%    � WindowStartupLocation$ CenterScreen=�5	   	   ���#DCE4F1 � 	Resources 5         RENTnew.GenderConverter   GenderConverter �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value��%�  &	        '��      '�� �    '�� "      5   
   6    �� 5   
   " ��6   .�5      ��  � ��$ Arial)�6+   �� 5       � ��
 �����6+   �� 5       � ��
 �   �6+   �� 5       � ��
 �����6,   �� 5       � ��$ 15(�6)   �� 5       � ��$ 10,0,0,0q�6'    5      P� 5       � ��$
 True��6/    �5      �� 5       � ��
 �����67   5      5      �� 5   
   " ��6   .�5      ��  � ��$ Arial)�6+   �� 5       � ��
 �   �6+   �� 5        � ��$ 25(�6)   5!      �� 5"   
   " ��6   .�5#      ��  � ��$ 0,0,5,0q�6'   �� 5$       � ��$ 23��6'   5%      5)      .��5*      � 	 � RowDefinitions	 5,   
   �� 5-      $��40 �6   6*   �� 5.      6   �� 5/      6   .+�52   
   �� $��0��6   
 �� Orientation$
 
Horizontal=�6"   $��0,0,0,0q�6;   
�������.+�53      �� -   5        $��createReportBTN��53   !   $��30��6   .��54      �� $
 
Horizontal=�6   
�������.+�55      �� $"��/images/icons8-excel-144.png��6   �� 56      $)��#Сохранить отчет Ecxel��6%   $��Center=�6E   6b   58      59      �� 5:      $��	Дата:��6    $��15(�6-   $��	10,0,10,0q�6;   $��Center=�6N   6k   %  Xceed.Wpf.Toolkit.MaskedTextBox  5;      -   5          Name$ _maskedTextBox��5;   6   $��0��6)   $��19(�6N      Mask$ 
00/00/0000��6\   $��26��6n   $��8��6z   $��Arial)�6�   �� 5<      $
��По��6    $��15(�6*   $��	10,0,10,0q�68   $��Center=�6K   6h     5=      -   5        $ _maskedTextBox1��5=   6   $��0��6)   $��19(�6O   $ 
00/00/0000��6]   $��26��6o   $��8��6{   $��Arial)�6�   5?      �� 5@   
   -   5        $��PatientName��5@   !   $��3��6   66   5B      5C      