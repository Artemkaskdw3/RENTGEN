   M S B A M L   `   `   `  ���� B  >RENTnew, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:RENTnewRENTnew      RENTnew.EditReserch   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:RENTnew     ] YXceed.Wpf.Toolkit.NET5, Version=4.6.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit    � Title$  EditReserch��$	��950��$	��500�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=� � 	Resources  �� 
TargetType �� Property �� Value �� Triggers P� Property	 P� Value   TextBlockForView��%�  '��       '�� �     '�� j    &	      �� " ��.���  � ��$ Arial)���  � ��
 �������  � ��
 �   ���  � ��$ 0q���  � ��$ 10q���  � ��$ 25(���  � ��$ 50�� P�  � ��$
	 True�� ���  � ��
 ������� " ��.���  � ��$ Arial)���  � ��
 �   ���  � ��$ 20(���  � ��$ 0,5,0,0q���  � ��$ 25���� " ��.���  � ��$
 Bold"���  � ��$ Arial)���  � ��
 �   ���  � ��$ 0,5,5,0q���  � ��$ 20(���  � ��$ Center=��� " ��.���  � ��$ Arial)���  � ��
 �   ���  � ��$ 10,0,0,0q���  � ��$ 15(���  � ��$ Center=�.��� 
 � RowDefinitions
 �� $
��Auto ��� $
��Auto �.+��� $��0��.+��� $;��5Редактирование исследования��$��25(�$��Center=��� $��0,30,0,0q�	 �� X1$ 0��	 �� Y1$ 0��	 �� X2$	 900��	 �� Y2$ 0��
�����w�$��4���� $��1��$��10q�.+��� $(��"Дата исследования:��%  Xceed.Wpf.Toolkit.MaskedTextBox  -     Name$ _maskedTextBox��$��0��$��19(�   Mask$ 
00/00/0000��$��26��$��8��$��Arial)��� $��Исследование����  �� Orientation$ 
Horizontal=�.+��� -   $��ReserchTBox��$��1��$��50���� -   $��ReserchTBlock��$
��Left=�#��[  �� $)��#Количество снимков��%  Xceed.Wpf.Toolkit.IntegerUpDown  -   $��PictureTBox��$��2��$��20(�$��Arial)�$��25��$��50��$
��Left=��� $+��%Плановое\Экстренное��	� -   $��	Planovaya��$��3�� 	� 	GroupName$
 Emrg��$��Плановое��$��	0,10,0,10q�$��Arial)�$��15(�	� -   $��	Emergency��$��4��$
 Emrg��$��Экстренное��$��0,0,0,10q�$��Arial)�$��15(��� $7��1Амбулаторное\Стационарное��	� -   $��	Ambulator��$��5��$ InOut��$��Амбулаторное��$��	0,10,0,10q�$��Arial)�$��15(�	� -   $��	Stacionar��$��6��$ InOut��$��Стационарное��$��0,0,0,10q�$��Arial)�$��15(��� $��Отделение���� $ 
Horizontal=�.+��� -	   $��DepTBox��$��7��$��50���� -
   $��	DepTBlock��$
��Left=�#��[  �� $%��ЛПУ прикрепления���� $ 
Horizontal=�.+��� -   $��HCFTBox��$��8��$��50���� -   $��	HCFTBlock��$
��Left=�#��[  �� $��Врач���� $ 
Horizontal=�.+��� -   $��DocTBox��$��9��$��50���� -   $��	DocTBlock��$
��Left=�#��[  �� $��Лаборант���� $ 
Horizontal=�.+��� -   $��
AssistTBox��$��10��$��50���� -   $��AssistTBlock��$
��Left=�#��[  �� $��Заключение���� $ 
Horizontal=�.+��� $
��Left=�$��0,0,10,0q�$��Орган:��#��[  �� -   $��PartOfBodyTBox��$��11��$��50���� -   $��PartOfBodyTBlock��$
��Left=�$��10,0,0,0q�#��[  �� $ 
Horizontal=�.+��� $
��Left=�$��0,0,10,0q�$��Паталогия:��#��[  �� -   $��
ResultTBox��$��12��$��50���� -   $��ResultTBlock��$
��Left=�$��10,0,0,0q�#��[  �� $��Доза��  -   $ _maskedTextBoxDose��$��13��$��19(�$ 0.000��$��26��$��8��$��Arial)��� -   $��Create��$ ��Редактировать���� -   $��BackBTN��$��Отмена��