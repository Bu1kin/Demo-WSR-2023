   M S B A M L   `   `   `  ����C  ?CookBook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:CookBook.Pages.AdminCookBook.Pages.Admin  5      '    !CookBook.Pages.Admin.ProductsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:CookBook.Pages.Admin     5      $	��560��5      $	��780��6     N� Title$  
Книги��5	      .��5
      �� .+�5   
   �� -   5         ��Name$ BtnAdd��5   $   $��Добавить��6    �� Left$ 23��6I   
 �� Top$ 22��6Z   $��30��6j   $	��108��6v   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DgBooks��5      $	��493��6$   $ 23��61   $ 57��6B   $	��728��6R      AutoGenerateColumns .     
IsReadOnly .  � ContextMenu 5      �� 5      .@�5      m� -   5         m�Name$ BtnEdit��5   1   $��Изменить��6   6B   m� 5      -   5        $ 	BtnDelete��5   0   $��Удалить��6   6C   5      	   Columns	 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Фото��6)      CellTemplate 5      �� 5      .R�5      �� $��50��6=   $��50��6H   ��6$   �� *Photo+6H   5      5      0  *System.Windows.Controls.DataGridTextColumn  5      $
 Название��6>   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Name+6>     5      $
 Цена��6?    6%   �� *Price+6?     5      $"
 Цена со скидкой��6C    6%   �� *	SalePrice+6C     5      $#
 Описание товара��6E    6%   �� *Description+6E     5      $ 
 Производитель��6?    6%   �� *Maker+6?     5       $
 Количество��6@    6%   �� *Amount+6@   5#      5$      5%      