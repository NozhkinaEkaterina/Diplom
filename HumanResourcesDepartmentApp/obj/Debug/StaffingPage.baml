   M S B A M L   `   `   `  ����V  RHumanResourcesDepartmentApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:HumanResourcesDepartmentAppHumanResourcesDepartmentApp  5      .    (HumanResourcesDepartmentApp.StaffingPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:HumanResourcesDepartmentApp     5      -   5          N� Title$  StaffingPage��5	       N� 
Background
 �����.��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��40 �6   �� 5      $��30 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
DGStaffing��5         AutoGenerateColumns .     
IsReadOnly . 
�������   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$  Специальность��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6^   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6<   �� *Position.Name+6j     5      $1 +Количество сотрудников��6%   $ * 6o   	 6E   �� *Number_Of_Staff_Units+6{     5      $ Оклад (руб.)��6%   $ * 6V   	 6;   �� *Salary+6b     5      $= 7Надбавка за ночные смены (руб.)��6%   $ * 6x   	 6N   �� *Night_Shift_Allowance+6�     5      $7 1Премиальная надбавка (руб.)��6%   $ * 6f   	 6J   �� *	Premium+6r     5      $- 'Районный коэффициент��6%   $ * 6l   	 6C   �� *District_Coefficient+6x     5      $ Итого (руб.)��6%   $ * 6V   	 6;   �� *In_All+6b   4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 auto 6)   
   CellTemplate
 5      �� 5      .R�5      ��  ��Name$ BtnStaffing��6%   -   5        $ ��Редактировать��5   :   
���P��$��18(�6z    J� Effect 5   "   3  -System.Windows.Media.Effects.DropShadowEffect  5    &   5"      5#      5%      5'      �� 5(   
   -   5        $	 Add��5(      $��Добавить��6   $
��Left=�61   $	��Top=�6L   $	��150��6x   $��20(�6�   
���P��$��1��6�   $��10,0,0,0q�6�    5)        5*      5,      �� 5-   
   -   5        $	 Del��5-      $��Удалить��6   $��Right=�60   $	��Top=�6L   $	��150��6x   $��20(�6�   
���P��$��1��6�   $��0,0,10,0q�6�    5.        5/      51      �� 53   
   -   5         ��Name$ TBSearch��53       $��20(�6   $��2��62   $	��540��6?   $��Center=�6L   
���P��6i   �� 54   
   -   5        $ 	BtnSearch��54      $��
Найти��6$   $��2��64   $	��100��6A   
���P��$��Right=�6`   $��0,0,10,0q�6�   $��20(�6�   55      56      