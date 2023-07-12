Die WeatherStation ist eine Klassenbibliothek, die Methoden zur Berechnung von meteorologischen Daten bereitstellt. Sie kann in Projekten zur Wetteranalyse, Klimaforschung oder anderen Anwendungen eingesetzt werden.

Funktionen:

    BerechneWolkenh�he(double temperatur, double taupunkt): 
    Diese Methode berechnet die Wolkenh�he basierend auf der Temperatur und dem Taupunkt. 
    Das Ergebnis wird in Metern zur�ckgegeben.

    BerechneWindchill(double temperatur, double windgeschwindigkeit): 
    Diese Methode berechnet den Windchill-Faktor basierend auf der Temperatur und der Windgeschwindigkeit. 
    Der Windchill-Faktor gibt an, wie kalt es sich bei einer bestimmten Temperatur und Windgeschwindigkeit anf�hlt.

    BerechneHitzeindex(double temperatur, double luftfeuchtigkeit): 
    Diese Methode berechnet den Hitzeindex basierend auf der Temperatur und der Luftfeuchtigkeit. Der Hitzeindex gibt an, wie hei� es sich bei einer bestimmten Temperatur und Luftfeuchtigkeit anf�hlt.

    BerechneTaupunkt(double temperatur, double luftfeuchtigkeit): 
    Diese Methode berechnet den Taupunkt basierend auf der Temperatur und der Luftfeuchtigkeit. 
    Der Taupunkt ist die Temperatur, bei der die Luft vollst�ndig mit Wasserdampf ges�ttigt ist und es zur Kondensation kommt.

Installation:

    F�gen Sie die WeatherStation-Klassenbibliothek Ihrem Projekt hinzu.

    Verwenden Sie die bereitgestellten Methoden, um meteorologische Daten zu berechnen.

Hinweis: Stellen Sie sicher, dass Sie die Parameterwerte gem�� den Anforderungen der jeweiligen Methode angeben.