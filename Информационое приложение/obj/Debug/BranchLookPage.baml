   M S B A M L   `   `   `  ����j  fИнформационое приложение, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullq=clr-namespace:Информационое_приложение/Информационое_приложение  5      D    >Информационое_приложение.BranchLookPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Olocal=clr-namespace:Информационое_приложение     5      -   5          N� Title$  BranchLookPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5         ��Name$ ClerBtn��5      $��
Назад��6&   $
��Left=�6M   $��5q�6h   �� 5      -   5        $ AddBtn��5      $��Добаваить��6%   $
��Left=�6O   $��5q�6j   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DG��5         
IsReadOnly .    AutoGenerateColumns .  $��1��6M      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Отрасаль��6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 67   �� * НазваниеОтрасли+  5      $ Комментарий��6%   	 6:   �� *&$КомментарийОтрасли+4  .System.Windows.Controls.DataGridTemplateColumn  5      
   CellTemplate
 5      �� 5      .R�5      �� $ UpBtn��6%   -   5        $��Изменить��5   4   6G   5      5!        5"      
 5#      �� 5$      .R�5%      �� $ DelBtn��6%   -   5        $��Улалить��5%   5   6G   5&      5(      5+      5,      5-      