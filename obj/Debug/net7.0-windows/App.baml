   M S B A M L   `   `   `  ����C  ?Farmacia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:FarmaciaFarmacia  5      b ^PresentationFramework.Aero2, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35hKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2Microsoft.Windows.Themes 5          Farmacia.App   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      (localclr-namespace:Farmacia     5      ]themeKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2     5      A =Wpf.Ui, Version=3.0.4.0, Culture=neutral, PublicKeyToken=null/ui&http://schemas.lepo.co/wpfui/2022/xaml  5        �� 	Resources  5
       �� MergedDictionaries$  Wpf.Ui.Markup.ThemesDictionary   Theme&   Wpf.Ui.Markup.ControlsDictionary �� Source   ColumnHeaderGripperStyle �� 
TargetType �� Property �� Value �� 
TargetType �� Padding  DataGridColumnHeaderStyle1=  7System.Windows.Controls.Primitives.DataGridColumnHeader3  -Microsoft.Windows.Themes.DataGridHeaderBorder	   CanUserSort
   IsClickable J� IsMouseOver   	IsHovered   	IsPressed   SeparatorBrush   SeparatorBrush   SeparatorVisibility   SeparatorVisibility   SortDirection   SortDirection J� SnapsToDevicePixels n�Name �� Color  DataGridTemplate1&   System.Windows.Controls.DataGrid  DataGridCellStyle1*  $System.Windows.Controls.DataGridCell �� Triggers P� Property P� Value   FocusBorderBrushKey ]� 
Conditions �� Property �� Value  DataGridRowStyle1)  #System.Windows.Controls.DataGridRow ��Name �� CornerRadius?  9System.Windows.Controls.Primitives.SelectiveScrollingGrid  � ColumnDefinitions! � RowDefinitions?	  9System.Windows.Controls.Primitives.DataGridCellsPresenter"   
ItemsPanelA
  ;System.Windows.Controls.Primitives.DataGridDetailsPresenter$#   SelectiveScrollingOrientation$   DetailsVisibility:  4System.Windows.Controls.Primitives.DataGridRowHeader  DataGridStyle1% ��Name  DataGridRowStyle2�� 5   
    5        5      $
 Dark=�6&     5      �� 5      $ Styles/LightTheme.xaml?�6%   �� 5      $ Styles/MainStyle.xaml?�6%   �� 5      $ Assets/Icons/Icons.xaml?�6%   %�  &	        &	     7   7   (�� �    5E      *DataGrid.FocusBorderBrushKey+)&	 �    &	 '    &	 �    &	 �    &	     �� 5      " n�65   .�5      ��  � ��$ 8��6*   �� 5       � ��
 ���� 6/   �� 5       �@�Cursor$ SizeWE��6+   �� 5       � �� 5      �� 5      " n�6*   .R�5      �� # z��6%   #��z��6I   5      5      5      �� 5      "  67   .�5       ��  � ��$ Center=�6=   �� 5!       � ��
 ���� 6/   �� 5"       � �� �#69717d6/   �� 5#       � �� 5$      �� 5%      "  6*   .R�5&      � .+�5'   "     # z��5(   %   #��z��5)   %   #��z��5*   %   #��z��5+   %   #
 z	 5,   %   # z 5-   %   # z��5.   %   # z 5/   %   # z 50   %   # z 51   %   ._�52   &   �� #��z��53   )   #��z��54   )   $
��True��55   )   # z 56   )   57   #   n� 58   "   $ PART_LeftHeaderGripper��59   %   $
��Left=�5:   %   8��  5;   %   n� 5<   "   $ PART_RightHeaderGripper��5=   %   $��Right=�5>   %   8�� 5?   %   5@      5A      5C      5D      �� 5E      $ 	#FF000000��6N   �� 5F      "  68   .R�5G      � 5H      �� 5I      "  6/   .�5J      ��  � ��
 ���� 6/   �� 5K       � ��$ Center=�66   �� 5L       �@�FocusVisualStyle 65   Z� �� 5M       � �� 5N      �� 5O      "  6*   .R�5P      �� #��z��5Q   !   $��0q�5R   !   $
 True��5S   !   ._�5T   "   �� # z 63   5U      5V      5X       5Y      P� 5Z       �@ 
IsSelected$
 True��64   . �5[      ��  � ��# � ��67   �� 5\       � ��# � ��67   �� 5]       � ��# � ��68   5^      P� 5_       �@J�IsKeyboardFocusWithin$
 True��6?   . �5`      ��  � ��# �  68   5a      ]� 5b       5c      �� 5d       �@ 
IsSelected$
 true��6>   �� 5e       �@��IsSelectionActive$ false��6N   ./�5g      ��  � ��# � /�67   �� 5h       � ��# � /�68   �� 5i       � ��# � .�67   5j      P� 5k       � {�$ false��63   . �5l      ��  � ��# � ��67   5m      5o      �� 5p      "  6.   .�5q      ��  � ��
 �����6/   �� 5r       �@J�SnapsToDevicePixels$
 True��68   �� 5s       �@=�ErrorTemplate 6=   Z� �� 5t       �@ ValidationErrorTemplate 5u      �� 5v      5x      �� 5y       � �� 5z      �� 5{      "  6*   .R�5|      �� $ 
DGR_Border��5}   !   #��z��5~   !   ���#e0e0e0$��1q�5�   !   $ 5��5�   !   $ False��5�   !   ._�5�   "       5�   &   �� 5�   *   $
��Auto �6;   �� 5�   *   $��* �6;   ! 5�   &   �� 5�   *   $��* �68   �� 5�   *   $
��Auto �68   .+�5�   &   	  $��1��5�   )   #��z" 5�   )   # z 5�   )   
  5�   &   $��1��5�   )   $��1��5�   )   $# Vertical=�5�   )   #y�z$ 5�   )     5�   &   $��2��68   $# Vertical=�6I   5�   #   5�      5�      5�       5�      P� 5�       �@J�IsMouseOver$
 True��65   . �5�      ��  � �� �#f5f5f567   �� 5�       � �� �#aaa68   5�      P� 5�       �@ 
IsSelected$
 True��64   . �5�      ��  � �� �#92BEFF67   5�      ]� 5�       5�      �� 5�       �@ 
IsSelected$
 True��6>   �� 5�       �@��IsSelectionActive$ False��6N   ./�5�      ��  � �� �#dfdfdf67   5�      5�      �� 5�      "  6+   .�5�      ��  � ��
 ���� 6/   �� 5�       � ��$ 0q�64   �� 5�        �@ RowDetailsVisibilityMode$ VisibleWhenSelected=�6=   �� 5�       � ��$
 True��6B   �� 5�       �@��PanningMode$
 Both=�6=   �� 5�       �@��IsFlicksEnabled$ False��6;   �� 5�       �@ AutoGenerateColumns$ False��68   �� 5�       �@ HeadersVisibility$ Column=�66   �� 5�       � ��$ 0,0,0,0q�6+   �� 5�       �@ SelectionMode$ Single=�62   �� 5�       �@ SelectionUnit$ FullRow=�62   �� 5�       �@ CanUserAddRows$ False��63   �� 5�       �@ CanUserResizeRows$ False��66   �� 5�       �@ CanUserDeleteRows$ False��66   �� 5�       �@ CanUserReorderColumns$ False��6:   �� 5�       � ��$ 13(�6-   �� 5�       �@ GridLinesVisibility$
 None=�68   �� 5�       � �� 5�      �� 5�      "  6*   .R�5�      �� #��z��6%   #��z��6O   ._�5�   "   �� $% DG_ScrollViewer��6/   $|�False��6H   ��5�   &   �� 5�   *   " ��6:   .R�5�   .   �   5�   2   �� 5�   6   $
��Auto �6G   �� 5�   6   $��* �6G   �� 5�   6   $
��Auto �6G   5�   /   5�   +   5�   #   5�      5�      5�      5�      �� 5�      "  6.   .�5�      ��  � ��
 �����6/   �� 5�       �@J�SnapsToDevicePixels$
 True��68   �� 5�       �@=�ErrorTemplate 6=   Z� �� 5�       �@ ValidationErrorTemplate 5�      �� 5�      5�      �� 5�       � �� 5�      �� 5�      "  6*   .R�5�      �� $ 
DGR_Border��5�   !   #��z��5�   !   $��0q�5�   !   $ 5��5�   !   $ False��5�   !   ._�5�   "       5�   &   �� 5�   *   $
��Auto �6;   �� 5�   *   $��* �6;   ! 5�   &   �� 5�   *   $��* �68   �� 5�   *   $
��Auto �68   .+�5�   &   	  $��1��5�   )   #��z" 5�   )   # z 5�   )   	  5�   &   $��1��5�   )   $��1��5�   )   $# Vertical=�5�   )   y�5�   )   �� *AreRowDetailsFrozen+	  5�   &   $��2��5�   )   $# Vertical=�5�   )   y�5�   )   �� *HeadersVisibility+5�   #   5      5     5      5     P� 5      �@J�IsMouseOver$
 True��65   . �5     ��  � �� �#623ed067   �� 5      � �� �#ffffff67   5     P� 5	      �@ 
IsSelected$
 True��64   . �5
     ��  � �� �#623ed067   �� 5      � �� �#ffffff67   5     ]� 5      5     �� 5      �@ 
IsSelected$
 True��6>   �� 5      �@��IsSelectionActive$ False��6N   ./�5     ��  � �� �#dfdfdf67   5     5     5     & �� 
MainWindow& 5        Farmacia.MainPage  5  
   $y�Visible=�6   5     