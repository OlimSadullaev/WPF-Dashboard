   M S B A M L   `   `   `  ????F  BReservation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Reservation.ViewsReservation.Views  5      +    %Reservation.Views.MakeReservationView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:Reservation.Views     5      .??5
      ?   ? IsSharedSizeScope$
  True??6    ? RowDefinitions 5   
   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   .+?5   
   ?? $??0??5       
  Header#??[  5      $??Make Reservation??5      ? 5   
   $??1??6   $??0 25 0 0q?6    5      ?? 5      $
??auto ?6    ?? 5      $
??auto ?6    .+?5      ?? $??0??6   $??Username??6%   ?? 5       $??1??6   $??0 5 0 0q?5!      ??5"      ?? *
UserName+ ?? UpdateSourceTrigger$ PropertyChanged=?5#      ? 5%   
   $??2??6   $??0 10 0 0q?6    5&      ?? 5'      $
??auto ?6    ?? 5(      $
??auto ?6     ? ColumnDefinitions 5*      ?? 5+      $
??auto ?6#    z? SharedSizeGroup$ FirstColumn??60   ?? 5,      $
??auto ?6#   $ SecondColumn??60   .+?5/      ?? $??0??6   $??0??50      $??	Floor No.??51      ?? 53      $??1??6   $??0??54      $	??100??55      $??0 5 0 0q?56      ??57      ?? *FloorNumber+$ PropertyChanged=??? 59      $??0??6   $??1??5:      $	??100??5;      $??10 0 0 0q?5<      $??Room No.??5=      ?? 5?      $??1??6   $??1??5@      $??10 5 0 0q?5A      ??5B      ?? *
RoomNumber+$ PropertyChanged=?5C      ? 5E   
   $??3??6    5F      ?? 5G      $
??auto ?6    ?? 5H      $
??auto ?6     5J      ?? 5K      $
??auto ?6#   ?? 5L      $
??auto ?6#   .+?5O      ?? $??0??5P      $??0??5Q      $??
Start Date??5R      (  "System.Windows.Controls.DatePicker  5T      $??1??5U      $??0??5V      $	??100??5W      $??0 5 0 0q?5X         SelectedDate 5Y      ?? *	StartDate+$ PropertyChanged=??? 5[      $??0??5\      $??1??5]      $??10 0 0 0q?5^      $??End Date??5_        5a      $??1??5b      $??1??5c      $	??100??5d      $??10 5 0 0q?5e       5f      ?? *	EndDate+$ PropertyChanged=?5g      ?? 5i   
   $??4??5j      $??0 50 0 0q?5k       ?? Orientation$ 
Horizontal=?5l      .+?5m      ?? $??Submit??67   ??6   ?? *SubmitButtton+67   ?? 5n      $??25 0 0 0q?6   $??Cancel??6'   ??68   ?? *CancelCommand+5o      5q      5r      