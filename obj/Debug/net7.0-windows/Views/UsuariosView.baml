   M S B A M L   `   `   `  ����C  ?Farmacia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Farmacia.ViewsFarmacia.Views  5      !    Farmacia.Views.UsuariosView   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Farmacia.Views     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        N� Title$  UsuariosView��5      $
��1440��5	      $	��960��5
       � 	Resources 5         btnColorPrimario �� Color  btnColorSecundario  btnColorTernario  btnPrimario �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� Padding	 �� CornerRadius
 J� SnapsToDevicePixels ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  &	        &	 !     &	 B     &	 c     �� 5   
   $ #304FFE��63   �� 5   
   $ #FFFFFF��65   �� 5   
   $ #0026CA��63   �� 5   
   " ��6$   .�5      ��  � ��
 ���� 6+   �� 5       � ��# �  6+   �� 5       � ��# �   6,   �� 5       � ��$	 400"�6+   �� 5       � ��$ 	12,6,12,6q�6(   �� 5       � ��$ 2q�60   �� 5       � ��$
 Auto��6&   �� 5       � ��$ Center=�6;   �� 5       � ��$ Center=�69   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $ 	btnBorder��5       #��z��5!      # z��5"      #��z��5#      #��z��5$      #��z��5%      $	 10��5&      $

 True��5'      ._�5(      �� $ ContentPresenter��5)   !   #��z��5*   !   #��z��5+   !   #��z��5,   !   $|�False��5-   !   $
��True��5.   !   #
 z
 5/   !   50       51      P� 52       �@J�IsMouseOver$
 True��6=   . �53   "   �� $ 	btnBorder��6)    � �� �#304FFE6V   �� 54   "    � ��$ #ffffff��6<   56      P� 57       � ��$
 True��6;   . �58   "   �� $ 	btnBorder��6)    � ��
 �����6V   5:      5<      5>      5@      5A      .��5B      � .+�5C   
   ��   SecundaryBackgroundColor#���  6   $	 5��6I   ._�5D      �� .+�5E      ��  �� Orientation$ 
Horizontal=�6   .+�5G      �  � ColumnDefinitions 5H      �� 5I      $
��Auto �6/   �� 5J      $��* �6/    � RowDefinitions 5L      �� 5M      $��* �6,   �� 5N      $��* �6,   .+�5P      �� $��0��5Q      $��0��5R      $��	30,5,0,10q�5S      $��Center=�5T      $��20(�5U      $
��Bold"�5V      $��Usuarios��5W      �� 5Y      $��0��5Z      $��1��5[      $ 
Horizontal=�5\      .+�5]      �� -   5        $	��btn��5^   !   $��1��5_   !   $��20,10,20,10q�5`   !   $��Agregar Usuario��5b   !   $��25(�5c   !   $
��Bold"�5d   !   #���  5e   !   ��5a   !   �� *
OpenCreate+5e   !   �� 5f      -   5        $��	btnEditar��5g   !   $��1��5h   !   $��20,10,20,10q�5i   !   $��Editar Usuario��5k   !   $��25(�5l   !   $
��Bold"�5m   !   #���  5n   !   ��5j   !   �� *
OpenEdit+5n   !   �� 5o      -   5        $��btnEliminar��5p   !   $��1��5q   !   $��20,10,20,10q�5r   !   $��Eliminar Usuario��5t   !   $��25(�5u   !   $
��Bold"�5v   !   #���  5w   !   ��5s   !   �� *
DeleteUser+5w   !   5y      �� 5z      $��1��6%   .+�5{      �� $	��307��5|   !   $��35,0,0,0q�5}   !   
�������
���   �  ModernTextBox#��[ 5�   !   ��5�   !   �� *
searchUser+ �� Mode$ TwoWay=�5�      5�      5�      �� 5�      .+�5�      &   System.Windows.Controls.DataGrid  -   5          Name$ ItemsDatagrid��5�      $��15q�5�         AutoGenerateColumns$ False��5�      
���   �   CanUserAddRows$
 True��5�         CanUserReorderColumns$ False��5�         CanUserResizeColumns$ False��5�        DataGridColumnHeaderStyle1   ColumnHeaderStyle# �  5�        DataGridRowStyle1   RowStyle# �  5�         SelectionMode$ Single=�5�      $
��1305��60   ��5�      �� *Users+ �� SelectedItem 5�      �� *UserSelected+$ TwoWay=�   Columns 5�      4  .System.Windows.Controls.DataGridTemplateColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 5�   !      CanUserResize$ False��5�   !       Header$  #��5�   !   !   
IsReadOnly$
! True��5�   !     5�      $ * 5�   !   "   CanUserSort$" False��5�   !   $  Nombre��5�   !   #   CellTemplate# 5�   "   �� 5�   &   .R�5�   *   �� .+�5�   .   �� $��20(�5�   1   
���   ���5�   1   �� *nombre+5�   +   5�   '   5�        5�      $ * 5�   !   $" False��5�   !   $  Email��5�   !   # 5�   "   �� 5�   &   .R�5�   *   �� .+�5�   .   �� $��20(�5�   1   
���   ���5�   1   �� *email+5�   +   5�   '   5�        5�      $ * 5�   !   $" False��5�   !   $  Permisos��5�   !   # 5�   "   �� 5�   &   .R�5�   *   �� $��20(�5�   -   
���   ���5�   -   �� *
permisos+5�   '   5�      5�      5�      5�      5�      5�      5�      