# Gra FPS Unity

Gra jest pierwszoosobową strzelanką 3D. Gracz wciela się w postać, która dąży do zniszczenia ukrytej bazy robotów. 

## Opis projektu

Rozgrywka jest podzielona na dwa obszary: Pustynny – etap wejścia do ukrytej bazy; Pomieszczeniowy – baza robotów. By osiągnąć swój cel, gracz pcha ładunek z bombą po wyznaczonej trasie. Przeciwnicy (roboty) starają się temu zapobiec atakując gracza. Po jego śmierci, gracz zostaje teleportowany na początek mapy. Do dyspozycji są 3 rodzaje broni – karabin, strzelba, pistolet. Przeciwnicy są wyposażeni w karabin lub strzelbę. W celu uzupełnienia stanu zdrowia gracza – na mapie w niektórych miejscach są rozmieszczone apteczki. Strzelając z broni, jest zużywana amunicja. Więcej amunicji można znaleźć w paczkach z amunicją, tak samo jak z apteczkami. Apteczki jak i amunicja po zebraniu, ponownie pojawiają się w tym samym miejscu po pewnym czasie. Gra jest w języku angielskim.

W celu stworzenia gry zostały wykorzystane następujące programy:

silnik graficzny - Unity 2019;
język programowania (skrypty) – C#
modele i animacja – Blender 2.8
tekstury - Photoshop

## Zwycięstwo i porażka

Gra kończy się zwycięstwem, jeżeli ładunek z bombą zostanie dopchany do końca przed upływem wyznaczonego czasu. W przeciwnym wypadku, gra zostanie zakończona porażką.

## Menu główne

Po uruchomieniu aplikacji pokaże się główne menu z czterema przyciskami:

a)	Play – przycisk uruchamiający grę, gracz zostanie od razu przeniesiony do rozgrywki

b)	Credits – przycisk przechodzący do sceny wyświetlającej nazwiska autorów gry (członkowie naszej sekcji). Można powrócić do menu głównego.

c)	Help – przycisk przechodzący do splash screena z instrukcją klawiszologii. Można powrócić do menu głównego.

d)	Quit - zamyka aplikację i wychodzi do pulpitu

## Sterowanie

W – chodzenie do przodu

S – chodzenie do tyłu

A – chodzenie w lewo

D – chodzenie w prawo

(lub za pomocą strzałek, odpowiednio: góra, dół, lewo, prawo)

Spacja – skok (możliwy też jest skok podwójny – podwójne naciśnięcie spacji)

Lewy klawisz myszy – oddanie strzału

R – przeładowanie aktualnie wyciągniętej broni

Esc – menu pauzy

Klawisze 1, 2, 3 – zmiana broni

## Rozgrywka

### System broni

Do dyspozycji dla gracza są 3 rodzaje broni w ekwipunku (od razu dostępne):
Karabin – zadaje serię szybkich strzałów w linii prostej
Strzelba – wystrzeliwuje kilka pocisków jednocześnie z dużym rozrzutem
Pistolet – zachowuje się podobnie jak karabin, lecz pociski wystrzeliwane są dużo wolniej

Każda z broni zużywa amunicje podczas wystrzału. W celu przeładowania magazynka należy nacisnąć klawisz R, o ile jest w zapasie amunicja. Tych samych broni używa gracz jak i zarówno przeciwnicy. Natomiast przeciwnicy posiadają nieskończoną ilość amunicji. W grze nie występuje friendly-fire, co za tym idzie przeciwnicy wzajemnie nie mogą się ranić.

### Apteczki i paczki z amunicją

Na mapie w paru miejscach występują paczki, które można zebrać. Jeżeli gracz zbierze apteczkę, to stan jego aktualnego zdrowia się zwiększy. Natomiast jeżeli jego zdrowie jest na maksymalnym poziomie, to wtedy nie będzie mógł jej zebrać. Paczki z amunicją dodają liczbę naboi dla każdej z jego broni. Nie ma ograniczenia, dla posiadanej liczby naboi. Po zebraniu paczki, po pewnym czasie znowu się ona pojawi w tym samym miejscu.

### Przeciwnicy

Są trzy rodzaje przeciwników, głównie różniących się tylko wyglądem i animacją. Przeciwnicy posiadają jedną z broni dostępnych dla gracza. Działanie ich broni bazuje na takiej samej zasadzie, lecz mają oni duży zapas amunicji. Roboty (przeciwnicy) wychodzą z portali porozmieszczanych w kilku miejscach na mapie. Każdy kolejno z portali zostaje uruchomiony, wtedy kiedy gracz przejdzie dalej przez mapę. Portale zostają wyłączone po wyjściu z niego z góry określonej liczby przeciwników. Przeciwnicy wychodzą z nich kolejno co 2 sekundy. Jeżeli gracz znajdzie się w pobliżu przeciwnika, ten do niego podąży próbując go zabić, strzelając w niego. Przeciwnicy mogą podbiegać do gracza, oddalać się od niego na dalszą odległość lub poruszać się w lewo i prawo podczas strzelania. Jeżeli gracz będzie w bardzo dalekiej odległości, to będą swobodnie się poruszać po mapie.

### Ładunek z bombą

Celem gracza jest dopchanie ładunku z bombą na koniec mapy i jego wysadzenie. Jeżeli gracz będzie bardzo blisko ładunku, wózek będzie poruszał się po wyznaczonej ścieżce, w postaci torów. Ładunek z bombą należy dopchać w określonym czasie (na górze HUDu znajduje się czasomierz odliczany w dół). Czas ten jest zwiększany, kiedy ładunek przejedzie przez specjalne tory zwiększające limit czasowy. Po dopchaniu do końca trasy (koniec trasy znajduje się na drugiej mapie), ładunek eksploduje niszcząc główny komputer (ważny obiekt dla przeciwników w bazie).

## Wygląd gry

<p align="center">
<br>
<img src="/images/Screenshot_1.png" width="70%"/>
<img src="/images/Screenshot_2.png" width="70%"/>
<img src="/images/Screenshot_3.png" width="70%"/>
<img src="/images/Screenshot_4.png" width="70%"/>
<img src="/images/Screenshot_5.png" width="70%"/>
</p>

## Współautor
Projekt współtworzony był wraz z:
- [Adr1an000](https://github.com/Adr1an000)
- [dawidmusialik898](https://github.com/dawidmusialik898)

[Oryginalne repozytorium projektu](https://github.com/Adr1an000/Projekt-GK)

