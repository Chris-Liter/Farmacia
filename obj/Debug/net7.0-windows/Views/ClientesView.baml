   M S B A M L   `   `   `  ����C  ?Farmacia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Farmacia.ViewsFarmacia.Views  5      !    Farmacia.Views.ClientesView   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Farmacia.Views     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        N� Title$  ClientesView��5      $
��1440��5	      $	��960��5
       � 	Resources 5         btnColorPrimario �� Color  btnColorSecundario  btnColorTernario  btnPrimario �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� Padding	 �� CornerRadius
 J� SnapsToDevicePixels ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  &	        &	 !     &	 B     &	 c     �� 5   
   $ #304FFE��63   �� 5   
   $ #FFFFFF��65   �� 5   
   $ #0026CA��63   �� 5   
   " ��6$   .�5      ��  � ��
 ���� 6+   �� 5       � ��# �  6+   �� 5       � ��# �   6,   �� 5       � ��$	 400"�6+   �� 5       � ��$ 	12,6,12,6q�6(   �� 5       � ��$ 2q�60   �� 5       � ��$
 Auto��6&   �� 5       � ��$ Center=�6;   �� 5       � ��$ Center=�69   �� 5       � �� 5      �� 5      " ��6&   .R�5       �� $ 	btnBorder��5!      #��z��5"      # z��5#      #��z��5$      #��z��5%      #��z��5&      $	 10��5'      $

 True��5(      ._�5)      �� $ ContentPresenter��5*   !   #��z��5+   !   #��z��5,   !   #��z��5-   !   $|�False��5.   !   $
��True��5/   !   #
 z
 50   !   51       52      P� 53       �@J�IsMouseOver$
 True��6=   . �54   "   �� $ 	btnBorder��6)    � �� �#304FFE6V   �� 55   "    � ��$ #ffffff��6<   57      P� 58       � ��$
 True��6;   . �59   "   �� $ 	btnBorder��6)    � ��
 �����6V   5;      5=      5?      5A      5B      .��5D      � .+�5E   
   ��   SecundaryBackgroundColor#���  6   $	 5��6I   ._�5F      �� .+�5G      ��  �� Orientation$ 
Horizontal=�6   .+�5I      �  � ColumnDefinitions 5J      �� 5K      $
��Auto �6/   �� 5L      $��* �6/    � RowDefinitions 5N      �� 5O      $��* �6,   �� 5P      $��* �6,   .+�5R      �� $��0��5S      $��0��5T      $��	30,5,0,10q�5U      $��Center=�5V      $��20(�5W      $
��Bold"�5X      $��Clientes��5Y      �� 5[      $��0��5\      $��1��5]      $ 
Horizontal=�5^      .+�5_      �� -   5        $	��btn��5`   !   $��1��5a   !   $��20,10,20,10q�5b   !   $��Agregar Cliente��5d   !   $��25(�5e   !   $
��Bold"�5f   !   #���  5g   !   ��5c   !   �� *
AbrirCreat+5g   !   �� 5h      -   5        $��	btnEditar��5i   !   $��1��5j   !   $��20,10,20,10q�5k   !   $��Editar Cliente��5m   !   $��25(�5n   !   $
��Bold"�5o   !   #���  5p   !   ��5l   !   �� *AbrirUpdate+5p   !   �� 5q      -   5        $��btnEliminar��5r   !   $��1��5s   !   $��20,10,20,10q�5t   !   $��Eliminar Cliente��5v   !   $��25(�5w   !   $
��Bold"�5x   !   #���  5y   !   ��5u   !   �� *Delete+5y   !   5{      �� 5|      $��1��6%   .+�5}      �� $	��307��5~   !   $��35,0,0,0q�5   !   
�������
���   �  ModernTextBox#��[ 5�   !   ��5�   !   �� *SearchProduct+ �� Mode$ TwoWay=�5�      5�      5�      �� 5�      $
��Left=�6   .+�5�      �� $
��Auto=�6#   .��5�      &   System.Windows.Controls.DataGrid  -   5          Name$ ItemsDatagrid��5�      $��15q�5�         AutoGenerateColumns$ False��5�      
���   �   CanUserAddRows$
 True��5�         CanUserReorderColumns$ False��5�         CanUserResizeColumns$ False��5�        DataGridColumnHeaderStyle1   ColumnHeaderStyle# �  5�        DataGridRowStyle1   RowStyle# �  5�         SelectionMode$ Single=�5�      ��5�      �� *
Clientes+ �� SelectedItem 5�      �� *SelectedCliente+$ TwoWay=�   Columns 5�      4  .System.Windows.Controls.DataGridTemplateColumn  5�   "   ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 350 5�   %      CanUserSort$ False��5�   %       Header$  Nombres��5�   %   !   CellTemplate! 5�   &   �� 5�   *   .R�5�   .   �� .+�5�   2   �� $��27(�5�   5   
���   ���5�   5   �� *cli_nombres+5�   /   5�   +   5�   #     5�   "   $	 350 5�   %   $ False��5�   %   $  	Apellidos��5�   %   ! 5�   &   �� 5�   *   .R�5�   .   �� .+�5�   2   �� $��27(�5�   5   
���   ���5�   5   �� *cli_apellidos+5�   /   5�   +   5�   #     5�   "   $	 300 5�   %   $ False��5�   %   $  Cedula��5�   %   ! 5�   &   �� 5�   *   .R�5�   .   �� $��27(�5�   1   
���   ���5�   1   �� *
cli_cedula+5�   +   5�   #     5�   "   $ False��69   $  Correo��6M   ! 5�   &   �� 5�   *   .R�5�   .   �� $��27(�5�   1   
���   ���5�   1   �� *
cli_correo+5�   +   5�   #   5�      5�      5�      5�      5�      5�      5�      