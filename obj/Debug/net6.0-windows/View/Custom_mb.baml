   M S B A M L   `   `   `  ����  
WPF_Market    WPF_Market.Custom_mb   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   c _MaterialDesignThemes.MahApps, Version=1.0.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a_ [MaterialDesignThemes.Wpf, Version=5.0.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5
   	   -   5          � Title$  MessageBoxWindow��5   	   $	��200��6"   $	��400��6/    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�6.   
������� � 
ResizeMode$ 	CanResize=�5	   	    � Topmost$
 True��6     � ShowInTaskbar$ False��6/      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��10(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignFont#���  5   	   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��197* �6   �� 5      $
��295* �6   	 � RowDefinitions	 5   
   �� 5      $��50 �6   �� 5      $��* �6   .+�5   
   #  MaterialDesignThemes.Wpf.Card  -   5        
  Name$
 
cardHeader��5      $��0��62   $��5q�6?   $��0q�6K   +  %MaterialDesignThemes.Wpf.ShadowAssist   Darken$
 True��5        PrimaryHueDarkBrush#���  5       ! PrimaryHueDarkForegroundBrush#���  5      $y�Visible=�5      $��2��63   .��5       �� .+�5!      �� -   5         ��Name$ txtTitle��5!      $��Center=�5"      $��Stretch=�5#         MaterialDesignTitleTextBlock#���  5$      $��20(�5%      Message Title6:   5&      5'      �� 5(   
   $��Right=�6   $��0,5,5,0q�5)      $	��Top=�6(   $��1��5*      .+�5+      �� -   5         ��Name$ btnClose��5+      $��35��5,   ,   $��35��67   
�������#���  5-   (    * &MaterialDesignFloatingActionDarkButton#��[ 5.      .��5/      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6*   50      51      � 52   
   $��1��6   $��2��6   .+�53      � $��10q�6   	 54      �� 55      $
��auto �6$   �� 56      $
��auto �6$   .+�5:      � $��0��6   	 5;      �� 5<      $
��auto �6(   �� 5=      $��* �6(   .+�5@      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffects 5A      ;  5MaterialDesignThemes.Wpf.Transitions.TransitionEffect  5B         Kind$ FadeIn=�6>     5C      $ SlideInFromBottom=�6>   .��5E      �� -   5         ��Name$ 
txtMessage��5E   "   $��Center=�66    �� 
IsReadOnly$
 True��5F   "   $��0��64   $��5q�6A   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$  ��5G   "   $��14(�6D    % !MaterialDesignFloatingHintTextBox#��[ 5H   "   $��ExtraExpanded&�5I   "   5K      5M      � 5N      -   5        $��btn_row��5N      $��1��5O      $��0,5,0,0q�6"    5P      �� 5Q      $��* �6+   �� 5R      $
��auto �6+   �� 5S      $
��auto �6+   �� 5T      $��* �6+   .+�5W      �� -   5        $ btnOk��5W      $��1��5X        MaterialDesignRaisedButton#��[ 5Y      $��5q�5Z      $��80��6(   $��OK��5[       � ToolTip$ Ok��6*   �� 5^      -   5        $ 	btnCancel��5^      $��2��5_      #��[ 5`      $��5q�5a      $��80��6(   $��Cancel��63   $ Cancel��5b      �� 5d      -	   5        $ btnYes��5d      $��1��5e      #��[ 5f      $��5q�5g      $��80��6(   $	��Yes��63   $	 Yes��5h      �� 5j      -
   5        $ btnNo��5j      $��2��5k      #��[ 5l      $��5q�5m      $��80��6(   $��No��5n      $ No��6*   5p      5r      5s      5t      5u      