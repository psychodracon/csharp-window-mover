   M S B A M L   `   `   `  ����I  EWindowMoverWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WindowMoverWPFWindowMoverWPF  5   	   M+clr-namespace:WindowMoverWPF.Data.ViewModelWindowMoverWPF.Data.ViewModel  5   	       WindowMoverWPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:WindowMoverWPF     5   	   A	viewModel+clr-namespace:WindowMoverWPF.Data.ViewModel     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)    � DataContext 5      1  +WindowMoverWPF.Data.ViewModel.MainViewModel  5   
   .��5      � ���#edf2f6 � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5       � RowDefinitions 5   
   �� 5      $��75 �6   �� 5      .+�5   
   �� $��0��6   ���#3540525      �� 5   
   $��Window Mover��6   $��Center=�5      $��Center=�5       
�������$��22(�5"      �� 5%   
   $��1��6   ���#354052.+�5&      	� $��Anchors��6   $��50��5'      $��14(�5(       d� 	IsChecked$
 trueY�5)         MenuButtonTheme#��[  5*      ��5+      �� *AnchorsViewCommand+	� 5,      $��Options��6   $��50��5-      $��14(�5.      #��[  5/      ��50      �� *SettingsViewCommand+51      �� 53   
   $��1��6   $��1��54      $��
10 0 10 10q�55      ��56      �� *CurrentView+58      59      