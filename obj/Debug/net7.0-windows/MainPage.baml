   M S B A M L   `   `   `  ����C  ?Farmacia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:FarmaciaFarmacia  5      7 clr-namespace:Farmacia.ViewModelFarmacia.ViewModel  5      5clr-namespace:Farmacia.ServicesFarmacia.Services  5	          Farmacia.MainPage   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:Farmacia     5      4locales clr-namespace:Farmacia.ViewModel     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      0servclr-namespace:Farmacia.Services     5	        � Title$  MainPage��5
      $
��1080��5      $	��720��5       � DataContext 5      '   !Farmacia.ViewModel.LoginViewModel  5   
   .��5      � 
���   �.+�5   
   ��  �� CornerRadius$ 20��6   ._�5      �� $��2q�6    J� Opacity$
 0.80Q�6)   ��5      �� 5       �� 
StartPoint$	 1,0&�6*    �� EndPoint$	 1,1&�6;   .��5      �  � Offset$ 0Q�6'    � Color$ 
BlueViolet��62   � 5      $
 0.25Q�6'   $
 Aqua��65   � 5      $
 0.50Q�6'   $ PaleVioletRed��65   � 5      $
 0.75Q�6'   $ DarkRed��65   � 5      $ 1Q�6'   $ Orange��62   5      ��5!      �� 5"      $	 0,1&�6*   $	 1,0&�6;   .��5#      � $	 0.0Q�6'   $ #060531��64   � 5$      $
 0.25Q�6'   $ #4A148C��65   � 5%      $
 0.50Q�6'   $ #081462��65   � 5&      $	 0.7Q�6'   $ #081043��64   5'      ._�5)      �� $��25q�6   $��Center=�6)   .+�5*      �� $��25,25,25,100q�5+      $��Center=�5,      $��55(�5-      $
��Bold"�5.      
�������$��Inicia Sesion��50      �� 51      $��	0,0,200,0q�52      $��Center=�53      $��20(�54      $��DemiBold"�55      
�������$��Usuario��57      �� 58      -   5         ��Name$ txtUser��59      $	��350��5:      $��30��5;      $��0,5,0,5q�5<      $��40,0,0,0q�5=      $��Center=�5>      
�������$��0,0,0,1q�5@      	 �� 
CaretBrush
	 �����$��20(�5B      $��Medium"�5C      
���������5E      �� *nombre+
 �� Mode$
 TwoWay=�.��6>   ��5F      �� 5G       j� 
AlignmentX$
 Left=�6)    j� Stretch$ Uniform=�6;   .��5H   .   5I      �� 5J      $	��360��5K      $��Segoe UI)�5L      $��20(�5M      $��DemiBold"�5N      
�������$��Contraseña��5P      G� 5Q      -   5        $	��350��5R      $��30��5S      $��0,5,0,25q�5T      $��40,0,0,0q�5U      $��Center=�5V      
�������$��0,0,0,1q�5X       G� 
CaretBrush
 �����$��
Montserrat)�5Z      $��20(�5[      $��Medium"�5\      
���������5`      �� 5a      $
 Left=�6)   $ Uniform=�6;   5c      �� 5e      -   5         ��Name$ LogIn��5f      $��0,0,0,15q�5g      $��0q�5h      $��Iniciar Sesión��5j       � Cursor$
 Hand��5k      $��
Montserrat)�5l      $��35(�5m      $��Heavy"�5n      
���������5i      �� *LoginCommand+��5p      �� 5q       �� 
TargetType" ��6$   .�5r   "   ��  �� Property � �� �� Value
 �  ��6?    �� Triggers 5s   "   P� 5t   &    P� Property �@J�IsMouseOver P� Value$
 True��6E   . �5u   *   ��  � ��
 �  ��6G   5v   '   5x      ��5z      �� 5{       �� 
TargetType" ��6.   .R�5|   "   �� $	��250��5}   %   $��60��5~   %   #��z��5   %   $ 10��5�   %   ._�5�   &   �� $��Center=�5�   )   $��Center=�5�   )    J� SnapsToDevicePixels$
 True��5�   )   5�   #   5�      ��5�      �� 5�      $	 0,0&�62   $	 1,1&�6C   .��5�   "   � $ 0Q�6/   $ #673AB7��6:   � 5�   "   $	 0.6Q�6/   $ #1f40FF��6<   � 5�   "   $	 0.3Q�6/   $ 
BlueViolet��6<   � 5�   "   $ 1Q�6/   $ DarkSlateBlue��6:   5�      5�      5�      5�      5�      5�      5�      