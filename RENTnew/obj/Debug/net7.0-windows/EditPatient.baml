   M S B A M L   `   `   `  ����B  >RENTnew, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:RENTnewRENTnew  5   	       RENTnew.EditPatient   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:RENTnew     5   	   ] YXceed.Wpf.Toolkit.NET5, Version=4.6.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	     � Title$  EditPatient��5   	   $	��900��6   $	��500��6+    � WindowStartupLocation$ CenterScreen=�5	   	    � 
ResizeMode$ NoResize=�5
   	   
������� � 	Resources 5       �� 
TargetType �� Property �� Value �� Triggers P� Property	 P� Value��%�  '��       '�� �    '�� �    �� 5   
   " ��6   .�5      ��  � ��$ Arial)�6+   �� 5       � ��
 �����6;   �� 5       � ��
 �   �6+   �� 5       � ��$ 0q�60   6<   �� 5       � ��$ 10q�6'   �� 5       � ��$ 25(�6)   �� 5       � ��$ 50��6'   65    5      P� 5       � ��$
	 True��6/    �5      �� 5       � ��
 �����67   5      5      �� 5    
   " ��6   .�5!      ��  � ��$ Arial)�6+   �� 5"       � ��
 �   �6+   �� 5#       � ��$ 20(�6)   �� 5$       � ��$ 0,5,0,0q�6'   69   �� 5%       � ��$ 25��6'   64   5&      �� 5'   
   " ��6   .�5(      ��  � ��$
 Bold"�6+   6:   �� 5)       � ��$ Arial)�6+   �� 5*       � ��
 �   �6+   �� 5+       � ��$ 0,5,5,0q�6'   69   �� 5,       � ��$ 20(�6)   �� 5-       � ��$ Center=�62   5.      5/      .��51      � $��20q�6   
 � RowDefinitions
 52   
   �� 53      $
��Auto �6   �� 54      $
��Auto �6   �� 55      $
��Auto �6   �� 56      $
��Auto �6   �� 57      $
��Auto �6   �� 58      $
��Auto �6   �� 59      $
��Auto �6   �� 5:      $
��Auto �6   �� 5;      $
��Auto �6   �� 5<      $
��Auto �6   �� 5=      $
��Auto �6   �� 5>      $
��Auto �6   �� 5?      $
��Auto �6   �� 5@      $
��Auto �6   �� 5A      $
��Auto �6   �� 5B      $
��Auto �6   �� 5C      $
��Auto �6   �� 5D      $
��Auto �6   �� 5E      $
��Auto �6   �� 5F      $
��Auto �6   �� 5G      $
��Auto �6   �� 5H      $
��Auto �6   .+�5K   
   �� $��0,0,0,30q�6   .+�5L      �� $3��-Редактирование пациента��6   $��25(�67   $��Center=�6E   6e   �� 5M      $��0,30,0,0q�6   	 �� X1$ 0��5N      	 �� Y1$ 0��6   	 �� X2$	 900��5O      	 �� Y2$ 0��6   
�����w�$��4��5Q      5R      5S      �� 5U   
   $��Фамилия:��6   $��1��6$   64   �� 5V   
   -   5        $��surname��5V      $��2��6!   60   �� 5X   
   $��Имя:��6   $��3��6"   61   �� 5Y   
   -   5        $��firstNameTB��5Y      $��4��6%   64   �� 5[   
   $��Отчество:��6   $��5��6'   66   �� 5\   
   -   5        $��middleNameTB��5\      $��6��6&   65   �� 5^   
   $ ��Дата рождения:��6   $��7��6+   6;   %  Xceed.Wpf.Toolkit.MaskedTextBox  5_   
   -   5          Name$ _maskedTextBox��5_      $��19(�65      Mask$ 
00/00/0000��6C   $��26��6U   $��8��6a   �� 5a   
   $��Пол:��6   $��9��6!   61   �� 5b   
   -   5        $��sexCB��5b       �� Text$ 	My Cities��6    $��10��61   $��35��6?   $��20(�6K   .@�5c      �� 
�������$��Arial)�62   .��6F   Мужской6O   �� 5d      $��Arial)�6   .��6/   Женский68   5e      �� 5h   
   $��Город:��6   $��11��6"   �� 5i   
   -   5         ��Name$ cityTextBox��5i      $��
Томск��6'   $��12��65   �� 5k   
   $��Улица:��6   $��13��6"   �� 5l   
   -   5        $ streetTextBox��5l      $��14��6)   �� 5n   
   $��Дом №:��6   $��15��6$   �� 5o   
   -   5        $ houseTextBox��5o      $��16��6)   �� 5q   
   $��Литера:��6   $��17��6$   �� 5r   
   -	   5        $ letterTextBox��5r      $��18��6*   �� 5t   
   $��Квартира №:��6   $��19��6'   �� 5u   
   -
   5        $ apartmentTextBox��5u      $��20��6,   �� 5z   
   $��21��6   $��20q�6#   .+�5{      �� -   5        $��Create��5{   -   $ ��Редактировать��6   6S   �� 5|      -   5        $
��Back��5|   &   $��Отмена��6   6G   5}      5~      5      