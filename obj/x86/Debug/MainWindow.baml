   M S B A M L   `   `   `  ����  	VotingApp    VotingApp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35` \RibbonControlsLibrary, Version=4.0.0.11019, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Imy@http://schemas.microsoft.com/winfx/2006/xaml/presentation/ribbon  5   �   -   5        $
��main��5   w     � Title$  Deeksha Voting App��6   $	��371��6    $	��710��6-    � 
ResizeMode$ CanMinimize=�69    � WindowStartupLocation$ CenterScreen=�6R    � Icon$+ %/VotingApp;component/Images/vote2.ico��6�   ��5      �� 5   
    �� ImageSource$) #/VotingApp;component/Images/bg4.jpg��6   .��5      � $
��Auto��6    � RowDefinitions 5	   
   �� 5
      $
��124* �6   �� 5      $
��168* �6   .+�5   
   �� -   5        $
��hlp2��5   z   $��Help & Support  ��6   $��1��60   $��57��6=   $��Right=�6I   $��0,141,511,0q�6e   $	��Top=�6�   $	��197��6�   $��LeftToRight=�6�   $��Right=�6�   $��Gabriola)�6�   $��25(�6�    � Cursor$
 Hand��6  $��Normal"�6  $��Normal$�6/  ��5      �� 5       �� EndPoint$ 1,0.5&�6&    �� 
StartPoint$ 0,0.5&�67   .��5      � 	 � Color$	 	#FF468EE9��6#   
 � Offset$
 0.219Q�65   � 5      $	 Transparent��6#   $
 1Q�67   5      ��5      �� 5      5      3  -Microsoft.Windows.Controls.Ribbon.RibbonGroup  5   
   -   5        $��banner��5   �   )   "CanAddToQuickAccessToolBarDirectly .  $��67��6D   $��Right=�6P   $��0,-10,-30,0q�6l   $	��Top=�6�   $	��744��6�   ��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $	 	#9D2EA5F0��6#   $
 0.156Q�65   � 5      $	 Transparent��6#   $
 1Q�67   5       � ContextMenu 5      �� 5       {�.  $y�Hidden=�60   5"      �� 5#   
   -   5        $��
TextBlock1��5#   �   $��22(�6   $��Normal$�6"   $��Normal"�65   ���	#FF5A5A5A$��33��6`   $��Center=�6l   $��292,40,270,0q�6�   $��
Welcome to��6�    �� TextAlignment$ Center=�6�   $	��Top=�6�   $	��126��6�   �� 5$   
   -   5        $��
TextBlock2��5$   �   $��35(�6   $��Normal$�6"   $��Normal"�65   
���   �$��61��6\   $��Center=�6h   $��181,63,160,0q�6�   $��Deeksha Voting App��6�   $ Center=�6�   $	��Top=�6�   $	��347��6�   �� 5%   
   -   5        $��
TextBlock3��5%   �   $��19(�6*   $��Normal$�68   $��Normal"�6K   
���   �$��27��6r   $��Center=�6~   $��436,134,8,0q�6�   $��Programmed & designed by��6�   $ Center=�6�   $	��Top=�6�   $	��244��6  $��1��6!  ��6   Z� 6!  �� 5&   
   -   5        $��
TextBlock5��5&   �   $��LeftToRight=�6*   $��Palatino Linotype)�6F   $��19(�6e   $��Italic$�6s   $
��Bold"�6�   
���   �$��30��6�   $
��Left=�6�   $��370,161,0,0q�6�   $&�� Aravind Balaji & Akshith Narayan��6�   $ Center=�6%  $	��Top=�6<  $	��310��6T  $��1��6`  ��6   Z� 6`  �� 5'   
   -   5        $��begin��5'   �   
��� � �$��Let the Voting Begin!��6%   $
 Hand��6E   $��Segoe UI)�6S   $��17(�6i   $��Normal$�6w   $��Normal"�6�   $��43��6�   $
��Left=�6�   $��
369,41,0,0q�6�   $	��Top=�6�   $	��245��6�   $��1��6
  ��5(      �� 5)      $ 0.5,1&�6&   $ 0.5,0&�67   .��5*      � $	 	#05FFFFFF��6#   $
 0Q�65   � 5+      $	 	#FF27B843��6#   $
 1Q�65   5,      5.      �� 5/   
   -	   5        $
��edit��5/   �   
��� � � �� 	ClickMode$ Release=�6%   $��Add/Remove Candidates��69   $
 Hand��6Y   $��Segoe UI)�6g   $��17(�6}   $��Normal$�6�   $��Normal"�6�   $��43��6�   $
��Left=�6�   {�. $��	96,41,0,0q�6�    J� Opacity$ 1Q�6	  $	��Top=�6  $	��245��6-  $��1��69  ��50      �� 51      $ 0.5,1&�6&   $ 0.5,0&�67   .��52      � $	 	#05FFFFFF��6#   $
 0Q�65   � 53      $	 	#FF27B843��6#   $
 1Q�65   54      56      �� 57   
   -
   5        $��TextBlock11��57   �   $��25(�6   $��Normal$�6"   $
��Bold"�65   ���	#FF5A5A5A$��38��6^   $��Center=�6j   $��-26,90,-30,0q�6�   $Z��T____________________________________________________________________________________��6�   $
 Left=�6  $	��Top=�6!  $	��744��69  $��1��6E  �� 58   
   -   5        $��Image1��58   L   $	��104��6   $
��Left=�6   $��
119,40,0,0q�68   $
��Fill=�6Z   $	��Top=�6i   $��68��6�   $-��'/VotingApp;component/Images/Deeksha.jpg��6�   $��2��6�   �� 59   
   -   5        $
��hlp1��59   W   $��1��6   $��55��6   $
��Left=�6)   $��	0,142,0,0q�6D   $��Uniform=�6c   $	��Top=�6u   $��55��6�   $*��$/VotingApp;component/Images/help.ico��6�   $
 Hand��6�   5:      5;      