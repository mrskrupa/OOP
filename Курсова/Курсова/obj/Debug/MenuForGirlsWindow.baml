   M S B A M L   `   `   `  ����I  EКурсова, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:КурсоваКурсова  5   	   '    !Курсова.MenuForGirlsWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Курсова     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  	MyProject��5	   	   $	��510��6   $	��750��6(    � WindowStyle$
 None=�64    � WindowStartupLocation$ CenterScreen=�6G   .��5
      � 
����i�� � RowDefinitions 5   
   �� 5      $	��17* �6   �� 5      $
��205* �6   .+�5   
   � -   5        $��ToolBar��5      $��0��6   .+�5      � 
������� J� Opacity$ 1Q�6#    � Points) �   ���W���j �����j �485      �� 5       �� Orientation$ 
Horizontal=�6   $��Right=�62   .+�5      �� -   5        $��MinimizedButton��5      $��28��6/   $��28��6;   $��2q�6F   $1��+Source/icons8-macos-свернуть-96.png��6Q   6~   �� 5      -   5        $��
ExitButton��5      $��28��6+   $��28��67   $��2q�6B   $/��)Source/icons8-macos-закрыть-96.png��6M   6y   5      5      �� 5   
   $	��500��6   $��0,10.4,0,49.2q�6    
�������$��Center=�6J    �� Padding$ 40q�6e   $	��650��6r    �� CornerRadius$ 25��6�   $	��350��6�   $��1��6�   	 J� Effect	 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      
   
BlurRadius$
 90Q�6#      Color$ Black��63      ShadowDepth$ 0Q�6A   ._�5      �� .+�5      �� $��Ваш раціон��6   $��30(�6.   $
��Bold"�6<   $��0 0 0 20q�6N   �� 5       -   5         ��Name$ textBox2��5       $��10(�6-   $
��Bold"�6;   $��0 0 0 20q�6M   �� 5!      -   5         ��Name$ Back_Button��5!   C   $A��;Повернутися на головну сторінку��6   $��0 0 0 20q�6X   6j   5"      5#      5$      5%      