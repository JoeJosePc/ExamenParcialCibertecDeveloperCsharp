   M S B A M L   `   `   `  ����R  NWpfMuestraDeLaboratorio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:WpfMuestraDeLaboratorioWpfMuestraDeLaboratorio  5   	   (    "WpfMuestraDeLaboratorio.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:WpfMuestraDeLaboratorio     5   	     � Title$-  'Mantenimiento De Muestra De Laboratorio��5   	   $	��400��69   $	��850��6F   .��5	      � .+�5
   
   ��  �� Orientation$ Vertical=�6   $��Center=�6,   .+�5      �� $ 
Horizontal=�6   .+�5      �� $ Vertical=�6   $	��550��64   $	��370��6@   .+�5      �� $��Muestras De Laboratorio��6   $��20(�6>   $
��Bold"�6L   $��50��6^   $��Bottom=�6j   $��Center=�6�   6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ dgMuestrasDeLaboratorio��5      $	��300��6@   $��12(�6�      
IsReadOnly .    CanUserReorderColumns .     CanUserResizeColumns .     CanUserResizeRows .     CanUserSortColumns .  ��6M   �� *!muestraDeLaboratorioRegistradas+6�   5      �� 5      $ Vertical=�6   $	��250��64   $	��370��6@   .+�5      �� -   5         ��Name$ panelBotones��5   !   $	��250��67   $	��370��6C   $ Vertical=�6P   $y�	Collapsed=�6g   .+�5      �� $$��/Imagenes/laboratorioPanel.png��6    $	��200��6H   6W   �� 5      $��50��6%   $��	10,0,20,0q�61   $ 
Horizontal=�6D   $��Center=�6]   .+�5      �� -   5        	 ��Name$	 
btnAgregar��5   %   $	��200��69   $��Agregar Muestra��6E   $��15(�6_   $
��Bold"�6m   6�   5      �� 5      $��50��6%   $��
10,20,20,0q�61   $ 
Horizontal=�6E   $��Center=�6^   .+�5      �� -   5        $	 btnActualizar��5   %   $	��200��6<   $��Actualizar Muestra��6H   $��15(�6e   $
��Bold"�6s   6�   5      5      �� 5      -   5        $ panelDatosUsuario��5   !   $	��250��6<   $ Vertical=�6H   $y�Visible=�6_   .+�5      �� $	��250��6%   $ 
Horizontal=�62   .+�5      �� $	��240��6)   $ Vertical=�65   $��	10,0,20,0q�6L   .+�5   "   �� $��50��6-   $��Bottom=�69   .+�5   &   �� $��Datos de Muestra��6,   $��20(�6G   $
��Bold"�6U   $��50��6g   $��Bottom=�6s   $��Center=�6�   6�   5   #   �� 5    "   $��25��6-   $��Bottom=�69   .+�5!   &   �� $��Nombre Persona Muestrada��6,   $��14(�6O   $
��Bold"�6]   $��25��6o   $��Bottom=�6{   $
��Left=�6�   6�   5"   #   �� 5#   "   $��25��6-   $��Bottom=�69   .+�5$   &   �� -   5        
 ��Name$
 txtNombrePersonaMuestrada��5$   .   $��25��6�    �� TextWrapping$
 Wrap=�6�   $��14(�6�   $��Center=�6�   ��6Q   �� *20nuevaMuestraDeLaboratorio.NombrePersonaMuestrada+6�   5%   #   �� 5&   "   $��25��6-   $��Bottom=�69   .+�5'   &   �� $��Fecha De Toma��6,   $��14(�6E   $
��Bold"�6S   $��25��6e   $��Bottom=�6q   $
��Left=�6�   6�   5(   #   �� 5)   "   $��30��6-   $��Bottom=�69   .+�5*   &   (  "System.Windows.Controls.DatePicker  -   5          Name$ dtpFechaDeToma��5*   1   $��14(�6�   $	��200��6�      Text 6I   �� *'%nuevaMuestraDeLaboratorio.FechaDeToma+6�   5+   #   �� 5,   "   $��25��6-   $��Bottom=�69   .+�5-   &   �� $#��Persona Que Toma La Muestrada��6,   $��14(�6T   $
��Bold"�6b   $��25��6t   $��Bottom=�6�   $
��Left=�6�   6�   5.   #   �� 5/   "   $��25��6-   $��Bottom=�69   .+�50   &   �� -   5        $!
 txtNombrePersonaTomaMuestra��50   .   $��25��6�   $
 Wrap=�6�   $��14(�6�   $��Center=�6�   ��6S   �� *42nuevaMuestraDeLaboratorio.NombrePersonaTomaMuestra+6�   51   #   52      53      �� 54      -	   5        $	 btnInsertar��54   !   $��Agregar Nueva Muestra��66   $��50��6V   $	��200��6b   $��14(�6n   $
��Bold"�6|   6�   58      5:      5;      5<      5>      5?      