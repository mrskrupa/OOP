   M S B A M L   `   `   `  ����I  EКурсова, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:КурсоваКурсова  5   	   #    Курсова.UserPageWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Курсова     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  	MyProject��5	   	   $	��420��6   $	��750��6(    � WindowStyle$
 None=�64    � WindowStartupLocation$ CenterScreen=�6G   .��5
      � 
���� �� � RowDefinitions 5   
   �� 5      $	��16* �6   �� 5      $
��181* �6   .+�5   
   � -   5        $��ToolBar��5      $��0��6   .+�5      � 
������� J� Opacity$ 1Q�6#    � Points) �   ���W���j �����j �485      �� 5       �� Orientation$ 
Horizontal=�6   $��Right=�62   .+�5      �� -   5        $��MinimizedButton��5      $��28��6/   $��28��6;   $��2q�6F   $1��+Source/icons8-macos-свернуть-96.png��6Q   6~   �� 5      -   5        $��
ExitButton��5      $��28��6+   $��28��67   $��2q�6B   $/��)Source/icons8-macos-закрыть-96.png��6M   6y   5      5      �� 5   
   $	��500��6   $��0,50,0,91.6q�6    
�������$��Center=�6H    �� Padding$ 40q�6c   $	��650��6p    �� CornerRadius$ 25��6   $	��220��6�   $��1��6�   	 J� Effect	 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      
   
BlurRadius$
 90Q�6#      Color$ Black��63      ShadowDepth$ 0Q�6A   ._�5      �� .+�5      �� $%��Головна сторінка��6   $��30(�64   $
��Bold"�6B   $��0 0 0 20q�6T   �� 5       $,��&Оберіть стать дитини��6   $��17(�68   $��DemiBold"�6F   $��0 0 0 20q�6\   � 5!      $��0 0 0 20q�6   .+�5"      �� -   5         ��Name$ Boys_Button��5"   9   $��Right=�6   $��Хлопчик��6N   $	��230��6z   �� 5#      -   5        $ Girls_Button��5#   8   $
��Left=�6   $��Дівчинка��6N   $	��230��6|   5$      5%      5&      5'      5(      