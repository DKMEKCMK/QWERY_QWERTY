   M S B A M L   `   `   `  ����@  <Hotel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:HotelHotel  5   	       Hotel.Employee   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Hotel     5   	     � Title$  Employee��5   	   $	��450��6   $
��1000��6'   .��5	      � .+�5
   
   �� .@�5      �� -   5        $��Сотрудники��5   0   ���	#FFA20E0E$
��Bold"�6[   .��5      � 
���  ��.+�5      &   System.Windows.Controls.DataGrid  -   5        $
��sotr��5      
���  ��
���  ��6g   5      5      �� 5      -   5        $��
Бронь��5   0   ���	#FFA20E0E$
��Bold"�6V   .��5      � 
���  ��.+�5        -   5        $
��bron��5   4   $��0,0,150,160q�6k   
���  ��
���  ��6�   �� 5      $��Center=�6   $	��165��6;   $��	0,243,0,0q�6H    �� TextWrapping$
 Wrap=�6[   $	��Top=�6o   $
��1000��6�   ���	#FFEEB5576�   �� 5      -   5        $��Удаление��5      $
��Left=�60   $��810,365,0,0q�6K   $	��Top=�6`   $��35��6x   $	��180��6�   $��24(�6�   ���	#FFF2D6AC6�   �� 5      -   5        $��Изменение��5      $
��Left=�61   $��810,322,0,0q�6L   $	��Top=�6a   $��35��6y   $	��180��6�   $��24(�6�   ���	#FFF2D6AC6�   �� 5      -   5        $��Добавление��5      $
��Left=�62   $��810,278,0,0q�6M   $	��Top=�6b   $��35��6z   $	��180��6�   $��24(�6�   ���	#FFF2D6AC6�   �� 5      -   5        $��Фильтрация��5      $
��Left=�62   $��30��6M   $��
850,10,0,0q�6Y   $	��Top=�6m   $	��135��6�   $��20(�6�   6�   �� 5      $
��Left=�6   $��30��69   $��
850,49,0,0q�6E   $
 Wrap=�6Y   $	��Top=�6m   $	��135��6�   
���   �
���  ��$!��Для фильтрации��6�   $��14(�6�    �� TextAlignment$
 Left=�6�   �� 5      -	   5        $��Surname_Booking��5      $
��Left=�65   $��35��6P   $��
30,258,0,0q�6\   $
 Wrap=�6p   $	��Top=�6�   $	��200��6�   ���	#FFD59A17$��16(�6�   $��Фамилия��6�   �� 5      -
   5        $��Name_Booking��5      $
��Left=�62   $��35��6M   $��
30,309,0,0q�6Y   $
 Wrap=�6m   $	��Top=�6�   $	��200��6�   ���	#FFD59A17$��16(�6�   $��Имя��6�   �� 5      -   5        $��Last_Name_Booking��5      $
��Left=�67   $��35��6R   $��
30,360,0,0q�6^   $
 Wrap=�6r   $	��Top=�6�   $	��200��6�   ���	#FFD59A17$��16(�6�   $��Отчество��6�   �� 5      -   5        $��Date_Booking��5      $
��Left=�62   $��35��6M   $��270,258,0,0q�6Y   $
 Wrap=�6n   $	��Top=�6�   $	��200��6�   ���	#FFD59A17$��16(�6�   $��Дата��6�   �� 5      -   5        $��Hotel_Class_Booking��5      $
��Left=�69   $��35��6T   $��270,309,0,0q�6`   $
 Wrap=�6u   $	��Top=�6�   $	��200��6�   ���	#FFD59A17$��16(�6�   $��Класс отеля��6�   �� 5      -   5        $��Floors_Booking��5      $
��Left=�64   $��35��6O   $��270,360,0,0q�6[   $
 Wrap=�6p   $	��Top=�6�   $	��200��6�   ���	#FFD59A17$��16(�6�   $��Этаж��6�   �� 5      -   5        $��Rooms_Booking��5      $
��Left=�63   $��35��6N   $��510,258,0,0q�6Z   $
 Wrap=�6o   $	��Top=�6�   $	��200��6�   ���	#FFD59A17$��16(�6�   $��Кол-во комнат��6�   �� 5       -   5        $��People_Booking��5       $
��Left=�64   $��35��6O   $��510,309,0,0q�6[   $
 Wrap=�6p   $	��Top=�6�   $	��200��6�   ���	#FFD59A17$��16(�6�   $��Кол-во людей��6�   �� 5!      -   5        $��Sum_Booking��5!      $
��Left=�61   $��35��6L   $��510,360,0,0q�6X   $
 Wrap=�6m   $	��Top=�6�   $	��200��6�   ���	#FFD59A17$��16(�6�   $��
Сумма��6�   5"      5#      �� 5$      -   5        $��Гостиницы��5$   0   ���	#FFA20E0E$
��Bold"�6Z   .��5%      � 
���  ��.+�5&        -   5        $��gostin��5&   6   $��0,0,150,160q�6o   
���  ��
���  ��6�   �� 5'      $��Center=�6   $	��165��6;   $��	0,243,0,0q�6H   $
 Wrap=�6[   $	��Top=�6o   $
��1000��6�   ���	#FFEEB5576�   �� 5(      -   5        $��Удаление��5(      $
��Left=�60   $��810,365,0,0q�6K   $	��Top=�6`   $��35��6x   $	��180��6�   $��24(�6�   ���	#FFF2D6AC6�   �� 5)      -   5        $��Изменение��5)      $
��Left=�61   $��810,322,0,0q�6L   $	��Top=�6a   $��35��6y   $	��180��6�   $��24(�6�   ���	#FFF2D6AC6�   �� 5*      -   5        $��Добавление��5*      $
��Left=�62   $��810,278,0,0q�6M   $	��Top=�6b   $��35��6z   $	��180��6�   $��24(�6�   ���	#FFF2D6AC6�   �� 5+      $��
Поиск��6   $
��Left=�6-   $��30��6H   $��
850,89,0,0q�6T   $	��Top=�6h   $	��135��6�   $��20(�6�   �� 5,      $
��Left=�6   $��30��69   $��850,128,0,0q�6E   $
 Wrap=�6Z   $	��Top=�6n   $	��135��6�   
���   �
���  ��$��Для поиска��6�   $��14(�6�   $
 Left=�6�   �� 5-      $��Фильтрация��6   $
��Left=�62   $��30��6M   $��
850,10,0,0q�6Y   $	��Top=�6m   $	��135��6�   $��20(�6�   �� 5.      $
��Left=�6   $��30��69   $��
850,49,0,0q�6E   $
 Wrap=�6Y   $	��Top=�6m   $	��135��6�   
���   �
���  ��$!��Для фильтрации��6�   $��14(�6�   $
 Left=�6�   �� 5/      -   5        $��Hotel_Class��5/      $
��Left=�61   $��35��6L   $��
30,258,0,0q�6X   $
 Wrap=�6l   $	��Top=�6�   $	��200��6�   ���	#FFD59A17$��16(�6�   $��Класс отеля��6�   �� 50      -   5        $��Floors_Hotel��50      $
��Left=�62   $��35��6M   $��
30,309,0,0q�6Y   $
 Wrap=�6m   $	��Top=�6�   $	��200��6�   ���	#FFD59A17$��16(�6�   $��Кол-во этажей��6�   �� 51      -   5        $��Rooms_Amount_Hotel��51      $
��Left=�68   $��35��6S   $��
30,360,0,0q�6_   $
 Wrap=�6s   $	��Top=�6�   $	��200��6�   ���	#FFD59A17$��16(�6�   $ ��Кол-во номеров��6�   �� 52      -   5        $��Rooms_On_Floors_Hotel��52      $
��Left=�6;   $��35��6V   $��270,258,0,0q�6b   $
 Wrap=�6w   $	��Top=�6�   $	��200��6�   ���	#FFD59A17$��16(�6�   $$��Номеров на этаже��6�   �� 53      -   5        $��Room_Capacity_Hotel��53      $
��Left=�69   $��35��6T   $��270,309,0,0q�6`   $
 Wrap=�6u   $	��Top=�6�   $	��200��6�   ���	#FFD59A17$��16(�6�   $'��!Местность номеров��6�   �� 54      -   5        $��Household_Services_Hotel��54      $
��Left=�6>   $��35��6Y   $��270,360,0,0q�6e   $
 Wrap=�6z   $	��Top=�6�   $	��200��6�   ���	#FFD59A17$��16(�6�   $��Службы быта��6�   �� 55      -   5        $��Food_Zones_Hotel��55      $
��Left=�66   $��35��6Q   $��510,258,0,0q�6]   $
 Wrap=�6r   $	��Top=�6�   $	��200��6�   ���	#FFD59A17$��16(�6�   $��Зона питания��6�   �� 56      -   5        $��Entertainments_Hotel��56      $
��Left=�6:   $��35��6U   $��510,309,0,0q�6a   $
 Wrap=�6v   $	��Top=�6�   $	��200��6�   ���	#FFD59A17$��16(�6�   $��Развлечения��6�   57      58      �� 59      -   5        $��
Фирмы��59   0   ���	#FFA20E0E$
��Bold"�6V   .��5:      � ���	#FFEEB557.+�5;        -    5        $
��firm��5;   4   
���  ��
���  ��$��	0,0,0,158q�6�   6�   �� 5<      -!   5        $��Удаление��5<      $
��Left=�60   $��788,357,0,0q�6K   $	��Top=�6`   $��35��6x   $	��180��6�   $��24(�6�   ���	#FFF2D6AC6�   �� 5=      -"   5        $��Изменение��5=      $
��Left=�61   $��788,314,0,0q�6L   $	��Top=�6a   $��35��6y   $	��180��6�   $��24(�6�   ���	#FFF2D6AC6�   �� 5>      -#   5        $��Добавление��5>      $
��Left=�62   $��788,270,0,0q�6M   $	��Top=�6b   $��35��6z   $	��180��6�   $��24(�6�   ���	#FFF2D6AC6�   �� 5?      -$   5        $��Name_Company��5?      $
��Left=�62   $��35��6M   $��
30,309,0,0q�6Y   $
 Wrap=�6m   $	��Top=�6�   $	��200��6�   ���	#FFD59A17$��16(�6�   $��Название��6�   �� 5@      -%   5        $��Type_Company��5@      $
��Left=�62   $��35��6M   $��270,309,0,0q�6Y   $
 Wrap=�6n   $	��Top=�6�   $	��200��6�   ���	#FFD59A17$��16(�6�   $%��Тип деятельности��6�   5A      5B      �� 5C      -&   5        $��Жалобы��5C   0   ���	#FFA20E0E$
��Bold"�6W   .��5D      � 
���  ��.+�5E        -'   5        $��jalob��5E   5   $��	0,0,150,0q�6m   
���  ��
���  ��6�   �� 5F      $��Фильтрация��6   $
��Left=�62   $��30��6M   $��
850,10,0,0q�6Y   $	��Top=�6m   $	��135��6�   $��20(�6�   �� 5G      $
��Left=�6   $��30��69   $��
850,49,0,0q�6E   $
 Wrap=�6Y   $	��Top=�6m   $	��135��6�   
���   �
���  ��$!��Для фильтрации��6�   $��14(�6�   $
 Left=�6�   5H      5I      �� 5J      -(   5        $��
Долги��5J   0   ���	#FFA20E0E$
��Bold"�6V   .��5K      � 
���  ��.+�5L        -)   5        $
��dolg��5L   4   $��0,0,150,160q�6k   
���  ��
���  ��6�   �� 5M      $��Center=�6   $	��165��6;   $��	0,243,0,0q�6H   $
 Wrap=�6[   $	��Top=�6o   $
��1000��6�   ���	#FFEEB5576�   �� 5N      -*   5        $��Удаление��5N      $
��Left=�60   $��810,365,0,0q�6K   $	��Top=�6`   $��35��6x   $	��180��6�   $��24(�6�   ���	#FFF2D6AC6�   �� 5O      -+   5        $��Изменение��5O      $
��Left=�61   $��810,322,0,0q�6L   $	��Top=�6a   $��35��6y   $	��180��6�   $��24(�6�   ���	#FFF2D6AC6�   �� 5P      -,   5        $��Добавление��5P      $
��Left=�62   $��810,278,0,0q�6M   $	��Top=�6b   $��35��6z   $	��180��6�   $��24(�6�   ���	#FFF2D6AC6�   �� 5Q      $��Фильтрация��6   $
��Left=�62   $��30��6M   $��
850,10,0,0q�6Y   $	��Top=�6m   $	��135��6�   $��20(�6�   �� 5R      $
��Left=�6   $��30��69   $��
850,49,0,0q�6E   $
 Wrap=�6Y   $	��Top=�6m   $	��135��6�   
���   �
���  ��$!��Для фильтрации��6�   $��14(�6�   $
 Left=�6�   �� 5S      --   5        $��Surname_Debts��5S      $
��Left=�63   $��35��6N   $��
30,258,0,0q�6Z   $
 Wrap=�6n   $	��Top=�6�   $	��200��6�   ���	#FFD59A17$��16(�6�   $��Фамилия��6�   �� 5T      -.   5        $��
Name_Debts��5T      $
��Left=�60   $��35��6K   $��
30,309,0,0q�6W   $
 Wrap=�6k   $	��Top=�6   $	��200��6�   ���	#FFD59A17$��16(�6�   $��Имя��6�   �� 5U      -/   5        $��Last_Name_Debts��5U      $
��Left=�65   $��35��6P   $��
30,360,0,0q�6\   $
 Wrap=�6p   $	��Top=�6�   $	��200��6�   ���	#FFD59A17$��16(�6�   $��Отчество��6�   �� 5V      -0   5        $��	Sum_Debts��5V      $
��Left=�6/   $��35��6J   $��270,258,0,0q�6V   $
 Wrap=�6k   $	��Top=�6   $	��200��6�   ���	#FFD59A17$��16(�6�   $��
Сумма��6�   �� 5W      -1   5        $��
Date_Debts��5W      $
��Left=�60   $��35��6K   $��270,309,0,0q�6W   $
 Wrap=�6l   $	��Top=�6�   $	��200��6�   ���	#FFD59A17$��16(�6�   $��Дата��6�   5X      5Y      �� 5Z      -2   5        $#��Клиентская база��5Z   0   ���	#FFA20E0E$
��Bold"�6`   .��5[      � 
���  ��.+�5\        -3   5        $��klient��5\   6   $��0,0,150,163q�6o   
���  ��
���  ��6�   �� 5]      $��Экспорт��6   $
��Left=�6/   $��30��6J   $��	850,8,0,0q�6V   $	��Top=�6i   $	��135��6�   $��20(�6�   �� 5^      $��
Поиск��6   $
��Left=�6-   $��30��6H   $��
850,46,0,0q�6T   $	��Top=�6h   $	��135��6�   $��20(�6�   �� 5_      $
��Left=�6   $��30��69   $��
850,85,0,0q�6E   $
 Wrap=�6Y   $	��Top=�6m   $	��135��6�   
���   �
���  ��$��Для поиска��6�   $��14(�6�   $
 Left=�6�   �� 5`      $��Center=�6   $	��165��6;   $��	0,243,0,0q�6H   $
 Wrap=�6[   $	��Top=�6o   $
��1000��6�   ���	#FFEEB5576�   �� 5a      -4   5        $��Удаление��5a      $
��Left=�60   $��810,365,0,0q�6K   $	��Top=�6`   $��35��6x   $	��180��6�   $��24(�6�   ���	#FFF2D6AC6�   �� 5b      -5   5        $��Изменение��5b      $
��Left=�61   $��810,322,0,0q�6L   $	��Top=�6a   $��35��6y   $	��180��6�   $��24(�6�   ���	#FFF2D6AC6�   �� 5c      -6   5        $��Добавление��5c      $
��Left=�62   $��810,278,0,0q�6M   $	��Top=�6b   $��35��6z   $	��180��6�   $��24(�6�   ���	#FFF2D6AC6�   �� 5d      -7   5        $��Surname_Client_Base��5d      $
��Left=�69   $��35��6T   $��
30,258,0,0q�6`   $
 Wrap=�6t   $	��Top=�6�   $	��200��6�   ���	#FFD59A17$��16(�6�   $��Фамилия��6�   �� 5e      -8   5        $��Name_Client_Base��5e      $
��Left=�66   $��35��6Q   $��
30,309,0,0q�6]   $
 Wrap=�6q   $	��Top=�6�   $	��200��6�   ���	#FFD59A17$��16(�6�   $��Имя��6�   �� 5f      -9   5        $��Last_Name_Client_Base��5f      $
��Left=�6;   $��35��6V   $��
30,360,0,0q�6b   $
 Wrap=�6v   $	��Top=�6�   $	��200��6�   ���	#FFD59A17$��16(�6�   $��Отчество��6�   �� 5g      -:   5        $��Email_Client_Base��5g      $
��Left=�67   $��35��6R   $��270,258,0,0q�6^   $
 Wrap=�6s   $	��Top=�6�   $	��200��6�   ���	#FFD59A17$��16(�6�   $��
Почта��6�   �� 5h      -;   5        $��Phone_Number_Client_Base��5h      $
��Left=�6>   $��35��6Y   $��270,309,0,0q�6e   $
 Wrap=�6z   $	��Top=�6�   $	��200��6�   ���	#FFD59A17$��16(�6�   $!��Номер телефона��6�   5i      5j      5k      5l      5m      