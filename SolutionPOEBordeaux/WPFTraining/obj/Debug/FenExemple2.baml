   M S B A M L   `   `   `  ����F  BWPFTraining, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WPFTrainingWPFTraining  5   	   A%clr-namespace:WPFTraining.ValidationsWPFTraining.Validations  5   	       WPFTraining.FenExemple2   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WPFTraining     5   	   <
localvalid%clr-namespace:WPFTraining.Validations     5   	   -   5          � Title$  FenExemple2��5
   	   $	��450��6   $	��800��6*    � 	Resources 5      5   /WPFTraining.Validations.MonConvertisseurErreurs   monConvertErreurs��%   &	          5   
   6-   5      .��5      �  � RowDefinitions 5   
   �� 5      $	��76* �6   �� 5      $	��49* �6   �� 5      $	��68* �6   �� 5      $	��45* �6   �� 5      $��0* �6   �� 5      $
��183* �6    � ColumnDefinitions 5   
   �� 5      $	��48* �6   �� 5      $
��217* �6   .+�5   
   �� $��Choisir un produit :��6   $��0��60   $��0��6=   $��10q�6M   �� 5   
   -   5         ��Name$ ComboProduits��5      $��0��6+   $��1��68   $��10q�6H   6T   �� 5   
   -   5         ��Name$ TBoxQte��5      $��1��6#   $��1��60   $��10,10,9.667,10.333q�6@   .��6\   ��5       �� 5!       �� Path$
 Text�6    �� ElementName$ TBoxQte��6&    �� ValidationRules 5"      3   -WPFTraining.Validations.RegleValidationInterv  5#      
	   Min$	 1X�6;   

   Max$	
 100X�6C   ,  &System.Windows.Controls.ValidationRule   ValidatesOnTargetUpdated . 6M   5%      .��5&      5'      �� 5(   
   
���  ��$��2��6&   $��0��63   $��2��6C   ��5)      �� $ TBoxQte��$ (Validation.Errors)� �� 	Converter# [  �� 5+   
   -   5         ��Name$ 
BtnAjouter��5+      $��Ajouter au panier��6%   $��3��6B   $��0��6O   $��2��6_   $��10q�6s   6   �� 5,   
   -   5        $ BtnAfficherPanier��5,      $��Voir le panier��6,   $��4��6F   $��0��6S   $��2��6c   $��10q�6w   6�   5-      5/      