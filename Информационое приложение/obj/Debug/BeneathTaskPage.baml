   M S B A M L   `   `   `  ����j  fИнформационое приложение, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullq=clr-namespace:Информационое_приложение/Информационое_приложение  5      E    ?Информационое_приложение.BeneathTaskPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Olocal=clr-namespace:Информационое_приложение     5      -   5          N� Title$  BeneathTaskPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5         ��Name$ 	GoBackBtn��5      $��
Назад��5      $
��Left=�5      $��5q�5      �� 5      -   5        $ AddBeneathTaskBtn��5      $)��#Добавить подзадачу��5      $
��Left=�5      $��5q�5      5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DG��5         AutoGenerateColumns .     
IsReadOnly . $��1��5!   %      Columns 5"      4  .System.Windows.Controls.DataGridTemplateColumn  5#         CellTemplate 5$      �� 5%      .R�5&      �� ��6%   �� *Статусы.Цвет+5'      5)      0  *System.Windows.Controls.DataGridTextColumn  5*      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Название��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 67   �� *Название+  5+      $	 Статус��6%   
 65   �� */-Статусы.НазваниеСтатуса+  5,      $	 Коментарий��6%   
 69   �� *,*КомментарийПодЗадание+  5-       5.      �� 5/      .R�50      �� $ EmpBtn��6%   -   5        $��Исполнители��51   %   52   %   53      55        56       57      �� 58      .R�59      �� $ 	UpTaskBtn��6%   -   5        $��Изменить��5:   %   5;   %   5<      5>        5?       5@      �� 5A      .R�5B      �� $ 
DelTaskBtn��6%   -   5        $��Удалить��5C   %   5D   %   5E      5G      5I      5J      5K      