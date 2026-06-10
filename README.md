# \# Number Guesser

# 

# \## Beschreibung

# 

# \*\*Number Guesser\*\* ist ein einfaches Unity-Spiel, bei dem der Computer versucht, die vom Spieler gedachte Zahl zu erraten. Der Spieler denkt sich eine Zahl innerhalb eines vorgegebenen Bereichs aus und gibt dem Computer Rückmeldung, ob die Vermutung zu hoch, zu niedrig oder korrekt ist.

# 

# Das Ziel des Spiels ist es, zu demonstrieren, wie die \*\*binäre Suche\*\* verwendet werden kann, um eine Zahl effizient zu finden.

# 

# \---

# 

# \## Steuerung

# 

# \### Higher

# 

# Wird gedrückt, wenn die vom Computer vorgeschlagene Zahl \*\*zu niedrig\*\* ist. Der Computer sucht anschließend im oberen Zahlenbereich weiter.

# 

# \### Lower

# 

# Wird gedrückt, wenn die vom Computer vorgeschlagene Zahl \*\*zu hoch\*\* ist. Der Computer sucht anschließend im unteren Zahlenbereich weiter.

# 

# \### Correct

# 

# Wird gedrückt, wenn der Computer die richtige Zahl erraten hat. Das Spiel zeigt an, dass die Suche erfolgreich war.

# 

# \### Restart

# 

# Startet das Spiel neu und setzt den Suchbereich auf die ursprünglichen Werte zurück.

# 

# \---

# 

# \## Verwendeter Algorithmus: Binäre Suche

# 

# Das Spiel verwendet den Algorithmus der \*\*binären Suche (Binary Search)\*\*.

# 

# Funktionsweise:

# 

# 1\. Der Computer wählt die Mitte des aktuellen Zahlenbereichs.

# 2\. Der Spieler gibt an, ob die Zahl höher oder niedriger ist.

# 3\. Der Suchbereich wird halbiert.

# 4\. Der Vorgang wird wiederholt, bis die richtige Zahl gefunden wurde.

# 

# Durch die ständige Halbierung des Suchbereichs kann die gesuchte Zahl sehr schnell gefunden werden.

# 

# \---

# 

# \## Technische Informationen

# 

# \*\*Unity-Version:\*\* 2022.3 LTS \*(bitte durch die tatsächlich verwendete Version ersetzen)\*

# 

# \*\*Startszene:\*\* `MainScene` \*(bitte durch den tatsächlichen Szenennamen ersetzen)\*

# 

# \---

# 

# \## Projektstruktur

# 

# \* `README.md` – Projektdokumentation

# \* `Assets/Scenes/MainScene.unity` – Startszene des Spiels

# \* `Assets/Scripts/` – Spielskripte und Logik

# 

# \---

# 

# \## Ziel des Projekts

# 

# Dieses Projekt dient als Einführung in die Programmierung von Spielmechaniken in Unity sowie in die Anwendung des Algorithmus der binären Suche.



