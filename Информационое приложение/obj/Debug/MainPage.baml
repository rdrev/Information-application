   M S B A M L   `   `   `  ����j  fИнформационое приложение, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullq=clr-namespace:Информационое_приложение/Информационое_приложение  5      >    8Информационое_приложение.MainPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Olocal=clr-namespace:Информационое_приложение     5      -   5          N� Title$  MainPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5         ��Name$ 
AddTaskBtn��5      $#��Создать задание��5      $
��Left=�5      $��Center=�5      $��5q�5      �� 5      -   5        $ AddEmployeesBtn��5      $'��!Список сотрудника��5      $
��Left=�5      $��Center=�5      $��5q�5      �� 5      -   5        $ AddStatusBtn��5      $��Список статус��5       $
��Left=�5"      $��Center=�5#      $��5q�5$      �� 5%      -   5        $ AddBranchBtn��5%      $#��Список отрасаль��5&      $
��Left=�5(      $��Center=�5)      $��5q�5*      5+      &   System.Windows.Controls.DataGrid  5-   
   -   5          Name$ DG��5-         AutoGenerateColumns .     
IsReadOnly . $��1��5/   %      Columns 50      4  .System.Windows.Controls.DataGridTemplateColumn  51         CellTemplate 52      �� 53      .R�54      �� ��6%   �� *Статусы.Цвет+55      57      0  *System.Windows.Controls.DataGridTextColumn  58      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Статус��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 65   �� */-Статусы.НазваниеСтатуса+  59      $	 Название��6%   
 67   �� *НазваниеЗадачи+  5:      $	 Отрасаль��6%   
 67   �� */-Отрасли.НазваниеОтрасли+  5;      $	 Начало��6%   
 65   �� *Начало+  5<      $	 Оканчание��6%   
 68   �� *Оканчание+  5=      $	 Коментарий��6%   
 69   �� *&$КоммениарийЗадание+  5>       5?      �� 5@      .R�5A      �� $ PodTaskUpdBtn��6%   -   5        $��
Этапы��5B   %   5C   %   5D      5F        5G       5H      �� 5I      .R�5J      �� $ EmpBtn��6%   -   5        $��Исполнители��5K   %   5L   %   5M      5O        5P       5Q      �� 5R      .R�5S      �� $ 	UpTaskBtn��6%   -	   5        $��Изменить��5T   %   5U   %   5V      5X      5Z      5[      5\      