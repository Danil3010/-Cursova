   M S B A M L   `   `   `  ����  Cursova1    Cursova1.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$#  Довідник лікаря��5   	   $	��350��6!   $	��974��6.    � Icon 5      �� 5   
    �� 	UriSource$= 7C:\Users\danil\OneDrive\Рабочий стол\ava.png?�6   .��5      �  � RowDefinitions 5	   
   �� 5
      $
��Auto �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��5q�6.   .+�5      �� -   5        $'��!Сортувати хвороби��5      61   �� 5      -   5        $/��)Сортувати медикаменти��5      65   �� 5      -   5        $!��Додати хворобу��5      6.   �� 5      -   5        $'��!Додати медикамент��5      61   �� 5      -   5        $%��Видалити хворобу��5      60   �� 5      -   5        $+��%Видалити медикамент��5      63   �� 5      -   5        $)��#Редагувати хворобу��5      62   �� 5      -   5        $/��)Редагувати медикамент��5      65   5      �� 5   
   $��1��6   .@�5      �� $��Хвороби��6   .��5      �� -	   5        $��diseasesListView��5       �� View 5      �� 5      .P�5      �� $��
Назва��6-    �� DisplayMemberBinding 6<   �� *Name+�� 5      $��Симптоми��6-    6?   �� *
Symptoms+�� 5      $��Процедури��6-    6@   �� *
Procedures+�� 5       $��Ліки��6-    6;   �� *	Medicines+5!      5#      5$      �� 5'      $��Медикаменти��6   .��5(      �� -
   5        $��medicinesListView��5(       5)      �� 5*      .P�5+      �� $��
Назва��6-    6<   �� *Name+�� 5,      $��Кількість��6-    6@   �� *
Quantity+�� 5-      $&�� Взаємозамінність��6-    6G   �� *Interchangeable+5.      50      51      52      53      54      