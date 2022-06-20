// See https://aka.ms/new-console-template for more information
using ImageMagick;

//add the your source folder path in which has the .heic files
string sourceFolderPath = @"E:\Photos\Maternity shoot-Helna";

//add the your destination folder path where you add jpg files
string destinationFolderPath = @"E:\Photos\Maternity shoot";

string[] allfiles = Directory.GetFiles(sourceFolderPath, "*.heic", SearchOption.AllDirectories);

foreach (var file in allfiles)
{
    FileInfo info = new FileInfo(file);
    using (MagickImage image = new MagickImage(info.FullName))
    {
        // Save frame as jpg
        image.Write(@$"{destinationFolderPath}\{info.Name}.jpg");
    }
}