   M S B A M L   `   `   `  ����N  Jwpf_GestioneNegozio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:wpf_GestioneNegoziowpf_GestioneNegozio  5   	   +    %wpf_GestioneNegozio.GestioneCategoria   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:wpf_GestioneNegozio     5   	     � Title$  GestioneCategoria��5   	   $	��450��6#   $	��800��60   .��5	      ]� .+�5      �� $	��250��6   .+�5   
   �� .��6   GESTIONE CATEGORIA6$   �� 5   
   .��6   Inserisci Categoria6%   �� 5   
   -   5         ��Name$ tbNome��5      6"   �� 5   
   -   5         ��Name$ btnSalva��5      .��6:   Salva Categoria6K   �� 5   
   .��6   %#Inserisci Id categria da aggiornare65   �� 5   
   -   5        $
 tbId��5      6    �� 5   
   .��6    Inserisci nuovo nome categoria60   �� 5   
   -   5        $ 	tbNomeCat��5      6%   �� 5   
   -   5        $ btnAggiorna��5      .��6@   Aggiorna Categoria6T   �� 5   
   .��6   &$Inserisci Id categoria da cancellare66   �� 5   
   -   5        $ tbId2��5      6!   �� 5   
   -   5        $ btnCancella��5      .��6@   Cancella Categoria6T   �� 5      -   5        $ btnHome��5      .��69   Torna a Home6G   5      � 5!      .+�5"   
   &   System.Windows.Controls.DataGrid  -	   5          Name$ dgCategoria��5"         AutoGenerateColumns$ False��6(      Columns 5#      0  *System.Windows.Controls.DataGridTextColumn  5$      ,  &System.Windows.Controls.DataGridColumn   Header$
 Nome��5%      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5&      �� *Nome+6/   5(      5)      5*      5+      