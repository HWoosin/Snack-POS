   M S B A M L   `   `   `  ����G  C분식집POS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:편의점_포스MVVM편의점_포스MVVM  5      '    !편의점_포스MVVM.재고조회   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:편의점_포스MVVM     5        N� Title$  재고조회��5	      .��5      � .+�5   
   �� $��창고재고
��6   $
��Left=�6+   $	��421��6F   $	��Top=�6S   $	��360��6k   .��5      &   System.Windows.Controls.DataGrid  -   5          Name$ product��5      $
��Left=�6(   $	��382��6C   $	��Top=�6P   $	��338��6h    J� RenderTransformOrigin$ 1.082,0.868&�6t   $��0,-9,0,0q�6�      AutoGenerateColumns .  ��6�   ��  �� Path$ ProductDatas� �� Mode$ TwoWay=� �� NotifyOnSourceUpdated .  �� NotifyOnTargetUpdated .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6)   
   Header$

 Name��63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   �� *Name+  5      $	 * 6)   $
 Maker��63    6B   �� *Maker+  5      $	 * 6)   $
 Price��63    6B   �� *Price+  5      $	 * 6)   $
 Count��63    6B   �� *Count+5      5      �� 5   
   $��수량 수정��6   $
��Left=�6"   $��81��6=   $	��Top=�6I   $	��151��6a   $��
365,10,0,0q�6m   .��5      �� -   5         ��Name$ 
Count_Copy��5      $
��Left=�6d   $��23��6    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��120��6�   $��6,17,0,0q�6�    � DataContext 6*   �� *SelectedItem+ �� ElementName$ product����6�   �� *Count+$ TwoWay=�5      5      5      