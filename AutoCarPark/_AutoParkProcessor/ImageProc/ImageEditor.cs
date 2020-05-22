using openalprnet;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;


namespace _AutoParkProcessor.ImageProc
{
    public class ImageEditor
    {
        private static string EnBenzeyenPlakayiGetir(List<AlprPlateNet> plakalar)
        {
            foreach (var item in plakalar)
            {
                return item.Characters.PadRight(12);
            }
            return "";
        }
        private static Rectangle boundingRectangle(List<Point> points)
        {
            // Add checks here, if necessary, to make sure that points is not null,
            // and that it contains at least one (or perhaps two?) elements

            var minX = points.Min(p => p.X);
            var minY = points.Min(p => p.Y);
            var maxX = points.Max(p => p.X);
            var maxY = points.Max(p => p.Y);

            return new Rectangle(new Point(minX, minY), new Size(maxX - minX, maxY - minY));
        }
        public static string AssemblyDirectory
        {
            get
            {
                var codeBase = Assembly.GetExecutingAssembly().CodeBase;
                var uri = new UriBuilder(codeBase);
                var path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }
        private static Image cropImage(Image img, Rectangle cropArea)
        {
            //var bmpImage = new Bitmap(img);
            //return bmpImage.Clone(cropArea, bmpImage.PixelFormat);
            Bitmap bmpImage = new Bitmap(cropArea.Width, cropArea.Height);
            using (Graphics gph = Graphics.FromImage(bmpImage))
            {
                gph.DrawImage(img, new Rectangle(0, 0, bmpImage.Width, bmpImage.Height), cropArea, GraphicsUnit.Pixel);
            }
            return bmpImage;
        }
        public static Bitmap combineImages(List<Image> images)
        {
            Bitmap finalImage = null;

            try
            {
                var width = 0;
                var height = 0;

                foreach (var bmp in images)
                {
                    width += bmp.Width;
                    height = bmp.Height > height ? bmp.Height : height;
                }
                finalImage = new Bitmap(width, height);
                using (var g = Graphics.FromImage(finalImage))
                {
                    g.Clear(Color.Black);
                    var offset = 0;
                    foreach (Bitmap image in images)
                    {
                        g.DrawImage(image,
                                    new Rectangle(offset, 0, image.Width, image.Height));
                        offset += image.Width;
                    }
                }

                return finalImage;
            }
            catch (Exception ex)
            {
                if (finalImage != null)
                    finalImage.Dispose();

                throw ex;
            }
            finally
            {
                foreach (var image in images)
                {
                    image.Dispose();
                }
            }
        }

        public static string processImageFile(string fileName)
        {
            string resultv2 = "";
            //resetControls();
            var region = "eu";
            String config_file = Path.Combine(AssemblyDirectory, "openalpr.conf");
            String runtime_data_dir = Path.Combine(AssemblyDirectory, "runtime_data");
            using (var alpr = new AlprNet(region, config_file, runtime_data_dir))
            {
                if (!alpr.IsLoaded())
                {
                    //resultv2 = "Error initializing OpenALPR";
                    return "Error initializing OpenALPR";
                }
                //pc_procesone.ImageLocation = fileName;
                //pc_procesone.Load();

                var results = alpr.Recognize(fileName);

                var images = new List<Image>(results.Plates.Count());
                // var i = 1;
                foreach (var result in results.Plates)
                {
                    var rect = boundingRectangle(result.PlatePoints);
                    var img = Image.FromFile(fileName);
                    var cropped = cropImage(img, rect);
                    images.Add(cropped);

                    resultv2 = Convert.ToString(EnBenzeyenPlakayiGetir(result.TopNPlates).Trim());
                }

                //if (images.Any())
                //{
                //     = resultv2;
                //    //pc_prosstwo.Image = combineImages(images);
                //}
            }
            //return resultv3;
            return resultv2;
        }

    }
}
