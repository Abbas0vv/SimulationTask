namespace First_Simulation.Helpers.Extentions;

public static class FileExtention
{
    public static string CreateFile(this IFormFile file, string webRootPath, string folderName)
    {
        string fileName = Guid.NewGuid().ToString() + file.FileName;
        string path = Path.Combine(webRootPath, folderName);
        using (var stream = new FileStream(path, FileMode.Create))
        {
            file.CopyTo(stream);
        }

        return fileName;
    }
}
