   M S B A M L   `   `   `  ����N  JScheduleAppointment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ScheduleAppointmentScheduleAppointment  5   	   $    ScheduleAppointment.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:ScheduleAppointment     5   	     � Title$  Schedule Appointments��5   	   $��461.199��6'   $��1228.914��68    � WindowStartupLocation$ CenterScreen=�6I   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgHospitals��5
      $
��Left=�6(   $	��295��6C   $��	34,72,0,0q�6P   $	��Top=�6c   $	��479��6{      SelectionMode$ Single=�6�      
IsReadOnly . 6�   �� 5   
   $��City:��6   $
��Left=�6    $��	36,27,0,0q�6;   $	��Top=�6N    J� RenderTransformOrigin$ 0.508,0.195&�6f   �� 5   
   -   5         ��Name$ cbCity��5      $
��Left=�6#   $��	87,27,0,0q�6>   $	��Top=�6Q   $	��120��6i   6u   �� 5   
   -   5         ��Name$ btnLogIn��5      $��Log In��6#   $
��Left=�64   $��1110,38,0,0q�6O   $	��Top=�6d   $��75��6|   6�     5   
   -   5        $ 	dgDoctors��5      $
��Left=�6&   $	��294��6A   $��
538,73,0,0q�6N   $	��Top=�6b   $	��647��6z   �� 5   
   -   5        $ btnScheduleAppointment��5      $��Shedule appointment��61   $
��Left=�6O   $��538,387,0,0q�6j   $	��Top=�6   $	��174��6�   6�   5      5      