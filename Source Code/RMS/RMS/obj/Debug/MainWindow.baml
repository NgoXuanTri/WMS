   M S B A M L   `   `   `  ����>  :RMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:RMSRMS  5   	       RMS.MainWindow   5   	   a ]DevExpress.Xpf.Core.v18.1, Version=18.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:RMS     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    � WindowState$ 	Maximized=�65    � 	Resources 5	         txtBase �� 
TargetType �� Property �� Value �� Triggers ]� 
Conditions �� Property	 �� Value��%
  &	        �� 5
   
   " ��6    .�5      ��  � ��
 ���� 6+   �� 5       � ��$ 12(�6)    5      ]� 5       5      �� 5       �@J�IsMouseOver	 . 6;   /�5      �� 5       � ��
 �����67   5      5      5      .��5      � 
 � ColumnDefinitions
 5   
   �� 5      -   5         �Name$
 menu��5      $	��200 �6+   �� 5      -   5        $ contents��5      $��* �6/   .+�5    
   ]� -   5        $��pnlMenu��5       $��5,5,397.4,4.8q�6#   $��2��6:   .+�5!      �� .+�5"      �� -   5        $��lblOperation��5"      $��
OPERATIONS��60   #��[  6B   $��12(�6c   $
��Bold"�6q   |�.  6�   �� 5#      -   5        $��lblReceivingDocument��5#      $��Receiving Document��68   #��[  6S   
��� ��� J� InputBindings 5$      d� 5%       d� MouseAction$ 	LeftClicke�6L    �� Command 6'   �� *OperationCommand+6L   5'      �� 5(      -   5        $��lblDispatchingDocument��5(      $��Dispatching Document��6:   #��[  6W   
��� ���6y   �� 5)      -   5        $��lblSubOperation3��5)      $��Sub Operations 3��64   #��[  6M   
��� ���6o   �� 5*      -   5        $��lblSubOperation4��5*      $��Sub Operations 4��64   #��[  6M   
��� ���6o   �� 5+      -	   5        $��	lblReport��5+      $��REPORTS��6-   #��[  6=   $��12(�6^   $
��Bold"�6l   |�.  6~   �� 5,      -
   5        $��lblSubReport1��5,      $��Sub Reports 1��61   #��[  6G   
��� ���6i   �� 5-      -   5        $��lblSubReport2��5-      $��Sub Reports 1��61   #��[  6G   
��� ���6h   �� 5.      -   5        $��lblBillings��5.      $��BILLINGS��6/   #��[  6@   $��12(�6b   $
��Bold"�6p   |�.  6�   5/      50      &   System.Windows.Controls.DataGrid  51   
   $��1��6      AutoGenerateColumns .  "   VerticalScrollBarVisibility$
 Auto=�6�   ��6#   �� *	Categorys+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�   Columns 52      0  *System.Windows.Controls.DataGridTextColumn  53      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *
CategoryID+$ PropertyChanged=�$ TwoWay=�  54      $
 Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6�    63   �� *CategoryName+$ PropertyChanged=�$ TwoWay=�6�   56      �� 57   
   -   5        $��	btnUpdate��57      $��Update��6"   $��1��63   $��Bottom=�6C   $
��Left=�6^   $	��100��6y   $��5,0,0,5q�6�   ��58      �� *UpdateCommand+�� 59   
   -   5        $��	btnInsert��59      $��Insert��6"   $��1��63   $��Bottom=�6C   $��Center=�6^   $	��100��6{   $��0,0,0,5q�6�   ��5:      �� *InsertCommand+�� 5;   
   -   5        $��	btnDelete��5;      $��Delete��6"   $��1��63   $��Bottom=�6C   $��Right=�6^   $	��100��6z   $��0,0,5,5q�6�   ��5<      �� *DeleteCommand+5=      5>      