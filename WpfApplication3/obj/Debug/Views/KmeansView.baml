   M S B A M L   `   `   `  ����J  FWpfApplication3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:WpfApplication3.ViewsWpfApplication3.Views  5      d `Microsoft.Maps.MapControl.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35tRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPFMicrosoft.Maps.MapControl.WPF 6@   &     WpfApplication3.Views.KmeansView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:WpfApplication3.Views     5      `mRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPF     6@   .��5	      � 
�������.+�5
   
   �� $
��Auto��6   $	��Top=�6    $��Center=�68   $��
30,9,692,0q�6U   
�������$��10(�6{   $
��Bold"�6�   $��22��6�   $��78��6�   �� 5   
   $��
Employee :��6   $��Bottom=�6&   $
��Left=�6A   $��
30,0,0,385q�6\   $��28��6p   $��65��6|   �� 5   
   -   5          ��Name$  	dmanFname��5      $��Bottom=�6M   $
��Left=�6h   $��
44,0,0,355q�6�   $��25��6�   $	��132��6�   ��6)   �� *MyName+ �� Mode$ TwoWay=�6�   �� 5   
   $��Distribution Number :��6   $��Bottom=�61   $
��Left=�6L   $��
30,0,0,291q�6g   $��28��6{   $	��146��6�   �� 5   
   -   5        $  disnb��5      $��Bottom=�6H   $
��Left=�6c   $��
44,0,0,261q�6~   $��25��6�   $	��132��6�   ��6%   �� *DisNB+$ TwoWay=�6�   �� 5   
   $��this cluster contains : ��6   $��0,0,643,423.6q�63   6L   �� 5   
   -   5         ��Name$ listado��5      
�������$��0,31,610,111.6q�66   � 5   
   $��195,24,15,116q�6    J� RenderTransformOrigin$ 0.5,0.5&�6&   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -0.181Q�6&   T� 5      5      .+�5      '  !Microsoft.Maps.MapControl.WPF.Map  -   5          Name$	 map��5      +  %Microsoft.Maps.MapControl.WPF.MapCore   CredentialsProviderT  NMicrosoft.Maps.MapControl.WPF.Design.ApplicationIdCredentialsProviderConverter$r lTOdRmkW390gp17Kf6CJj~rckEG0baSMjfAKI50l7p8w~AmkUsdyKtsB_YUA1W-B9a3Hue5QSsBP6C0x3DADZ0PWV5Z-Hi4dvjgeXVOFab01y 6!      Mode;  5Microsoft.Maps.MapControl.WPF.Design.MapModeConverter$ AerialWithLabels 6�      Center<  6Microsoft.Maps.MapControl.WPF.Design.LocationConverter$ 32.340685,34.868625 6�   	   	ZoomLevel$	 7Q�6�   $��0,-25,0,-0.4q�6�   5       � 5!   
   -   5        
 �Name$
 progress��5!      $
��Left=�6(   $��10��6C   $��
209,16,0,0q�6O   $	��Top=�6c   $	��100��6{    � IsIndeterminate .  
���   �
�������6�   �� 5$   
   -   5         ��Name$
 prev��5$      $��Prev.��6   $��16(�6/   $��32��6=   $	��110��6J   $
��Left=�6V   $	��Top=�6q   $��246,379,0,0q�6�    �� 	IsDefault . 
�������
���������6�   �� *MyReplaceUCCommand+��6�   �� *	Content+ �� ElementName$
 prev��6"  �� 5%   
   -   5        $
 next��5%      $
��Next��6   $��16(�6.   $��32��6<   $��96��6I   $
��Left=�6T   $	��Top=�6o   $��547,379,0,0q�6�    . 
�������
���������6�   �� *MyReplaceUCCommand+��6�   �� *	Content+$
 next��6   �� 5'   
   -   5        $ ok��5'      $��OK��6   $��16(�6+   $��32��69   $	��143��6F   $
��Left=�6R   $	��Top=�6m   $��378,379,0,0q�6�    . ���	#FF1BA85B$ 1.557,0.617&�6   
���   ���6�   �� *MyReplaceUCCommand+��6�   �� *	Content+$ ok��6D  �� 5*   
   -	   5        $ cancel��5*      $��Cancel��6!   $��16(�62   $��87��6@   $��Right=�6K   $��0,417,10,9.6q�6�   
���������6g   �� *MyReplaceUCCommand+��6�   �� *	Content+$ cancel��6�   5,      5-      