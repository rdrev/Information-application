   M S B A M L   `   `   `  ����j  fИнформационое приложение, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullq=clr-namespace:Информационое_приложение/Информационое_приложение  5      =    7Информационое_приложение.EmpPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Olocal=clr-namespace:Информационое_приложение     5      -   5          N� Title$  EmpPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5         ��Name$ 	GoBackBtn��5      $��
Назад��5      $
��Left=�5      $��5q�5      �� 5      -   5        $	��CBE��5       �� DisplayMemberPath$ Фамилия��5      $��5q�5      $	��300��5      �� 5      -   5        $ AddTaskEmpBtn��5      $��Сохранить��5      $��5q�5      5       &   System.Windows.Controls.DataGrid  5#   
   -   5          Name$ DG��5#         AutoGenerateColumns .     
IsReadOnly . $��1��5%   )      Columns 5&      0  *System.Windows.Controls.DataGridTextColumn  5'      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Фамилия��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 66   �� *Фамилия+  5(      $	 Имя��6%   
 62   �� *Имя+  5)      $	 Отчество��6%   
 67   �� *Отчество+5+      5,      5-      