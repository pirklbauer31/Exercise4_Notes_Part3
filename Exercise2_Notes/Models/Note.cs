using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using Newtonsoft.Json;

namespace Exercise2_Notes.Models
{
    public class Note:GalaSoft.MvvmLight.ObservableObject
    {
        public Note()
        {
            NoteId = Guid.NewGuid().ToString();
        }
        public Note(string noteContent, DateTime noteDateTime)
        {
            NoteId = Guid.NewGuid().ToString();
            NoteContent = noteContent;
            NoteDateTime = noteDateTime;
        }

        public Note(string noteContent, DateTime noteDateTime, Geopoint noteLocation)
        {
            NoteId = Guid.NewGuid().ToString();
            NoteContent = noteContent;
            NoteDateTime = noteDateTime;
            NoteLocation = noteLocation;
        }

        public string NoteContent { get; set; }

        public DateTime NoteDateTime { get; set; }

        public string NoteId { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        [JsonIgnore]
        public Geopoint NoteLocation {
            get
            {
                return new Geopoint(new BasicGeoposition
                {
                    Latitude = Latitude,
                    Longitude = Longitude
                });
            }
            set
            {
                Latitude = value.Position.Latitude;
                Longitude = value.Position.Longitude;
            }
        }

    }
}
