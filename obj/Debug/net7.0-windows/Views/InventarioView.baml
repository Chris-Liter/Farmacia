   M S B A M L   `   `   `  ����C  ?Farmacia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Farmacia.ViewModelFarmacia.ViewModel  5      /clr-namespace:Farmacia.ViewsFarmacia.Views  5      #    Farmacia.Views.InventarioView   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7
inventario clr-namespace:Farmacia.ViewModel     5      .localclr-namespace:Farmacia.Views     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        N� Title$  InventarioView��5	      $
��1220��5
      $	��960��5       � 	Resources 5         btnColorPrimario �� Color  btnColorSecundario  btnColorTernario  btnPrimario �� 
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
��Bold"�5X      $��
Inventario��5Y      �� 5[      $��0��5\      $��1��5]      $ 
Horizontal=�5^      .+�5_      �� -   5        $	��btn��5`   !   $��1��5a   !   $��20,10,20,10q�5b   !   $��Agregar Producto��5d   !   $��25(�5e   !   $
��Bold"�5f   !   #���  5g   !   ��5c   !   �� *Open+5g   !   �� 5h      -   5        $��	btnEditar��5i   !   $��1��5j   !   $��20,10,20,10q�5k   !   $��Editar Producto��5n   !   $��25(�5o   !   $
��Bold"�5p   !   #���  5q   !   ��5m   !   �� *EditarProducto+5q   !   �� 5r      -   5        $��btnEliminar��5s   !   $��1��5t   !   $��20,10,20,10q�5u   !   $��Eliminar Producto��5x   !   $��25(�5y   !   $
��Bold"�5z   !   #���  5{   !   ��5w   !   �� *DeleteProduct+5{   !   5}      �� 5~      $��1��6%   .+�5      �� $	��307��5�   !   $��35,0,0,0q�5�   !   
�������
���   �  ModernTextBox#��[ 5�   !   ��5�   !   �� *SearchProduct+ �� Mode$ TwoWay=�5�      5�      5�      �� 5�      .+�5�      �� $
��Auto=�6#   .��5�      &   System.Windows.Controls.DataGrid  -   5          Name$ ItemsDatagrid��5�      $��15q�5�         AutoGenerateColumns$ False��5�      
���   �   CanUserAddRows$
 True��5�         CanUserReorderColumns$ False��5�         CanUserResizeColumns$ False��5�        DataGridColumnHeaderStyle1   ColumnHeaderStyle# �  5�        DataGridRowStyle1   RowStyle# �  5�         SelectionMode$ Single=�5�      ��5�      �� *	Productos+ �� SelectedItem 5�      �� *SelectedProduct+$ TwoWay=�   Columns 5�      4  .System.Windows.Controls.DataGridTemplateColumn  5�   "   ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 5�   %      CanUserResize$ False��5�   %       Header$  #��5�   %   !   
IsReadOnly$
! True��5�   %     5�   "   $ * 5�   %   "   CanUserSort$" False��5�   %   $  Codigo��5�   %   #   CellTemplate# 5�   &   �� 5�   *   .R�5�   .   �� .+�5�   2   �� $��20(�5�   5   
���   ���5�   5   �� *codigo_producto+5�   /   5�   +   5�   #     5�   "   $ * 5�   %   $" False��5�   %   $  Nombre��5�   %   # 5�   &   �� 5�   *   .R�5�   .   �� .+�5�   2   �� $��20(�5�   5   
���   ���5�   5   �� *nombre+5�   /   5�   +   5�   #     5�   "   $ * 5�   %   $" False��5�   %   $  Precio��5�   %   # 5�   &   �� 5�   *   .R�5�   .   �� .+�5�   2   �� $��20(�5�   5   
���   ���5�   5   �� *precio+5�   /   5�   +   5�   #     5�   "   $ * 5�   %   $" False��5�   %   $  Stock��5�   %   # 5�   &   �� 5�   *   .R�5�   .   �� $��20(�5�   1   
���   ���5�   1   �� *stock+5�   +   5�   #   5�      5�      5�      5�      5�      5�      5�      