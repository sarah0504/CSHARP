   M S B A M L   `   `   `  ����J  FWpfApplication3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:WpfApplication3.ViewModel2WpfApplication3.ViewModel2  5      =#clr-namespace:WpfApplication3.ViewsWpfApplication3.Views  6E   2    ,WpfApplication3.ViewModel2.ClientUserControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:WpfApplication3.ViewModel2     5      5View1#clr-namespace:WpfApplication3.Views     6E   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962af bMaterialDesignThemes.MahApps, Version=0.1.5.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aHMaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   6w   .��5	      �   � ColumnDefinitions  5
   
   �� 5      $	��17* �6   �� 5      $
��183* �6   .+�5   
   �� -   5         ��Name$ 
MapWinButt��5      $
��Left=�6�   $	��Top=�6�   $��45��6�   $��31��6�   ���	#FFC6FBDE���	#FF1BA85B���	#FFC6FBDE$��0,-6,0,0q�6  ��6%   �� *mapWinCommand+��6G   �� *	Content+ �� ElementName$ 
MapWinButt��.��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Globe=�6&   $��25��64   $	��25 ��6@   $��Center=�6L   5      5      �� 5   
   -   5        $ 
AddWinButt��5      $
��Left=�6�   $��	45,-6,0,0q�6�   $	��Top=�6�   $��34��6�   $��31��6�   ���	#FFC6FBDE���	#FF1BA85B���	#FFC6FBDE$��2��6&  ��6%   �� *addWinCommand+��6G   �� *	Content+$ 
AddWinButt��.��5        $	 Add=�6&   $��25��62   $	��25 ��6>   $��Center=�6J   5      5      �� 5   
   -   5         ��Name$
 page��5      $��0,25,0,-0.4q�6'   $��2��6<   .��5      � ���	#FFC6FBDE$��
0,0,0,-0.2q�6*   .+�5      �� -   5         ��Name$ listView��5      ���	#FFC6FBDE$��0,10,0,-0.4q�6E   ���	#FFC6FBDE��5      �� 5      .R�5      ��  �� Orientation$ Vertical=�6)   .+�5   "   (   "WpfApplication3.Views.itemTemplate  5      5       5"      5$      5%      5&      5'      