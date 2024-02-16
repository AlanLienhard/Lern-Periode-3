# Lern-Periode 3

Alan Lienhard

12.1. bis 23.2.2024

## Grob-Planung

1. Wo stehen Sie mit Ihren Noten? In welchen Modulen waren Sie besonders stark; in welchen sind die ungenügend? Welche davon sind besonders wichtig?
   
    Ich war in den Modulen 431 und 162 gut, beim Letzteren war ich in einem Teil (Datenmodelle mit Visual Paradigm) gut und im Anderen (Excel filtern) schlecht. Ich hatte auch eine schlechte Note im Modul 319, obwohl ich fand, dass ich das Thema gut verstand (vermutlich habe ich das Thema dann bloss schlecht beschrieben).

2. Was hatten Sie sich am Ende von LP2 vorgenommen? Was war Ihr VBV? Wie könnten Sie diesen besonders gut üben?
   
   Ich habe mir in der letzten LP vorgenommen, dass ich im LA mehr coden werde, um mich dort zu verbessern. Um das umzusetzen wären kleinere und auch grössere Coding-Projekte gut.

3. Was wäre ein geeignetes Projekt würd diese LP3?
   
   Ich dachte, dass ich in dieser LP ein kleines Spiel machen will (z.B. Snake oder Flappy Bird) in der C# Konsole. Ich arbeite in dieser LP nicht an dem "The Odin Project" weiter, weil (so wie ich es verstanden habe) müssen wir am Ende dieser LP einen funktionierenden Code haben und ToP geht zu lange. 

## 12.1.2024

✍️ Heute habe ich mich erkundigt, wie ich diese zwei möglichen Projektideen umsetzen kann. Ich habe mich entschieden, mich an einem Snake-Spiel in C# auf der Konsole zu versuchen. Dazu muss ich eine Art "Grid" oder Spielfeld machen. Die Konsole soll sich mehrmals in der Sekunde ohne zu flackern refreshen. Wenn die Schlange ein bestimmtes Objekt berührt, soll sie länger werden und die Punktezahl steigt. Ich denke, die grösste Schwierigkeit wird es, dass es nicht Game Over ist, wenn die Schlange den Rand vom Spielfeld berührt und, dass wenn sie den Rand berührt dann am anderen Ende rauskommt (z.B. berührt den oberen Rand und kommt am unteren Rand wieder raus). Also das typische Snake-Spiel.

## 19.1.2024

- [x] Spielfeld machen (Cursor darf auch nicht sichtbar sein)
- [x] (halbwegs geschafft) Konsolenapplikation soll sich mehrmals in der Sekunde erneuern/refreshen
- [ ] Objekt machen, das die Schlange bei Kontakt länger macht und den Score erhöht


| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| --------------- | -------------------- | -------------- | -------------- | -------- |
| 1               | Applikation wird gestartet                   | Applikation wird refreshed              |   Änderung wird angezeigt, falls vorhanden             |          |
| 2          |      Schlange bewegt sich                 |        Schlange kollidiert mit dem Spielfeld Rand        |   Schlange geht nicht über den Rand hinaus             |          |
| 3              |          Schlange bewegt sich und der Bildschirm refreshed sich            |    Schlange berührt Objekt            |  Score + 1 und Schlange wird um ein Zeichen länger              |          |
---
✍️ Heute am 16.1 habe ich angefangen am Spiel zu arbeiten. Ich habe zuerst das "Spielfeld" gemacht mit einem provisorischem Charakter/Schlangenkopf, der sich zur Zeit nur nach links und rechts bewegen kann. Ich habe beim Googeln und suchen auf Websiten wie Stackoverflow mehr Zeit verschwendet, als ich dachte, dass es möglich sei. Zum Beispiel, ich habe gefragt, wie man den Cursor in einer KonsolenApplikation unsichtbar macht (ausser man klickt mit der Maus). Ich hatte dabei leider viele Ergebnisse, die sagten, man könnte den Cursor nicht wirklich unsichtbar machen. Später dann bekam ich ein Google-Ergebnis, das ganz einfach nur eine Linie für das brauchte, nähmlich ´´´
Console.CursorVisible = false;```. Ich soll auch machen, dass wenn sich der Screen refreshed, dass der Bildschirm nicht flickert. Ich soll natürlich auch das dritte Arbeitspaket nachholen.(130 Wörter)

☝️ Vergessen Sie nicht, bis zum 16.1 einen ersten Code auf github hochzuladen, und in der Spalte **Erfüllt?** einzutragen, ob Ihr Code die Test-Fälle erfüllt

## 26.1.2024

- [ ] Drittes Arbeitspaket vom 19.01 nachholen
      
- [ ] Machen, dass der Screen beim Refreshen nicht flickert
      
- [ ] Speicherung von einem Highscore

- [ ] Spiel endet, wenn Schlange sich selber beisst

- [ ] Zeit für sonstige Fehlerbehebung

| Testfall-Nummer | Ausgangslage (Given)                                             | Eingabe (When)              | Ausgabe (Then) | Erfüllt? |
| --------------- | ---------------------------------------------------------------- | --------------------------- | -------------- | -------- |
| 5               |                                                                  |                             |                |     Ja     |
| 7               | Spiel gestartet, Schlange lang genug, dass sie sich beissen kann | Schlange beisst sich selber | Spiel endet    |       Nein   |
| 8               |                                                                  |                             |                |    Nein      |

✍️ Heute am 23.1 habe ich erstmal viel weniger geschafft, als ich es erwartet/geplant hatte. Ich wollte zuerst noch machen, dass wenn die Schlange (was zu der Zeit nur ein 'X' ist) z.B. den linken Rand berührt, dass sie am rechten Rand wieder raus kommt, und das in alle Richtungen. Ich dachte es wäre nicht kompliziert, aber ich habe da zu viel Zeit gebraucht und wurde noch nicht fertig damit. Das Problem für mich war, das die CursorPosition in einer Unter-Schleife (Schleife in Schleife) einer Variabel zugewiesen wurde. Dieser Wert wird aber in einer "Überliegenden" Schleife genutzt. Ich werde mich aber noch in den kommenden Ferien daran versuchen. (107 Wörter) 

☝️ Vergessen Sie nicht, bis zum 23.1 Ihren fixfertigen Code auf github hochzuladen, und in der Spalte **Erfüllt?** einzutragen, ob Ihr Code die Test-Fälle erfüllt

## 16.2.2024

✍️ Heute am 16.2. habe ich den Code von meinem Projekt nach vorgegebenen Angaben "aufbereitet" (hoffentlich richtig gemacht). Dazu musste ich Variabeln, die ich im Code habe, einen englischen Namen geben und den Namen nach der Funktionalität wählen. Ich habe auch Kommentare im Code gelöscht/geändert/hinzugefügt, je nachdem, ob sie passen. Kommentare beschreiben nicht, was der Code macht, sondern wieso bestimmte Sachen so sind, wie sie sind.  (65 Wörter)

## Reflexion

Formen Sie Ihre Zusammenfassungen in Hinblick auf Ihren VBV zu einem zusammenhängenden Text von 100 bis 200 Wörtern (wieder mit Angabe in Klammern).

Verfassen Sie zusätzlich einen kurzen Abschnitt, in welchem Sie über die Länge der Projekte reflektieren: Fanden Sie die 10-wöchtige LP2 oder die 4-wöchige LP3 angenehmer? Was bedeutet das für Ihre Planung der zukünftigen LP
