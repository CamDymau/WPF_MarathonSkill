   M S B A M L   `   `   `  ����I  EMarathonSkills, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:MarathonSkills.RunnerMarathonSkills.Runner  5   	   .    (MarathonSkills.Runner.ContactCoordinator   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:MarathonSkills.Runner     5   	     � 
ResizeMode$  NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5	   	    � Title$ ContactCoordinator��5
   	   $	��450��6$   $	��600��61   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��21* �6   �� 5      $	��37* �6   �� 5      $��212.146 �6   �� 5      $��149.854 �6    � RowDefinitions 5   
   �� 5      $��82 �6   �� 5      $	��250 �6   �� 5      .+�5   
   �� $
��Left=�6   $��	14,25,0,0q�6/   $
��Wrap=�6B   $��Контакты��6V   $	��Top=�6f   $��24(�6~   $��2��6�   �� 5   
   $��1��6   $
��Left=�6$   $��0,30,0,0q�6?   $��1��6Q   $
��Wrap=�6^   $����Для получения дополнительной информации пожалуйста свяжитесь с координаторами��6r   $	��Top=�6�   $��3��6�   $	��361��6�   $��16(�6�   �� 5   
   $��1��6   $
��Left=�6$   $��0,86,0,0q�6?   $��1��6Q   $
��Wrap=�6^   $��Телефон: ��6r   $	��Top=�6�   $��92��6�   $��16(�6�   $
��Bold"�6�   �� 5   
   $��1��6   $
��Left=�6$   $��	0,123,0,0q�6?   $��1��6R   $
��Wrap=�6_   $��Email:��6s   $	��Top=�6�   $��92��6�   $��16(�6�   $
��Bold"�6�   �� 5   
   -   5         ��Name$ txt_tel��5      $��1��6%   $
��Left=�65   $��	72,86,0,0q�6P   $��1��6c   $
��Wrap=�6p   $��+55 11 9988 7766��6�   $	��Top=�6�   $��2��6�   $	��272��6�   $��16(�6�   �� 5   
   -   5        $��	txt_email��5      $��1��6%   $
��Left=�65   $��
62,123,0,0q�6P   $��1��6d   $
��Wrap=�6q   $%��coordinators@marathonskills.org��6�   $	��Top=�6�   $��2��6�   $	��288��6�   $��16(�6�   5      5      