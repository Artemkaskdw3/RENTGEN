   M S B A M L   `   `   `  ���� B  >RENTnew, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:RENTnewRENTnew      RENTnew.EditPatient   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:RENTnew     ] YXceed.Wpf.Toolkit.NET5, Version=4.6.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit    � Title$  EditPatient��$	��900��$	��500�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=�
������� � 	Resources  �� 
TargetType �� Property �� Value �� Triggers P� Property	 P� Value��%)  '��       '�� �     '�� j    �� " ��.���  � ��$ Arial)���  � ��
 �������  � ��
 �   ���  � ��$ 0q���  � ��$ 10q���  � ��$ 25(���  � ��$ 50�� P�  � ��$
	 True�� ���  � ��
 ������� " ��.���  � ��$ Arial)���  � ��
 �   ���  � ��$ 20(���  � ��$ 0,5,0,0q���  � ��$ 25���� " ��.���  � ��$
 Bold"���  � ��$ Arial)���  � ��
 �   ���  � ��$ 0,5,5,0q���  � ��$ 20(���  � ��$ Center=�.��� $��20q�
 � RowDefinitions
 �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� $��0,0,0,30q�.+��� $3��-Редактирование пациента��$��25(�$��Center=��� $��0,30,0,0q�	 �� X1$ 0��	 �� Y1$ 0��	 �� X2$	 900��	 �� Y2$ 0��
�����w�$��4���� $��Фамилия:��$��1���� -   $��surname��$��2���� $��Имя:��$��3���� -   $��firstNameTB��$��4���� $��Отчество:��$��5���� -   $��middleNameTB��$��6���� $ ��Дата рождения:��$��7��%  Xceed.Wpf.Toolkit.MaskedTextBox  -     Name$ _maskedTextBox��$��19(�   Mask$ 
00/00/0000��$��26��$��8���� $��Пол:��$��9���� -   $��sexCB�� �� Text$ 	My Cities��$��10��$��35��$��20(�.@��� 
�������$��Arial)�.��Мужской�� $��Arial)�.��Женский�� $��Город:��$��11���� -    ��Name$ cityTextBox��$��
Томск��$��12���� $��Улица:��$��13���� -   $ streetTextBox��$��14���� $��Дом №:��$��15���� -   $ houseTextBox��$��16���� $��Литера:��$��17���� -	   $ letterTextBox��$��18���� $��Квартира №:��$��19���� -
   $ apartmentTextBox��$��20���� $��21��$��20q�.+��� -   $��Create��$ ��Редактировать���� -   $
��Back��$��Отмена��