   M S B A M L   `   `   `  ����B  >RENTnew, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:RENTnewRENTnew  5   	       RENTnew.Reserachs   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:RENTnew     5   	     � Title$]  WРентген - Автоматизиврованное рабочее место 1.0.0��5   	   $	��900��6C   $
��1600��6P    � WindowStartupLocation$ CenterScreen=�5	   	   ���#DCE4F1 � 	Resources 5         RENTnew.GenderConverter   GenderConverter �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value)  #System.Windows.Controls.DataGridRow��%<  &	        '��      '  �    '��     '�� �      5   
   6    �� 5   
   " ��6   .�5      ��  � ��$ Arial)�6+   �� 5       � �� �#DCE4F16+   �� 5       � ��
 �   �6+   �� 5       � �� �#DCE4F16,   �� 5       � ��$ 15(�6)   �� 5       � ��$ 10,0,0,0q�6'    5      P� 5       � ��$
 True��6/    �5      �� 5       � ��
 �����67   5      5      �� 5   
   "  6   .�5      ��  � ��$ Arial)�6+   �� 5       � ��$ 25(�6)   5      �� 5    
   " ��6   .�5!      ��  � ��$ Arial)�6+   �� 5"       � ��
 �   �6+   �� 5#       � ��$ 25(�6)   5$      �� 5%   
   " ��6   .�5&      ��  � ��$ 0,0,5,0q�6'   �� 5'       � ��$ 20��6'   5(      5,      .��5-      � 	 � RowDefinitions	 5/   
   �� 50      $��20 �6   6*   �� 51      $��40 �6   6*   �� 52      6   �� 53      6   .+�56   
   o� 
�������$��0��6"   .@�57      m� $��Начало��6   .@�58      �� 6   59      m� 5:      $��Справочник��6   .@�5;      �� 6   5<      m� 5=      $��Отчеты��6   .@�5>      �� 6   5?      m� 5@      $��О программе��6   .@�5A      �� 6   5B      5C      �� 5D   
   $��1��6   
 �� Orientation$
 
Horizontal=�6"   $��0,0,0,0q�6;   .+�5E      �� -   5        $��Backdown��5E   !   $��30��6   .��5F      �� $
 
Horizontal=�6   .+�5G      �� $ ��/images/icons8-back-80.png��6   �� 5H      $��Вернуться��6%   $��Center=�69   6V   5I      5J      �� 5K      -   5        $��createResBTN��5K   !   $��30��6   .��5L      �� $
 
Horizontal=�6   .+�5M      �� $ ��/images/icons8-plus-80.png��6   �� 5N      $��Создать��6%   $��Center=�67   6T   5O      5P      �� 5Q      $��30��6   .��5R      �� $
 
Horizontal=�6   .+�5S      �� $ ��/images/icons8-edit-80.png��6   �� 5T      $ ��Редактировать��6%   $��Center=�6=   6Z   5U      5V      �� 5W      -   5        $��Delete��5W   !   $��30��6   .��5X      �� $
 
Horizontal=�6   .+�5Y      �� $%��/images/icons8-trash-can-80.png��6   �� 5Z      $��Удалить��6%   $��Center=�67   6T   5[      5\      5]      &   System.Windows.Controls.DataGrid  5^   
   -   5        $��	reserchDT��5^   '   $��
10,0,10,10q�6      AutoGenerateColumns$ False��6~   $��2��6�   ���	#FFF9F9F9   AlternatingRowBackground �#E8E8E8 �� AlternationCount$ 2��6�      
IsReadOnly$
 True��6�   ��68   ��    Columns 5`      0  *System.Windows.Controls.DataGridTextColumn  5a      ,  &System.Windows.Controls.DataGridColumn   Header$! Дата посещение��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6x      FontSize$ 15Q�6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *DateReserch+ �� StringFormat$ 
dd.MM.yyyy��6�     5b      $/ )Название исследования��6%   $ * 6q   $ 15Q�6{    6D   �� *NameRerserch.NameReserch+6{     5c      $ Заключение��6%   $ * 6d   $ 15Q�6n    69   �� *Result.NamePathologies+6n   5e      �� 5h   
   -   5        $��PatientName��5h   !   $��3��6   66   5j      5k      