   M S B A M L   `   `   `  ????I  EGym_Management, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Gym_ManagementGym_Management  5   	   M+clr-namespace:Gym_Management.MVVM.ViewModelGym_Management.MVVM.ViewModel  5   	       Gym_Management.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Gym_Management     5   	   A	viewModel+clr-namespace:Gym_Management.MVVM.ViewModel     5   	   $	??600??5	   	   $	??920??6     ? WindowStyle$
  None=?5
   	    ? 
ResizeMode$ NoResize=?5   	   
??????  ? AllowsTransparency$
 True??5   	    ? DataContext 5      1  +Gym_Management.MVVM.ViewModel.MainViewModel  5   
   .??5      ?? ???#272537 ?? CornerRadius$ 20??5      ._?5   
   ?  ? ColumnDefinitions 5      ?? 5      $	??200 ?6#   ?? 5       ? RowDefinitions 5      ?? 5      $	??75  ?6    ?? 5      .+?5       ?? $??Elysian??6   $??Center=?5!      $
??Left=?5"      
???????$??22(?5$      $??20,0,0,0q?5%      ?? 5(      $??1??6   .+?5)      	? $
??Home??6   $??50??5*      
???????$??14(?5,         MenyuButtonTheme#??[  5-       d? 	IsChecked$
 TrueY?5.      ??5/      ?? *HomeViewCommand+	? 51      $??	Discovery??6   $??50??52      
???????$??14(?54      #??[  55      ??56      ?? *DiscoveryViewCommand+	? 58      $??Featured??6   $??50??59      
???????$??14(?5;      #??[  5<      5?      ?? 5A      $	??250??6   $??40??5B      $??Center=?5C      $
??Left=?5D      $??5q?5E      $??1??5F        ModernTextbox#??[ 5G      ?? 5I      $??1??6   $??1??5J      $??10q?5K      ??5L      ?? *CurrentView+5O      5R      5S      