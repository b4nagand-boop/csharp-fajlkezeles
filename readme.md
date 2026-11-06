# Biztonsági beléptetőrendszer

A program a portások és biztonsági őrök munkáját könnyíti meg egy beléptető programmal, ami az alábbi információkat tudja feljegyezni felhasználói bemenettel:
- Emberek esetén igazolványszámot,
- Autók esetén rendszámot,
- Ezek a létesítménybe való bejutásának időpontját.

## Használati útmutató

A programnak két funkciója van: eltárolni a bevitt adatokat, és lehetővé tenni az azok közötti keresést.

### 1. Adatok hozzáadása és eltárolása

#### 1.1 A felhasználó által elvégezendő lépések

1. lépés: A felhasználó kiválasztja a belépő egyed típusát.
    - Ember és kerékpár esetén **"I"** (Igazolványszám) betűt,
    - Személygépkocsi és egyéb jármű esetén **"R"** (Rendszám) betűt.

2. lépés: A felhasználó felviszi az egyed azonosítóját.
    - Ember és kerékpár esetén a **személyigazolvány számát**,
    - Személygépkocsi és egyéb jármű esetén **rendszámot**.

#### 1.2 A program működése

1. lépés: A program beolvassa a felhasználó által bekért adatokat.

2. lépés: A program leellenőrzi az adatok formájának helyességét.
    - Személyi igazolványszám esetén: **123456AB** (6 darab szám és 2 darab betű)
    - Rendszám esetén: **ABC-123** (3 darab betű és 3 darab szám kötőjellel elválasztva)

> [!WARNING]
> A program csak az 1990 és 2022 közötti rendszám formátumot fogadja el.

3. lépés: A program beolvassa az operációs rendszer dámutát és idejét.

4. lépés: A program megnézi, hogy a rendszerben benne van-e már az azonosító.
    - Ha nincs benne, akkor létrehoz neki egy fájlt, ahol jegyzi a be- és kilépések dátumát, illetve hozzárendeli a típusát és felviszi a rendszerbe.
    - Ha benne van, akkor felviszi az azonosítóhoz rendelt fájlba a dátumot.

### 2. Adatok böngészése

#### 2.1 A felhasz