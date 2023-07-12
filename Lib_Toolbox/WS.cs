namespace WeatherStation
{

    /*  Hier ein Beispiel für das erstellen einer Klassenbibliothek und bereitstellen via NuGet.
     *  Nuget ist ein Paketmanager für Visual Studio und ermöglicht es, Klassenbibliotheken zu veröffentlichen bzw. zu installieren.
     *
     *  Eine Klassenbilbiothek ist eine Sammlung von Methoden, die in einem Projekt verwendet werden können.
     *  Sie hat keine Einstiegsmethode (Main) und kann daher nicht direkt ausgeführt werden.
     *  
     *  Erstellte NuGet-Pakete können bei NuGet händisch über das WebTool hochgeladen werden oder per CLI.
     *  
     * 
     * Die XML -Kommentare sind wichtig, damit die Dokumentation der Methoden in der NuGet-Paketbeschreibung angezeigt werden kann.
     * Es versteht sich als Code-Dokumentation und sollte daher immer verwendet werden.
     * 
     * Während die Verwendung von XML-Kommentaren optional ist, wird sie allgemein als gute Praxis angesehen, insbesondere wenn
     * Sie eine Bibliothek erstellen oder den Code mit anderen teilen möchten. 
     * Es hilft dabei, den Code für andere Entwickler zugänglicher und verständlicher zu machen.
     * 
     * Marc Winter
     * Version 1.0
     * 12.07.2023
     *  
     */

    public class WS
    {
        /// <summary>
        /// Berechnet die Wolkenhöhe basierend auf Temperatur und Taupunkt.
        /// </summary>
        public static double BerechneWolkenhöhe(double temperatur, double taupunkt)
        {
            double wolkenhöhe = (temperatur - taupunkt) * 125;
            return wolkenhöhe;
        }

        /// <summary>
        /// Berechnet den Windchill basierend auf Temperatur und Windgeschwindigkeit.
        /// </summary>
        public static double BerechneWindchill(double temperatur, double windgeschwindigkeit)
        {
            double windchill = 13.12 + 0.6215 * temperatur - 11.37 * Math.Pow(windgeschwindigkeit, 0.16) + 0.3965 * temperatur * Math.Pow(windgeschwindigkeit, 0.16);
            return windchill;
        }

        /// <summary>
        /// Berechnet den Hitzeindex basierend auf Temperatur und Luftfeuchtigkeit.
        /// </summary>
        public static double BerechneHitzeindex(double temperatur, double luftfeuchtigkeit)
        {
            double t = temperatur;
            double rh = luftfeuchtigkeit;

            double hitzeindex = (0.363636 * t)
                + (0.081106 * rh)
                + (0.00941695 * t * rh)
                + (0.000817621 * t * t)
                + (0.00000320179 * rh * rh)
                + (0.000000512829 * t * t * rh)
                - (0.0000000148214 * t * rh * rh)
                + (0.000000000843296 * t * t * rh * rh)
                - (0.0000000000481975 * t * t * t)
                + (0.00000000000153269 * rh * rh * rh)
                - (0.0000000000000218329 * t * t * t * rh)
                + (0.000000000000000843296 * t * rh * rh * rh)
                - (0.0000000000000000481975 * t * t * t * rh * rh);

            return hitzeindex;
        }

        /// <summary>
        /// Berechnet den Taupunkt basierend auf Temperatur und Luftfeuchtigkeit.
        /// </summary>
        public static double BerechneTaupunkt(double temperatur, double luftfeuchtigkeit)
        {
            double a = 17.27;
            double b = 237.7;
            double alpha = ((a * temperatur) / (b + temperatur)) + Math.Log(luftfeuchtigkeit / 100.0);
            double taupunkt = (b * alpha) / (a - alpha);
            return taupunkt;
        }
    }
}