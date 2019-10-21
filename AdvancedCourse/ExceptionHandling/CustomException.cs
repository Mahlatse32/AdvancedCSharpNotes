using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class CustomException
    {
        public List<Video> GetVideos(string str)
        {
            try
            {
                //Access youtube web service
                //Read the data
                //Create a list of video objects
            }
            catch (Exception ex)
            {

                throw new YoutubeException("Cannot fetch youtube videos", ex.InnerException);
            }

            return new List<Video>();
        }
    }
}
