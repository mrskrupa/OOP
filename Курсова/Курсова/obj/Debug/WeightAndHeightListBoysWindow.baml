   M S B A M L   `   `   `  ����I  EКурсова, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:КурсоваКурсова  5   	   2    ,Курсова.WeightAndHeightListBoysWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Курсова     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  	MyProject��5	   	   $	��510��6   $	��750��6(    � WindowStyle$
 None=�64    � WindowStartupLocation$ CenterScreen=�6G   .��5
      � 
����� � � RowDefinitions 5   
   �� 5      $	��31* �6   �� 5      $
��412* �6   .+�5   
   � -   5        $��ToolBar��5      $��0��6   .+�5      � 
������� J� Opacity$ 1Q�6#    � Points) �   ���W���j �����j �485      �� 5       �� Orientation$ 
Horizontal=�6   $��Right=�62   .+�5      �� -   5        $��MinimizedButton��5      $��28��6/   $��28��6;   $��2q�6F   $1��+Source/icons8-macos-свернуть-96.png��6Q   6~   �� 5      -   5        $��
ExitButton��5      $��28��6+   $��28��67   $��2q�6B   $/��)Source/icons8-macos-закрыть-96.png��6M   6y   5      5      �� 5   
   $	��500��6   $��0,9.8,0,52.2q�6    
�������$��Center=�6I    �� Padding$ 40q�6d   $	��650��6q    �� CornerRadius$ 25��6�   $	��350��6�   $��1��6�   	 J� Effect	 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      
   
BlurRadius$
 90Q�6#      Color$ Black��63      ShadowDepth$ 0Q�6A   ._�5      �� .+�5      �� $��Ваш кабінет��6   $��30(�6/   $
��Bold"�6=   $��0 0 0 20q�6O   �� 5       $=��7Будь ласка заповніть всі дані:��6   $��17(�6B   $��DemiBold"�6P   $��0 0 0 20q�6f   �� 5!      -   5         ��Name$ WeightBoysBox��5!      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$F @Введіть вагу дитини! ( у кілограмах)��61    %  !MaterialDesignFloatingHintTextBox#��[  6w   �� 5"      -   5        $ HeightBoysBox��5"      $? 9Введіть зріст дитини! (у метрах)��61   #��[  6s   �� 5#      -   5        $ 
AgeBoysBox��5#      $C =Введіть вік дитини! (повних років)��6.   #��[  6r   �� 5$      -   5         ��Name$ Continue_Button��5$   .   $��Продовжити��6   $
��0 20q�6G   6U   5%      5&      5'      5(      