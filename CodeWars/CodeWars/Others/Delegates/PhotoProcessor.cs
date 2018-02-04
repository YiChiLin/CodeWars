using System;

namespace CodeWars.Others.Delegates
{
    public class Photo
    {
        public static Photo Load(string path)
        {
            return new Photo();
        }
    }

    public class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Apply Brightness");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Apply Contrast");
        }
    }

    public class PhotoProcessor
    {
        public void Process(string path, PhotoFilterHandler handler)
        {
            var photo = Photo.Load(path);
            handler(photo);
        }

        public delegate void PhotoFilterHandler(Photo photo);
    }
}