   M S B A M L   `   `   `  ����B  >WPF_Pro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WPF_ProWPF_Pro  5   	       WPF_Pro.PAdg   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WPF_Pro     5   	     � Title$
  PAdg��5   	   $	��431��6   $��213.898��6#   .��5	      �  � Cursor$	 Pen��6   $	��402��6   $	��Top=�6%   $��0,0,0,-2q�6=   $
��Left=�6O   $	��209��6j    � RowDefinitions 5
   
   �� 5      �� 5      $��0* �6   �� 5      $��0* �6   �� 5      $��0* �6    J� OpacityMask 5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6    � Offset$ 0Q�6-   � 5      $ 	#FFEE1414��6   $ 1Q�61   5      ��5   
   �� 5      $ 0.5,1&�6"   $ 0.5,0&�63   .��5      � $ Black��6   $ 0Q�6-   � 5      $ 	#FF5D6791��6   $ 1Q�61   5       � ColumnDefinitions 5   
   �� 5      .+�5   
   �� $
��Left=�6   $��0��6/   $��374,3,-212,-3q�6:   $
��Wrap=�6Q   $��	TextBlock��6e   $	��Top=�6v   $��5��6�   $��3��6�   �� 5    
   $��Grupa��6   $
��Left=�6    $��59,29,-202,0q�6;   $	��Top=�6Q   $	��356��6i   ���	#FFFFF3F3$��20(�6�   $
��Bold"�6�   $��37��6�   �� 5!   
   -   5        	 ��Name$	 k��5!      $��Ok��6   $
��Left=�6)   $��
59,354,0,0q�6D   $	��Top=�6X   $	��108��6p   $��20��6|   6�   �� 5"   
   $
��Left=�6   $��	24,56,0,0q�6+   $	��Top=�6>   $��10��6V   $��10��6b   �� 5#   
   -   5        
 ��Name$
 i2��5#       $��Id P:��6   $
��Left=�6,   $��
38,272,0,0q�6G   $	��Top=�6[   
�������$��26��6�   $��56��6�   �� 5$   
   -   5         ��Name$ i1��5$      $
��Left=�6   $��24��69   $��118,274,0,0q�6E    �� TextWrapping$
 Wrap=�6Z   $	��Top=�6n   $��55��6�   �� 5&   
   $4��.Intoduceti Id-ul Profesorului si Id-ul 
Grupei��6   $
��Left=�6M   $��0,71,0,0q�6h   $	��Top=�6z   
�������$	��203��6�   $��63��6�   �� 5'   
   -   5        $
 g2��5'       $��Id G:��6   $
��Left=�6,   $��
38,313,0,0q�6G   $	��Top=�6[   
�������$��26��6�   $��56��6�   �� 5(   
   -   5        $ g1��5(      $
��Left=�6   $��24��69   $��118,315,0,0q�6E   $
 Wrap=�6Z   $	��Top=�6n   $��55��6�   &   System.Windows.Controls.DataGrid  5)   
   -   5          Name$
 Grup��5)      $
��Left=�6!   $	��116��6<   $��
24,134,0,0q�6I   $	��Top=�6]   $	��169��6u      
IsReadOnly .  � 	Resources 5*      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%�   '        �� 5+      "  6   .�5,      ��  � ��
 �P��63   �� 5-       � ��$ SemiBold"�63   �� 5.       � ��$ 0,0,1,3q�68   �� 5/       � ��
 �����64   50      51         Columns 52      0  *System.Windows.Controls.DataGridTextColumn  53      ,  &System.Windows.Controls.DataGridColumn   Header$ Id Grupa��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 60 67   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6B   �� *
Id_Grupa+  54      $ 
Nume Grupa��6%   $	 110 69    6E   �� *
Nume_Grupa+58      �� 59   
   -   5        $	 k_Copy��59   (   $��Adauga Grupa��6   $
��Left=�68   $��
85,109,0,0q�6S   $	��Top=�6g   $	��108��6   $��20��6�   6�   �� 5:   
   -   5        $	 k2��5:      $��Ok��6   $
��Left=�6*   $��
59,299,0,0q�6E   $	��Top=�6Y   $	��108��6q   $��20��6}   $y�Hidden=�6�   6�   �� 5;   
   -	   5        $
 n1��5;   &   $��Nume Grupa:��6   $
��Left=�62   $��
24,258,0,0q�6M   $	��Top=�6a   
�������$��26��6�   $��83��6�   $y�Hidden=�6�   �� 5<   
   -
   5        $ n2��5<      $
��Left=�6   $��24��69   $��118,260,0,0q�6E   $
 Wrap=�6Z   $	��Top=�6n   $��75��6�   $y�Hidden=�6�   5=      5>      