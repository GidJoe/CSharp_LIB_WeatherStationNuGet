Die WeatherStation ist eine Klassenbibliothek, die Methoden zur Berechnung von meteorologischen Daten bereitstellt. Sie kann in Projekten zur Wetteranalyse, Klimaforschung oder anderen Anwendungen eingesetzt werden.

Funktionen:

    BerechneWolkenhöhe(double temperatur, double taupunkt): 
    Diese Methode berechnet die Wolkenhöhe basierend auf der Temperatur und dem Taupunkt. 
    Das Ergebnis wird in Metern zurückgegeben.

    BerechneWindchill(double temperatur, double windgeschwindigkeit): 
    Diese Methode berechnet den Windchill-Faktor basierend auf der Temperatur und der Windgeschwindigkeit. 
    Der Windchill-Faktor gibt an, wie kalt es sich bei einer bestimmten Temperatur und Windgeschwindigkeit anfühlt.

    BerechneHitzeindex(double temperatur, double luftfeuchtigkeit): 
    Diese Methode berechnet den Hitzeindex basierend auf der Temperatur und der Luftfeuchtigkeit. Der Hitzeindex gibt an, wie heiß es sich bei einer bestimmten Temperatur und Luftfeuchtigkeit anfühlt.

    BerechneTaupunkt(double temperatur, double luftfeuchtigkeit): 
    Diese Methode berechnet den Taupunkt basierend auf der Temperatur und der Luftfeuchtigkeit. 
    Der Taupunkt ist die Temperatur, bei der die Luft vollständig mit Wasserdampf gesättigt ist und es zur Kondensation kommt.

Installation:

    Fügen Sie die WeatherStation-Klassenbibliothek Ihrem Projekt hinzu.

    Verwenden Sie die bereitgestellten Methoden, um meteorologische Daten zu berechnen.

Hinweis: Stellen Sie sicher, dass Sie die Parameterwerte gemäß den Anforderungen der jeweiligen Methode angeben.