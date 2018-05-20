using System;

namespace Smart.iOS
{
    public class DataModel
    {
        public String Title { get; set; }

        public String Text { get; set; }


        public DataModel(String title)
        {
            Title = title;
        }
    }
}
