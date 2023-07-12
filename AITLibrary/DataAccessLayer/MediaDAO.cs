using DataAccessLayer.DataSet1TableAdapters;
using DataAccessLayer.MediaDSTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class MediaDAO
    {
        private MediaDS mediaDataSet;
        private TabMediaTableAdapter TabMediaTableAdapter;
        private ViewMediaTableAdapter ViewMediaTableAdapter;

        public MediaDAO()
        {
            mediaDataSet = new MediaDS();
            TabMediaTableAdapter = new TabMediaTableAdapter();
            ViewMediaTableAdapter = new ViewMediaTableAdapter();    
        }
        public MediaDS.ViewMediaDataTable ListMedia()
        {
            ViewMediaTableAdapter.Fill(mediaDataSet.ViewMedia);
            return mediaDataSet.ViewMedia;
        }

        // Method to execute the FillByPublishYear() sql statement
        public MediaDS.ViewMediaDataTable ListMediaByPublishYear(int publishYear)
        {
            ViewMediaTableAdapter.FillByPublishYear(mediaDataSet.ViewMedia, publishYear);
            return mediaDataSet.ViewMedia;
        }

        // Method to execute the FillByGenreName() sql statement
        public MediaDS.ViewMediaDataTable ListMediaByGenreName(string mediaGenre)
        {
            ViewMediaTableAdapter.FillByGenreName(mediaDataSet.ViewMedia, mediaGenre);
            return mediaDataSet.ViewMedia;
        }
        /*  private MediaDS mediaDataSet;
          private ViewMediaTableAdapter viewMediaAdapter;
          private TabLanguageTableAdapter languageTableAdapter;
          private TabGenreTableAdapter genreTableAdapter;
          private TabDirectorTableAdapter directorTableAdapter;
          private TabMediaTableAdapter tabMediaAdapter;
          public MediaDAO() { 

          }*/
    }
}
