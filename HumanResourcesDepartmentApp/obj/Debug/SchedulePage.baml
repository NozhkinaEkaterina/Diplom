   M S B A M L   `   `   `  ����V  RHumanResourcesDepartmentApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:HumanResourcesDepartmentAppHumanResourcesDepartmentApp  5      .    (HumanResourcesDepartmentApp.SchedulePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:HumanResourcesDepartmentApp     5        N� Title$  SchedulePage��5	       N� 
Background
 �����.��5      �  � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $��* �6   �� 5      $��40 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
DGSchedule��5      $��1��6'      AutoGenerateColumns .     
IsReadOnly . 
�������   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ День недели��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6`   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6:   �� *DayOfTheWeek.Name+6l     5      $ Статус��6%   $ * 6P   	 65   �� *Status+6\   4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 auto 6)   
   CellTemplate
 5      �� 5      .R�5      ��  ��Name$ BtnSchedule��6%   -   5        $ ��Редактировать��5   :   
���P��$��18(�6�    J� Effect 5   "   3  -System.Windows.Media.Effects.DropShadowEffect  5   &   5      5      5      5!      �� 5"   
   -   5        $	 Add��5"      $��Добавить��6   $
��Left=�61   $	��Top=�6L   $	��150��6w   $��2��6�   $��20(�6�   
���P��$��10,0,0,0q�6�    5#        5$      5&      �� 5'   
   -   5        $	 Del��5'      $��Удалить��6   $��Right=�60   $	��Top=�6L   $	��150��6w   $��2��6�   $��20(�6�   
���P��$��0,0,10,0q�6�    5(        5)      5+      �� 5,   
   -   5        $ Search��5,      $��Сформировать��6!   $��Right=�68   $��Center=�6T   $	��150��6�   $��0��6�   $��20(�6�   
���P��$��
0,-1,10,10q�6�    5-        5.      50      �� 52   
   -   5         ��Name$ CBSearch��52      $��20(�6%   $��0��63   
���P�� �� DisplayMemberPath$ 	Full_Name��6t    �� SelectedValuePath$ 
Id_Profile��6�   $��
10,0,250,0q�6�    �� SelectedItem 6S   �� *	Profile+6�   53      54      