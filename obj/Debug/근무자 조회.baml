   M S B A M L   `   `   `  ����G  C분식집POS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:편의점_포스MVVM편의점_포스MVVM  5      +    %편의점_포스MVVM.근무자_조회   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:편의점_포스MVVM     5        N� Title$  근무자_조회��5	      .��5      � .+�5   
   �� $��근무자
��6   $
��Left=�6*   $	��421��6E   $	��Top=�6R   $	��360��6j   .��5      &   System.Windows.Controls.DataGrid  -   5          Name$ worker��5      $
��Left=�6'   $	��390��6B   $	��Top=�6O   $	��339��6g   $��	0,-9,0,-4q�6s      AutoGenerateColumns .  ��6�   ��  �� Path$ WorkerDatas� �� Mode$ TwoWay=� �� NotifyOnSourceUpdated .  �� NotifyOnTargetUpdated .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6)   	   Header$
	 Name��63   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6A   �� *Name+  5      $ * 6)   $		 Age��63   
 6@   �� *Age+  5      $ * 6)   $	 Phone��63   
 6B   �� *Phone+  5      $ * 6)   $	 Address��63   
 6D   �� *	Address+5      5      �� 5   
   
���   �$��1q�6^   $
��Left=�6r   $	��148��6�   $	��Top=�6�   $	��142��6�   $��
365,23,0,0q�6�    � DataContext 6%   �� *SelectedItem+ �� ElementName$ worker��._�5      �� $��0,0,9,0q�6   .+�5      �� -   5         ��Name$ 이름��5      $
��Left=�6&   $��23��6A    �� TextWrapping$
 Wrap=�6M   $	��Top=�6a   $	��120��6y   $��9,9,0,0q�6�   ��6�   �� *Name+$ TwoWay=��� 5      -   5        $ 나이��5      $
��Left=�6&   $��23��6A   $
 Wrap=�6M   $	��Top=�6a   $	��120��6y   $��9,9,0,0q�6�   ��6�   �� *Age+$ TwoWay=��� 5      -   5        $ 전화��5      $
��Left=�6&   $��23��6A   $
 Wrap=�6M   $	��Top=�6a   $	��120��6y   $��9,9,0,0q�6�   ��6�   �� *Phone+$ TwoWay=��� 5      -   5        $ 주소��5      $
��Left=�6&   $��23��6A   $
 Wrap=�6M   $	��Top=�6a   $	��120��6y   $��9,9,0,0q�6�   ��6�   �� *	Address+$ TwoWay=�5      5      5"      5#      