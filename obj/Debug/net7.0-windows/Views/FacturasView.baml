   M S B A M L   `   `   `  ����C  ?Farmacia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Farmacia.ViewsFarmacia.Views  5      !    Farmacia.Views.FacturasView   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Farmacia.Views     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        N� Title$  FacturasView��5      $
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
��Bold"�5X      $��Facturas��5Y      �� 5[      $��0��5\      $��1��5]      $ 
Horizontal=�5^      .+�5`      �� -   5        $��btnEliminar��5a   !   $��1��5b   !   $��20,10,20,10q�5c   !   $��Anular Factura��5e   !   $��25(�5f   !   $
��Bold"�5g   !   #���  5h   !   ��5d   !   �� *AnularFactura+5h   !   5j      5t      5u      �� 5v      .+�5w      �� $
��Auto=�6#   .��5x      &   System.Windows.Controls.DataGrid  -   5          Name$ ItemsDatagrid��5y      $��15q�5z         AutoGenerateColumns$ False��5{      
���   �   CanUserAddRows$
 True��5}         CanUserReorderColumns$ False��5~         CanUserResizeColumns$ False��5        DataGridColumnHeaderStyle1   ColumnHeaderStyle# �  5�        DataGridRowStyle1   RowStyle# �  5�         SelectionMode$ Single=�5�      ��5�      �� *
Facturas+ �� SelectedItem 5�      �� *SelectedFactura+ �� Mode$ TwoWay=�   Columns 5�      4  .System.Windows.Controls.DataGridTemplateColumn  5�   "   ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 5�   %      CanUserResize$ False��5�   %       Header$  #��5�   %   !   
IsReadOnly$
! True��5�   %     5�   "   $ * 5�   %   "   CanUserSort$" False��5�   %   $  Numero Factura��5�   %   #   CellTemplate# 5�   &   �� 5�   *   .R�5�   .   �� .+�5�   2   �� $��20(�5�   5   
���   ���5�   5   �� *
fac_numero+5�   /   5�   +   5�   #     5�   "   $ * 5�   %   $" False��5�   %   $  Fecha��5�   %   # 5�   &   �� 5�   *   .R�5�   .   �� .+�5�   2   �� $��20(�5�   5   
���   ���5�   5   �� *	fac_fecha+5�   /   5�   +   5�   #     5�   "   $ * 5�   %   $" False��5�   %   $  Subtotal��5�   %   # 5�   &   �� 5�   *   .R�5�   .   �� .+�5�   2   �� $��20(�5�   5   
���   ���5�   5   �� *fac_subtotal+5�   /   5�   +   5�   #     5�   "   $ * 5�   %   $" False��5�   %   $	  Iva��5�   %   # 5�   &   �� 5�   *   .R�5�   .   �� $��20(�5�   1   
���   ���5�   1   �� *fac_total_iva+5�   +   5�   #     5�   "   $ * 5�   %   $" False��5�   %   $  Total��5�   %   # 5�   &   �� 5�   *   .R�5�   .   �� $��20(�5�   1   
���   ���5�   1   �� *	fac_total+5�   +   5�   #     5�   "   $ * 5�   %   $" False��5�   %   $  Estado��5�   %   # 5�   &   �� 5�   *   .R�5�   .   �� $��20(�68   ��6F   �� *
fac_tipo+��5�   2   �� 5�   6   " ��6<   .�5�   :   ��  � ��
 �   �6W   $ �� Triggers$ 5�   :   �� 5�   >   % �� Binding% 6J   �� *
fac_tipo+& �� Value
& Activo6g   .a�5�   B   ��  � ��
 � � �6_   5�   ?   �� 5�   >   % 6J   �� *
fac_tipo+& Anulado6g   .a�5�   B   ��  � ��
 �  ��6_   5�   ?   5�   7   5�   /   5�   +   5�   #   5�      5�      5�      5�      5�      5�      5�      