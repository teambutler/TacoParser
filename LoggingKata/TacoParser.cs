﻿namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();
        
        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing");

            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
            var cells = line.Split(',');



            // If your array.Length is less than 3, something went wrong
            if (cells.Length < 3)
            {
                // Log that and return null
                // Do not fail if one record parsing fails, return null
                return null; // TODO Implement
            }
            double lat;
            double.TryParse(cells[0], out lat);
            
            double lng;
            double.TryParse(cells[1], out lng);

            var name = cells[2];

            // Done - grab the latitude from your array at index 0
            // Done - grab the longitude from your array at index 1
            // Done - grab the name from your array at index 2



            // Done - Your going to need to parse your string as a `double`
            // which is similar to parsing a string as an `int`



            // Done - You'll need to create a TacoBell class
            // that conforms to ITrackable

            // Done - Then, you'll need an instance of the TacoBell class
            // With the name and point set correctly

            var taco = new TacoBell();

            // Done - Then, return the instance of your TacoBell class
            // Since it conforms to ITrackable

            taco.Name = name;
            var point = new Point();
            point.Latitude = lat;
            point.Longitude = lng;

            taco.Location = point;

            return taco;

        }
    }
}