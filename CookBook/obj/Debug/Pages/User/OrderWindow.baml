   M S B A M L   `   `   `  ����C  ?CookBook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CookBook.Pages.UserCookBook.Pages.User  5   	   %    CookBook.Pages.User.OrderWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:CookBook.Pages.User     5   	     � 
ResizeMode$  NoResize=�5   	    � Title$ Состав заказа��5	   	   $	��500��6   $	��800��6,   .��5
      �� .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DgBooks��5         AutoGenerateColumns .     
IsReadOnly .  �� Left$ 10��6R   
 �� Top$ 80��6c   $	��772��6s   $	��354��6    � ContextMenu 5      �� 5      .@�5      m� -   5         m�Name$ BtnSave��5   2   $��Сохранить��6   6C   m� 5      -   5        $ 	BtnDelete��5   0   $��Удалить��6   6C   5      	   Columns	 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Фото��6)      CellTemplate 5      �� 5      .R�5      �� $��50��6B   $��50��6M   ��6$   �� *
Book.Photo+6M   5      5      0  *System.Windows.Controls.DataGridTextColumn  5      $
 Название��6C   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *	Book.Name+6C     5      $"
 Цена за единицу��6D    6%   �� *
Book.Price+6D     5      $6
 0Цена со скидкой за единицу��6H    6%   �� *Book.SalePrice+6H     5      $#
 Описание товара��6J    6%   �� *Book.Description+6J     5      $ 
 Производитель��6D    6%   �� *
Book.Maker+6D     5      $
 Количество��6@    6%   �� *Amount+6@     5       $
 Цена за всё��6?    6%   �� *Price+6?     5!      $.
 (Цена за всё со скидкой��6C    6%   �� *	SalePrice+6C     5"       5#      �� 5$      .R�5%      ��  �� Orientation$ 
Horizontal=�6)   .+�5&   "   �� $��40��6)   $��60��65   $��Сохранить��6@   �� 5'   "   $��40��6)   $��60��65   $��Удалить��6@   5(      5)      5+      5-      �� 5.   
   -   5         ��Name$ TbAmount��5.      $��23��6$   $ 10��60    �� TextWrapping$
 Wrap=�6A   $	 439��6U   $	��772��6f   �� 5/   
   $��Код��6   $ 17��6   $ 18��6/   �� 50   
   $��Дата��6   $ 17��6   $ 44��60   �� 51   
   $"��Цена со скидкой��6   $	 250��6*   $ 18��6<   �� 52   
   $"��Цена без скидки��6   $	 250��6*   $ 44��6<   �� 53   
   -   5        $��LbCode��53      $ 63��6   $ 18��6/   $��53��6?   $��22��6J   �� 54   
   -   5         ��Name$ LbDate��54      $ 63��6    $ 45��61   $��53��6A   $��21��6L   �� 55   
   -   5        $ LbSalePrice��55      $	 372��6%   $ 18��67   $��52��6G   $��26��6R   �� 56   
   -   5        $ LbPrice��56      $	 372��6!   $ 44��63   $��52��6C   $��22��6N   57      58      