   M S B A M L   `   `   `  ����U  QSystem.Runtime, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a7,clr-namespace:System;assembly=System.RuntimeSystem  5      C ?Farmacia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Farmacia.Views.ScreensFarmacia.Views.Screens 5      /   )Farmacia.Views.Screens.ManipularInventory   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      ?System,clr-namespace:System;assembly=System.Runtime     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:Farmacia.Views.Screens     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      -   5          �Name$
  comp��5	       � Title$ Producto��5
      $	��600��5      $	��400��5       � 
ResizeMode$ NoResize=�5       � WindowStartupLocation$ CenterScreen=�5      .��5      � -   5         �Name$ miCompo��5      .+�5   
   �� ��5      �� 5       �� 
StartPoint$	 0,1&�6&    �� EndPoint$	 1,0&�67   .��5      �  � Offset$	 0.6Q�6#    � Color$ #060531��60   � 5      $
 0.10Q�6#   $ #4A148C��61   � 5      $
 0.25Q�6#   $ #081462��61   � 5      $	 0.7Q�6#   $ #081043��60   5      ._�5      � $��20q�6   	 � RowDefinitions	 5      �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5       $
��Auto �6$   �� 5!      $
��Auto �6$   �� 5"      $
��Auto �6$   �� 5#      $��* �6$   
 � ColumnDefinitions
 5%      �� 5&      $
��Auto �6'   �� 5'      $��* �6'   .+�5+      �� $��0��5,      $��0��5-      $
��15,5q�5.      $��Center=�5/      $��20(�50      
�������$��Codigo:��52      �� 53      -   5        $��
lbl_codigo��54      $��0��55      $��1��56      $
��15,5q�57      $��Center=�58      $��20)�59      ��5:      �� *codigo_producto+�� 5=      $��1��5>      $��0��5?      $
��15,5q�5@      $��Center=�5A      $��20(�5B      
�������$��Precio:��5D      �� 5E      -   5         ��Name$ 
lbl_precio��5F      $��1��5G      $��1��5H      $
��15,5q�5I      $��Center=�5J      $��20)�5K      ��5L      �� *precio+�� 5O      $��2��5P      $��0��5Q      $
��15,5q�5R      $��Center=�5S      $��20(�5T      
�������$��Nombre:��5V      �� 5W      -   5        $ 
lbl_nombre��5X      $��2��5Y      $��1��5Z      $
��15,5q�5[      $��Center=�5\      $��20)�5]      ��5^      �� *nombre+�� 5a      $��3��5b      $��0��5c      $
��15,5q�5d      $��Center=�5e      $��20(�5f      
�������$��Stock:��5h      �� 5i      -   5        $ 	lbl_stock��5j      $��3��5k      $��1��5l      $
��15,5q�5m      $��Center=�5n      $��20)�5o      ��5p      �� *stock+�� 5s      $��4��5t      $��0��5u      $
��15,5q�5v      $��Center=�5w      $��20(�5x      
�������$
��Iva:��5z      �� 5{      -   5        $ lbl_iva��5|      $��4��5}      $��1��5~      $
��15,5q�5      $��Center=�5�      $��20)�5�      ��5�      �� *iva+�� 5�      $��5��5�      $��2��5�      $��15,20q�5�      $��Stretch=�5�      .+�5�      �� $��Center=�5�      $��Guardar��5�      $��30(�5�      $��UltraExpanded&�5�      $
��Bold"�5�         btnPrimario#���   5�      ��5�      �� *CreateOrUpdate+ �� Mode$ TwoWay=�5�      5�      5�      5�      5�      5�      