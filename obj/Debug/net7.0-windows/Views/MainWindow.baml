   M S B A M L   `   `   `  ����C  ?Farmacia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Farmacia.ViewsFarmacia.Views  5          Farmacia.Views.MainWindow   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Farmacia.Views     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      -   5          � Title$  
MainWindow��5      $
��1440��5	      $	��960��5
       � AllowsTransparency$
 True��5      
������  � WindowStartupLocation$ CenterScreen=�5       � WindowState$ Normal=�5       � WindowStyle$
 None=�5      .��5      ��    PrimaryBackgroundColor#���   6    �� CornerRadius$ 8��6C   ._�5   
   �  � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      .+�5      ��   SecundaryBackgroundColor#���  6   $ 8 0 0 8��6M   ._�5      � -   5         �Name$ gridMenu��5      $��60��6)    � RowDefinitions 5      �� 5      $��60 �6(   �� 5      $��80 �6(   �� 5      $
��Auto �6(   �� 5      .+�5"      �� $��1��5#      $	��Top=�5$      	 �� Orientation$	 
Horizontal=�5%      .+�5&      F� $��25��5'      $��25��5(      $��16,0,0,0q�5)      $
��Left=�5*        PrimaryBlueColor#���  5+      
 �� Stretch$

 Fill=�5,      5-      d� 50      -   5         d�Name$ btnMenu��51      $��0,0,15,0q�52      $��Right=�53      $��Center=�54      
������ $��0q�56        MenuIconStyle#��[ 57       � Triggers 58      :� 59       :� RoutedEvent$ ToggleButton.Unchecked��6+   .[�5:   "   �� .��5;   &   �� -   5         ��Name$ HideStackPanel��5;   1   .��5<   *   W�  g� 	BeginTime	 0:0:05=   -    �� 
TargetName$ gridMenu��5>   -    �� TargetProperty$ Width�5?   -    W� From 2005@   -   	 W� To 605A   -    g� Duration$ 0:0:0.1D�5B   -   5C   '   5D   #   5E      :� 5F      $ ToggleButton.Checked��6+   .[�5G   "   �� .��5H   &   �� -   5        $ ShowStackPanel��5H   1   .��5I   *   W� 	 0:0:05J   -   $ gridMenu��5K   -   $ Width�5L   -    605M   -    2005N   -   $ 0:0:0.1D�5O   -   5P   '   5Q   #   5R      5T      �� 5V      $��3��6!   .+�5W      	� -   5         	�Name$ rdHome��5X      $
��Home��5Z       d� 	IsChecked$
 TrueY�5[        MenuRadioButtonStyle#���  5\        home
 � Tag# �  5]      	� 5^      -   5        $ rdSounds��5_      $��0,5,0,5q�5`      $��
Inventario��5b      #���  5c        	inventory# �  5d      	� 5e      -   5        $ rdNotes��5f      $��Facturas��5h      #���  5i        invoice# �  5j      	� 5l      -	   5        $ 
rdClientes��5m      $��0,5,0,5q�5n      $��Clientes��5p      #���  5q        clients# �  5r      	� 5s      -
   5        $ 	rdCompras��5t      $��0,5,0,5q�5u      $��Compras��5w      #���  5x       	 	purchases# � 	 5y      	� 5z      -   5        $ rdVender��5{      $��0,5,0,5q�5|      $��Ventas��5~      #���  5       	
 sales# � 
 5�      	� 5�      -   5        $ 	rdPayment��5�      $��0,5,0,5q�5�      $��Usuarios��5�      #���  5�       	 users# �  5�      5�      �� 5�      $��3��5�      $	��200��5�      $��0,0,0,20q�5�      $��Bottom=�5�      $	 
Horizontal=�5�      .+�5�      A� $��40��5�      $��40��5�      $��10,0,0,0q�5�      ��5�      �� 5�   "    �� ImageSource$! /Assets/wpfui-icon-1024.png��6-   5�      �� 5�      $��8,0,0,0q�6%   $	 Vertical=�66   .+�5�      �� $
��Left=�5�   !   $��Center=�5�   !   $��Farmacia��5�   !   $��14(�5�   !   $��SemiBold"�5�   !     TextPrimaryColor#���  5�   !   �� 5�      $��	0,-10,0,0q�5�   !   $
��Left=�5�   !   $��Center=�5�   !   $��lafarmacia@gmail.com��5�   !   $��11(�5�   !   $��Regular"�5�   !     PrimaryGrayColor#���  5�   !   5�      5�      5�      5�      � 5�      $��1��6    5�      �� 5�      $��60 �6$   �� 5�      .+�5�      �� $��0��5�      $��4��5�      $��30��5�      $��0,5,10,0q�5�      $��Right=�5�      $	��Top=�5�      $��RightToLeft=�5�      $	 
Horizontal=�5�      .+�5�      �� -   5         ��Name$ btnClose��5�       	 close#���  5�        IconButtonsStyle#��[ 5�      $ IsCloseButton��5�      �� 5�      -   5        $ 
btnRestore��5�      $	��5,0q�5�      ��5�      �� 5�       �� BasedOn# [ 6$    �� 
TargetType" ��6P   .�5�   "   ��  �� Property � ��  maximize �� Value# �  6<    �� Triggers 5�   "   �� 5�   &    �� Binding 62   ��   �� ElementName$
  home��! �� Path$! WindowState�" �� Value" 	Maximized6i   .a�5�   *   ��  � ��  restore# �  6D   5�   '   5�      5�      �� 5�      -   5        $ btnMinimize��5�        minimize#���  5�      #���  5�      5�      �� 5�      $��1��6   $��10q�6&   ._�5�       � -   5        #  �Name$# PagesNavigation��5�      $  � NavigationUIVisibility$$ Hidden=�65   5�      5�      5�      5�      5�      5�      