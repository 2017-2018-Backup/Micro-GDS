   M S B A M L   `   `   `  ����H  DBatchPlotting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:BatchPlottingBatchPlotting  5   	   #    BatchPlotting.BatchProcessBar   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:BatchPlotting     5   	     � Title$  MicroSOPS - Publish v1.1��5   	    � Icon$ Resources/SOPS2016.ico��6*    � 
ResizeMode$ NoResize=�6H   $	��150��6^   $	��450��6k    � WindowStartupLocation$ CenterScreen=�6w    � 	Resources 5	       �� 
TargetType �� Property �� Value �� 
TargetType	 J� SnapsToDevicePixels
 {�Name �� Triggers P� Property P� Value �� 
TargetName N� EnterActions �� 
TargetName �� TargetProperty t� From	 t� To g� Duration g� AutoReverse g� RepeatBehavior��%�  '�       �� 5
   
   " �6-   .�5      ��  � �� �	#FFCBECB06+   �� 5       � ��
 �����6+   �� 5       � ��
 �����6@   �� 5       � ��$ 1q�60   �� 5       � �� 5      �� 5      " �6&   .R�5      � $��TemplateRoot��6   	 . .+�5      �� #��z��6(   �� 5      $��
PART_Track��6(   $��0q�6:   {� 5      $
 PART_Indicator��6(   $
��Left=�6@   $��0q�6[   ._�5   "   � $��
Foreground��6'   .+�5   &   �� $��	Indicator��6T   #��z��60   6T   � 5   &   $��	Animation��6+   }�. .+�5   *   �� $��PART_GlowRect��61   $��0,0,0,0q�6G   $
��Left=�6X   #��z��6s   5   '   � 5   &   $��Overlay��6+   5   '   5   #   5      �� 5       #��z��6%   #��z��5!      5"       5#      P� 5$       �@�IsIndeterminate . . �5%   "   �� $ 	Indicator��6)    � ��
 ���� 6P   �� 5&   "   $ PART_GlowRect��6)    � ��$	 100��6U    5'   "   �� 5(   &   .��5)   *   �� .��5*   .   t� $ PART_GlowRect��5+   )   $ Margin�5,   )   $ 	-50,0,0,0X�5-   )   $ 	400,0,0,0X�6;   $ 0:0:2D�6J    . $ Forever��5.   <   5/   +   50   '   52      54      56      57      58      .��59      �  � RowDefinitions 5:   
   �� 5;      $��30 �6   6*   �� 5<      $��30 �6   6*   �� 5=      $��* �6   6)   .+�5?   
   �� -   5        $��	lblHeader��5?      $��0��6!   $��Processing......��6.   6K   �� 5@   
   -   5        $��lblStatusPublisher��5@      $��1��6*   69   � 5A   
   -   5        $��pbStatus��5A   4   $��2��6   $��5,0,5,0q�6#   $��30��6D   �� 5B   
   -   5        $��txtPercentage��5B   3   $��2��6   
���  ��$��Center=�6H   $��Center=�6f   5C      5D      