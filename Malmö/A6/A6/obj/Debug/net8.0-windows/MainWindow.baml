   M S B A M L   `   `   `  ����=  9A6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:A6A6  5   	       A6.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ] YXceed.Wpf.Toolkit.NET5, Version=4.6.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   localclr-namespace:A6  5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)   .��5
      � .+�5   
   o� $	��Top=�6   .@�5      m� $��_File��6   .@�5      m� -   5        $
��_New��5      6)   m� 5      -   5        $��_Open��5      6*   m� 5      -   5        $��_Save��5      6*   �� 5      m� 5      -   5        $��_Exit��5      6*   5      m� 5      $��_Help��6   .@�5      m� -   5        $��_About��5      6+   5      5      �� 5   
   $��Date and Time��6   $
��Left=�6(   $��	10,39,0,0q�6C   $	��Top=�6V   &   Xceed.Wpf.Toolkit.DateTimePicker  5   
   -   5          Name$ dateTimePicker��5      $
��Left=�66   $��
133,37,0,0q�6Q   $	��Top=�6e   $	��300��6}   $��30��6�    � ToolTip$ Select a date and time��6�   �� 5   
   $��Priority��6   $
��Left=�6#   $��26��6>   $��
471,41,0,0q�6J   $	��Top=�6^   $��61��6v   �� 5   
   -   5        $��priorityComboBox��5      $
��Left=�6+   $��
553,43,0,0q�6F   $	��Top=�6Z   $	��120��6r   �� 5   
   $��To Do��6   $
��Left=�6    $��	10,97,0,0q�6;   $	��Top=�6N   �� 5   
   -   5        $��toDoTxt��5      $
��Left=�6!   $��30��6<   $��
133,97,0,0q�6H    �� TextWrapping$
 Wrap=�6\   $�� ��6p   $	��Top=�6x   $	��300��6�   �� 5   
   -	   5        $��addBtn��5      $	��Add��6   $
��Left=�6-   $��30��6H   $��
550,97,0,0q�6T   $	��Top=�6h   $	��123��6�   6�   �� 5   
   $
��Left=�6   $	��226��6.   $��To Do��6;   $��	8,153,0,0q�6J   $	��Top=�6]   $	��780��6u   6�   �� 5   
   $
��Date��6   $
��Left=�6   $��
23,172,0,0q�6:   $	��Top=�6N   �� 5    
   $
��Hour��6   $
��Left=�6   $��28��6:   $��174,172,0,0q�6F   $	��Top=�6[   $��44��6s   �� 5!   
   $��Priority��6   $
��Left=�6#   $��26��6>   $��270,172,0,0q�6J   $	��Top=�6_   $��55��6w   �� 5"   
   $��Description��6   $
��Left=�6&   $��26��6A   $��400,172,0,0q�6M   $	��Top=�6b   $��73��6z   �� 5#   
   -
   5        $��toDoList��5#      $
��Left=�6"   $	��159��6=   $��
23,203,0,0q�6J   $	��Top=�6^   $	��749��6v   �� 5$   
   -   5        $��currentTimeLabel��5$   #   $��00:00:00��6   $
��Left=�6;   $��32��6V   $��726,384,0,0q�6b   $	��Top=�6w   $��64��6�   5'      5(      