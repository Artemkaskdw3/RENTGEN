   M S B A M L   `   `   `  ���� B  >RENTnew, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:RENTnewRENTnew      RENTnew.MainWindow   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:RENTnew     ] YXceed.Wpf.Toolkit.NET5, Version=4.6.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit    � Title$]  WРентген - Автоматизиврованное рабочее место 1.0.0��$	��900��$
��1600�� � WindowStartupLocation$ CenterScreen=�
������� � 	Resources    RENTnew.GenderConverter   GenderConverter �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value)  #System.Windows.Controls.DataGridRow  PageButtonStyle	 �� 
TargetType
 �� CornerRadius��%  &	        '��      '  �     '�� !    '�� u    &	 �      �� " ��.���  � ��$ Arial)���  � �� �#DCE4F1��  � ��
 �   ���  � �� �#DCE4F1��  � ��$ 25(���  � ��$ 06,0,0,0q� P�  � ��$
 True�� ���  � ��
 ������� "  .���  � ��$ Arial)���  � ��$ 25(��� " ��.���  � ��$ Arial)���  � ��
 �   ���  � ��$ 25(��� " ��.���  � ��$ 0,0,5,0q���  � ��$ 20���� " ��.���  � �� �#DCE4F1��  � ��
 �   ���  � ��$
 Bold"���  � ��$ 50����  � ��$ 25����  � �� �� "	 ��.R��� #��z��
���   �$��1q�$
 8��._��� $��Center=�$��Center=� P�  � ��$
 True�� ���  � ��
 �����.���   
 Adress � Orientation��%a  &	       �� .R�� $ 
Horizontal=�.+��� $��15(����� *City+�� $�� ул. ��$��15(��� $��15(����� *Street+�� $��	, дом ��$��15(��� $��15(����� *
Building+�� $��, литера ��$��15(��� $��15(����� *Letter+�� $��, квартира ��$��15(��� $��15(����� *Appartaments+ � RowDefinitions �� $��20 ��� .+�o� $��0��
�������.@�m� $��Начало��m� $��Справочник��.@��� m� $��Отчеты��.@�m� -   $��RentWork��$B��<Отчет рентгенологическая работа��m� $��О программе��.@��� A� $��1�����#DCE4F1.+��  �� $��30 ��� $��40 ��� �� $��40 �.+�� $��0��$ 
Horizontal=�.+��� $��Фамилия:��$��15(�$��5q��� -   $��SearchTB��$	��200��$��20���� $ ��Дата рождения:��$��15(�$��10,5,0,0q�%  Xceed.Wpf.Toolkit.MaskedTextBox  -     Name$ _maskedTextBox��$��15(�   Mask$ 
00/00/0000��$��25��$
��auto���� -   $��Filter��$!��Принять фильтр��$��15(�$��10,0,5,0q��� -   $��Update��$%��Отчистить фильтр��$��15(�$��0,0,0,0q�� $��1��$ 
Horizontal=�$��5q�.+��� -   $��CreatePatient��$��15(�.����  �� Orientation$ 
Horizontal=�.+��� $ ��/images/icons8-plus-80.png���� $��Создать��$��Center=��� -   $��OpenBTN��$��15(�.���� $ 
Horizontal=�.+��� $)��#/images/icons8-opened-folder-80.png���� $��Открыть��$��Center=��� -   $
��Edit��$��15(�.���� $ 
Horizontal=�.+��� $ ��/images/icons8-edit-80.png���� $ ��Редактировать��$��Center=��� -	   $��UdateBTN��$��15(�.���� $ 
Horizontal=�.+��� $#��/images/icons8-refresh-80.png���� $��Обновить��$��Center=��� -
    ��Name$ Delete��$��15(�.���� $ 
Horizontal=�.+��� $%��/images/icons8-trash-can-80.png���� $��Удалить��$��Center=�&   System.Windows.Controls.DataGrid  -   $��	patientDG��   CanUserSortColumns$ False��   AlternatingRowBackground �#E8E8E8 �� AlternationCount$ 2��$��2��   AutoGenerateColumns$ False��   
IsReadOnly$
 True��$��10q�$��15(����	#FFF9F9F9����    Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Дата создание��   Width5  /System.Windows.Controls.DataGridLengthConverter$ *    FontSize$ 15Q�1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
CreateDate+ �� StringFormat$ dd.MM.yyyy, HH:mm��  $ Фамилия��$ * $ 15Q� �� *	Surname+  $ Имя��$ * $ 15Q� �� *	FirstName+  $ Отчество��$ * $ 15Q� �� *
MiddleName+  $ Дата рождения��$ * $ 15Q� �� *Age+$ 
dd.MM.yyyy��  $ Пол��$ * $ 15Q� �� *Sex+ �� 	Converter# [  4	  .System.Windows.Controls.DataGridTemplateColumn	  $ 
Адрес�� 	  CellTemplate# [ �� $��3��$ 
Horizontal=�.+��� -   $��Amount��$'��!Количество строк: ��$��15(�$��10q��� -   $��btnBack��$	��<<<��#��[ �� -   $��numOfPageTB��$��1 ��$��15(�$��10q��� -   $��btnNext��$	��>>>��#��[ 