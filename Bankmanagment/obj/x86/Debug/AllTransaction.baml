   M S B A M L   `   `   `  ����  Bankmanagment"    Bankmanagment.AllTransaction   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6my-http://schemas.microsoft.com/wpf/2008/toolkit  5   7   .��5      � 
������   � RowDefinitions  5	   
   �� 5
      $��20 �6   �� 5      $��* �6   .+�5   
   � $��1��6   .+�5      �� 
�������._�5      � .+�5      � -   5        $��
LayoutRoot��5      ��5      �� 5       �� EndPoint$ 1,0.5&�62    �� 
StartPoint$ 0,0.5&�6C   .��5   "   �  � Color$ #95B9C7��6/    � Offset$ 0Q�6?   � 5   "   $ White��6/   $ 1Q�6=   5        5      �� 5      $��5 �6,   �� 5      $��5 �6,   �� 5      $��50 �6,   �� 5      $
��auto �6,   �� 5      $��50 �6,   �� 5      $
��264* �6,   .+�5      � $��0��6   $��	20,20,0,0q�6,    � ColumnDefinitions 5       �� 5!   "   $	��33* �63   �� 5"   "   $
��595* �63   .+�5$      �� -   5        $��Header��5$   X   $��2��6)   $
��Left=�6=    �� Orientation$ 
Horizontal=�6f   $��80.987��6   .+�5%   "   �� -   5        $��TextBlockTitle��5%   `   $��Calibri)�6,   $��18(�6A   $��5,0,0,0q�6O   $��	Statement��6v   $��NoWrap=�6�   $��Bottom=�6�   $
��Auto��6�   5&      5'      � 5(      $��3��6   .+�5)      �� $��2��6(   $��20,30.6,20,0q�63   $	��Top=�6I   $
��auto��6a   � 5*      $��0��6#    5+   "   �� 5,   &   $��20 �67   �� 5-   &   $
��Auto �67     5/   "   �� 50   &   $��40 �64   �� 51   &   $
��Auto �64   .+�53   "   � $��1��6'   $��0��67   .+�54   &   �� -   5        $��TextBlockTransaction��54      $��Calibri)�60   $��18(�6E   $
��Left=�6S   $��5,0,0,0q�6n   $��All Transaction Details��6�   $��NoWrap=�6�   $��Center=�6�   $
��Auto��6�   55   #   56      57      &   System.Windows.Controls.DataGrid  58      -   5        $��	dataGrid1��58   �      AutoGenerateColumns . $��14(�6>   $
��Bold"�6L   $	��297��6^   $��Stretch=�6k   $   HorizontalScrollBarVisibility$ Visible=�6�   $��0,17,0,0q�6�   	   RowBackground
	 �����$	��Top=�6�   "
   VerticalScrollBarVisibility$
 Visible=�6  $	��802��6(  $��4��64  $��2��6A  6R  59      5:      5;      5<      5=      5>      