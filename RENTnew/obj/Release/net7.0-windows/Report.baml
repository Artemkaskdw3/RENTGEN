   M S B A M L   `   `   `  ���� B  >RENTnew, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:RENTnewRENTnew      RENTnew.Report   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:RENTnew     ] YXceed.Wpf.Toolkit.NET5, Version=4.6.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit    � Title$  Report��$	��300��$	��600�� � WindowStartupLocation$ CenterScreen=����#DCE4F1 � 	Resources    RENTnew.GenderConverter   GenderConverter �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value��%�  &	        '��      '�� �     '�� 1      �� " ��.���  � ��$ Arial)���  � ��
 �������  � ��
 �   ���  � ��
 �������  � ��$ 15(���  � ��$ 10,0,0,0q� P�  � ��$
 True�� ���  � ��
 ������� " ��.���  � ��$ Arial)���  � ��
 �   ���  � ��$ 25(��� " ��.���  � ��$ 0,0,5,0q���  � ��$ 23��.��� 	 � RowDefinitions	 �� $��40 ��� �� .+��� $��0��
 �� Orientation$
 
Horizontal=�$��0,0,0,0q�
�������.+��� -   $��createReportBTN��$��30��.���� $
 
Horizontal=�
�������.+��� $"��/images/icons8-excel-144.png���� $)��#Сохранить отчет Ecxel��$��Center=��� $��	Дата:��$��15(�$��	10,0,10,0q�$��Center=�%  Xceed.Wpf.Toolkit.MaskedTextBox  -     Name$ _maskedTextBox��$��0��$��19(�   Mask$ 
00/00/0000��$��26��$��8��$��Arial)��� $
��По��$��15(�$��	10,0,10,0q�$��Center=�  -   $ _maskedTextBox1��$��0��$��19(�$ 
00/00/0000��$��26��$��8��$��Arial)��� -   $��PatientName��$��3��