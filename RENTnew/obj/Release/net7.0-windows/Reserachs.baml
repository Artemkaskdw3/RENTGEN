   M S B A M L   `   `   `  ���� B  >RENTnew, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:RENTnewRENTnew      RENTnew.Reserachs   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:RENTnew       � Title$]  WРентген - Автоматизиврованное рабочее место 1.0.0��$	��900��$
��1600�� � WindowStartupLocation$ CenterScreen=����#DCE4F1 � 	Resources    RENTnew.GenderConverter   GenderConverter �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value)  #System.Windows.Controls.DataGridRow��%�  &	        '��      '  �     '�� !    '�� u      �� " ��.���  � ��$ Arial)���  � �� �#DCE4F1��  � ��
 �   ���  � �� �#DCE4F1��  � ��$ 15(���  � ��$ 10,0,0,0q� P�  � ��$
 True�� ���  � ��
 ������� "  .���  � ��$ Arial)���  � ��$ 25(��� " ��.���  � ��$ Arial)���  � ��
 �   ���  � ��$ 25(��� " ��.���  � ��$ 0,0,5,0q���  � ��$ 20��.��� 	 � RowDefinitions	 �� $��20 ��� $��40 ��� �� .+�o� 
�������$��0��.@�m� $��Начало��.@��� m� $��Справочник��.@��� m� $��Отчеты��.@��� m� $��О программе��.@��� �� $��1��
 �� Orientation$
 
Horizontal=�$��0,0,0,0q�.+��� -   $��Backdown��$��30��.���� $
 
Horizontal=�.+��� $ ��/images/icons8-back-80.png���� $��Вернуться��$��Center=��� -   $��createResBTN��$��30��.���� $
 
Horizontal=�.+��� $ ��/images/icons8-plus-80.png���� $��Создать��$��Center=��� $��30��.���� $
 
Horizontal=�.+��� $ ��/images/icons8-edit-80.png���� $ ��Редактировать��$��Center=��� -   $��Delete��$��30��.���� $
 
Horizontal=�.+��� $%��/images/icons8-trash-can-80.png���� $��Удалить��$��Center=�&   System.Windows.Controls.DataGrid  -   $��	reserchDT��$��
10,0,10,10q�   AutoGenerateColumns$ False��$��2�����	#FFF9F9F9   AlternatingRowBackground �#E8E8E8 �� AlternationCount$ 2��   
IsReadOnly$
 True������    Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$! Дата посещение��   Width5  /System.Windows.Controls.DataGridLengthConverter$ *    FontSize$ 15Q�1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *DateReserch+ �� StringFormat$ 
dd.MM.yyyy��  $/ )Название исследования��$ * $ 15Q� �� *NameRerserch.NameReserch+  $ Заключение��$ * $ 15Q� �� *Result.NamePathologies+�� -   $��PatientName��$��3��