   M S B A M L   `   `   `  ����J  FWpfApplication3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:WpfApplication3.ViewsWpfApplication3.Views  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      "    WpfApplication3.Views.AddDis   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:WpfApplication3.Views     5      6sys&clr-namespace:System;assembly=mscorlib     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962af bMaterialDesignThemes.MahApps, Version=0.1.5.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   6A   .��5	      �� -   5          ��Name$
  page��5	      .��5
   
   � -   5         �Name$ biggrid��5
      
�������$
��Left=�63   $	��420��6N   $	��800��6[   $��
3,0,0,-0.4q�6g    J� RenderTransformOrigin$ 0.5,0.5&�6{   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -0.021Q�6&   T� 5      5      .+�5      �� 
�������$��1q�6)   $
��Left=�6=   $	��438��6X   $��	10,10,0,0q�6e   $	��Top=�6x   $	��803��6�   
������� J� OpacityMask
 �   �._�5      � -   5        $ dataGrid��5      $��-1,-19,29,35q�6)   .+�5      1&clr-namespace:System;assembly=mscorlibSystem 6;   (  "System.Windows.Controls.DatePicker  6   2sys&clr-namespace:System;assembly=mscorlib   6;   -   5          Name$ dater��5   �      IsTodayHighlighted . 
 �� Now   DisplayDate# Z 6n   $��220,84,154.6,308.8q�6�   	   SelectedDate	 6�   �� 
 �� Path$

 date� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6  �� 5      $����................................................................................................................................................��6   $��11,51,145.6,343.8q�6�   
�������$��Microsoft Sans Serif)�6�   $��16(�6  #��� ��6  $ 0.5,0.5&�6]  z�5      V� 5      .~�5   "   �� �� 5   "    �� AngleY$ 0.212Q�60   �� 5   "   T� 5   "    T� Y$ 0.698Q�65   5      5       �� 5!      $\��VAdd a new distribution - to add a new distribution please fill all the required fields��6   $��0,22,19.6,355.8q�6}   
�������$��Microsoft Sans Serif)�6�   $ ��20                        (�6�   #��� ��5"      �� 5#      $��Date to delivery*��6   $��85,84,572.6,284.8q�68   
�������$��Microsoft Sans Serif)�6f   $��12(�6�   #��� ��6�   �� 5$      $��
To who ? *��6   $��85,141,368.6,223.8q�61   
�������$��Microsoft Sans Serif)�6`   $��12(�6�   #��� ��6�   �� 5%      $��* required fields��6   $��220,313,461.6,84.8q�68   
�������$��Microsoft Sans Serif)�6g   $ ��10                        (�6�   
���   �5&      �� 5'      $	��by*��6   $��85,202,112.6,158.8q�6*   
�������$��Microsoft Sans Serif)�6Y   $��12(�6{   #��� ��6�   $ 0.569,-0.445&�6�   � 5)      -   5        $ 	checkGrid��5)      .+�5*      �� -   5         ��Name$ checkFoodCB��5*   #   $��231,250,214.6,111.8q�6�   ��68   �� *foodCheckComm+��6Z   �� *	Content+ �� ElementName$ checkFoodCB��.��5+      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Food=�67   $��52��6C   $��55��6O   $��Center=�6Z   5,      �� 5.      -   5        $ checkDrugCB��5.   #   $��405,250,63.6,-17.2q�6�   ��68   �� *drugCheckComm+��6Z   �� *	Content+$ checkDrugCB�� d� 	IsChecked 6�   �� *
checkdrugs+$ TwoWay=�.��5/        $ Medicine=�67   $��44��6H   $��56��6T   $��Center=�6_   50      51      55      58      � 59      -   5        $ 
buttonGrid��59      $��91,1,-67,130q�6'   .+�5:      �� -	   5         ��Name$ addDis��5:      $	��Add��6�   $
��Left=�6�   $��143,333,0,-85q�6�   $	��Top=�6�   $	��270��6�   ���	#FF0F9D58$��Microsoft Sans Serif)�6�   
�������$��41��62  ��6)   �� *
addDisComm+��6H   �� *	Content+$ addDis��62  �� 5;      -
   5        $ 
cancelButt��5;      $��	or Cancel��6�   $
��Left=�6�   $��418,336,0,-82q�6�   $	��Top=�6�   $��92��6�   
�������$��10(�6  
�������#��� ��6'  $ 
0.53,0.175&�6o  $��35��6�  ��6-   �� *
cancelComm+��6L   �� *	Content+$ 
cancelButt��6�  �� 5<      -   5         ��Name$ ListDM��5<      $
��Left=�6D   $��143,196,0,0q�6_   $	��Top=�6t   $	��400��6�   $��33��6�   ��6,   �� 6�   �� 5=      -   5        $ selectClient��5=      $��select clients��6�   $
��Left=�6�   $��143,136,0,0q�6�   $	��Top=�6�   $	��270��6�   ���	#FF0F9D58$��Microsoft Sans Serif)�6  
�������$��33��6M  ��6/   �� *selectClientComm+��6T   �� *	Content+$ selectClient��6M  5>      �� 5?      -   5         ��Name$
 box3��5?      $y�Hidden=�6"   $��You have selected��66   $
��Left=�6R   $	��Top=�6m   $��25��6�   $	��109��6�   $��505,141,0,0q�6�   �� 5@      -   5        $
 box1��5@      $y�Hidden=�6"   $
��Left=�66   $	��Top=�6Q   $��61��6i   $��43��6u   $��691,136,0,0q�6�   .��5A        $
 Done=�6+   $��28��68   $��33��6D   $��Center=�6O   $ 0.886,0.993&�6j   5B      �� 5C      -   5        $
 box2��5C      $y�Hidden=�6"   $��clients��66   $
��Left=�6H   $	��Top=�6c   $��25��6{   $��44��6�   $��642,141,0,0q�6�   �� 5D      -   5         ��Name$
 box4��5D   B   
������ {�.  $
��Left=�6P   $��23��6k   $��614,143,0,0q�6w    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $��23��6�   5F      5G      5H      