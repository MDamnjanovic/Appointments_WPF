   M S B A M L   `   `   `  ����N  JScheduleAppointment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:ScheduleAppointment.ViewScheduleAppointment.View  5   	   (    "ScheduleAppointment.View.FrmDoctor   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:ScheduleAppointment.View     5   	     � Title$  Doctor's profile��5   	   $	��450��6"   $	��800��6/    � WindowStartupLocation$ CenterScreen=�6;   .��5	      � .+�5
   
   �� $��Date:��6   $
��Left=�6    $��	54,60,0,0q�6;   $	��Top=�6N   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dtDate_Appointments��5      $
��Left=�62   $��
117,60,0,0q�6M   $	��Top=�6a   $	��147��6y   6�   �� 5   
   -   5         ��Name$ tb_12AM��5      $
��Left=�6#   $��23��6>   $��344,174,0,0q�6J    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��235��6�   �� 5   
   -   5         ��Name$ btn_12AM��5      $��set Therapy��6#   $
��Left=�69   $��604,174,0,0q�6T   $	��Top=�6i   $��98��6�    �� IsCancel . 6�   �� 5   
   -   5        $ tb_10AM��5      $
��Left=�6#   $��23��6>   $��
346,97,0,0q�6J   $
 Wrap=�6^   $	��Top=�6r   $	��235��6�   �� 5   
   -   5        $ btn_10AM��5      $��set Therapy��6#   $
��Left=�69   $��
606,97,0,0q�6T   $	��Top=�6h   $��98��6�    .  J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ 0.244Q�6&   T� 5      5      5      �� 5   
   -   5        $ tb_11AM��5      $
��Left=�6#   $��23��6>   $��345,135,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��235��6�   �� 5   
   -   5        $ btn_11AM��5      $��set Therapy��6#   $
��Left=�69   $��605,135,0,0q�6T   $	��Top=�6i   $��98��6�    . $ 0.072,0.609&�6�   z�5      V� 5      .~�5      �� �� 5      �� 5      $ 0.244Q�6&   T� 5       	 T� X$	 -0.009Q�6)   
 T� Y$
 -0.18Q�64   5!      5#      �� 5$   
   -   5        $ tb_9AM��5$      $
��Left=�6"   $��23��6=   $��
347,58,0,0q�6I   $
 Wrap=�6]   $	��Top=�6q   $	��235��6�   �� 5%   
   -	   5        $ btn_9AM��5%      $��set Therapy��6"   $
��Left=�68   $��
607,58,0,0q�6S   $	��Top=�6g   $��98��6    . $ 0.5,0.5&�6�   z�5&      V� 5'      .~�5(      �� �� 5)      �� 5*      $ 0.244Q�6&   T� 5+      5,      5.      �� 5/   
   -
   5        $ tb_1PM��5/      $
��Left=�6"   $��23��6=   $��344,211,0,0q�6I   $
 Wrap=�6^   $	��Top=�6r   $	��235��6�   �� 50   
   -   5        $ btn_1PM��50      $��set Therapy��6"   $
��Left=�68   $��604,211,0,0q�6S   $	��Top=�6h   $��98��6�    . 6�   �� 51   
   -   5        $ tb_2PM��51      $
��Left=�6"   $��23��6=   $��344,247,0,0q�6I   $
 Wrap=�6^   $	��Top=�6r   $	��235��6�   �� 52   
   -   5        $ btn_2PM��52      $��set Therapy��6"   $
��Left=�68   $��604,247,0,0q�6S   $	��Top=�6h   $��98��6�    . 6�   �� 53   
   -   5        $ tb_3PM��53      $
��Left=�6"   $��23��6=   $��344,286,0,0q�6I   $
 Wrap=�6^   $	��Top=�6r   $	��235��6�   �� 54   
   -   5        $ btn_3PM��54      $��set Therapy��6"   $
��Left=�68   $��604,286,0,0q�6S   $	��Top=�6h   $��98��6�    . 6�   �� 55   
   -   5        $ tb_4PM��55      $
��Left=�6"   $��23��6=   $��344,320,0,0q�6I   $
 Wrap=�6^   $	��Top=�6r   $	��235��6�   �� 56   
   -   5        $ btn_4PM��56      $��set Therapy��6"   $
��Left=�68   $��604,320,0,0q�6S   $	��Top=�6h   $��98��6�    . 6�   �� 57   
   -   5         ��Name$ labelDoctor��57      $��Label��6%   $
��Left=�65   $��28��6P   $��	21,10,0,0q�6\   $	��Top=�6o   $	��420��6�   �� 58   
   $	��9AM��6   $
��Left=�6   $��
296,55,0,0q�69   $	��Top=�6M   �� 59   
   $
��10AM��6   $
��Left=�6   $��
296,94,0,0q�6:   $	��Top=�6N   �� 5:   
   $
��11AM��6   $
��Left=�6   $��294,132,0,0q�6:   $	��Top=�6O   �� 5;   
   $
��12AM��6   $
��Left=�6   $��294,171,0,0q�6:   $	��Top=�6O   �� 5<   
   $	��1PM��6   $
��Left=�6   $��294,205,0,0q�69   $	��Top=�6N   �� 5=   
   $	��2PM��6   $
��Left=�6   $��294,247,0,0q�69   $	��Top=�6N   �� 5>   
   $	��3PM��6   $
��Left=�6   $��294,286,0,0q�69   $	��Top=�6N   �� 5?   
   $	��4PM��6   $
��Left=�6   $��294,320,0,0q�69   $	��Top=�6N   �� 5@   
   -   5        $ btnShowTherapyHistory��5@      $��Show therapies��60   $
��Left=�6I   $��
36,375,0,0q�6d   $	��Top=�6x   $	��104��6�   6�   5B      5C      