   M S B A M L   `   `   `  ����J  FWpfApplication3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication3WpfApplication3  5          WpfApplication3.MenuV   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:WpfApplication3     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962af bMaterialDesignThemes.MahApps, Version=0.1.5.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aHMaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   6:   $	��500��5      $	��800��6   
�������  � 	Resources  5	         MenuOpen �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  	MenuClose��%�  &	        &	 �     �� 5
   
   .��5      U� $ (FrameworkElement.Width)�6,   $ MenuGrid��6a   .\�5        $ 0��6'   $ 50Q�63   6@     5      $ 0:0:0.5��6'   $	 200Q�69   6G   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ MenuGrid��6a   .\�5        $ 0��6'   $	 200Q�63   6A     5      $ 0:0:0.5��6'   $ 50Q�69   6F   5      5      5       � Triggers 5      :� 5   
    :� RoutedEvent$ ButtonBase.Click��6    :� 
SourceName$ ButtonOpenMenu��66   .[�5      �� #��[  6   5      :� 5   
   $ ButtonBase.Click��6   $ ButtonCloseMenu��66   .[�5      �� #��[ 6   5       .��5"      � -   5        $	��ado��5"      ���	#FFC6FBDE.+�5#   
   � $��73��6   $	��Top=�6   ���	#FFC6FBDE.+�5$      �� $��Delivery Service��6   $��Center=�60   $��Bottom=�6M   $��22(�6h   $��50��6v   $��306,0,291,0q�6�    J� RenderTransformOrigin$ 1.324,0.291&�6�   ���	#FF1BA85B$��Stencil)�6�   $	��203��6�   �� 5&      $��Right=�6   	 �� Orientation$	 
Horizontal=�65   '  !MaterialDesignThemes.Wpf.PopupBox  5'      $��Right=�6&   $��0,0,10,0q�6B   
   PlacementMode$
 BottomAndAlignRightEdges=�6T      	StaysOpen .  $��49��6�   $ 9.249,0.774&�6�      PopupContent. 5(      �� $	��150��6   .+�5)      �� $��Accounts��6   �� 5*      $��Settings��6   �� 5+      $
��Help��6   �� 5,      �� 5-      -   5         ��Name$ ButtonPopUpLogOut��5-      $��LogOut��68   5/      50      51      � 52   
   -   5         �Name$ MenuGrid��52      $��50��6!   $
��Left=�6,   ���	#FFC6FBDE.+�53      �� $ -2.314,0.529&�6   .+�54      � $��73��6   
�������.+�55      �� -   5        $ ButtonCloseMenu��55      $y�	Collapsed=�66   $��60��6M   $��60��6X   $	��Top=�6�   $��Right=�6�   ��6d   Z� ��6z   Z� .��56      '  !MaterialDesignThemes.Wpf.PackIcon  $��25��62   $��25��6>      Kind$ 	ArrowLeft=�6I   ���	#FF1838616Z   57      �� 58      -   5        $ ButtonOpenMenu��58      $��60��65   $��60��6@   $	��Top=�6y   $��Right=�6�   ��6L   Z� ��6b   Z� .��59        $��25��62   $��25��6>   $
 Menu=�6I   ���	#FF1838616U   5:      5;      �� 5<      ���	#FF1BA85B���	#FFC6FBDE c� OverflowMode$ Never=�6I   .@�5=      �� $��60��6$   $ 0.5,0.5&�60   $ Never=�6P   .��5?      �� $	 
Horizontal=�6%   $ Never=�6>   .+�5@      �� -   5        $ ClientButton��5@   �   
������ 
��� � �
������ ��6%   �� *ClientCommand+��6G   �� *	Content+ �� ElementName$ ClientButton��.��5C   "     $	 Men=�6=   $��25��6H   $	��25 ��6T   $��Center=�6`   5E   #   5F      �� 5G      $��Customer Management��6(   $��Center=�6C   $��20 10q�6^   5I      5J      5K      5L      �� 5M      ���	#FF1BA85B���	#FFC6FBDE$ Never=�6I   .@�5N      �� $��60��6#   .��5O      �� $	 
Horizontal=�6%   .+�5P      �� -   5        $ 
DistButton��5P   %   
������ 
��� � �
������ ��69   �� *DistCommand+��6Y   �� *	Content+$ 
DistButton��.��5Q   "     $ TruckDelivery=�6:   $��25��6O   $	��25 ��6[   $��Center=�6g   5S   #   5T      �� 5U      $��Distribution Mangement��6(   $��Center=�6F   $��20 10q�6a   5W      5X      5Y      5Z      �� 5[      ���	#FF1BA85B���	#FFC6FBDE.@�5\      �� $��60��6#   .��5]      �� $	 
Horizontal=�6%   .+�5^      �� -   5        $ 	DelButton��5^      
������ 
��� � �
������ ��6%   �� *
DelCommand+��6D   �� *	Content+$ 	DelButton��.��5`   "     $ CustomerService=�6:   $��25��6R   $	��25 ��6^   $��Center=�6j   5b   #   5c      �� 5d      $��Delivery_Men Mangement��6(   $��Center=�6F   $��20 10q�6a   5f      5g      5h      5i      �� 5j      ���	#FF1BA85B���	#FFC6FBDE.@�5k      �� $��60��6#   .��5l      �� $	 
Horizontal=�6%   .+�5m      �� -	   5        $ StatisticsButton��5m   �   
������ 
��� � �
������ ��6%   �� *StatCommand+��6E   �� *	Content+$ StatisticsButton��.��5o   "     $ BarChart=�6:   $��25��6J   $	��25 ��6V   $��Center=�6b   5q   #   5r      �� 5s      $��Statistics Results��6(   $��Center=�6B   $��20 10q�6]   5u      5v      5w      5x      5y      5z      � 5|   
   .+�5~      �� -
   5         ��Name$
 page��5~      $
��Left=�6+   $��	50,73,0,0q�6F   $	��Top=�6Y   $	��427��6q   $	��750��6~   
�������.��5      � .+�5�      �� $��/pictures/test.jpg��6   $
��Left=�5�      $	��427��6   $	��Top=�6*   $	��750��6B   �� 5�      $5��/Welcome to your delivery service application  !��6    
�������$��20(�5�   +   $��156,69,181.4,322.2q�69   �� 5�      $-��'Enjoy your time and have a good work ! ��6   $��Center=�6K   $��Center=�6f   
�������$��20(�5�   +   $��328,105,54.4,284.2q�69   $��38��6U   $	��368��6a   5�      5�      5�      5�      5�      5�      