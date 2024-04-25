using System.Drawing;

namespace VerticalBlackLineDetection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Check if the correct number of arguments is provided
            if (args.Length != 1)
            {
                Console.WriteLine("Invalid number of arguments. Please provide the absolute path of the test image.");
                return;
            }

            try
            {
                // Load the image from the provided path
                using Bitmap image = new Bitmap(args[0]);

                int imageWidth = image.Width;
                int imageHeight = image.Height;
                bool inBlackBar = false;
                int blackBarCount = 0;

                // Loop through each column in the image
                for (int x = 0; x < imageWidth; x++)
                {
                    bool containsBlackPixel = false;

                    // Loop through each row in the column
                    for (int y = 0; y < imageHeight; y++)
                    {
                        Color pixelColor = image.GetPixel(x, y);
                        if (IsBlack(pixelColor))
                        {
                            containsBlackPixel = true;
                            break; // Exit the loop if a black pixel is found
                        }
                    }

                    // Check for transition from white to black
                    if (!inBlackBar && containsBlackPixel)
                    {
                        inBlackBar = true;
                        blackBarCount++;
                    }
                    else if (inBlackBar && !containsBlackPixel)
                    {
                        inBlackBar = false;
                    }
                }

                Console.WriteLine($"Number of vertical black bars: {blackBarCount}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        // Helper method to check if a pixel is black
        private static bool IsBlack(Color pixelColor)
        {
            return pixelColor.R == 0 && pixelColor.G == 0 && pixelColor.B == 0;
        }
    }
}