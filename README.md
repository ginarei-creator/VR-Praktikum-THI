# VR-Praktikum-THI
Projekt von: Gina Reinert

## Roll a ball:
dieses Projekt enthält eine funktionierende Version mit VR-Unterstützung für "Roll A Ball". 
- Ball rollt
- Spielfeld hat Borders
- 10 gelbe, rotierende Cubes sind über die Spielfläche verteilt
- bei Collision mit den Pickups verschwinden diese

### Erweiterungen:
- Punktesystem und Anzeige des Levels
- schwarze Pick ups geben Minuspunkte
- gelbe Pick ups geben Pluspunkte
- mit Aufsammeln aller Pickups im ersten Board (blau) öffnet sich eine Tür zu Level 2 (rot)
- hat man 14 Punkte in Level 2, erscheint Level 3 (grün), welches sich ab bewegt
- am Anfang des Spiels erscheint der Hinweis, dass das Spiel mit ablegen des Balls auf der grünen Fläche gewonnen ist

## Flugsimulator
dieses Projekt enthält eine funktionierende Version mit VR-Unterstützung für einen Flugsimulator
- **Szenen:** Inspektion_without_hover und CockpitVR
- **Features:** alle Standardfeatures sind enthalten
- **Videos:** SzeneInspektionUndSwitchScene.mp4, SzeneCockpit.mp4 

### Erweiterungen
- **Partikel:** Feuerstrahl aus den Turbinen, bei Tastendruck der Taste "P" oder drücken des roten Buttons unter der rechten Kanonen-Kamera schießen Raketen aus den Kanonen
- **Render Textures:** Kameras an jeder Kanone, welche im Cockpit rechts und links angezeigt werden
- **Umgebungsanpassungen:** unsichtbare Meshes, damit der Player nach der Inspektion über den Flügel zur Schwingtür laufen kann und Geräusche an den Turbinen und im Cockpit
- **Displays:** blinkendes Warnzeichen und Schrift in rot bei Unterschreitung der Mindesthöhe (50m), HUD nur auf einem Auge eingeblendet
- **Buttons:** zwei rote Buttons im Cockpit: der unter der rechten Kanonen-Kamera ist für das Abfeuern der Kanone, der andere zum switchen zwischen HUD und Canvas
- Steuerung erfolgt durch Joystick und rechtem Handcontroller
- **Joystick-Steuerung:** Throttle zur Veränderung der Geschwindigkeit; es ist auch rückwärts fliegen möglich, der Stick steuert Nick-, Wank- und Rollbewegungen des Flugobjektes
- **Inspektions-Areal:** realistische Darstellung einer abgelegenen Startbahn und ein paar verlassenen Gebäuden
- Hinweis: durch Bugs beim Cut and Paste der Terrain-Objekte in eine seperate Folder befinden sich diese teils noch im Assets Folder. Ich habe so gut es geht aufgeräumt, habe aber nicht mehr geschafft alle zu entfernen aus Angst, mein Terrain zu verunstalten.




